using System.Globalization;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Celebrity.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly CelebrityContext context;

        public UserRepository(CelebrityContext context)
        {
            this.context = context;
        }

        public async Task<string> GetCurrentUserCulture(string id)
        {
            var user = await context.Users.FindAsync(id);
            return user.Culture;
        }

        public async Task UpdateUserData(User user, CultureInfo culture)
        {
            if (user.IsLoggedIn)
            {
                var databaseUser = await context.Users.FirstOrDefaultAsync(x => x.Id == user.Id.ToString());
                databaseUser.Culture = culture.ToString();
                context.Entry(databaseUser).State = EntityState.Modified;
            }
        }
    }
}
