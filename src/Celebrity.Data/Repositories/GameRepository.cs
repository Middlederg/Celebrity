using Celebrity.Repositories;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Celebrity.Data
{
    public class GameRepository : IGameRepository
    {
        private readonly CelebrityContext context;

        public GameRepository(CelebrityContext context)
        {
            this.context = context;
        }

        public void CreateGame(Game game)
        {
            var info = game.GetGameInfo();

            var concepts = game.Deck.GetAllconcepts().Select(x => new DeckConcepts()
            {
                Id = Guid.NewGuid(),
                Concept = x.Entity,
                IsGuessed = x.IsChecked
            }).ToList();

            int index = -1;
            var teams = game.GetTeams().Select(team =>
            {
                index++;
                var points = team.GetPointsInfo().Select(x => new TeamPoints()
                {
                    Id = Guid.NewGuid(),
                    Concept = x.id,
                    Round = x.round
                }).ToList();
                return new TeamsInGame()
                {
                    Id = Guid.NewGuid(),
                    TeamName = team.ToString(),
                    Color = team.Color,
                    Fails = team.Fails,
                    TeamId = index,
                    Points = points
                };
            }).ToList();

            var games = new Games()
            {
                Id = info.Id,
                CreationDate = info.CreationDate,
                OwnerId = info.Owner.Id?.ToString(),
                CurrentRound = info.CurrentRound,
                CurrentTeam = info.CurrentTeam,
                TotalRounds = info.TotalRounds,
                Percentage = info.Percentage,
                Concepts = concepts,
                Teams = teams,
                LoadedGames = new List<LoadedGames>()
            };
            context.Games.Add(games);
        }

        public async Task DeleteGame(GameId id)
        {
            var game = await context.Games.FindAsync((Guid)id);
            if (game != null)
            {
                context.Games.Remove(game);
            }
        }

        public async Task<GameInfo> GetGameInfo(GameId id)
        {
            var game = await context.Games
                .Include(x => x.Owner)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (game is null)
            {
                return null;
            }
            return new GameInfoMapper(game).Map();
        }

        public async Task<IEnumerable<Team>> GetTeams(GameId id, Deck deck)
        {
            var game = await context.Games
                   .Include(x => x.Teams)
                   .ThenInclude(x => x.Points)
                   .FirstOrDefaultAsync(x => x.Id == id);

            return game.Teams.Select(x =>
            {
                var team = new Team(x.Color, x.TeamName);
                foreach (var point in x.Points)
                {
                    var concept = deck.SearchConcept(new ConceptId(point.Concept));
                    team.AddPoint(concept, point.Round);
                }
                foreach (var i in Enumerable.Range(0, team.Fails))
                {
                    team.AddFailure();
                }
                return team;
            });
        }

        public void AddLoadedLog(GameId id, User user, ClientInfo clientInfo)
        {
            var loadedGames = new LoadedGames()
            {
                Id = Guid.NewGuid(),
                GameId = id,
                User = user.Id,
                LoadedDate = DateTime.Now,
                UserAgent = clientInfo.UserAgent.ToString(),
                IpAddress = clientInfo.IpAddress.ToString()
            };
            context.LoadedGames.Add(loadedGames);
        }
    }
}
