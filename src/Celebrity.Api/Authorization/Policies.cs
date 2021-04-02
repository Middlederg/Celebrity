using IdentityModel;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace Celebrity.Api
{

    public static class Policies
    {
        public const string IsAdminPolicy = nameof(IsAdminPolicy);

        public static void Configure(AuthorizationOptions options)
        {
            options.InvokeHandlersAfterFailure = true;

            options.AddPolicy(IsAdminPolicy, policyBuilder =>
            {
                policyBuilder.RequireAuthenticatedUser();
                policyBuilder.RequireClaim(claimType: JwtClaimTypes.Role, Celebrity.Shared.Roles.Admin);
            });
        }
    }
}
