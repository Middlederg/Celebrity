using Celebrity.Shared;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Celebrity.FunctionalTests
{
    [Collection(nameof(ServerFixtureCollection))]
    public class CategoryShould
    {
        private readonly ServerFixture Given;

        public CategoryShould(ServerFixture fixture)
        {
            Given = fixture ?? throw new ArgumentNullException(nameof(fixture));
        }



        [Fact]
        public async Task Be_found()
        {
            var subcategory = await Given.SubcategoryInDatabase();

            var response = await Given
               .Server
               .CreateRequest(CategoryEndpoints.GetCategory((int)subcategory.Category))
               .GetAsync();

            await response.ShouldBe(StatusCodes.Status200OK);
            var result = await response.ReadJsonResponse<Category>();

            result.Subcategories.Should().ContainEquivalentOf(new Shared.BaseObject()
            {
                Id = subcategory.Id,
                Name = subcategory.Name
            });
            result.Value.Should().Be(subcategory.Category);
        }

        [Fact]
        public async Task Be_all_found()
        {
            var subcategory = await Given.SubcategoryInDatabase();

            var response = await Given
               .Server
               .CreateRequest(CategoryEndpoints.GetCategories())
               .GetAsync();

            await response.ShouldBe(StatusCodes.Status200OK);
            var result = await response.ReadJsonResponse<IEnumerable<Category>>();

            result.Should().ContainEquivalentOf(new Shared.Category()
            {
                Value = subcategory.Category,
                Subcategories = new List<Shared.BaseObject>()
                {
                    new Shared.BaseObject()
                    {
                        Id = subcategory.Id,
                        Name = subcategory.Name
                    }
                }
            });
        }

    }
}
