using System.Collections.Generic;
using System.Linq;

namespace Celebrity.Model
{
    public class Juego
    {
        private int ronda;
        private int turno;

        public Mazo Mazo { get; private set; }
        public List<Equipo> Equipos { get; private set; }
        public List<Ronda> Rondas { get; private set; }

        public Equipo EquipoActual => Equipos[turno];
        public Equipo EquipoSiguiente => Equipos[turno >= Equipos.Count - 1 ? 0 : turno + 1];
        public Ronda RondaActual => Rondas[ronda - 1];

        public int DuracionCrono { get; }

        public Juego(IEnumerable<Equipo> equipos, MazoBaseCreator mazoCreator, int duracionCrono, int numeroRondas = 3)
        {
            Equipos = equipos.ToList();
            DuracionCrono = duracionCrono;
            turno = 0;
            Rondas = new List<Ronda> { new PrimeraRonda() };
            if (numeroRondas >= 2) Rondas.Add(new SegundaRonda());
            if (numeroRondas >= 3) Rondas.Add(new TerceraRonda());
            if (numeroRondas >= 4) Rondas.Add(new CuartaRonda());
            ronda = 1;
            Mazo = new Mazo(mazoCreator);
        }

        private void AvanzarTurno() => turno = turno >= Equipos.Count - 1 ? 0 : turno + 1;

        public void Acertado()
        {
            EquipoActual.AddAcierto(Mazo.PrimeraTarjeta(), RondaActual.NumeroRonda);
            Mazo.Acertar();
        }

        public void AvanzarRonda()
        {
            ronda++;
            Mazo.ReiniciarRonda();
        }

        public void AvanzarTurnoSiguienteEquipo()
        {
            AvanzarTurno();
            if (!Mazo.Terminado())
                Mazo.PonerPrimeraTarjetaAlFinal();
        }

        public bool RondaFinalizada() => Mazo.Terminado();
        public bool JuegoFinalizado() => ronda > Rondas.Count;

        public Equipo Ganador()
        {
            var puntuaciónGanadora = Equipos.Max(x => x.NumeroAciertos());
            var numeroEquiposGanadores = Equipos.Count(x => x.NumeroAciertos() == puntuaciónGanadora);

            if (numeroEquiposGanadores != 1)
                return null;
            return Equipos.First(x => x.NumeroAciertos() == puntuaciónGanadora);
        }

        public FinalDeJuego GetDatosFinalJuego() => new FinalDeJuego(this);
    }
}
