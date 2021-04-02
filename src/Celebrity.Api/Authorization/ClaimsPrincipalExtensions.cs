using IdentityModel;
using System;
using System.Security.Claims;

namespace Celebrity.Api
{
    public static class ClaimsPrincipalExtensions
    {
        public static bool IsAdmin(this ClaimsPrincipal currentUser)
        {
            var claim = currentUser.FindFirstValue(JwtClaimTypes.Role);
            return !string.IsNullOrWhiteSpace(claim) && claim.Equals(Celebrity.Shared.Roles.Admin);
        }
    }
}
