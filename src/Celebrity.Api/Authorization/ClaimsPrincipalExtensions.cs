using System;
using System.Security.Claims;

namespace Celebrity.Api
{
    public static class ClaimsPrincipalExtensions
    {
        public static bool IsAdmin(this ClaimsPrincipal currentUser)
        {
            var claim = currentUser.FindFirstValue(ClaimTypes.Role);
            return !string.IsNullOrWhiteSpace(claim) && claim.Equals(Roles.Admin);
        }
    }
}
