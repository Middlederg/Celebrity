using System;
using System.Collections.Generic;
using System.Linq;

namespace Celebrity.GamingContext
{
    public class SetUpNewGameService
    {
        public Game Create(IEnumerable<Concept> concepts, IEnumerable<Team> teams, int totalCounts, User user)
        {
            return new Game(new GameId(), 
                new RoundContext(totalCounts),
                new Deck(concepts.ToList()),
                new Teams(teams),
                user,
                DateTime.Now);
        }
    }
}
