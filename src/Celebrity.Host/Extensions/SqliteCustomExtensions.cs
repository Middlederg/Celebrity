using Celebrity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

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

            //services.AddIdentityCore<Users>(options =>
            //{
            //    options.User.RequireUniqueEmail = true;
            //    options.SignIn.RequireConfirmedAccount = true;
            //}).AddEntityFrameworkStores<CelebrityContext>();

            return services;
        }
    }

}
