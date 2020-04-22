using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Celebrity.Repositories
{
    public interface IGameRepository
    {
        Task<GameInfo> GetGameInfo(GameId id);
        Task<IEnumerable<Team>> GetTeams(GameId id, Deck deck);
        Task<IEnumerable<GameInfo>> GetGamesWithConcept(ConceptId id);

        void CreateGame(Game game);
     
        Task DeleteGame(GameId id);

        void AddLoadedLog(GameId id, User user, ClientInfo clientInfo);
    }
}
