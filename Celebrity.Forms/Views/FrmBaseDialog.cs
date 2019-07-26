using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Celebrity.Forms.Views
{
    public partial class FrmBaseDialog : Celebrity.Forms.Views.FrmBase
    {
        public event EventHandler AceptadoClick;
        public event EventHandler CanceladoClick;

        public FrmBaseDialog()
        {
            InitializeComponent();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            int grosor = 1;
            var color = Program.ColorFondoNeutral;
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle,
                      color, grosor, ButtonBorderStyle.Solid,
                      color, grosor, ButtonBorderStyle.Solid,
                      color, grosor, ButtonBorderStyle.Solid,
                      color, grosor, ButtonBorderStyle.Solid);
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            AceptadoClick?.Invoke(this, e);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            CanceladoClick?.Invoke(this, e);
        }
    }
}
