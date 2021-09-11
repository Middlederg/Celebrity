using Bogus;
using Celebrity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using System;
using System.IO;
using System.Linq;

namespace Celebrity.FunctionalTests
{
    public class ServerFixture
    {
        public T GetService<T>() => Server.Services.GetService<T>();

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
            var context = Server.Services.GetService<CelebrityContext>();

            context.Concepts.RemoveRange(context.Concepts.ToList());
            context.Subcategories.RemoveRange(context.Subcategories.ToList());
            context.SaveChanges();
        }

    }
}
