using Celebrity.Model;
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
        public IEnumerable<Dificultad> Dificultades
        {
            get
            {
                if (CbxFacil.Checked) yield return Dificultad.Facil;
                if (CbxMedia.Checked) yield return Dificultad.Media;
                if (CbxDificil.Checked) yield return Dificultad.Dificil;
            }
            set
            {
                if (value.Contains(Dificultad.Facil)) CbxFacil.Checked = true;
                if (value.Contains(Dificultad.Media)) CbxMedia.Checked = true;
                if (value.Contains(Dificultad.Dificil)) CbxDificil.Checked = true;
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
