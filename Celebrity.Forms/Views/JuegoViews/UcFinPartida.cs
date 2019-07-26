using Celebrity.Context;
using Celebrity.Forms.UserControls;
using Celebrity.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Celebrity.Forms.JuegoViews
{
    public partial class UcFinPartida : UcBase, IFinPartidaView
    {
        public event EventHandler Closed;

        public UcFinPartida()
        {
            InitializeComponent();
            BtnContinuar.ColorFondo = LblSeparador.BackColor = LblSeparador2.BackColor = Program.ColorFondoNeutral;
            BtnContinuar.ColorLetra = Program.ColorLetraNeutral;
        }

        public void Informar(FinalDeJuego finalJuego)
        {
            TablaResumen.UpdateTable(finalJuego.Equipos, finalJuego.Rondas);
            if (finalJuego.Empate)
                LblTitulo.Text = "Empate";
            else
            {
                LblTitulo.Text = $"Victoria del {finalJuego.Ganador.ToString()}";
                LblSeparador.BackColor = LblSeparador2.BackColor = BtnContinuar.ColorFondo = finalJuego.Ganador.Color.GetColor;
            }
        }

        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            Closed?.Invoke(this, EventArgs.Empty);
        }
    }
}
