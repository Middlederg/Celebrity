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

            result.Id.Should().NotBeEmpty();
            result.Name.Should().Be(dto.Name);
            result.Category.Should().Be(dto.Category);
            result.Concepts.Should().BeEmpty();
        }

        [Fact]
        public async Task Be_found_after_created()
        {
            var subcategory = await Given.SubcategoryInDatabase();

            var response = await Given
               .Server
               .CreateRequest(SubcategoryEndpoints.GetSubcategory(subcategory.Id))
               .GetAsync();

            await response.ShouldBe(StatusCodes.Status200OK);
            var result = await response.ReadJsonResponse<Subcategory>();

            result.Should().BeEquivalentTo(subcategory);
        }

        [Fact]
        public async Task Be_all_found_after_create_2()
        {
            var subcategory1 = await Given.SubcategoryInDatabase();
            var subcategory2 = await Given.SubcategoryInDatabase();

            var response = await Given
               .Server
               .CreateRequest(SubcategoryEndpoints.GetSubcategories())
               .GetAsync();

            await response.ShouldBe(StatusCodes.Status200OK);
            var result = await response.ReadJsonResponse<IEnumerable<Subcategory>>();

            result.Should().HaveCountGreaterOrEqualTo(2);
            result.Should().ContainEquivalentOf(subcategory1);
            result.Should().ContainEquivalentOf(subcategory2);
        }

        [Fact]
        public async Task Be_updated()
        {
            var subcategory = await Given.SubcategoryInDatabase();

            var dto = SubcategoryMother.Update();

            var response = await Given
               .Server
               .CreateRequest(SubcategoryEndpoints.PatchUpdate(subcategory.Id))
               .WithJsonBody(dto)
               .PatchAsync();

            await response.ShouldBe(StatusCodes.Status204NoContent);

            var result = await Given.GetSubcategoryFromDatabase(subcategory.Id);

            result.Id.Should().Be(subcategory.Id);
            result.Name.Should().Be(dto.Name);
            result.Category.Should().Be(dto.Category);
        }

        [Fact]
        public async Task Be_deleted()
        {
            var subcategory = await Given.SubcategoryInDatabase();

            var response = await Given
               .Server
               .CreateRequest(SubcategoryEndpoints.GetSubcategory(subcategory.Id))
               .GetAsync();
            await response.ShouldBe(StatusCodes.Status200OK);

            response = await Given
               .Server
               .CreateRequest(SubcategoryEndpoints.DeleteSubcategory(subcategory.Id))
               .DeleteAsync();
            await response.ShouldBe(StatusCodes.Status204NoContent);

            response = await Given
              .Server
              .CreateRequest(SubcategoryEndpoints.GetSubcategory(subcategory.Id))
              .GetAsync();
            await response.ShouldBe(StatusCodes.Status404NotFound);
        }





    }
}
