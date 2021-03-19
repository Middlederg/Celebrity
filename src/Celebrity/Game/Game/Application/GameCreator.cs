using System;
using System.Linq;
using System.Threading.Tasks;

namespace Celebrity.Domain
{
    public class GameCreator
    {
        private readonly IGameRepository gameRepository;
        private readonly IConceptRepository conceptRepository;
        private readonly IUnitOfWork unitOfWork;

        public GameCreator(IGameRepository gameRepository, IDeckRepository conceptsRepository, IUnitOfWork unitOfWork)
        {
            this.gameRepository = gameRepository;
            this.conceptRepository = conceptsRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task<Game> Create(Shared.CreateGameCommand command)
        {
            var concepts = await conceptRepository.GetFromCriteria(command.Criteria);

            var teams = command.Teams.Select(x => new Team(new TeamId(), x.Color, x.Name));

            var game = new Game(new GameId(),
               new RoundContext(command.TotalRounds),
               concepts,
               teams,
               DateTime.Now);
            gameRepository.CreateGame(game);
            await unitOfWork.CompleteAsync();
            return game;
        }
    }
}
