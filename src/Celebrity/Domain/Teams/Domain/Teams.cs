using System;
using System.Collections.Generic;
using System.Linq;

namespace Celebrity.Domain
{
    public class Teams
    {
        public int Turn { get; private set; }
        public void MoveToNextTeamTurn() => Turn = Turn >= TotalTeams - 1 ? 0 : Turn + 1;

        private readonly IEnumerable<Team> teams;
        public Team CurrentTeam => teams.ElementAt(Turn);
        public Team NextTeam => teams.ElementAt(Turn >= TotalTeams - 1 ? 0 : Turn + 1);
        public int TotalTeams => teams.Count();
        public Ranking Ranking => new Ranking(teams);

        internal Teams(IEnumerable<Shared.CreateTeam> teams)
        {
            this.teams = teams.Select(x => new Team(new TeamId(), x.Color, x.Name));
            Turn = 0;
        }
    }
}
