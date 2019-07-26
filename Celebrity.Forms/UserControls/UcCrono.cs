using Celebrity.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Celebrity.Forms.UserControls
{
    public partial class UcCrono : UcBase, ICrono
    {
        public event EventHandler TimesUp;

        public bool Active { get; private set; }

        private int duracion;
        public int Duracion
        {
            get => duracion;
            set
            {
                if (Active)
                    throw new ArgumentException("No se puede cambiar la duración cuando el crono está activado");

                if (value <= 0)
                    throw new ArgumentOutOfRangeException("La duración debe ser mayor que 0");
                duracion = value;
            }
        }

        public int Segundos { get; private set; }

        public UcCrono()
        {
            InitializeComponent();
        }

        public void Start()
        {
            Segundos = Duracion;
            LblDescripcion.Text = duracion.ToString();
            TimerTiempo.Start();
            Active = true;
        }

        public void Stop()
        {
            Active = false;
            TimerTiempo.Stop();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            var color = Color.FromArgb(41, 128, 185);
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle,
                      color, 3, ButtonBorderStyle.Solid,
                      color, 3, ButtonBorderStyle.Solid,
                      color, 3, ButtonBorderStyle.Solid,
                      color, 3, ButtonBorderStyle.Solid);
        }

        private void TimerTiempo_Tick(object sender, EventArgs e)
        {
            Segundos--;
            LblDescripcion.Text = Segundos.ToString();
            if (Segundos <= 0)
            {
                TimesUp?.Invoke(this, EventArgs.Empty);
                Stop();
            }
        }
    }
}
