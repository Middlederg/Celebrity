using Bogus;
using Celebrity.Shared;
using Microsoft.AspNetCore.Http;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Celebrity.FunctionalTests
{
    public static class SubcategoryMother
    {
        public static CreateSubcategory Create()
        {
            var faker = new Faker<CreateSubcategory>()
                .StrictMode(true)
                .RuleFor(x => x.Category, f => f.PickRandom<CategoryValue>())
                .RuleFor(x => x.Name, f => f.Commerce.Categories(1).First());

            faker.Locale = Constants.CurrentLocale;

            return faker.Generate();
        }

        public static UpdateSubcategory Update()
        {
            var faker = new Faker<UpdateSubcategory>()
                 .StrictMode(true)
                 .RuleFor(x => x.Category, f => f.PickRandom<CategoryValue>())
                 .RuleFor(x => x.Name, f => f.Commerce.Categories(1).First());

            faker.Locale = Constants.CurrentLocale;

            return faker.Generate();
        }
    }

    [Collection(nameof(ServerFixtureCollection))]
    public class SubcategoryShould
    {
        private readonly ServerFixture Given;

        public SubcategoryShould(ServerFixture fixture)
        {
            Given = fixture ?? throw new ArgumentNullException(nameof(fixture));
        }

        [Fact]
        public async Task Be_created()
        {
            var dto = SubcategoryMother.Create();

            var response = await Given
               .Server
               .CreateRequest(SubcategoryEndpoints.PostCreate)
               .WithJsonBody(dto)
               .PostAsync();
            await response.ShouldBe(StatusCodes.Status201Created);
            var result = await response.ReadJsonResponse<Subcategory>();

            result.Id.Should().NotBe(0);
            result
        }

        [Fact]
        public async Task Be_found_after_created()
        {
            var report = await Given.SamplingReportInDatabase();

            var response = await Given
               .Server
               .CreateRequest(SamplingReportsEndpoint.Get(report.Id))
               .WithIdentity(Identities.OnlySatStandardUser)
               .GetAsync();

            await response.ShouldBe(StatusCodes.Status200OK);
            var result = await response.ReadJsonResponse<SamplingReport>();

            result.Should().BeEquivalentTo(report);
        }

        [Fact]
        public async Task Be_all_found_after_create_2()
        {
            var report1 = await Given.SamplingReportInDatabase();
            var report2 = await Given.SamplingReportInDatabase();

            var response = await Given
               .Server
               .CreateRequest(SamplingReportsEndpoint.GetAllActive)
               .WithIdentity(Identities.OnlySatStandardUser)
               .GetAsync();

            await response.ShouldBe(StatusCodes.Status200OK);
            var result = await response.ReadJsonResponse<IEnumerable<SamplingReport>>();

            result.Should().HaveCountGreaterOrEqualTo(2);
            result.Should().ContainEquivalentOf(report1);
            result.Should().ContainEquivalentOf(report2);
        }

        [Fact]
        public async Task Be_deleted()
        {
            var report = await Given.SamplingReportInDatabase();

            var response = await Given
               .Server
               .CreateRequest(SamplingReportsEndpoint.Get(report.Id))
               .WithIdentity(Identities.OnlySatStandardUser)
               .GetAsync();
            await response.ShouldBe(StatusCodes.Status200OK);

            response = await Given
               .Server
               .CreateRequest(SamplingReportsEndpoint.Delete(report.Id))
               .WithIdentity(Identities.OnlySatStandardUser)
               .DeleteAsync();
            await response.ShouldBe(StatusCodes.Status204NoContent);

            response = await Given
              .Server
              .CreateRequest(SamplingReportsEndpoint.Get(report.Id))
              .WithIdentity(Identities.OnlySatStandardUser)
              .GetAsync();
            await response.ShouldBe(StatusCodes.Status404NotFound);
        }

        [Fact]
        public async Task Be_found_after_created_by_budget_number()
        {
            var report = await Given.SamplingReportInDatabase();

            var response = await Given
               .Server
               .CreateRequest(SamplingReportsEndpoint.GetFromBudgetNumber(report.BudgetCode.Number, report.BudgetCode.Year))
               .WithIdentity(Identities.OnlySatStandardUser)
               .GetAsync();

            await response.ShouldBe(StatusCodes.Status200OK);
            var result = await response.ReadJsonResponse<IEnumerable<SamplingReport>>();

            result.Should().HaveCount(1);
            result.Should().BeEquivalentTo(report);
        }

        [Fact]
        public async Task Fail_to_be_deleted_when_is_in_progress()
        {

        }

        [Fact]
        public async Task Fail_to_be_deleted_when_is_completed()
        {

        }

        [Fact]
        public async Task Be_approved()
        {
            var report = await Given.SamplingReportInDatabase();
            report.Status.Should().Be(SamplingReportStatus.Draft);

            var dto = UserMother.ChangeStatusUser();

            var response = await Given
               .Server
               .CreateRequest(SamplingReportsEndpoint.Approve(report.Id))
               .WithIdentity(Identities.OnlySatStandardUser)
               .WithJsonBody(dto)
               .PatchAsync();
            await response.ShouldBe(StatusCodes.Status204NoContent);

            var result = await Given.GetSamplingReport(report.Id);
            result.Status.Should().Be(SamplingReportStatus.Approved);
        }

        [Fact]
        public async Task Fail_to_approve_when_is_in_progress()
        {

        }


        [Fact]
        public async Task Be_reverted_from_approval()
        {
            var report = await Given.SamplingReportInDatabase();
            report.Status.Should().Be(SamplingReportStatus.Draft);

            await Given.ApproveSamplingReport(report.Id);

            var dto = UserMother.ChangeStatusUser();

            var response = await Given
               .Server
               .CreateRequest(SamplingReportsEndpoint.RevertApproval(report.Id))
               .WithIdentity(Identities.OnlySatStandardUser)
               .WithJsonBody(dto)
               .PatchAsync();
            await response.ShouldBe(StatusCodes.Status204NoContent);

            var result = await Given.GetSamplingReport(report.Id);
            result.Status.Should().Be(SamplingReportStatus.Draft);
        }
    }
}
