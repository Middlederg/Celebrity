using System.Net.Http;

namespace Celebrity.Web
{
    public class ApiClient
    {
        public HttpClient Client { get; }

        public ApiClient(HttpClient client)
        {
            Client = client;
        }
    }

}
