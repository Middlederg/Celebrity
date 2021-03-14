using System.Collections.Generic;
using System.Linq;

namespace Celebrity.Domain
{
    public class Ranking
    {
        public IEnumerable<Team> Teams { get; }

        public Ranking(IEnumerable<Team> teams)
        {
            Teams = teams;
        }

        public IEnumerable<Team> GetRanking()
        {
            return Teams
                .OrderByDescending(x => x.TotalGuessedConcepts())
                .ToList();
        }

        public Team Winner()
        {
            return GetRanking().First();
        }
    }
}
