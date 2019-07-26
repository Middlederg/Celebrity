using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Celebrity.Forms.CustomControls
{
    public partial class CustomButton : IconButton
    {
        public ComportamientoBoton ModoComportamiento { get; set; } = ComportamientoBoton.Oscurecer;
        public int Cantidad { get; set; } = 10;

        public Color ColorFondo
        {
            get => BackColor;
            set
            {
                BackColor = value;
                FlatAppearance.MouseOverBackColor = ModoComportamiento.Procesar(value, Cantidad);
                FlatAppearance.MouseDownBackColor = ModoComportamiento.Procesar(value, Cantidad*2);
            }
        }

        public Color ColorLetra
        {
            get => ForeColor;
            set => ForeColor = IconColor = value;
        }

        public CustomButton()
        {
            InitializeComponent();
        }
    }
}
