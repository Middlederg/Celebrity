using Celebrity.Shared;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Celebrity.Web
{
    [Service]
    public class SubcategoryRepository
    {
        private readonly ApiClient client;

        public SubcategoryRepository(ApiClient client)
        {
            this.client = client;
        }

        public async Task<IEnumerable<Subcategory>> GetAll()
        {
            string endpoint = SubcategoryEndpoints.GetSubcategories();
            var result = await client.Client.GetFromJsonAsync<IEnumerable<Subcategory>>(endpoint);
            return result;
        }

        public async Task<Subcategory> Get(Guid id)
        {
            string endpoint = SubcategoryEndpoints.GetSubcategory(id);
            var result = await client.Client.GetFromJsonAsync<Subcategory>(endpoint);
            return result;
        }

        public async Task<Subcategory> Create(CreateSubcategory dto)
        {
            string endpoint = SubcategoryEndpoints.PostCreate;
            var response = await client.Client.PostAsJsonAsync(endpoint, dto);
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadFromJsonAsync<Subcategory>();
            return result;
        }

        public async Task Update(Guid subcategoryId, UpdateSubcategory dto)
        {
            string endpoint = SubcategoryEndpoints.PatchUpdate(subcategoryId);
            var response = await client.Client.PatchJsonAsync(endpoint, dto);
            response.EnsureSuccessStatusCode();
        }

        public async Task Delete(Guid subcategoryId)
        {
            string endpoint = SubcategoryEndpoints.DeleteSubcategory(subcategoryId);
            var response = await client.Client.DeleteAsync(endpoint);
            response.EnsureSuccessStatusCode();
        }
    }
}
