using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Celebrity.Domain;

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
            context.Games.Add(game);
        }

        public void DeleteGame(Game game)
        {
            context.Games.Remove(game);
        }

        public Task<Game> Get(GameId id)
        {
            var game = context.Games
                 .Include(x => x.DeckConcepts)
                 .Include(x => x.Teams)
                    .ThenInclude(x => x.Points)
                 .FirstOrDefaultAsync(x => x.Id == id);

            return game;
        }
    }
}
