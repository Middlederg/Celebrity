using Celebrity.Data.Repositories;
using Celebrity.Forms.EdicionViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celebrity.Forms.Views
{
    public partial class FrmEditar : FrmBase
    {
        public FrmEditar()
        {
            InitializeComponent();
        }

        private void BtnCategorias_Click(object sender, EventArgs e)
        {
            Visible = false;
            using (var f = new FrmCategoriasList(new CategoriasRepository()))
            {
                f.ShowDialog();
            }
            Visible = true;
        }

        private void BtnConceptos_Click(object sender, EventArgs e)
        {
            Visible = false;
            using (var f = new FrmConceptosList(new ConceptosRepository(), new CategoriasRepository()))
            {
                f.ShowDialog();
            }
            Visible = true;
        }
    }
}
