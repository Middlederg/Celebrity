using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Celebrity;

namespace Celebrity.Data
{
    public class CelebrityContext : IdentityDbContext<Users>
    {
        internal DbSet<Concepts> Concepts { get; set; }
        internal DbSet<Categories> Categories { get; set; }
        internal DbSet<Subcategories> Subcategories { get; set; }
        internal DbSet<SubcategoriesInConcepts> SubcategoriesInConcepts { get; set; }

        public CelebrityContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CelebrityContext).Assembly);

            //string cs = @"<add name="Model1sdfzg" connectionString="data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=F:\DESARROLLO\Repos\Personas\src\Personas.Data\PersonasDB.mdf;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework" providerName="System.Data.SqlClient" />"
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    options.UseSqlite("Data Source=personas.db");
        //}
    }
}
