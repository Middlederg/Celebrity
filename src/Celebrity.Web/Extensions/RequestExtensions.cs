//using Celebrity.Data;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using Celebrity.Repositories;
//using Microsoft.AspNetCore.Http;
//using System.Globalization;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.AspNetCore.Localization;
//using System.Linq;
//using System.Security.Claims;

using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Celebrity.Web
{
    public static class RequestExtensions
    {
        public static string ToJson<TContent>(this TContent content)
        {
            var json = JsonSerializer.Serialize<TContent>(content);
            return json;
        }

        public static StringContent ToJsonBody<TContent>(this TContent content, string contentType = "application/json")
        {
            var body = new StringContent(content.ToJson(), Encoding.UTF8, contentType);
            return body;
        }

        public static async Task<HttpResponseMessage> PatchJsonAsync<TContent>(this HttpClient client, string url, TContent content, string contentType = "application/json")
        {
            var body = content.ToJsonBody(contentType);
            var response = await client.PatchAsync(url, body);
            response.EnsureSuccessStatusCode();
            return response;
        }
    }

    //public static class IServiceCollectionExtensions
    //{
    //    /// <summary>
    //    /// localize request according to {culture} route value.
    //    /// define supported cultures list, 
    //    /// define default culture for fallback,
    //    /// customize culture info e.g.: dat time format, digit shape,...
    //    /// </summary>
    //    /// <param name="services"></param>
    //    public static void ConfigureRequestLocalization(this IServiceCollection services)
    //    {
    //        var cultures = new CultureInfo[]
    //        {
    //            new CultureInfo("en"),
    //            new CultureInfo("es"),
    //            new CultureInfo("it")
    //        };
    //        services.Configure<RequestLocalizationOptions>(options =>
    //        {
    //            options.DefaultRequestCulture = new RequestCulture(User.DefaultCulture);
    //            options.SupportedCultures = cultures.OrderBy(x => x.EnglishName).ToList();
    //            options.SupportedUICultures = cultures.OrderBy(x => x.EnglishName).ToList();

    //            options.AddInitialRequestCultureProvider(new CustomRequestCultureProvider(async context =>
    //            {
    //                if (context.User.Identity.IsAuthenticated)
    //                {
    //                    string userId = context.User.FindFirstValue(ClaimTypes.NameIdentifier);
    //                    var userRepository = context.RequestServices.GetService<IUserRepository>();
    //                    var culture = await userRepository.GetCurrentUserCulture(userId);
    //                    return new ProviderCultureResult(culture);
    //                }
    //                return null;
    //            }));
    //        });
    //    }
    //}
}
