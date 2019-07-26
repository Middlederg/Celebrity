using Celebrity.Model;

namespace Celebrity.Context
{
    public interface IFinTurnoView : ICerrable
    {
        void Informar(Equipo equipoActual, Equipo equipoSiguiente, int numeroAciertos);
    }
}
