using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Celebrity.Context;
using Celebrity.Forms.UserControls;
using Celebrity.Model;

namespace Celebrity.Forms.JuegoViews
{
    public partial class UcFinRonda : UcBase, IFinRondaView
    {
        public event EventHandler Closed;

        public UcFinRonda()
        {
            InitializeComponent();

            BtnContinuar.ColorFondo = LblSeparador.BackColor = LblSeparador2.BackColor = Program.ColorFondoNeutral;
            BtnContinuar.ColorLetra = Program.ColorLetraNeutral;
        }

        public void Informar(Ronda rondaActual, IEnumerable<Equipo> equipos, IEnumerable<Ronda> rondas)
        {
            LblTitulo.Text = $"Fin de la {rondaActual.ToString()}";
            TablaResumen.UpdateTable(equipos, rondas);
        }

        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            Closed?.Invoke(this, e);
        }
    }
}
