using Celebrity.Forms.Views;
using Celebrity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Celebrity.Forms.EdicionViews
{
    public partial class FrmCategoria : FrmBaseDialog
    {
        private IEnumerable<ComboBaseItem> categorias;

        public Guid? Id { get; set; }
        public string Nombre
        {
            get => TbxNombre.Text.Trim();
            set => TbxNombre.Text = value;
        }

        public string CategoriaPadre
        {
            get
            {
                if (CbxPrincipal.Checked)
                    return null;
                return (string)CmbPadre.SelectedValue;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    CmbPadre.SelectedValue = value;
                    CbxPrincipal.Checked = false;
                }
                else
                {
                    CbxPrincipal.Checked = true;
                }
            }
        }

        public FrmCategoria(IEnumerable<ComboBaseItem> categorias)
        {
            InitializeComponent();
            this.categorias = categorias;

            CmbPadre.DataSource = categorias;
            CmbPadre.DisplayMember = "Text";
            CmbPadre.ValueMember = "Value";

            AceptadoClick += OnAcepted;
        }

        private void OnAcepted(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbxNombre.Text))
            {
                CatErrorProvider.SetError(TbxNombre, "Debe seleccionar un nombre para la categoría");
                return;
            }

            if (categorias.Any(x => x.Text.ToUpper().Equals(Nombre.ToUpper())))
            {
                CatErrorProvider.SetError(TbxNombre, "Debe seleccionar un nombre de categoría que no exista");
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CbxPrincipal_CheckedChanged(object sender, EventArgs e)
        {
            CmbPadre.Enabled = !CbxPrincipal.Checked;
        }

        public override void OnClosedClicked() => Close();
    }
}
