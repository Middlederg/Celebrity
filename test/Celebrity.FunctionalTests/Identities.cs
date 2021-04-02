using IdentityModel;
using System.Collections.Generic;
using System.Security.Claims;

namespace Celebrity.FunctionalTests
{
    public static class Identities
    {
        public static readonly IEnumerable<Claim> Administrator = new[]
        {
            new Claim(JwtClaimTypes.Subject, "1"),
            new Claim(JwtClaimTypes.Name, "admin@user.com"),
            new Claim(JwtClaimTypes.Role, Celebrity.Shared.Roles.Admin),
        };
    }
}
