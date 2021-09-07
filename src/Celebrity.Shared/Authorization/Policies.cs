using Microsoft.AspNetCore.Authorization;

namespace Celebrity.Shared
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
                policyBuilder.RequireClaim(claimType: "role", Celebrity.Shared.Roles.Admin);
            });
        }
    }
}
