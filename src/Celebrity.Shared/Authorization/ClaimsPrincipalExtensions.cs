using IdentityModel;
using System;
using System.Security.Claims;
using System.Linq;

namespace Celebrity.Shared
{
    public static class ClaimsPrincipalExtensions
    {
        public static bool IsAdmin(this ClaimsPrincipal currentUser)
        {
            var claim = currentUser.Claims.FirstOrDefault(x => x.Type.Equals(JwtClaimTypes.Role))?.Value;
            return !string.IsNullOrWhiteSpace(claim) && claim.Equals(Celebrity.Shared.Roles.Admin);
        }
    }
}
