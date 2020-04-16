using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Http;

namespace Celebrity.Blazor
{
    public class ClientInfoFinderService
    {
        private readonly IJSRuntime jsRuntime;
        private readonly IHttpContextAccessor httpContextAccessor;

        public ClientInfoFinderService(IHttpContextAccessor httpContextAccessor, IJSRuntime jsRuntime)
        {
            this.httpContextAccessor = httpContextAccessor;
            this.jsRuntime = jsRuntime;
        }

        public async Task<ClientInfo> GetClientInfo()
        {
            var userAgent = await GetUserAgent();
            var ipAddress = GetIpAddress();
            return new ClientInfo(userAgent, ipAddress);
        }

        private async Task<UserAgent> GetUserAgent()
        {
            try
            {
                var userAgent = await jsRuntime.InvokeAsync<string>("getUserAgent");
                return new UserAgent(userAgent);
            }
            catch { }
            return UserAgent.Undefined;
        }

        private IpAddress GetIpAddress()
        {
            string ipAddress = httpContextAccessor.HttpContext.Connection?.RemoteIpAddress.ToString();
            return new IpAddress(ipAddress);
        }
    }
}
