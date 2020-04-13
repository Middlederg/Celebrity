using Celebrity;
using System.Collections.Generic;

namespace Celebrity.Context
{
    public interface IEndOfRoundView : IDismisable
    {
        void Inform(Round currentRound, IEnumerable<Team> teams, IEnumerable<Round> rounds);
    }
}
