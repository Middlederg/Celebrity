using Celebrity;
using System;

namespace Celebrity.Context
{
    public interface IConceptView
    {
        event EventHandler OnGuessedAnswer;
        event EventHandler OnFailedAnswer;

        ICrono Crono { get; }
        Round CurrentRound { get; set; }
        void SetConcept(Game game);
    }
}
