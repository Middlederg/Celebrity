using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Components.Authorization;
using System.Threading.Tasks;
using Celebrity.Data;
using System.Globalization;

namespace Celebrity.Blazor
{
    public class UserFinderService
    {
        private readonly AuthenticationStateProvider authenticationStateProvider;
        private readonly UserManager<Users> userManager;

        public UserFinderService(AuthenticationStateProvider authenticationStateProvider,
            UserManager<Users> userManager)
        {
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

            if (user.Identity.IsAuthenticated)
            {
                var currentUser = await userManager.GetUserAsync(user);
                return User.Create(currentUser.Id, currentUser.UserName, currentUser.GetCulture());
            }
            return User.Anonymous(CultureInfo.CurrentCulture);
        }
    }
}
