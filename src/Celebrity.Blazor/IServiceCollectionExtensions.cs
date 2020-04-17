using Celebrity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Celebrity.Repositories;
using Microsoft.AspNetCore.Http;
using System.Globalization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using System.Linq;
using System.Security.Claims;

namespace Celebrity.Blazor
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddCustomServices(this IServiceCollection services)
        {
            //services.AddScoped<Random>();
            //services.AddScoped<IRandomProvider, RandomProvider>();
            services.AddScoped<IUnitOfWork, CelebrityContext>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ISubcategoryRepository, SubcategoryRepository>();
            services.AddScoped<IGameRepository, GameRepository>();
            services.AddScoped<IConceptRepository, ConceptRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<SubcategoryCreatorService>();
            services.AddScoped<SubcategoryDeleteService>();
            services.AddScoped<SubcategoryEditorService>();
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

        /// <summary>
        /// localize request according to {culture} route value.
        /// define supported cultures list, 
        /// define default culture for fallback,
        /// customize culture info e.g.: dat time format, digit shape,...
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureRequestLocalization(this IServiceCollection services)
        {
            var cultures = new CultureInfo[]
            {
                new CultureInfo("en"),
                new CultureInfo("es"),
                new CultureInfo("it")
            };
            services.Configure<RequestLocalizationOptions>(options =>
            {
                options.DefaultRequestCulture = new RequestCulture(User.DefaultCulture);
                options.SupportedCultures = cultures.OrderBy(x => x.EnglishName).ToList();
                options.SupportedUICultures = cultures.OrderBy(x => x.EnglishName).ToList();

                options.AddInitialRequestCultureProvider(new CustomRequestCultureProvider(async context =>
                {
                    if (context.User.Identity.IsAuthenticated)
                    {
                        string userId = context.User.FindFirstValue(ClaimTypes.NameIdentifier);
                        var userRepository = context.RequestServices.GetService<IUserRepository>();
                        var culture = await userRepository.GetCurrentUserCulture(userId);
                        return new ProviderCultureResult(culture);
                    }
                    return null;
                }));
            });
        }
    }
}
