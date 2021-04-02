using Celebrity.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Celebrity.Web
{
    [Service]
    public class ConceptRepository
    {
        private readonly ApiClient client;

        public ConceptRepository(ApiClient client)
        {
            this.client = client;
        }

        public async Task<IEnumerable<Concept>> GetAllFromCategory(CategoryValue value)
        {
            string endpoint = ConceptEndpoints.GetAllFromCategory(value);
            var result = await client.Client.GetFromJsonAsync<IEnumerable<Concept>>(endpoint);
            return result;
        }

        public async Task<IEnumerable<Concept>> GetAllFromSubcategory(Guid id)
        {
            string endpoint = ConceptEndpoints.GetAllFromSubcategory(id);
            var result = await client.Client.GetFromJsonAsync<IEnumerable<Concept>>(endpoint);
            return result;
        }

        public async Task<Concept> Get(Guid id)
        {
            string endpoint = ConceptEndpoints.GetConcept(id);
            var result = await client.Client.GetFromJsonAsync<Concept>(endpoint);
            return result;
        }

        public async Task<IEnumerable<Concept>> Create(params CreateConcept[] dtoCollection)
        {
            string endpoint = ConceptEndpoints.PostCreateList;
            var response = await client.Client.PostAsJsonAsync(endpoint, dtoCollection.ToList());
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadFromJsonAsync<IEnumerable<Concept>>();
            return result;
        }

        public async Task Update(params UpdateConcept[] dtoCollection)
        {
            string endpoint = ConceptEndpoints.PatchUpdateList;
            var response = await client.Client.PatchJsonAsync(endpoint, dtoCollection);
            response.EnsureSuccessStatusCode();
        }

        public async Task Update(Guid conceptId, params Guid[] subcategoryIdCollection)
        {
            string endpoint = ConceptEndpoints.PutSubcategoriesFromConcept(conceptId);
            var response = await client.Client.PatchJsonAsync(endpoint, subcategoryIdCollection);
            response.EnsureSuccessStatusCode();
        }

        public async Task Delete(Guid conceptId)
        {
            string endpoint = ConceptEndpoints.DeleteConcept(conceptId);
            var response = await client.Client.DeleteAsync(endpoint);
            response.EnsureSuccessStatusCode();
        }
    }
}
