using System;
using System.Collections.Generic;

namespace Celebrity.Model
{
    public class FinalDeJuego
    {
        private Juego juego;

        public IEnumerable<Equipo> Equipos => juego.Equipos;
        public IEnumerable<Ronda> Rondas => juego.Rondas;
        public Equipo Ganador { get; private set; }
        public bool Empate => Ganador == null;

        public FinalDeJuego(Juego juego)
        {
            this.juego = juego;
            if (!juego.JuegoFinalizado())
                throw new Exception("El juego aun no ha finalizado");
            Ganador = juego.Ganador();
        }
    }
}
