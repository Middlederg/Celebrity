using Celebrity.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Celebrity
{
    public class GameLoaderService
    {
        private readonly IGameRepository gameRepository;
        private readonly IConceptRepository conceptsRepository;

        public GameLoaderService(IGameRepository gameRepository, IConceptRepository conceptsRepository)
        {
            this.gameRepository = gameRepository;
            this.conceptsRepository = conceptsRepository;
        }

        public async Task<Game> Load(Guid id)
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
                gameinf
               );

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
