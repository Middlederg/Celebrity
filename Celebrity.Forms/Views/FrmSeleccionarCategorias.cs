using Celebrity.Model;
using Celebrity.Repositories;
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
    public partial class FrmSeleccionarCategorias : FrmBaseDialog
    {
        public IEnumerable<Categoria> Categorias
        {
            get
            {
                foreach (TreeNode node in Tvw.Nodes)
                {
                    if (node.Checked)
                        yield return node.Tag as Categoria;

                    foreach (TreeNode subnode in node.Nodes)
                    {
                        if (subnode.Checked)
                            yield return subnode.Tag as Categoria;
                    }
                }
            }
            set
            {
                foreach (TreeNode node in Tvw.Nodes)
                {
                    var categoria = node.Tag as Categoria;
                    node.Checked = value.Contains(categoria);
                    foreach (TreeNode subnode in node.Nodes)
                    {
                        var subcategoria = subnode.Tag as Categoria;
                        subnode.Checked = value.Contains(subcategoria);
                    }
                }
            }
        }

        public string CategoriasString() => string.Join(", ", Categorias.Select(x => x.ToString()));

        private ICategoriasRepository repository;
        public FrmSeleccionarCategorias(ICategoriasRepository repository)
        {
            InitializeComponent();
            AceptadoClick += OnAceptarClicked;
            this.repository = repository;
            Fill();
        }

        public void Fill()
        {
            Tvw.Nodes.Clear();

            var categorias = repository.GetCategorias().ToList();
            var categoriasPrincipales = categorias.Where(x => !x.HasParent);
            var categoriasSecundarias = categorias.Where(x => x.HasParent);

            foreach (var categoria in categoriasPrincipales)
            {
                var node = new TreeNode(categoria.ToString())
                {
                    Checked = false,
                    Tag = categoria
                };
                foreach (var subcategoria in categoriasSecundarias.Where(x => x.IsChildOf(categoria.Id)))
                {
                    var subnode = new TreeNode(subcategoria.ToString())
                    {
                        Checked = false,
                        Tag = subcategoria
                    };
                    node.Nodes.Add(subnode);
                }
                Tvw.Nodes.Add(node);
            }
            Tvw.AfterCheck += OnAfterChecked;
        }

        private void OnAfterChecked(object sender, TreeViewEventArgs e)
        {
            foreach (TreeNode node in e.Node.Nodes)
                node.Checked = e.Node.Checked;
        }

        private void OnAceptarClicked(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
