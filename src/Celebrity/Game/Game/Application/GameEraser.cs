using System.Threading.Tasks;

namespace Celebrity.Domain
{
    [Service]
    public class GameEraser
    {
        private readonly GameFinder finder;
        private readonly IGameRepository gameRepository;
        private readonly IUnitOfWork unitOfWork;

        public GameEraser(GameFinder finder, IGameRepository gameRepository, IUnitOfWork unitOfWork)
        {
            this.finder = finder;
            this.gameRepository = gameRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task Delete(GameId id)
        {
            var game = await finder.Find(id);
            gameRepository.DeleteGame(game);
            await unitOfWork.CompleteAsync();
        }
    }
}
