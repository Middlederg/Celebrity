using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Celebrity.Web
{
    public class Response<T> : ProblemDetailsResponse
    {
        public T Content { get; private set; }

        public static async Task<Response<T>> Build(HttpResponseMessage response)
        {
            var result = new Response<T>();
            await result.SetResponse(response);
            return result;
        }

        private async Task SetResponse(HttpResponseMessage response)
        {
            if (!await ReadErrors(response))
            {
                Content = await response.Content.ReadFromJsonAsync<T>();
            }
        }
    }
}
