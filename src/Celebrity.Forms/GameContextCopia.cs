using Celebrity.Forms.JuegoViews;
using Celebrity.Forms.Views;
using Celebrity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celebrity.Forms
{
    public class GameContextCopia
    {
        private Game juego;
        private FrmJuego gameView;

        private int numeroAciertos;

        public GameContextCopia(MazoBaseCreator mazoCreator, int crono, int numeroRondas, params Team[] equipos)
        {
            juego = new Game(equipos, mazoCreator, crono, numeroRondas);
        }

        public void Play()
        {
            using (gameView = new FrmJuego())
            {
                SuscribeToEvents();
                gameView.NuevaRonda.Ronda = juego.RondaActual;
                gameView.ShowNuevaRonda();
                gameView.ShowDialog();
            }
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
            gameView.Tarjeta.Tarjeta = juego.deck.VisibleConcept();
            gameView.ShowTarjeta();
        }

        private void OnRespuestaCorrecta(object sender, EventArgs e)
        {
            juego.Acertado();
            numeroAciertos++;

            if (juego.RondaFinalizada())
                FinDeTurno();  
            else
                gameView.Tarjeta.Tarjeta = juego.deck.VisibleConcept();
        }

        private void OnRespuestaFallo(object sender, EventArgs e)
        {
            juego.EquipoActual.AddFailure();
            juego.deck.PassConcept();
            gameView.Tarjeta.Tarjeta = juego.deck.VisibleConcept();
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
                gameView.FinRonda.Informar(juego.RondaActual, juego.Teams, juego.Rondas);
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
            gameView.Close();
        }
    }
}
