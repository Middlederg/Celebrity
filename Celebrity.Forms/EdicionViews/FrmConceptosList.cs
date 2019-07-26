using Celebrity.Forms.Views;
using Celebrity.Model;
using Celebrity.Repositories;
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
    public partial class FrmConceptosList : FrmBase
    {
        private ICategoriasRepository categoriasRepository;
        private IConceptosRepository repository;
        
        private IEnumerable<Concepto> conceptos;
        private IEnumerable<Concepto> GetConceptos
        {
            get
            {
                var conceptosFiltrados = conceptos;
                var categoria = (string) CmbCategoria.SelectedValue;
                if (categoria != null)
                {
                    conceptosFiltrados = conceptosFiltrados.Where(x => 
                        x.TieneCategoria(categoria)).ToList();
                }
                if (string.IsNullOrWhiteSpace(TbxBuscar.Text))
                    return conceptosFiltrados;
                string filtro = TbxBuscar.Text.Trim().ToUpper();
                return conceptosFiltrados.Where(x => x.ToString().ToUpper().Contains(filtro)).ToList();
            }
        }
        private IEnumerable<ComboBaseItem> categoriasAll;

        public FrmConceptosList(IConceptosRepository repository, ICategoriasRepository categoriasRepository)
        {
            InitializeComponent();

            this.repository = repository;
            this.categoriasRepository = categoriasRepository;
            categoriasAll = categoriasRepository.GetComboItemsAll().ToList();

            var comboCategoriasList = categoriasAll.ToList();
            comboCategoriasList.Insert(0, new ComboBaseItem() { Value = null, Text = "Cualquiera" });
            CmbCategoria.DataSource = comboCategoriasList;
            CmbCategoria.DisplayMember = "Text";
            CmbCategoria.ValueMember = "Value";

            CmbCategoria.SelectedIndexChanged += CmbCategoria_SelectedIndexChanged;
            LoadFromDataBase();
            Fill();
        }

        private void LoadFromDataBase() => conceptos = repository.GetConceptos().ToList();
        private void Fill()
        {
            Lvw.Items.Clear();
            foreach (var concepto in GetConceptos)
            {
                var item = new ListViewItem(concepto.ToString()) { Tag = concepto };
                item.SubItems.Add(concepto.Dificultad.ToString());
                Lvw.Items.Add(item);
            }
        }

        private void BtnAddConceptoClick(object sender, EventArgs e)
        {
            using (var f = new FrmConcepto(conceptos.Select(x => x.ToString()).ToList(), categoriasAll))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    var categorias = categoriasRepository.GetCategoriasPorId(f.CategoriasSeleccionadas.ToList());
                    repository.InsertarConcepto(Concepto.Create(f.Nombre, f.Dificultad, categorias));
                    LoadFromDataBase();
                    Fill();
                }
            }
        }

        private void OnDoubleClick(object sender, EventArgs e)
        {
            if (Lvw.SelectedItems.Count == 1)
            {
                var concepto = Lvw.SelectedItems[0].Tag as Concepto;
                using (var f = new FrmConcepto(conceptos.Select(x => x.ToString()).ToList(), categoriasAll))
                {
                    f.Id = concepto.Id;
                    f.Nombre = concepto.ToString();
                    f.Dificultad = concepto.Dificultad;
                    f.CategoriasSeleccionadas = concepto.Categorias.Select(x => x.Id.ToString());
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        concepto.CambiarNombre(f.Nombre);
                        concepto.CambiarDificultad(f.Dificultad);
                        var categorias = categoriasRepository.GetCategoriasPorId(f.CategoriasSeleccionadas);
                        concepto.EditarCategorias(categorias);
                        repository.EditarConcepto(concepto);
                        LoadFromDataBase();
                        Fill();
                    }
                }
            }
        }

        private void BtnOk_Click(object sender, EventArgs e) => Close();
        public override void OnClosedClicked() => Close();

        private void FiltrarTextChanged(object sender, EventArgs e) => Fill();
        private void CmbCategoria_SelectedIndexChanged(object sender, EventArgs e) => Fill();
        
    }
}
