using System;
using System.Threading.Tasks;

namespace Celebrity.Domain
{
    [Service]
    public class GameFinder
    {
        private readonly IGameRepository gameRepository;

        public GameFinder(IGameRepository gameRepository)
        {
            this.gameRepository = gameRepository;
        }

        public async Task<Game> Find(GameId id)
        {
            var game = await gameRepository.Get(id);
            if (game is null)
            {
                throw new NotFoundException(id, nameof(Game));
            }
            return game;
        }
    }
}
