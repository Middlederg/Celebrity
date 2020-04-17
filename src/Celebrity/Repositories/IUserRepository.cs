using System.Globalization;
using System.Threading.Tasks;

namespace Celebrity
{
    public interface IUserRepository
    {
        Task<string> GetCurrentUserCulture(string userid);
        Task UpdateUserData(User user, CultureInfo culture);
    }
}