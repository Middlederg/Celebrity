using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Celebrity.Forms.UserControls
{
    public partial class UcEditLabel : UcBase
    {
        public event EventHandler OnEditClicked;

        public string Titulo
        {
            get => Lbl.Text.Trim();
            set
            {
                Lbl.Text = value;
                TtAyuda.SetToolTip(Lbl, value);
            }
        }

        public UcEditLabel()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            OnEditClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
