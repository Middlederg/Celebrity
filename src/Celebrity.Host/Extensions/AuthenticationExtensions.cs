using Celebrity.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Text;

namespace Celebrity.Host
{
    public static class AuthenticationExtensions
    {
        public static IServiceCollection AddCustomAuthentication(this IServiceCollection services,
            ApiConfiguration apiConfiguration)
        {
            var key = Encoding.ASCII.GetBytes(apiConfiguration.Secret);

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.Events = new JwtBearerEvents
                    {
                        OnTokenValidated = async context =>
                        {
                            var userManager = context.HttpContext.RequestServices.GetRequiredService<UserManager<User>>();
                            var username = context.Principal.Identity.Name;
                            var user = await userManager.FindByNameAsync(username);

                            if (user is null)
                            {
                                context.Fail("Unauthorized");
                            }
                        }
                    };
                    //options.RequireHttpsMetadata = environment.EnvironmentName == "Development";
                    options.SaveToken = true;
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = apiConfiguration.Issuer,
                        ValidAudience = apiConfiguration.Audience,
                        IssuerSigningKey = new SymmetricSecurityKey(key),
                    };
                });
            return services;
        }
    }
}
