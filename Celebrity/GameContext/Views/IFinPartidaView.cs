using Celebrity.Model;

namespace Celebrity.Context
{
    public interface IFinPartidaView : ICerrable
    {
        void Informar(FinalDeJuego finalJuego);
    }
}
