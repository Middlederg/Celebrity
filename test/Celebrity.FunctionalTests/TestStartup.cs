using Acheve.AspNetCore.TestHost.Security;
using Acheve.TestHost;
using Celebrity.Data;
using Hellang.Middleware.ProblemDetails;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Celebrity.FunctionalTests
{
    public class TestStartup
    {
        private readonly IConfiguration configuration;
        private readonly IWebHostEnvironment environment;

        public TestStartup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            this.configuration = configuration;
            this.environment = environment;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            Celebrity.Api.Configuration.ConfigureServices(services, environment, configuration)
                .AddProblemDetails(configure =>
                {
                    configure.IncludeExceptionDetails = (context, exception) => true;
                })
                .AddDbContextPool<CelebrityContext>(setup =>
                {
                    string connectionString = configuration.GetConnectionString("Sqlite");
                    setup.UseSqlite(connectionString, sqlServerOptions =>
                    {
                        sqlServerOptions.MigrationsAssembly(typeof(CelebrityContext).Assembly.FullName);
                    });
                }).AddCustomIdentityOptions()
                .AddAuthorization()
                .AddAuthentication(setup =>
                {
                    setup.DefaultAuthenticateScheme = TestServerDefaults.AuthenticationScheme;
                    setup.DefaultChallengeScheme = TestServerDefaults.AuthenticationScheme;
                })
                .AddTestServer();
        }


        public void Configure(IApplicationBuilder app)
        {
            Api.Configuration.Configure(app, host => host);
        }
    }
}
