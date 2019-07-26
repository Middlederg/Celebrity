using Celebrity.Data;
using Celebrity.Data.Repositories;
using Celebrity.Forms.Views;
using Celebrity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Celebrity.Forms
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //new SeedPrincipal();

            //Application.Run(new FrmEditar());
            Application.Run(new FrmInicio());

            //var mazoCreator = new MazoFastCreator(new TarjetaRepository());
            //new GameContext(mazoCreator).Play();
        }

        public static System.Drawing.Color ColorFondoNeutral = System.Drawing.Color.DimGray;
        public static System.Drawing.Color ColorLetraNeutral = System.Drawing.Color.White;
    }
}
