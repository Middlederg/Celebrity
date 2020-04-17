using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Components.Authorization;
using System.Threading.Tasks;
using Celebrity.Data;
using System.Globalization;

namespace Celebrity.Blazor
{
    public class UserEditorService
    {
        private readonly AuthenticationStateProvider authenticationStateProvider;
        private readonly UserManager<Users> userManager;

        public UserEditorService(AuthenticationStateProvider authenticationStateProvider,
            UserManager<Users> userManager)
        {
            this.authenticationStateProvider = authenticationStateProvider;
            this.userManager = userManager;
        }

        public async Task ChangeCulture(CultureInfo newCulture)
        {
            var authState = await authenticationStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;

            if (user.Identity.IsAuthenticated)
            {
                var currentUser = await userManager.GetUserAsync(user);
                currentUser.Culture = newCulture.ToString();
                await userManager.UpdateAsync(currentUser);
            }
        }
    }
}
