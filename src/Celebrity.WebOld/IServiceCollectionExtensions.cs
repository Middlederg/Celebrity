using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Celebrity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Celebrity.Web
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddCustomServices(this IServiceCollection services)
        {
            //services.AddScoped<Random>();
            //services.AddScoped<IRandomProvider, RandomProvider>();
            return services;
        }

        public static IServiceCollection AddSqlite(this IServiceCollection services, IConfiguration configuration)
        {            
            services.AddDbContext<CelebrityContext>(options =>
            {
                options.UseSqlite(configuration.GetValue<string>("ConnectionString:Sqlite"));
            });

            services.AddDefaultIdentity<IdentityUser>(options =>
            {
                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedAccount = true;
            }).AddEntityFrameworkStores<CelebrityContext>();

            return services;
        }
    }
}
