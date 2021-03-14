using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.Extensions.Configuration;

namespace Celebrity.Web
{
    public class CustomAuthorizationMessageHandler : AuthorizationMessageHandler
    {
        public CustomAuthorizationMessageHandler(IAccessTokenProvider provider, NavigationManager navigation,
            IConfiguration configuration)
            : base(provider, navigation)
        {
            var settings = new ClientSettings();
            configuration.Bind("ClientSettings", settings);

            ConfigureHandler(
                authorizedUrls: new[] { settings.BaseUrl });
        }
    }

}
