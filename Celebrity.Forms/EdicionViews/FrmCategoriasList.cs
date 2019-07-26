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
    public partial class FrmCategoriasList : FrmBase
    {
        private ICategoriasRepository repository;
        private IEnumerable<Categoria> categorias;
        private IEnumerable<Categoria> GetCategorias
        {
            get
            {
                if (string.IsNullOrWhiteSpace(TbxBuscar.Text))
                    return categorias;
                string filtro = TbxBuscar.Text.Trim().ToUpper();
                return categorias.Where(x => x.ToString().ToUpper().Contains(filtro)).ToList();
            }
        }

        public FrmCategoriasList(ICategoriasRepository repository)
        {
            InitializeComponent();

            this.repository = repository;
            LoadFromDataBase();
            Fill();
        }

        private void LoadFromDataBase() => categorias = repository.GetCategorias().ToList();
        private void Fill()
        {
            Lvw.Items.Clear();
            foreach (var categoria in GetCategorias)
            {
                var item = new ListViewItem(categoria.ToString()) { Tag = categoria };
                Lvw.Items.Add(item);
            }
        }

        private void BtnAddCategorias_Click(object sender, EventArgs e)
        {
            using (var f = new FrmCategoria(repository.GetComboItemsCategorias().ToList()))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    string parent = f.CategoriaPadre;
                    repository.InsertarCategoria(Categoria.Create(f.Nombre, parent == null ? (Guid?)null : new Guid(parent)));
                    LoadFromDataBase();
                    Fill();
                }
            }
        }

        private void FiltrarTextChanged(object sender, EventArgs e)
        {
            Fill();
        }

        private void OnDoubleClick(object sender, EventArgs e)
        {
            if (Lvw.SelectedItems.Count == 1)
            {
                var categoria = Lvw.SelectedItems[0].Tag as Categoria;
                using (var f = new FrmCategoria(repository.GetComboItemsCategorias().ToList()))
                {
                    f.Id = categoria.Id;
                    f.Nombre = categoria.ToString();
                    f.CategoriaPadre = categoria.ParentToString;
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        categoria.CambiarNombre(f.Nombre);
                        var padre = f.CategoriaPadre;
                        categoria.CambiarPadre(padre != null ? new Guid(padre) : (Guid?)null);
                        repository.EditarCategoria(categoria);
                        Fill();
                    }
                }
            }
        }

        private void BtnOk_Click(object sender, EventArgs e) => Close();
        public override void OnClosedClicked() => Close();
    }
}
