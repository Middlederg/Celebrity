using Celebrity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celebrity.Context
{
    public class GameContext
    {
        private Juego juego;
        private IMainView gameView;

        private int numeroAciertos;

        public GameContext(IMainView gameView, MazoBaseCreator mazoCreator, int crono, int numeroRondas, params Equipo[] equipos)
        {
            juego = new Juego(equipos, mazoCreator, crono, numeroRondas);
            this.gameView = gameView;
        }

        public void Play()
        {
            SuscribeToEvents();
            gameView.NuevaRonda.Ronda = juego.RondaActual;
            gameView.ShowNuevaRonda();
            gameView.MostrarVista();
            gameView.Dispose();
        }

        private void SuscribeToEvents()
        {
            gameView.NuevaRonda.Closed += OnNuevaRondaClosed;
            gameView.NuevoTurno.Closed += OnNuevoTurnoClosed;
            gameView.Tarjeta.RespuestaCorrecta += OnRespuestaCorrecta;
            gameView.Tarjeta.RespuestaFallo += OnRespuestaFallo;
            gameView.Tarjeta.Crono.TimesUp += OnTimesUp;
            gameView.FinTurno.Closed += OnFinTurnoClosed;
            gameView.FinRonda.Closed += OnFinRondaClosed;
            gameView.FinPartida.Closed += OnFinPartidaClosed;
        }

        private void OnNuevaRondaClosed(object sender, EventArgs e)
        {
            gameView.NuevoTurno.Equipo = juego.EquipoActual;
            gameView.ShowNuevoTurno();
        }

        private void OnNuevoTurnoClosed(object sender, EventArgs e)
        {
            numeroAciertos = 0;
            gameView.Tarjeta.RondaActual = juego.RondaActual;
            gameView.Tarjeta.Crono.Duracion = juego.DuracionCrono;
            gameView.Tarjeta.Crono.Start();
            gameView.Tarjeta.Tarjeta = juego.Mazo.PrimeraTarjeta();
            gameView.ShowTarjeta();
        }

        private void OnRespuestaCorrecta(object sender, EventArgs e)
        {
            juego.Acertado();
            numeroAciertos++;

            if (juego.RondaFinalizada())
                FinDeTurno();  
            else
                gameView.Tarjeta.Tarjeta = juego.Mazo.PrimeraTarjeta();
        }

        private void OnRespuestaFallo(object sender, EventArgs e)
        {
            juego.EquipoActual.Fallo();
            juego.Mazo.PonerPrimeraTarjetaAlFinal();
            gameView.Tarjeta.Tarjeta = juego.Mazo.PrimeraTarjeta();
        }

        private void OnTimesUp(object sender, EventArgs e)
        {
            FinDeTurno();
        }

        private void FinDeTurno()
        {
            gameView.Tarjeta.Crono.Stop();
            gameView.FinTurno.Informar(juego.EquipoActual, juego.EquipoSiguiente, numeroAciertos);
            gameView.ShowFinTurno();
        }

        private void OnFinTurnoClosed(object sender, EventArgs e)
        {
            if (juego.RondaFinalizada())
            {
                gameView.FinRonda.Informar(juego.RondaActual, juego.Equipos, juego.Rondas);
                gameView.ShowFinRonda();
            }
            else
            {
                gameView.NuevoTurno.Equipo = juego.EquipoSiguiente;
                gameView.ShowNuevoTurno();
            }
            
            juego.AvanzarTurnoSiguienteEquipo();
        }

        private void OnFinRondaClosed(object sender, EventArgs e)
        {
            juego.AvanzarRonda();
            if (juego.JuegoFinalizado())
            {
                gameView.FinPartida.Informar(juego.GetDatosFinalJuego());
                gameView.ShowFinPartida();
            }
            else
            {
                gameView.NuevaRonda.Ronda = juego.RondaActual;
                gameView.ShowNuevaRonda();
            }
        }

        private void OnFinPartidaClosed(object sender, EventArgs e)
        {
            gameView.CerrarVista();
        }
    }
}
