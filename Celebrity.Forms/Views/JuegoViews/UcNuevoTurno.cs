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
    public partial class UcNuevoTurno : UcBase, INuevoTurnoView
    {
        public event EventHandler Closed;

        private Equipo equipo;
        public Equipo Equipo
        {
            get => equipo;
            set
            {
                equipo = value;
                LblEquipo.Text = $"Turno del {value.ToString()}";
                LblSeparador.BackColor = LblSeparador2.BackColor = BtnContinuar.ColorFondo = BtnTitulo.IconColor = LblEquipo.BackColor = value.Color.GetColor;
            }
        }

        public UcNuevoTurno()
        {
            InitializeComponent();
        }

        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            Closed?.Invoke(this, EventArgs.Empty);
        }
    }
}
