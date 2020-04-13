using Celebrity;

namespace Celebrity.Context
{
    public interface IEndOfTurnView : IDismisable
    {
        void Inform(Team currentTeam, Team nextTeam, int guessedConceptsCount);
    }
}
