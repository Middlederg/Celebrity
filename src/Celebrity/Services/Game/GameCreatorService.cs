using Celebrity.Repositories;
using System.Threading.Tasks;

namespace Celebrity
{
    public class GameCreatorService
    {
        private readonly IGameRepository gameRepository;
        private readonly IConceptRepository conceptsRepository;

        public GameCreatorService(IGameRepository gameRepository, IConceptRepository conceptsRepository)
        {
            this.gameRepository = gameRepository;
            this.conceptsRepository = conceptsRepository;
        }

        public async Task<Game> Create(GameCreationCriteria criteria, User currentUser)
        {
            var concepts = await conceptsRepository.GetConcepts(criteria);
            var game = new SetUpNewGameService().Create(concepts, criteria.Teams, criteria.TotalRounds, currentUser);
            gameRepository.CreateGame(game);
            return game;
        }
    }
}
