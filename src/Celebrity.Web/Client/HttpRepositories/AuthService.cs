using Blazored.LocalStorage;
using Celebrity.Shared;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Celebrity.Web
{

    public class AuthService
    {
        private readonly ApiClient apiClient;
        private readonly AuthenticationStateProvider authenticationStateProvider;
        private readonly ILocalStorageService localStorage;

        public AuthService(ApiClient apiClient,
                           AuthenticationStateProvider authenticationStateProvider,
                           ILocalStorageService localStorage)
        {
            this.apiClient = apiClient;
            this.authenticationStateProvider = authenticationStateProvider;
            this.localStorage = localStorage;
        }

        public async Task<RegisterResult> Register(RegisterModel registerModel)
        {
            var response = await apiClient.Client.PostAsJsonAsync("api/accounts", registerModel);
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadFromJsonAsync<RegisterResult>();
            return result;
        }

        public async Task<Response<LoginResult>> Login(LoginModel loginModel)
        {
            var response = await apiClient.Client.PostAsJsonAsync("api/login", loginModel.ToJsonBody());
            var result = await Response<LoginResult>.Build(response);

            Console.WriteLine(result.Content.ToJson());
            if (!result.HasError)
            {


                await localStorage.SetItemAsync("authToken", result.Content.Token);
                ((ApiAuthenticationStateProvider)authenticationStateProvider).MarkUserAsAuthenticated(loginModel.Email);
                apiClient.Client.DefaultRequestHeaders.Authorization = 
                    new AuthenticationHeaderValue("bearer", result.Content.Token);

            }

            return result;
        }

        public async Task Logout()
        {
            await localStorage.RemoveItemAsync("authToken");
            ((ApiAuthenticationStateProvider)authenticationStateProvider).MarkUserAsLoggedOut();
            apiClient.Client.DefaultRequestHeaders.Authorization = null;
        }
    }


}
