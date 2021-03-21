using Celebrity.Shared;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;
using Xunit;
using Microsoft.AspNetCore.TestHost;
using FluentAssertions;
using System.Collections.Generic;
using System.Linq;

namespace Celebrity.FunctionalTests
{
    [Collection(nameof(ServerFixtureCollection))]
    public class SubcategoryShould
    {
        private readonly ServerFixture Given;

        public SubcategoryShould(ServerFixture fixture)
        {
            Given = fixture ?? throw new ArgumentNullException(nameof(fixture));
        }

        //[Fact]
        //public async Task Be_created()
        //{
        //    var dto = SubcategoryMother.Create();

        //    var response = await Given
        //       .Server
        //       .CreateRequest(SubcategoryEndpoints.PostCreate)
        //       .WithJsonBody(dto)
        //       .PostAsync();

        //    await response.ShouldBe(StatusCodes.Status201Created);
        //    var result = await response.ReadJsonResponse<Subcategory>();

        //    result.Id.Should().NotBe(0);
        //    //result.Name.
        //}

        //[Fact]
        //public async Task Be_found_after_created()
        //{
        //    var report = await Given.SamplingReportInDatabase();

        //    var response = await Given
        //       .Server
        //       .CreateRequest(SamplingReportsEndpoint.Get(report.Id))
        //       .WithIdentity(Identities.OnlySatStandardUser)
        //       .GetAsync();

        //    await response.ShouldBe(StatusCodes.Status200OK);
        //    var result = await response.ReadJsonResponse<SamplingReport>();

        //    result.Should().BeEquivalentTo(report);
        //}

        //[Fact]
        //public async Task Be_all_found_after_create_2()
        //{
        //    var report1 = await Given.SamplingReportInDatabase();
        //    var report2 = await Given.SamplingReportInDatabase();

        //    var response = await Given
        //       .Server
        //       .CreateRequest(SamplingReportsEndpoint.GetAllActive)
        //       .WithIdentity(Identities.OnlySatStandardUser)
        //       .GetAsync();

        //    await response.ShouldBe(StatusCodes.Status200OK);
        //    var result = await response.ReadJsonResponse<IEnumerable<SamplingReport>>();

        //    result.Should().HaveCountGreaterOrEqualTo(2);
        //    result.Should().ContainEquivalentOf(report1);
        //    result.Should().ContainEquivalentOf(report2);
        //}

        //[Fact]
        //public async Task Be_deleted()
        //{
        //    var report = await Given.SamplingReportInDatabase();

        //    var response = await Given
        //       .Server
        //       .CreateRequest(SamplingReportsEndpoint.Get(report.Id))
        //       .WithIdentity(Identities.OnlySatStandardUser)
        //       .GetAsync();
        //    await response.ShouldBe(StatusCodes.Status200OK);

        //    response = await Given
        //       .Server
        //       .CreateRequest(SamplingReportsEndpoint.Delete(report.Id))
        //       .WithIdentity(Identities.OnlySatStandardUser)
        //       .DeleteAsync();
        //    await response.ShouldBe(StatusCodes.Status204NoContent);

        //    response = await Given
        //      .Server
        //      .CreateRequest(SamplingReportsEndpoint.Get(report.Id))
        //      .WithIdentity(Identities.OnlySatStandardUser)
        //      .GetAsync();
        //    await response.ShouldBe(StatusCodes.Status404NotFound);
        //}

      

      
       
    }
}
