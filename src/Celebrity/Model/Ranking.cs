using System.Collections.Generic;
using System.Linq;

namespace Celebrity
{
    public class Ranking
    {
        private readonly IEnumerable<Team> teams;

        public Ranking(IEnumerable<Team> teams)
        {
            this.teams = teams;
        }

        public IEnumerable<Team> GetRanking()
        {
            return teams
                .OrderByDescending(x => x.TotalGuessedConcepts())
                .ToList();
        }

        public Team Winner()
        {
            return GetRanking().First();
        }
    }
}
