using Celebrity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celebrity.Context
{
    public class GameContext
    {
        private const int DefaultCronoDuration = 30;

        private readonly Game game;
        private readonly IMainView gameView;

        private int numeroAciertos;

        public GameContext(IMainView gameView, List<Concept> concepts, IEnumerable<Team> teams, int totalRounds = RoundFactory.DefaultTotalRounds)
        {
            game = new Game(concepts, teams, totalRounds);
            this.gameView = gameView;
        }

        public void Play()
        {
            SuscribeToEvents();
            gameView.StartRound.Round = game.CurrentRound;
            gameView.ShowStartRound();
            gameView.MostrarVista();
            gameView.Dispose();
        }

        private void SuscribeToEvents()
        {
            gameView.StartRound.OnClosing += OnStartRoundClosed;
            gameView.StartTeamTurn.OnClosing += OnStartTeamTurnClosed;
            gameView.Tarjeta.OnGuessedAnswer += OnRespuestaCorrecta;
            gameView.Tarjeta.OnFailedAnswer += OnRespuestaFallo;
            gameView.Tarjeta.Crono.TimesUp += OnTimesUp;
            gameView.FinTurno.OnClosing += OnFinTurnoClosed;
            gameView.FinRonda.OnClosing += OnFinRondaClosed;
            gameView.FinPartida.OnClosing += OnFinPartidaClosed;
        }

        private void OnStartRoundClosed(object sender, EventArgs e)
        {
            gameView.StartTeamTurn.Team = game.CurrentTeam;
            gameView.ShowNuevoTurno();
        }

        private void OnStartTeamTurnClosed(object sender, EventArgs e)
        {
            numeroAciertos = 0;
            gameView.Tarjeta.CurrentRound = game.CurrentRound;
            gameView.Tarjeta.Crono.Duracion = DefaultCronoDuration;
            gameView.Tarjeta.Crono.Start();
            gameView.Tarjeta.Concept = game.deck.VisibleConcept();
            gameView.ShowTarjeta();
        }

        private void OnRespuestaCorrecta(object sender, EventArgs e)
        {
            game.GuessCurrentConcept();
            numeroAciertos++;

            if (game.EndOfRound())
                FinDeTurno();  
            else
                gameView.Tarjeta.Concept = game.deck.VisibleConcept();
        }

        private void OnRespuestaFallo(object sender, EventArgs e)
        {
            game.CurrentTeam.AddFailure();
            game.deck.PassConcept();
            gameView.Tarjeta.Concept = game.deck.VisibleConcept();
        }

        private void OnTimesUp(object sender, EventArgs e)
        {
            FinDeTurno();
        }

        private void FinDeTurno()
        {
            gameView.Tarjeta.Crono.Stop();
            gameView.FinTurno.Inform(game.CurrentTeam, game.NextTeam, numeroAciertos);
            gameView.ShowFinTurno();
        }

        private void OnFinTurnoClosed(object sender, EventArgs e)
        {
            if (game.EndOfRound())
            {
                gameView.FinRonda.Inform(game.CurrentRound, game.teams, game.rounds);
                gameView.ShowFinRonda();
            }
            else
            {
                gameView.StartTeamTurn.Team = game.NextTeam;
                gameView.ShowNuevoTurno();
            }
            
            game.AvanzarTurnoSiguienteEquipo();
        }

        private void OnFinRondaClosed(object sender, EventArgs e)
        {
            game.NextRound();
            if (game.EndOfGame())
            {
                gameView.FinPartida.Informar(game.GetDatosFinalJuego());
                gameView.ShowFinPartida();
            }
            else
            {
                gameView.StartRound.Round = game.CurrentRound;
                gameView.ShowStartRound();
            }
        }

        private void OnFinPartidaClosed(object sender, EventArgs e)
        {
            gameView.CerrarVista();
        }
    }
}
