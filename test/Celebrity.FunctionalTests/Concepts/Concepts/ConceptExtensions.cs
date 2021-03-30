using Celebrity.Shared;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace Celebrity.FunctionalTests
{
    public static class ConceptExtensions
    {
        public static async Task<Subcategory> ConceptInDatabase(this ServerFixture given)
        {
            var subcategory = await given.SubcategoryInDatabase();
            var dto = ConceptMother.Create(subcategory.Id);

            var response = await given
               .Server
               .CreateRequest(ConceptEndpoints.Base)
               .WithJsonBody(dto)
               .PostAsync();

            await response.ShouldBe(StatusCodes.Status201Created);
            var result = await response.ReadJsonResponse<Subcategory>();

            return result;
        }

        public static async Task<Subcategory> GetSubcategoryFromDatabase(this ServerFixture given, Guid id)
        {
            var dto = SubcategoryMother.Create();

            var response = await given
               .Server
               .CreateRequest(SubcategoryEndpoints.GetSubcategory(id))
               .WithJsonBody(dto)
               .GetAsync();

            await response.ShouldBe(StatusCodes.Status200OK);
            var result = await response.ReadJsonResponse<Subcategory>();

            return result;
        }
    }
}
