using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Celebrity.Model
{
    public class Equipo
    {
        private readonly string nombre;
        public Color Color { get; private set; }
        
        private List<Acierto> aciertos;
        public IReadOnlyList<Acierto> Aciertos => aciertos.ToList();
        public void AddAcierto(Concepto tarjeta, int ronda) => aciertos.Add(new Acierto(tarjeta, ronda));

        public int NumeroFallos { get; private set; }
        public void Fallo() => NumeroFallos++;

        public Equipo(Color color, string nombre = null)
        {
            this.nombre = nombre;
            Color = color;
            aciertos = new List<Acierto>();
        }

        public int NumeroAciertos(int? ronda = null)
        {
            if (ronda.HasValue)
                return aciertos.Count(x => x.Ronda == ronda);
            else return aciertos.Count();
        }

        public IEnumerable<string> TarjetasAcertadas(int? ronda = null)
        {
            if (ronda.HasValue)
                return aciertos.Where(x => x.Ronda == ronda).Select(x => x.Tarjeta.ToString());
            else return aciertos.Select(x => x.Tarjeta.ToString());
        }

        public IEnumerable<(int ronda, int numeroAciertos)> ResumenAciertos()
        {
            foreach (int ronda in Enumerable.Range(1, 4))
            {
                int numeroAciertos = NumeroAciertos(ronda);
                if (numeroAciertos > 0)
                    yield return (ronda, numeroAciertos);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is Equipo c)
                return c.Color.Equals(Color);
            return false;
        }
        public override int GetHashCode() => Color.GetHashCode();

        public override string ToString()
        {
            if (string.IsNullOrWhiteSpace(nombre))
                return $"Equipo {Color.ToString().ToLower()}";
            return nombre;
        }
    }
}
