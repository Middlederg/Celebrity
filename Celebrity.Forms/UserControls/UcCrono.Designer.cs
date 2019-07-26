namespace Celebrity.Forms.UserControls
{
    partial class UcCrono
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.TimerTiempo = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblDescripcion.Font = new System.Drawing.Font("Liberation Mono", 20F);
            this.LblDescripcion.Location = new System.Drawing.Point(5, 5);
            this.LblDescripcion.Margin = new System.Windows.Forms.Padding(0);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(50, 50);
            this.LblDescripcion.TabIndex = 3;
            this.LblDescripcion.Text = "27";
            this.LblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerTiempo
            // 
            this.TimerTiempo.Interval = 1000;
            this.TimerTiempo.Tick += new System.EventHandler(this.TimerTiempo_Tick);
            // 
            // UcCrono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LblDescripcion);
            this.Name = "UcCrono";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(60, 60);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Timer TimerTiempo;
    }
}
