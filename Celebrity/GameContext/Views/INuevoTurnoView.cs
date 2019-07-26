using Celebrity.Model;

namespace Celebrity.Context
{
    public interface INuevoTurnoView : ICerrable
    {
        Equipo Equipo { get; set; }
    }
}
