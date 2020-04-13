using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celebrity.Forms.UserControls
{
    public partial class UcTag : UcBase
    {
        public event EventHandler OnClosedClick;

        public string Id { get; set; }
        public string Titulo
        {
            get => LblTitulo.Text;
            set
            {
                LblTitulo.Text = value;
                TtAyuda.SetToolTip(LblTitulo, value);
            }
        }

        public UcTag()
        {
            InitializeComponent();
        }


        private void BtnRemove_Click(object sender, EventArgs e)
        {
            OnClosedClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
