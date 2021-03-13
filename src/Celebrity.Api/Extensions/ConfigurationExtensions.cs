using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Microsoft.Extensions.Configuration
{

    public static class ConfigurationExtensions
    {
        public static IServiceCollection AddCustomConfiguration(this IServiceCollection services, 
            IConfiguration configuration)
        {
            services.Configure<ApiConfiguration>(configuration.GetSection("ApiConfiguration"));
            services.AddScoped(x => x.GetRequiredService<IOptionsSnapshot<ApiConfiguration>>().Value);
            
            return services;
        }
    }
}
