namespace Celebrity.Forms.JuegoViews
{
    partial class UcFinPartida
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
            this.TlpContenido = new System.Windows.Forms.TableLayoutPanel();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblSeparador = new System.Windows.Forms.Label();
            this.LblSeparador2 = new System.Windows.Forms.Label();
            this.BtnContinuar = new Celebrity.Forms.CustomControls.CustomButton();
            this.TablaResumen = new Celebrity.Forms.UserControls.UcResumen();
            this.TlpContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpContenido
            // 
            this.TlpContenido.ColumnCount = 1;
            this.TlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpContenido.Controls.Add(this.LblTitulo, 0, 1);
            this.TlpContenido.Controls.Add(this.LblSeparador, 0, 2);
            this.TlpContenido.Controls.Add(this.LblSeparador2, 0, 0);
            this.TlpContenido.Controls.Add(this.BtnContinuar, 0, 4);
            this.TlpContenido.Controls.Add(this.TablaResumen, 0, 3);
            this.TlpContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpContenido.Location = new System.Drawing.Point(0, 0);
            this.TlpContenido.Margin = new System.Windows.Forms.Padding(0);
            this.TlpContenido.Name = "TlpContenido";
            this.TlpContenido.Padding = new System.Windows.Forms.Padding(15);
            this.TlpContenido.RowCount = 5;
            this.TlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.TlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.TlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpContenido.Size = new System.Drawing.Size(300, 400);
            this.TlpContenido.TabIndex = 3;
            // 
            // LblTitulo
            // 
            this.LblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitulo.Font = new System.Drawing.Font("Open Sans", 20F);
            this.LblTitulo.Location = new System.Drawing.Point(15, 17);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(270, 94);
            this.LblTitulo.TabIndex = 9;
            this.LblTitulo.Text = "titulo";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSeparador
            // 
            this.LblSeparador.BackColor = System.Drawing.Color.DimGray;
            this.LblSeparador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblSeparador.Font = new System.Drawing.Font("Open Sans", 11F);
            this.LblSeparador.Location = new System.Drawing.Point(15, 111);
            this.LblSeparador.Margin = new System.Windows.Forms.Padding(0);
            this.LblSeparador.Name = "LblSeparador";
            this.LblSeparador.Size = new System.Drawing.Size(270, 2);
            this.LblSeparador.TabIndex = 3;
            this.LblSeparador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSeparador2
            // 
            this.LblSeparador2.AutoSize = true;
            this.LblSeparador2.BackColor = System.Drawing.Color.DimGray;
            this.LblSeparador2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblSeparador2.Location = new System.Drawing.Point(15, 15);
            this.LblSeparador2.Margin = new System.Windows.Forms.Padding(0);
            this.LblSeparador2.Name = "LblSeparador2";
            this.LblSeparador2.Size = new System.Drawing.Size(270, 2);
            this.LblSeparador2.TabIndex = 4;
            // 
            // BtnContinuar
            // 
            this.BtnContinuar.BackColor = System.Drawing.Color.DimGray;
            this.BtnContinuar.Cantidad = 10;
            this.BtnContinuar.ColorFondo = System.Drawing.Color.DimGray;
            this.BtnContinuar.ColorLetra = System.Drawing.Color.White;
            this.BtnContinuar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnContinuar.FlatAppearance.BorderSize = 0;
            this.BtnContinuar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.BtnContinuar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.BtnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnContinuar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnContinuar.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContinuar.ForeColor = System.Drawing.Color.White;
            this.BtnContinuar.IconChar = FontAwesome.Sharp.IconChar.Trophy;
            this.BtnContinuar.IconColor = System.Drawing.Color.White;
            this.BtnContinuar.IconSize = 28;
            this.BtnContinuar.Location = new System.Drawing.Point(15, 344);
            this.BtnContinuar.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.BtnContinuar.ModoComportamiento = Celebrity.Forms.ComportamientoBoton.Oscurecer;
            this.BtnContinuar.Name = "BtnContinuar";
            this.BtnContinuar.Rotation = 0D;
            this.BtnContinuar.Size = new System.Drawing.Size(270, 41);
            this.BtnContinuar.TabIndex = 5;
            this.BtnContinuar.Text = "¡Enhorabuena!";
            this.BtnContinuar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnContinuar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnContinuar.UseVisualStyleBackColor = false;
            this.BtnContinuar.Click += new System.EventHandler(this.BtnContinuar_Click);
            // 
            // TablaResumen
            // 
            this.TablaResumen.BackColor = System.Drawing.Color.White;
            this.TablaResumen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablaResumen.Font = new System.Drawing.Font("Open Sans", 12F);
            this.TablaResumen.Location = new System.Drawing.Point(15, 113);
            this.TablaResumen.Margin = new System.Windows.Forms.Padding(0);
            this.TablaResumen.Name = "TablaResumen";
            this.TablaResumen.Size = new System.Drawing.Size(270, 221);
            this.TablaResumen.TabIndex = 8;
            // 
            // UcFinPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.Controls.Add(this.TlpContenido);
            this.Name = "UcFinPartida";
            this.TlpContenido.ResumeLayout(false);
            this.TlpContenido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpContenido;
        private System.Windows.Forms.Label LblSeparador;
        private System.Windows.Forms.Label LblSeparador2;
        private CustomControls.CustomButton BtnContinuar;
        private UserControls.UcResumen TablaResumen;
        private System.Windows.Forms.Label LblTitulo;
    }
}
