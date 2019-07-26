using Celebrity.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Celebrity.Forms.Views
{
    public partial class FrmAddEquipo : FrmBaseDialog
    {
        public Equipo Equipo
        {
            get
            {
                var color = new Model.Color(ColorSelector.Color);
                var nombre = string.IsNullOrWhiteSpace(Tbx.Text) ? null : Tbx.Text.Trim();
                return new Equipo(color, nombre);
            }
            set
            {
                ColorSelector.Color = value.Color.GetColor;
                Tbx.Text = value.ToString();
            }
        }
        public FrmAddEquipo()
        {
            InitializeComponent();
            AceptadoClick += OnAceptacoClicked;
        }

        private void OnAceptacoClicked(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if (ColorSelector.ShowDialog() == DialogResult.OK)
            {
                Btn.ColorFondo = ColorSelector.Color;
            }            
        }

        
    }
}
