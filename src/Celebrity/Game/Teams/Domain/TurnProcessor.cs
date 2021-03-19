using System.Collections.Generic;

namespace Celebrity.Domain
{
    public class TurnProcessor
    {
        private readonly IEnumerable<Team> teams;
        private readonly int currentTeam;
        public int TotalTeams => teams.Count();

        internal TurnProcessor(IEnumerable<Team> teams, int currentTeam)
        {
            this.teams = teams;
            this.currentTeam = currentTeam;
        }

        public int NextTurn => currentTeam >= TotalTeams - 1 ? 0 : currentTeam + 1;
        public Team NextTeam => teams.ElementAt(NextTurn);
    }
}
