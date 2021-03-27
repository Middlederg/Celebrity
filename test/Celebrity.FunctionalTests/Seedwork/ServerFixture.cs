using Bogus;
using Celebrity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;
using System;
using System.IO;

namespace Celebrity.FunctionalTests
{
    public class ServerFixture
    {
       // public IConfiguration Configuration { get; }
        public TestServer Server { get; private set; }

        public ServerFixture()
        {
            Log.Logger = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .WriteTo.Console(Serilog.Events.LogEventLevel.Warning)
                .CreateLogger();

            var host = new HostBuilder()
              .ConfigureWebHost(webBuilder =>
              {
                  webBuilder
                    .UseTestServer()
                    .UseSerilog()
                    .UseStartup<TestStartup>()
                    .UseContentRoot(Directory.GetCurrentDirectory())
                    .ConfigureAppConfiguration(app =>
                    {
                        app.AddJsonFile("appsettings.json", optional: true);
                        app.AddUserSecrets(typeof(ServerFixture).Assembly, optional: true);
                        app.AddEnvironmentVariables();
                    });
              })
              .Start();

            host.MigrateDbContext<CelebrityContext>();
            Server = host.GetTestServer();
            //Configuration = Server.Services.GetService<IConfiguration>();

            InitializeDatabase();
        }

        protected virtual void InitializeDatabase()
        {
            //var context = Server.Services.GetService<CelebrityContext>();
        }

    }
}
