using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Components.Authorization;
using System.Threading.Tasks;
using Celebrity.Data;

namespace Celebrity.Blazor
{
    public class UserFinderService
    {
        private readonly ClientInfoFinderService clientInfoFinderService;
        private readonly AuthenticationStateProvider authenticationStateProvider;
        private readonly UserManager<Users> userManager;

        public UserFinderService(ClientInfoFinderService clientInfoFinderService, 
            AuthenticationStateProvider authenticationStateProvider,
            UserManager<Users> userManager)
        {
            this.clientInfoFinderService = clientInfoFinderService;
            this.authenticationStateProvider = authenticationStateProvider;
            this.userManager = userManager;
        }

        public async Task<bool> IsUserAthenticated()
        {
            var authState = await authenticationStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;
            return user.Identity.IsAuthenticated;
        }

        public async Task<User> GetCurrentUser()
        {
            var authState = await authenticationStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;

            var clientInfo = await clientInfoFinderService.GetClientInfo();

            if (user.Identity.IsAuthenticated)
            {
                var currentUser = await userManager.GetUserAsync(user);
                return User.Create(currentUser.Id, currentUser.UserName, clientInfo);
            }
            return User.Anonymous(clientInfo);
        }

    
    }
}
