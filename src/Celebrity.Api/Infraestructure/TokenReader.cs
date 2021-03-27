using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Celebrity.Api
{
    //public class TokenReader
    //{
    //    private readonly IConfiguration configuration;

    //    public TokenReader(IConfiguration configuration)
    //    {
    //        this.configuration = configuration;
    //    }

    //    public IEnumerable<Claim> Read(string token)
    //    {
    //        string secret = configuration.GetValue<string>(TokenGenerator.ApiKeyConfigurationName);
    //        var tokenHandler = new JwtSecurityTokenHandler();
    //        var key = Encoding.ASCII.GetBytes(secret);

    //        var validations = new TokenValidationParameters
    //        {
    //            ValidateIssuerSigningKey = true,
    //            IssuerSigningKey = new SymmetricSecurityKey(key),
    //            ValidateIssuer = false,
    //            ValidateAudience = false
    //        };
    //        var claims = tokenHandler.ValidateToken(token, validations, out var _);

    //        return claims.Claims;
    //    }
    //}
}

