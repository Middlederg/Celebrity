using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Celebrity.Domain;
using System.Linq;

namespace Celebrity.Data
{
    public class TeamRepository : ITeamRepository
    {
        private readonly CelebrityContext context;

        public TeamRepository(CelebrityContext context)
        {
            this.context = context;
        }

        public async Task AddTeam(Team team)
        {
            await context.Teams.AddAsync(team);
        }

        public async Task<Team> GetTeam(TeamId id)
        {
            var list = await context
                .Teams
                .FirstOrDefaultAsync(x => x.Id == id);

            return list;
        }

        public async Task<IEnumerable<Team>> GetTeams(GameId id)
        {
            var list = await context
              .Teams
              .Where(x => x.GameId == id)
              .ToListAsync();

            return list;
        }
    }
}
