using Celebrity.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Celebrity.Host
{
    public static class EntityFrameworkExtensions
    {
        public static IServiceCollection AddCustomEntityFrameworkCore(this IServiceCollection services, IConfiguration configuration)
        {
            string migrationsAssembly = typeof(CelebrityContext).GetTypeInfo().Assembly.GetName().Name;
            string connectionString = configuration.GetConnectionString("Sqlite");

            services.AddDbContextPool<CelebrityContext>(options =>
            {
                options.UseSqlite(connectionString, options =>
                {
                    options.MigrationsAssembly(migrationsAssembly);
                });
            });

            services.AddDefaultIdentity<Users>(options =>
            {
                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedAccount = true;
            }).AddEntityFrameworkStores<CelebrityContext>();

            return services;
        }

      
    }

}
