using System;

namespace Celebrity.FunctionalTests
{
    public class ServerFixture
    {
        public IConfiguration Configuration { get; }
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

            host.MigrateDbContext<PlatformContext>();
            Server = host.GetTestServer();
            Configuration = Server.Services.GetService<IConfiguration>();

            Randomizer.Seed = new Random();
            InitializeDatabase();
            InitializeStorage();
        }

        protected virtual void InitializeDatabase()
        {
            var context = Server.Services.GetService<PlatformContext>();

            new TasksEraser(context).Execute();
            new SatEraser(context).Execute();
            new CustomersEraser(context).Execute();
            new DeleteAllBaseData(context).Execute();
            new SeedBaseData(context).Execute();
            new CustomersSeed(context).Execute();
        }

        protected void InitializeStorage()
        {
            var blobStorage = new BlobStorage(Configuration);
            blobStorage.DeleteContainer(IntegrationTests.StorageBlobShould.ContainerName);
            blobStorage.DeleteContainer(StorageContainers.PointPhotos);
        }
    }
}
