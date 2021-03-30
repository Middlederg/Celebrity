using Celebrity.Shared;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace Celebrity.FunctionalTests
{
    public static class SubcategoryExtensions
    {
        public static async Task<Subcategory> SubcategoryInDatabase(this ServerFixture given)
        {
            var dto = SubcategoryMother.Create();

            var response = await given
               .Server
               .CreateRequest(SubcategoryEndpoints.PostCreate)
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

        public static Shared.BaseObject AsBaseObject(this Shared.Subcategory subcategory)
        {
            return new Shared.BaseObject()
            {
                Id = subcategory.Id,
                Name = subcategory.Name
            };
        }
    }
}
