using System.Collections.Generic;
using System.Threading.Tasks;

namespace Celebrity.Domain
{
    public interface ITeamRepository
    {
        Task<IEnumerable<Team>> GetTeams(GameId id);
        Task<IEnumerable<Team>> GetTeam(TeamId id);
        Task<Team> AddTeam(Team team);
    }
}
