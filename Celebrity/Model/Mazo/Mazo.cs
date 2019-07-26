using System.Collections.Generic;
using System.Linq;

namespace Celebrity.Model
{
    public class Mazo
    {
        public List<Concepto> Tarjetas { get; private set; }

        public Mazo(MazoBaseCreator mazoCreator)
        {
            Tarjetas = mazoCreator.Create().ToList();
        }

        public void Acertar() => PrimeraTarjeta().Acertar();
        public void ReiniciarRonda()
        {
            foreach (var tarjeta in Tarjetas)
                tarjeta.Reiniciar();
        }

        public void PonerPrimeraTarjetaAlFinal()
        {
            var tarjeta = PrimeraTarjeta();
            Tarjetas.Remove(tarjeta);
            Tarjetas.Add(tarjeta);
        }

        public bool Terminado() => Tarjetas.All(x => x.Acertada);
        public int TarjetasSinAcertar() => Tarjetas.Count(x => !x.Acertada);
        public Concepto PrimeraTarjeta() => Tarjetas.First(x => !x.Acertada);
    }
}
