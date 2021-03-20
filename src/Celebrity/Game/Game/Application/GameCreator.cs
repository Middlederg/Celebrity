using System;
using System.Linq;
using System.Threading.Tasks;

namespace Celebrity.Domain
{
    [Service]
    public class GameCreator
    {
        private readonly IGameRepository gameRepository;
        private readonly IConceptRepository conceptRepository;
        private readonly IDeckRepository deckRepository;
        private readonly ITeamRepository teamRepository;
        private readonly IUnitOfWork unitOfWork;

        public GameCreator(IGameRepository gameRepository, 
            IConceptRepository conceptRepository, 
            IDeckRepository deckRepository,
            ITeamRepository teamRepository,
            IUnitOfWork unitOfWork)
        {
            this.gameRepository = gameRepository;
            this.conceptRepository = conceptRepository;
            this.deckRepository = deckRepository;
            this.teamRepository = teamRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task<Game> Create(Shared.CreateGameCommand command)
        {
            var concepts = await conceptRepository.GetFromCriteria(command.Criteria);

            var game = new Game(new GameId(),
               command.TotalRounds,
               DateTime.Now);
            gameRepository.CreateGame(game);

            foreach (var dto in command.Teams)
            {
                var team = new Team(new TeamId(), dto.Color, game.Id, dto.Name);
                await teamRepository.AddTeam(team);
                game.AddTeam(team);
            }
            await deckRepository.CreateGameConcepts(concepts);

            await unitOfWork.CompleteAsync();
            return game;
        }
    }
}
