using Celebrity.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Celebrity.Domain
{
    public class GameLoaderService
    {
        private readonly IGameRepository gameRepository;
        private readonly IDeckRepository conceptsRepository;
        private readonly IUnitOfWork unitOfWork;

        public GameLoaderService(IGameRepository gameRepository, IDeckRepository conceptsRepository, IUnitOfWork unitOfWork)
        {
            this.gameRepository = gameRepository;
            this.conceptsRepository = conceptsRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task<Game> Load(Guid id, User user, ClientInfo clientInfo)
        {
            var gameId = new GameId(id);
            var concepts = await conceptsRepository.GetConceptsFromGame(gameId);
            var deck = DeckFactory.Create(concepts);
            var gameInfo = await gameRepository.GetGameInfo(gameId);
            var avaliableTeams = await gameRepository.GetTeams(gameId, deck);
            
            var game = new Game(
                gameId,
                GetRoundContext(gameInfo.TotalRounds, gameInfo.CurrentRound),
                deck,
                GetTeams(avaliableTeams, gameInfo.CurrentTeam),
                gameInfo.Owner,
                gameInfo.CreationDate
               );

            gameRepository.AddLoadedLog(game.Id, user, clientInfo);
            await unitOfWork.CompleteAsync();

            return game;
        }

        private RoundContext GetRoundContext(int totalRounds, int currentRound)
        {
            var roundContext = new RoundContext(totalRounds);
            while (roundContext.CurrentRoundNumber != currentRound)
            {
                roundContext.MoveToNextRound();
            }
            return roundContext;
        }

        private Teams GetTeams(IEnumerable<Team> avaliableTeams, int currentTeam)
        {
            var teams = new Teams(avaliableTeams);
            while (teams.Turn != currentTeam)
            {
                teams.MoveToNextTeamTurn();
            }
            return teams;
        }
    }
}
