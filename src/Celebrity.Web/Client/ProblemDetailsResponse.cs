using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Celebrity.Web
{
    public abstract class ProblemDetailsResponse : IResponse
    {
        private ProblemDetails problemDetails;
        public string ErrorTitle => problemDetails?.Title ?? "";
        public string ErrorDetail
        {
            get
            {
                return problemDetails?.Detail ?? "";
            }
        }

        public int ErrorCode => problemDetails?.Status ?? 0;
        public bool HasError => problemDetails != null;

        protected async Task<bool> ReadErrors(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                problemDetails = await response.Content.ReadFromJsonAsync<ProblemDetails>();
                return true;
            }
            return false;
        }

        public override string ToString() => ErrorCode.ToString();
    }
}
