using Microsoft.AspNetCore.Hosting;
using System;
using Microsoft.AspNetCore.Builder;
using System.Data;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class CustomExtensions
    {
        public static IServiceCollection AddCustomMvc(this IServiceCollection services) =>
            services
                .AddControllers()
                .AddApplicationPart(typeof(CustomExtensions).Assembly)
                .Services;

        public static IServiceCollection AddCustomDapper(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("SqlServer");
            services.AddTransient<IDbConnection>((sp) => new SqlConnection(connectionString));
            return services;
        }

        public static bool IsDevelopment(this IWebHostEnvironment environment) => environment.EnvironmentName == "Development";

        public static IApplicationBuilder UseIf(this IApplicationBuilder app, bool condition, Func<IApplicationBuilder, IApplicationBuilder> action)
        {
            return condition ? action(app) : app;
        }
    }
}
