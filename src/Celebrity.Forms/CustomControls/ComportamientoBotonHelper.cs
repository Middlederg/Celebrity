using System;
using System.Drawing;

namespace Celebrity.Forms
{
    public static class ComportamientoBotonHelper
    {
        public static Color Oscurecer(this Color color, int cantidad)
        {
            return Color.FromArgb(
                (color.R - cantidad).Ajustar(), 
                (color.G - cantidad).Ajustar(), 
                (color.B - cantidad).Ajustar()
                );
        }

        public static Color Aclarar(this Color color, int cantidad)
        {
            return Color.FromArgb(
                (color.R + cantidad).Ajustar(), 
                (color.G + cantidad).Ajustar(), 
                (color.B + cantidad).Ajustar()
                );
        }

        public static Color Procesar(this ComportamientoBoton modo, Color color, int cantidad)
        {
            if (modo == ComportamientoBoton.Aclarar)
                return color.Aclarar(cantidad);
            return color.Oscurecer(cantidad);
        }

        private static int Ajustar(this int valor) => Math.Max(Math.Min(155, valor), 0);
    }
}
