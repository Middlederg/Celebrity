using Celebrity.Context;
using Celebrity.Data.Repositories;
using Celebrity;
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
    public partial class FrmInicio : FrmBase
    {
        public IEnumerable<Team> Equipos() => EquiposSelector.GetEquipos();
        public IEnumerable<Difficulty> Dificultades() => DificultadSelector.Tag as IEnumerable<Difficulty>;
        public IEnumerable<Category> Categorias() => CategoriasSelector.Tag as IEnumerable<Category>;

        public int NumeroConceptos
        {
            get => (int)NudConceptos.Value;
            set => NudConceptos.Value = value;
        }

        public int NumeroRondas
        {
            get => (int)NudRondas.Value;
            set => NudRondas.Value = value;
        }

        public int SegundosCrono
        {
            get => (int)NudSegundos.Value;
            set => NudSegundos.Value = value;
        }

        public FrmInicio()
        {
            InitializeComponent();

            EquiposSelector.OnPlusClicked += OnAddEquipoClicked;
            DificultadSelector.OnEditClicked += OnDificultadClicked;
            CategoriasSelector.OnEditClicked += OnCategoriasClicked;
        }

        private void OnAddEquipoClicked(object sender, EventArgs e)
        {
            using (var fEquipo = new FrmAddEquipo())
            {
                if (fEquipo.ShowDialog() == DialogResult.OK)
                {
                    EquiposSelector.AddEquipo(fEquipo.Equipo);
                }
            }
        }

        private void OnDificultadClicked(object sender, EventArgs e)
        {
            using (var fDificultad = new FrmDificultad())
            {
                if (fDificultad.ShowDialog() == DialogResult.OK)
                {
                    DificultadSelector.Tag = fDificultad.Dificultades;
                    DificultadSelector.Titulo = fDificultad.DificultadesString();
                }
            }
        }

        private void OnCategoriasClicked(object sender, EventArgs e)
        {
            using (var fCategorias = new FrmSeleccionarCategorias(new CategoriasRepository()))
            {
                if (fCategorias.ShowDialog() == DialogResult.OK)
                {
                    CategoriasSelector.Tag = fCategorias.Categorias.ToList();
                    CategoriasSelector.Titulo = fCategorias.CategoriasString();
                }
            }
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnJugar_Click(object sender, EventArgs e)
        {
            if (!Validacion())
                return;

            Visible = false;
            var categorias = Categorias() ?? new CategoriasRepository().GetCategorias();
            var mazoCreator = new MazoCreator(new ConceptosRepository(), categorias, Dificultades(), NumeroConceptos);
            new GameContext(new FrmJuego(), mazoCreator, SegundosCrono, NumeroRondas, Equipos().ToArray()).Play();
            Close();
        }

        private bool Validacion()
        {
            if (Equipos() == null || Equipos().Count() == 0)
            {
                EpErrores.SetError(EquiposSelector, "Debes seleccionar algún equipo");
                return false;
            }

            return true;
        }
    }
}
