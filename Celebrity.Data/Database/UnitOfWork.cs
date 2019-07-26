using System;
using System.Data.SQLite;
using System.IO;
using System.Text;

namespace Celebrity.Data
{
    public static class UnitOfWork
    {
        public static string GetConnectionString()
        {
            //Produccion
            //var path = Directory.GetCurrentDirectory();
            //return $"Data Source={path}\\Database\\CelebrityDatabase.db";

            //Desarrollo
            var path = @"C:\Users\jcl\Source\Repos\Celebrity\Celebrity.Data\";
            return $"Data Source={path}\\Database\\CelebrityDatabase.db";
        }

      
    }
}
