using System;
using System.Threading.Tasks;

namespace Celebrity.GamingContext
{
    public class GameFinder
    {
        public async Task<Shared.Game> Find(Guid id)
        {
            var game = new Shared.Game() { Id = Guid.NewGuid() };
            return game;
        }
    }
}
