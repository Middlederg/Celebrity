using System.Net.Http;
using System.Threading.Tasks;

namespace Celebrity.Web
{
    public class EmptyResponse : ProblemDetailsResponse
    {
        public static async Task<EmptyResponse> Build(HttpResponseMessage response)
        {
            var result = new EmptyResponse();
            await result.SetResponse(response);
            return result;
        }

        private async Task SetResponse(HttpResponseMessage response)
        {
            await ReadErrors(response);
        }
    }
}
