using Celebrity.Shared;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Celebrity.FunctionalTests
{
    public static class ConceptExtensions
    {
        public static async Task<Concept> ConceptInDatabase(this ServerFixture given)
        {
            var subcategory = await given.SubcategoryInDatabase();
            var dto = ConceptMother.Create(subcategory.Id);

            var response = await given
               .Server
               .CreateRequest(ConceptEndpoints.PostCreateList)
               .WithJsonBody(new List<CreateConcept>() { dto })
               .PostAsync();

            await response.ShouldBe(StatusCodes.Status200OK);
            var result = await response.ReadJsonResponse<IEnumerable<Concept>>();

            return result.First();
        }

        public static async Task<Concept> GetConceptFromDatabase(this ServerFixture given, Guid id)
        {
            var dto = SubcategoryMother.Create();

            var response = await given
               .Server
               .CreateRequest(ConceptEndpoints.GetConcept(id))
               .WithJsonBody(dto)
               .GetAsync();

            await response.ShouldBe(StatusCodes.Status200OK);
            var result = await response.ReadJsonResponse<Concept>();

            return result;
        }
    }
}
