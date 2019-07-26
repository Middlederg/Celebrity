using Celebrity.Model;
using System.Collections.Generic;

namespace Celebrity.Context
{
    public interface IFinRondaView : ICerrable
    {
        void Informar(Ronda rondaActual, IEnumerable<Equipo> equipos, IEnumerable<Ronda> rondas);
    }
}
