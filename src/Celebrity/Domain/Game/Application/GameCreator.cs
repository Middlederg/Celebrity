using System;
using System.Threading.Tasks;

namespace Celebrity.Domain
{
    public class GameCreator
    {
        private readonly IGameRepository gameRepository;
        private readonly IDeckRepository conceptsRepository;
        private readonly IUnitOfWork unitOfWork;

        public GameCreator(IGameRepository gameRepository, IDeckRepository conceptsRepository, IUnitOfWork unitOfWork)
        {
            this.gameRepository = gameRepository;
            this.conceptsRepository = conceptsRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task<Game> Create(Shared.CreateGameCommand command)
        {
            var concepts = await conceptsRepository.GetConcepts(criteria);
            var game = new Game(new GameId(),
               new RoundContext(command.TotalRounds),
               new Deck(concepts.ToList()),
               new Teams(command.Teams),
               DateTime.Now);
            gameRepository.CreateGame(game);
            await unitOfWork.CompleteAsync();
            return game;
        }
    }
}
