using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Celebrity.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CelebrityContext context;

        public UnitOfWork(CelebrityContext context)
        {
            this.context = context;
        }

        public void Complete() => context.SaveChanges();
        public async Task CompleteAsync()
        {
            try
            {

                await context.SaveChangesAsync();
            }
            catch (System.Exception ex)
            {
                if (ex.InnerException is SqlException sqlException)
                {
                    string errorsMessages = string.Join(", ", GetErrors(sqlException));
                    throw new System.Exception(errorsMessages);
                }
                throw;
            }
        }

        private IEnumerable<string> GetErrors(SqlException sqlException)
        {
            foreach (var error in sqlException.Errors)
            {
                yield return error.ToString();
            }
        }
    }
}
