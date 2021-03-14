using System.Globalization;
using System.Threading.Tasks;

namespace Celebrity.GamingContext
{
    public class UserEditorService
    {
        private readonly IUserRepository userRepository;
        private readonly IUnitOfWork unitOfWork;

        public UserEditorService(IUserRepository userRepository, IUnitOfWork unitOfWork)
        {
            this.userRepository = userRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task ChangeCulture(User user, CultureInfo newCulture)
        {
            await userRepository.UpdateUserData(user, newCulture);
            await unitOfWork.CompleteAsync();
        }
    }
}
