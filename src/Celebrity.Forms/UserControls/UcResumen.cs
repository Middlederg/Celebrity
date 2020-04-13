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
    public partial class UcResumen : UcBase
    {
        public UcResumen()
        {
            InitializeComponent();
        }

        public void UpdateTable(IEnumerable<Team> equipos, IEnumerable<Round> rondas)
        {
            var ancho = Width / (equipos.Count() + 1);
            Controls.Clear();
            TableLayoutPanel table = new TableLayoutPanel()
            {
                Location = new System.Drawing.Point(0, 20),
                Width = Width,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset,
                RowCount = rondas.Count() + 1,
                ColumnCount = equipos.Count() + 1
            };
            int iCol = 1;
            foreach (var equipo in equipos)
            {
                var lbl = CreateCell(equipo.Color.ToString(), ContentAlignment.MiddleCenter, ancho, equipo.Color.GetColor, FontStyle.Bold);
                table.Controls.Add(lbl, iCol, 0);
                iCol++;
            }

            int iRow = 1;
            foreach (var ronda in rondas)
            {
                var lbl = CreateCell(ronda.ToString(), ContentAlignment.MiddleLeft, ancho, null, FontStyle.Bold);
                table.Controls.Add(lbl, 0, iRow);
                iCol = 1;
                foreach (var equipo in equipos)
                {
                    var lblDetalle = CreateCell(equipo.Points(ronda.Number).ToString(), ContentAlignment.MiddleRight, ancho);
                    table.Controls.Add(lblDetalle, iCol, iRow);
                    iCol++;
                }
                iRow++;
            }
            Controls.Add(table);
        }

        private Label CreateCell(string value, ContentAlignment alignment, int ancho, System.Drawing.Color? backColor = null, 
            FontStyle style = FontStyle.Regular)
        {
            return new Label()
            {
                Text = value,
                Font = new Font("Open Sans", 10, style),
                AutoSize = false,
                TextAlign = alignment,
                Dock = DockStyle.Fill,
                BackColor = backColor ?? System.Drawing.Color.Transparent,
                Padding = new Padding(0),
                Margin = new Padding(0),
                Width = ancho,
                Height = 20
            };
        }


    }
}
