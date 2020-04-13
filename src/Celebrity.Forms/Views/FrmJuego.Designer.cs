namespace Celebrity.Forms.Views
{
    partial class FrmJuego
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
            this.pContenedor = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pContenedor
            // 
            this.pContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContenedor.Location = new System.Drawing.Point(0, 38);
            this.pContenedor.Margin = new System.Windows.Forms.Padding(0);
            this.pContenedor.Name = "pContenedor";
            this.pContenedor.Size = new System.Drawing.Size(300, 362);
            this.pContenedor.TabIndex = 1;
            // 
            // FrmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.Cerrable = true;
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.pContenedor);
            this.Maximizable = true;
            this.Minimizable = true;
            this.Name = "FrmJuego";
            this.Text = "Celebrity";
            this.Titulo = "Celebrity";
            this.WindowColor = System.Drawing.Color.DimGray;
            this.Controls.SetChildIndex(this.pContenedor, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pContenedor;
    }
}
