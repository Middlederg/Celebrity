using System.Threading.Tasks;

namespace Celebrity.Domain
{
    [Service]
    public class GameEraser
    {
        private readonly IGameRepository gameRepository;
        private readonly IUnitOfWork unitOfWork;

        public GameEraser(IGameRepository gameRepository, IUnitOfWork unitOfWork)
        {
            this.gameRepository = gameRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task Delete(GameId id)
        {
            await gameRepository.DeleteGame(id);
            await unitOfWork.CompleteAsync();
        }
    }
}
