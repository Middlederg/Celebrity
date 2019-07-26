using Celebrity.Model;
using System;

namespace Celebrity.Context
{
    public interface INuevaRondaView : ICerrable
    {
        Ronda Ronda { set; }
    }
}
