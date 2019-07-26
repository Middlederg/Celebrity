using Celebrity.Context;
using Celebrity.Forms.JuegoViews;
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
    public partial class FrmJuego : FrmBase, IMainView
    {
        public FrmJuego()
        {
            InitializeComponent();
            pContenedor.Controls.AddRange(
                new UserControl[] 
                {
                    new UcNuevaRonda() { Dock = DockStyle.Fill },
                    new UcNuevoTurno() { Dock = DockStyle.Fill },
                    new UcTarjeta() { Dock = DockStyle.Fill },
                    new UcFinTurno() { Dock = DockStyle.Fill },
                    new UcFinRonda() { Dock = DockStyle.Fill },
                    new UcFinPartida() { Dock = DockStyle.Fill }
                });
        }

        private T GetControl<T>() => pContenedor.Controls.OfType<T>().FirstOrDefault();
        private void ShowControl<T>()
        {
            var selectedControl = GetControl<T>();
            foreach (Control control in pContenedor.Controls)
                control.Visible = false;
            (selectedControl as Control).Visible = true;
        }

        public INuevaRondaView NuevaRonda => GetControl<UcNuevaRonda>();
        public void ShowNuevaRonda() => ShowControl<UcNuevaRonda>();
        public INuevoTurnoView NuevoTurno => GetControl<UcNuevoTurno>();
        public void ShowNuevoTurno() => ShowControl<UcNuevoTurno>();
        public ITarjetaView Tarjeta => GetControl<UcTarjeta>();
        public void ShowTarjeta() => ShowControl<UcTarjeta>();
        public IFinTurnoView FinTurno => GetControl<UcFinTurno>();
        public void ShowFinTurno() => ShowControl<UcFinTurno>();
        public IFinRondaView FinRonda => GetControl<UcFinRonda>();
        public void ShowFinRonda() => ShowControl<UcFinRonda>();
        public IFinPartidaView FinPartida => GetControl<UcFinPartida>();
        public void ShowFinPartida() => ShowControl<UcFinPartida>();


        public void MostrarVista() => ShowDialog();
        public void CerrarVista() => Close();
    }
}
