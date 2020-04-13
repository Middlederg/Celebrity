using Celebrity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Celebrity.Forms.Views
{
    public partial class FrmDificultad : Celebrity.Forms.Views.FrmBaseDialog
    {
        public IEnumerable<Difficulty> Dificultades
        {
            get
            {
                if (CbxFacil.Checked) yield return Difficulty.Facil;
                if (CbxMedia.Checked) yield return Difficulty.Media;
                if (CbxDificil.Checked) yield return Difficulty.Dificil;
            }
            set
            {
                if (value.Contains(Difficulty.Facil)) CbxFacil.Checked = true;
                if (value.Contains(Difficulty.Media)) CbxMedia.Checked = true;
                if (value.Contains(Difficulty.Dificil)) CbxDificil.Checked = true;
            }
        }

        public string DificultadesString() => string.Join(", ", Dificultades.ToList());

        public FrmDificultad()
        {
            InitializeComponent();
            AceptadoClick += OnAceptarClicked;
        }

        private void OnAceptarClicked(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
