using System;

namespace Celebrity.Context
{
    public interface IMainView : IDisposable
    {
        void MostrarVista();
        void CerrarVista();

        IStartRoundView StartRound { get; }
        void ShowStartRound();
        IStartTeamTurnView StartTeamTurn { get; }
        void ShowNuevoTurno();
        IConceptView Tarjeta { get; }
        void ShowTarjeta();
        IEndOfTurnView FinTurno { get; }
        void ShowFinTurno();
        IEndOfRoundView FinRonda { get; }
        void ShowFinRonda();
        IEndOfGameView FinPartida { get; }
        void ShowFinPartida();
    }
}
