using Celebrity.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Celebrity.Forms.UserControls
{
    public partial class UcEquipo : UcBase
    {
        public event EventHandler OnCloseClicked;

        private Equipo equipo;
        public Equipo Equipo
        {
            get => equipo;
            set
            {
                equipo = value;
                BackColor = value.Color.GetColor;
                ToolTipAyuda.SetToolTip(this, value.ToString());
            }
        }

        public UcEquipo()
        {
            InitializeComponent();
        }

        private void BtnClose(object sender, EventArgs e)
        {
            OnCloseClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
