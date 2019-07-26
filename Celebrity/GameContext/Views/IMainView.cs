using System;

namespace Celebrity.Context
{
    public interface IMainView : IDisposable
    {
        void MostrarVista();
        void CerrarVista();

        INuevaRondaView NuevaRonda { get; }
        void ShowNuevaRonda();
        INuevoTurnoView NuevoTurno { get; }
        void ShowNuevoTurno();
        ITarjetaView Tarjeta { get; }
        void ShowTarjeta();
        IFinTurnoView FinTurno { get; }
        void ShowFinTurno();
        IFinRondaView FinRonda { get; }
        void ShowFinRonda();
        IFinPartidaView FinPartida { get; }
        void ShowFinPartida();
    }
}
