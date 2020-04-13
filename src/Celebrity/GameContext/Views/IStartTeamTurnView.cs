using Celebrity;

namespace Celebrity.Context
{
    public interface IStartTeamTurnView : IDismisable
    {
        Team Team { get; set; }
    }
}
