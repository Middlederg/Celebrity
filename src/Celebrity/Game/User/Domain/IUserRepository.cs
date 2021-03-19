using System;
using System.Globalization;
using System.Threading.Tasks;

namespace Celebrity.Domain
{
    public interface IUserRepository
    {
        Task<string> GetCurrentUserCulture(string userid);
        Task UpdateUserData(User user, CultureInfo culture);
        Task<User> GetUser(Guid id);
    }
}