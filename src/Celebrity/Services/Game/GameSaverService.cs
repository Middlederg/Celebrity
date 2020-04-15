using Celebrity.Repositories;

namespace Celebrity
{
    public class GameSaverService
    {
        private readonly IGameRepository gameRepository;

        public GameSaverService(IGameRepository gameRepository)
        {
            this.gameRepository = gameRepository;
        }

        public void Save(Game game)
        {
            gameRepository.DeleteGame(game.Id);
            gameRepository.CreateGame(game);
        }
    }
}
