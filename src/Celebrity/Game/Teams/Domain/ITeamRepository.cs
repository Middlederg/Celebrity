using System.Collections.Generic;
using System.Threading.Tasks;

namespace Celebrity.Domain
{
    public interface ITeamRepository
    {
        Task<IEnumerable<Team>> GetTeams(GameId id);
        Task<Team> GetTeam(TeamId id);
        Task AddTeam(Team team);
    }
}
