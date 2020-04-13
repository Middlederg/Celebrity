using Celebrity.Context;
using Celebrity.Forms.UserControls;
using Celebrity;
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

        public Round Ronda
        {
            set
            {
                LblPrincipal.Text = value.ToString();
                LblDescripcion.Text = value.Description;
                LblOpciones.Text = value.AnswerLimitationInstructions();
                LblPasar.Text = value.NextConceptInstructions();
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
