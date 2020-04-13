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
    public partial class UcFinTurno : UcBase, IFinTurnoView
    {
        public event EventHandler Closed;

        public UcFinTurno()
        {
            InitializeComponent();

            BtnContinuar.ColorFondo = LblSeparador.BackColor = LblSeparador2.BackColor = Program.ColorFondoNeutral;
            BtnContinuar.ColorLetra = Program.ColorLetraNeutral;
        }

        public void Informar(Team equipoActual, Team equipoSiguiente, int numeroAciertos)
        {
            NumeroAciertos aciertos = new NumeroAciertos(numeroAciertos);
            LblNumeroAciertos.Text = aciertos.ToString();
            LblMensaje.Text = aciertos.Mensaje();
            LblSiguienteEquipo.Text = $"Ahora es el turno del equipo {equipoSiguiente.ToString()}";

            LblSeparador.BackColor = LblSeparador2.BackColor = BtnContinuar.ColorFondo = equipoActual.Color.GetColor;
        }

        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            Closed?.Invoke(this, EventArgs.Empty);
        }
    }
}
