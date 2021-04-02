using Celebrity.Shared;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Celebrity.Web
{
    [Service]
    public class CategoryRepository
    {
        private readonly ApiClient client;

        public CategoryRepository(ApiClient client)
        {
            this.client = client;
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            string endpoint = CategoryEndpoints.GetCategories();
            var result = await client.Client.GetFromJsonAsync<IEnumerable<Category>>(endpoint);
            return result;
        }

        public async Task<Category> Get(CategoryValue value)
        {
            string endpoint = CategoryEndpoints.GetCategory((int)value);
            var result = await client.Client.GetFromJsonAsync<Category>(endpoint);
            return result;
        }
    }
}
