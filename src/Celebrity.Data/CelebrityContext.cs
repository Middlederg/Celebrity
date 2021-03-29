using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Celebrity;
using System.Threading.Tasks;
using Celebrity.Domain;

namespace Celebrity.Data
{
    public class CelebrityContext : DbContext, IUnitOfWork
    {
        internal DbSet<Concept> Concepts { get; set; }
        internal DbSet<Subcategory> Subcategories { get; set; }

        internal DbSet<Game> Games { get; set; }
        internal DbSet<DeckConcept> DeckConcepts { get; set; }
        internal DbSet<Team> Teams { get; set; }
        internal DbSet<Point> Points { get; set; }

        public CelebrityContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CelebrityContext).Assembly);
            base.OnModelCreating(modelBuilder);
            //string cs = @"<add name="Model1sdfzg" connectionString="data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=F:\DESARROLLO\Repos\Personas\src\Personas.Data\PersonasDB.mdf;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework" providerName="System.Data.SqlClient" />"

            //new SubcategoryCreator(modelBuilder);
        }

        public void Complete() => SaveChanges();
        public async Task CompleteAsync() => await SaveChangesAsync();

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    options.UseSqlite("Data Source=personas.db");
        //}
    }
}
