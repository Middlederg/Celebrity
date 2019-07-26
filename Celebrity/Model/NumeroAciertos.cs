using System;
using System.Collections.Generic;
using System.Text;

namespace Celebrity.Model
{
    public class NumeroAciertos
    {
        public int Numero { get; private set; }

        public NumeroAciertos(int numero)
        {
            Numero = numero;
        }

        public override string ToString()
        {
            if (Numero == 0)
                return "Ninguna tarjeta acertada";

            if (Numero == 1)
                return "Una tarjeta acertada";

            return $"{Numero} tarjetas acertadas";
        }

        public string Mensaje()
        {
            if (Numero <= 0)
                return "Podéis hacerlo mejor";

            if (Numero == 1)
                return "Pasito a pasito";

            if (Numero == 2)
                return "¡No está mal!";

            if (Numero == 3)
                return "¡Bastante bien!";

            if (Numero == 4)
                return "¡Un equipo super compenetrado!";

            if (Numero == 5)
                return "¡Increible!";

            return "La victoria está a un paso";
        }
    }
}
