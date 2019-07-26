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
    public partial class UcNuevaRonda : UcBase, INuevaRondaView
    {
        public event EventHandler Closed;

        public Ronda Ronda
        {
            set
            {
                LblPrincipal.Text = value.ToString();
                LblDescripcion.Text = value.Descripcion;
                LblOpciones.Text = value.FallarText();
                LblPasar.Text = value.PasarText();
            }
        }

        public UcNuevaRonda()
        {
            InitializeComponent();

            BtnContinuar.ColorFondo = LblSeparador.BackColor = LblSeparador2.BackColor = Program.ColorFondoNeutral;
            BtnContinuar.ColorLetra = Program.ColorLetraNeutral;
        }

        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            Closed?.Invoke(this, EventArgs.Empty);
        }
    }
}
