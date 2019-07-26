using Celebrity.Model;
using System;

namespace Celebrity.Context
{
    public interface ITarjetaView
    {
        event EventHandler RespuestaCorrecta;
        event EventHandler RespuestaFallo;

        ICrono Crono { get; }
        Ronda RondaActual { get; set; }
        Concepto Tarjeta { get; set; }
    }
}
