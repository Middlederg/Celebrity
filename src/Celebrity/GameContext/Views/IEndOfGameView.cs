using Celebrity;

namespace Celebrity.Context
{
    public interface IEndOfGameView : IDismisable
    {
        void Inform(Ranking ranking);
    }
}
