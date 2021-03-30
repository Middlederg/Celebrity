using Celebrity.Shared;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using System.Collections.Generic;
using System.Linq;

namespace Celebrity.FunctionalTests
{
    [Collection(nameof(ServerFixtureCollection))]
    public class ConceptShould
    {
        private readonly ServerFixture Given;

        public ConceptShould(ServerFixture fixture)
        {
            Given = fixture ?? throw new ArgumentNullException(nameof(fixture));
        }

        [Fact]
        public async Task Be_created()
        {
            var subcategory = await Given.SubcategoryInDatabase();
            var dto = ConceptMother.Create(subcategory.Id);

            var response = await Given
               .Server
               .CreateRequest(ConceptEndpoints.PostCreateList)
               .WithJsonBody(new List<CreateConcept>() { dto })
               .PostAsync();

            await response.ShouldBe(StatusCodes.Status200OK);
            var resultList = await response.ReadJsonResponse<IEnumerable<Concept>>();
            resultList.Should().HaveCount(1);
            var result = resultList.First();
            result.Id.Should().NotBeEmpty();
            result.Name.Should().Be(dto.Name);
            result.Subcategories.Should().HaveCount(1);
            result.Subcategories.First().Id.Should().Be(subcategory.Id);
            result.Subcategories.First().Name.Should().Be(subcategory.Name);
            result.Type.Should().Be(dto.Type);
            result.Difficulty.Should().Be(dto.Difficulty);
        }

        [Fact]
        public async Task Be_found_after_create()
        {
            var concept = await Given.ConceptInDatabase();

            var response = await Given
               .Server
               .CreateRequest(ConceptEndpoints.GetConcept(concept.Id))
               .GetAsync();

            await response.ShouldBe(StatusCodes.Status200OK);
            var result = await response.ReadJsonResponse<Concept>();

            result.Should().BeEquivalentTo(concept);
        }

        [Fact]
        public async Task Be_all_found_in_category_after_create_2()
        {
            var subcategory = await Given.SubcategoryInDatabase();
            var dto1 = ConceptMother.Create(subcategory.Id);
            var dto2 = ConceptMother.Create(subcategory.Id);

            var response = await Given
               .Server
               .CreateRequest(ConceptEndpoints.PostCreateList)
               .WithJsonBody(new List<CreateConcept>() { dto1, dto2 })
               .PostAsync();
            await response.ShouldBe(StatusCodes.Status200OK);
            var created = await response.ReadJsonResponse<IEnumerable<Concept>>();
            created.Should().HaveCount(2);

            response = await Given
               .Server
               .CreateRequest(ConceptEndpoints.GetAllFromCategory(subcategory.Category))
               .GetAsync();

            await response.ShouldBe(StatusCodes.Status200OK);
            var result = await response.ReadJsonResponse<IEnumerable<Concept>>();
            result.Should().HaveCountGreaterOrEqualTo(2);
            result.Should().ContainEquivalentOf(created.ElementAt(0));
            result.Should().ContainEquivalentOf(created.ElementAt(1));
        }

        [Fact]
        public async Task Be_all_found_in_subcategory_after_create_2()
        {
            var subcategory = await Given.SubcategoryInDatabase();
            var dto1 = ConceptMother.Create(subcategory.Id);
            var dto2 = ConceptMother.Create(subcategory.Id);

            var response = await Given
               .Server
               .CreateRequest(ConceptEndpoints.PostCreateList)
               .WithJsonBody(new List<CreateConcept>() { dto1, dto2 })
               .PostAsync();
            await response.ShouldBe(StatusCodes.Status200OK);
            var created = await response.ReadJsonResponse<IEnumerable<Concept>>();
            created.Should().HaveCount(2);

            response = await Given
               .Server
               .CreateRequest(ConceptEndpoints.GetAllFromSubcategory(subcategory.Id))
               .GetAsync();

            await response.ShouldBe(StatusCodes.Status200OK);
            var result = await response.ReadJsonResponse<IEnumerable<Concept>>();
            result.Should().HaveCountGreaterOrEqualTo(2);
            result.Should().ContainEquivalentOf(created.ElementAt(0));
            result.Should().ContainEquivalentOf(created.ElementAt(1));
        }

        [Fact]
        public async Task Be_one_updated()
        {
            var concept = await Given.ConceptInDatabase();

            var dto = ConceptMother.Update(concept.Id);

            var response = await Given
               .Server
               .CreateRequest(ConceptEndpoints.PatchUpdateList)
               .WithJsonBody(new List<UpdateConcept>() { dto })
               .PatchAsync();

            await response.ShouldBe(StatusCodes.Status204NoContent);

            var result = await Given.GetConceptFromDatabase(concept.Id);

            result.Id.Should().Be(concept.Id);
            result.Name.Should().Be(dto.Name);
            result.Name.Should().NotBe(concept.Name);
            result.Difficulty.Should().Be(dto.Difficulty);
            result.Type.Should().Be(dto.Type);
        }

        [Fact]
        public async Task Be_two_updated()
        {
            var concept1 = await Given.ConceptInDatabase();
            var concept2 = await Given.ConceptInDatabase();

            var dto1 = ConceptMother.Update(concept1.Id);
            var dto2 = ConceptMother.Update(concept2.Id);

            var response = await Given
               .Server
               .CreateRequest(ConceptEndpoints.PatchUpdateList)
               .WithJsonBody(new List<UpdateConcept>() { dto1, dto2 })
               .PatchAsync();

            await response.ShouldBe(StatusCodes.Status204NoContent);

            var result1 = await Given.GetConceptFromDatabase(concept1.Id);
            result1.Id.Should().Be(concept1.Id);
            result1.Name.Should().Be(dto1.Name);
            result1.Name.Should().NotBe(concept1.Name);
            result1.Difficulty.Should().Be(dto1.Difficulty);
            result1.Type.Should().Be(dto1.Type);

            var result2 = await Given.GetConceptFromDatabase(concept2.Id);
            result2.Id.Should().Be(concept2.Id);
            result2.Name.Should().Be(dto2.Name);
            result2.Name.Should().NotBe(concept2.Name);
            result2.Difficulty.Should().Be(dto2.Difficulty);
            result2.Type.Should().Be(dto2.Type);
        }

        [Fact]
        public async Task Be_deleted()
        {
            var concept = await Given.ConceptInDatabase();

            var response = await Given
               .Server
               .CreateRequest(ConceptEndpoints.GetConcept(concept.Id))
               .GetAsync();
            await response.ShouldBe(StatusCodes.Status200OK);

            response = await Given
               .Server
               .CreateRequest(ConceptEndpoints.DeleteConcept(concept.Id))
               .DeleteAsync();
            await response.ShouldBe(StatusCodes.Status204NoContent);

            response = await Given
              .Server
              .CreateRequest(ConceptEndpoints.GetConcept(concept.Id))
              .GetAsync();

            await response.ShouldBe(StatusCodes.Status404NotFound);
        }
    }
}
