namespace Celebrity.Forms.Views
{
    partial class FrmDificultad
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
            this.TlpCentro = new System.Windows.Forms.TableLayoutPanel();
            this.CbxFacil = new System.Windows.Forms.CheckBox();
            this.CbxMedia = new System.Windows.Forms.CheckBox();
            this.CbxDificil = new System.Windows.Forms.CheckBox();
            this.TlpCentro.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpCentro
            // 
            this.TlpCentro.ColumnCount = 1;
            this.TlpCentro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpCentro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpCentro.Controls.Add(this.CbxFacil, 0, 0);
            this.TlpCentro.Controls.Add(this.CbxMedia, 0, 1);
            this.TlpCentro.Controls.Add(this.CbxDificil, 0, 2);
            this.TlpCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpCentro.Location = new System.Drawing.Point(1, 39);
            this.TlpCentro.Margin = new System.Windows.Forms.Padding(0);
            this.TlpCentro.Name = "TlpCentro";
            this.TlpCentro.Padding = new System.Windows.Forms.Padding(30, 12, 0, 0);
            this.TlpCentro.RowCount = 3;
            this.TlpCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TlpCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TlpCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TlpCentro.Size = new System.Drawing.Size(178, 122);
            this.TlpCentro.TabIndex = 2;
            // 
            // CbxFacil
            // 
            this.CbxFacil.AutoSize = true;
            this.CbxFacil.Location = new System.Drawing.Point(33, 15);
            this.CbxFacil.Name = "CbxFacil";
            this.CbxFacil.Size = new System.Drawing.Size(59, 24);
            this.CbxFacil.TabIndex = 0;
            this.CbxFacil.Text = "Fácil";
            this.CbxFacil.UseVisualStyleBackColor = true;
            // 
            // CbxMedia
            // 
            this.CbxMedia.AutoSize = true;
            this.CbxMedia.Location = new System.Drawing.Point(33, 51);
            this.CbxMedia.Name = "CbxMedia";
            this.CbxMedia.Size = new System.Drawing.Size(71, 24);
            this.CbxMedia.TabIndex = 1;
            this.CbxMedia.Text = "Media";
            this.CbxMedia.UseVisualStyleBackColor = true;
            // 
            // CbxDificil
            // 
            this.CbxDificil.AutoSize = true;
            this.CbxDificil.Location = new System.Drawing.Point(33, 87);
            this.CbxDificil.Name = "CbxDificil";
            this.CbxDificil.Size = new System.Drawing.Size(67, 24);
            this.CbxDificil.TabIndex = 2;
            this.CbxDificil.Text = "Difícil";
            this.CbxDificil.UseVisualStyleBackColor = true;
            // 
            // FrmDificultad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(180, 200);
            this.Controls.Add(this.TlpCentro);
            this.Name = "FrmDificultad";
            this.Text = "Seleccionar dificultad";
            this.Titulo = "Seleccionar dificultad";
            this.Controls.SetChildIndex(this.TlpCentro, 0);
            this.TlpCentro.ResumeLayout(false);
            this.TlpCentro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpCentro;
        private System.Windows.Forms.CheckBox CbxFacil;
        private System.Windows.Forms.CheckBox CbxMedia;
        private System.Windows.Forms.CheckBox CbxDificil;
    }
}
