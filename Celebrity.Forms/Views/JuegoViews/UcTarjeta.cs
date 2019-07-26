using Celebrity.Context;
using Celebrity.Forms.UserControls;
using Celebrity.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Celebrity.Forms.JuegoViews
{
    public partial class UcTarjeta : UcBase, ITarjetaView
    {
        public event EventHandler RespuestaCorrecta;
        public event EventHandler RespuestaFallo;

        public ICrono Crono => Cronometro;

        private Ronda rondaActual;
        public Ronda RondaActual
        {
            get => rondaActual;
            set
            {
                rondaActual = value;
                BtnFallo.Visible = rondaActual.SePuedePasar;
                TlpContenido.SetColumnSpan(BtnAcierto, rondaActual.SePuedePasar ? 1 : 2);
            }
        }

        private Concepto tarjeta;
        public Concepto Tarjeta
        {
            get => tarjeta;
            set
            {
                tarjeta = value;
                LblTarjeta.Text = value.ToString();
            }
        }

        public UcTarjeta()
        {
            InitializeComponent();
        }

        private void BtnAcierto_Click(object sender, EventArgs e)
        {
            RespuestaCorrecta?.Invoke(this, EventArgs.Empty);
        }

        private void BtnFallo_Click(object sender, EventArgs e)
        {
            RespuestaFallo?.Invoke(this, EventArgs.Empty);
        }
    }
}
