using Celebrity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Celebrity.Forms.UserControls
{
    public partial class UcEquipos : UcBase
    {
        public event EventHandler OnPlusClicked;

        public IEnumerable<Team> GetEquipos()
        {
            return Flp.Controls.OfType<UcEquipo>().Select(x => x.Equipo).ToList();
        }

        public void SetEquipos(IEnumerable<Team> value)
        {
            if (value != null)
            {
                foreach (var equipo in value)
                    AddEquipo(equipo);
            }
        }

        public UcEquipos()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            OnPlusClicked?.Invoke(this, EventArgs.Empty);
        }

        public void AddEquipo(Team equipo)
        {
            var uc = new UcEquipo()
            {
                Equipo = equipo
            };
            uc.OnCloseClicked += RemoveEquipoClicked;
            Flp.Controls.Add(uc);
        }

        private void RemoveEquipoClicked(object sender, EventArgs e)
        {
            Flp.Controls.Remove(sender as Control);
        }
    }
}
