using Celebrity.Repositories;
using System.Threading.Tasks;

namespace Celebrity
{
    public class GameSaverService
    {
        private readonly IGameRepository gameRepository;
        private readonly IUnitOfWork unitOfWork;

        public GameSaverService(IGameRepository gameRepository, IUnitOfWork unitOfWork)
        {
            this.gameRepository = gameRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task Save(Game game)
        {
            await gameRepository.DeleteGame(game.Id);
            gameRepository.CreateGame(game);
            await unitOfWork.CompleteAsync();
        }
    }
}
