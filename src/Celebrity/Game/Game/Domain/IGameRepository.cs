using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Celebrity.Domain
{
    public interface IGameRepository
    {
        Task<Game> Get(GameId id);

        void CreateGame(Game game);
     
        void DeleteGame(Game game);
    }
}
