using Celebrity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using Celebrity.Repositories;

namespace Celebrity.Blazor
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddCustomServices(this IServiceCollection services)
        {
            //services.AddScoped<Random>();
            //services.AddScoped<IRandomProvider, RandomProvider>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IGameRepository, GameRepository>();
            services.AddScoped<IConceptRepository, ConceptRepository>();
            services.AddScoped<CategoryCreatorService>();
            services.AddScoped<CategoryDeleteService>();
            services.AddScoped<CategoryEditorService>();
            services.AddScoped<GameCreatorService>();
            services.AddScoped<GameLoaderService>();
            services.AddScoped<GameSaverService>();
            services.AddScoped<CategoriesQuery>();
            return services;
        }

        public static IServiceCollection AddSqlite(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CelebrityContext>(options =>
            {
                options.UseSqlite(configuration.GetValue<string>("ConnectionString:Sqlite"));
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
