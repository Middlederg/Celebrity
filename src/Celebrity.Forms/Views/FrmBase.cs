using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celebrity.Forms.Views
{
    public partial class FrmBase : Form
    {
        public Color WindowColor
        {
            get => TlpPrincipal.BackColor;
            set
            {
                TlpPrincipal.BackColor = value;
                BtnMax.ColorFondo = value;
                BtnMin.ColorFondo = value;
                BtnClose.ColorFondo = value;
            }
        }

        public string Titulo
        {
            get => LblTitulo.Text;
            set
            {
                LblTitulo.Text = value;
                Text = value;
            }
        }

        public bool Minimizable
        {
            get { return BtnMin.Visible; }
            set
            {
                BtnMin.Visible = value;
                ChangeColumn(value, 2);
            }
        }

        public bool Maximizable
        {
            get { return BtnMax.Visible; }
            set
            {
                BtnMax.Visible = value;
                ChangeColumn(value, 3);
            }
        }
        public bool Cerrable
        {
            get { return BtnClose.Visible; }
            set
            {
                BtnClose.Visible = value;
                ChangeColumn(value, 4);
            }
        }

        private void ChangeColumn(bool visible, int columna)
        {
            if (visible) MakeVisible(columna);
            else MakeInvisible(columna);
        }
        private void MakeVisible(int columna) => TlpPrincipal.ColumnStyles[columna].Width = 30;
        private void MakeInvisible(int columna) => TlpPrincipal.ColumnStyles[columna].Width = 0;

        public FrmBase()
        {
            InitializeComponent();
        }

        private void BtnMaxClick(object sender, EventArgs e) => BarraSuperiorDobleClick(null, null);
        private void BtnCloseClick(object sender, EventArgs e) => OnClosedClicked();
        private void BtnMinClick(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;
        private void BarraSuperiorDobleClick(object sender, EventArgs e)
           => WindowState = WindowState.Equals(FormWindowState.Maximized) ?
            FormWindowState.Normal :
            FormWindowState.Maximized;

        public virtual void OnClosedClicked() => Application.Exit();


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                 int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MoveFormMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
