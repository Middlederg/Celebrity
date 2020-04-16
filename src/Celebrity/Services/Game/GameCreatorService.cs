using Celebrity.Repositories;
using System.Threading.Tasks;

namespace Celebrity
{
    public class GameCreatorService
    {
        private readonly IGameRepository gameRepository;
        private readonly IConceptRepository conceptsRepository;
        private readonly IUnitOfWork unitOfWork;

        public GameCreatorService(IGameRepository gameRepository, IConceptRepository conceptsRepository, IUnitOfWork unitOfWork)
        {
            this.gameRepository = gameRepository;
            this.conceptsRepository = conceptsRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task<GameId> Create(GameCreationCriteria criteria, User currentUser)
        {
            var concepts = await conceptsRepository.GetConcepts(criteria);
            var game = new SetUpNewGameService().Create(concepts, criteria.Teams, criteria.TotalRounds, currentUser);
            gameRepository.CreateGame(game);
            await unitOfWork.CompleteAsync();
            return game.Id;
        }
    }
}
