using Celebrity.Forms.UserControls;
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
    public partial class FrmConcepto : FrmBaseDialog
    {
        private IEnumerable<ComboBaseItem> categorias;
        private IEnumerable<string> conceptosExistentes;

        string nombreOriginal;
        public Guid? Id { get; set; }
        public string Nombre
        {
            get => TbxNombre.Text.Trim();
            set
            {
                TbxNombre.Text = value;
                nombreOriginal = value;
            }
        }

        public Difficulty Dificultad
        {
            get
            {
                if (RbtFacil.Checked) return Difficulty.Facil;
                if (RbtMedia.Checked) return Difficulty.Media;
                if (RbtDificil.Checked) return Difficulty.Dificil;
                return Difficulty.None;
            }
            set
            {
                if (value.EsFacil) RbtFacil.Checked = true;
                if (value.EsMedia) RbtMedia.Checked = true;
                if (value.EsDificil) RbtDificil.Checked = true;
            }
        }

        public IEnumerable<string> CategoriasSeleccionadas
        {
            get
            {
                foreach (UcTag tag in FlpTags.Controls.OfType<UcTag>())
                    yield return tag.Id;
            }
            set
            {
                foreach (ComboBaseItem categoria in categorias.Where(x => value.Contains(x.Value)))
                    AddTagToPanel(categoria);
            }
        }

        public FrmConcepto(IEnumerable<string> conceptosExistentes, IEnumerable<ComboBaseItem> categorias)
        {
            InitializeComponent();
            this.categorias = categorias;
            this.conceptosExistentes = conceptosExistentes;

            AceptadoClick += OnAcepted;
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newTag = TbxCategoria.Text.Trim();
                if(!string.IsNullOrWhiteSpace(TbxCategoria.Text))
                {
                    var categoria = categorias.FirstOrDefault(x => x.Text.ToUpper().Equals(newTag.ToUpper()));
                    if (categoria != null)
                    {
                        AddTagToPanel(categoria);
                    }
                }
            }
        }

        private void AddTagToPanel(ComboBaseItem categoria)
        {
            if (!IsInPanel(categoria))
            {
                var tag = new UcTag()
                {
                    Id = categoria.Value,
                    Titulo = categoria.Text
                };
                tag.OnClosedClick += TagOnClosedClick;
                FlpTags.Controls.Add(tag);
            }
        }

        private bool IsInPanel(ComboBaseItem categoria)
        {
            foreach (var tag in FlpTags.Controls.OfType<UcTag>())
            {
                if (tag.Id.Equals(categoria.Value))
                    return true;
            }
            return false;
        }

        private void TagOnClosedClick(object sender, EventArgs e)
        {
            FlpTags.Controls.Remove(sender as Control);
        }

        private void OnCategoriasTextChanged(object sender, EventArgs e)
        {
            var elementos = categorias
                .Where(x => x.Text.ToUpper().Contains(TbxCategoria.Text.Trim().ToUpper()))
                .Select(x => x.Text)
                .OrderBy(x => x).ToArray();

            AutoCompleteStringCollection autoCompleteSource = new AutoCompleteStringCollection();
            autoCompleteSource.AddRange(elementos);
            TbxCategoria.AutoCompleteCustomSource = autoCompleteSource;
        }

        private void OnAcepted(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbxNombre.Text))
            {
                CatErrorProvider.SetError(TbxNombre, "Debe seleccionar un nombre para el concepto");
                return;
            }

            if (nombreOriginal == null)
            {
                if (conceptosExistentes.Any(x => x.ToUpper().Equals(Nombre.ToUpper())))
                {
                    CatErrorProvider.SetError(TbxNombre, "Debe seleccionar un nombre de concepto que no exista");
                    return;
                }
            }

            if (!RbtFacil.Checked && !RbtMedia.Checked && !RbtDificil.Checked)
            {
                CatErrorProvider.SetError(TlpDificultad, "Debe seleccionar la dificultad para el concepto");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        public override void OnClosedClicked() => Close();
    }
}
