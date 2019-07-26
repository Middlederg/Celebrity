namespace Celebrity.Forms.JuegoViews
{
    partial class UcTarjeta
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
            this.LblTarjeta = new System.Windows.Forms.Label();
            this.BtnFallo = new Celebrity.Forms.CustomControls.CustomButton();
            this.LblSeparador = new System.Windows.Forms.Label();
            this.LblSeparador2 = new System.Windows.Forms.Label();
            this.BtnAcierto = new Celebrity.Forms.CustomControls.CustomButton();
            this.Cronometro = new Celebrity.Forms.UserControls.UcCrono();
            this.TlpContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpContenido
            // 
            this.TlpContenido.ColumnCount = 2;
            this.TlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpContenido.Controls.Add(this.LblTarjeta, 0, 3);
            this.TlpContenido.Controls.Add(this.LblSeparador, 0, 4);
            this.TlpContenido.Controls.Add(this.LblSeparador2, 0, 2);
            this.TlpContenido.Controls.Add(this.Cronometro, 0, 0);
            this.TlpContenido.Controls.Add(this.BtnAcierto, 0, 6);
            this.TlpContenido.Controls.Add(this.BtnFallo, 1, 6);
            this.TlpContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpContenido.Location = new System.Drawing.Point(0, 0);
            this.TlpContenido.Margin = new System.Windows.Forms.Padding(0);
            this.TlpContenido.Name = "TlpContenido";
            this.TlpContenido.Padding = new System.Windows.Forms.Padding(15);
            this.TlpContenido.RowCount = 8;
            this.TlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.TlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.TlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.TlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.TlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.TlpContenido.Size = new System.Drawing.Size(300, 400);
            this.TlpContenido.TabIndex = 3;
            // 
            // LblTarjeta
            // 
            this.TlpContenido.SetColumnSpan(this.LblTarjeta, 2);
            this.LblTarjeta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTarjeta.Font = new System.Drawing.Font("Open Sans", 18F);
            this.LblTarjeta.Location = new System.Drawing.Point(15, 117);
            this.LblTarjeta.Margin = new System.Windows.Forms.Padding(0);
            this.LblTarjeta.Name = "LblTarjeta";
            this.LblTarjeta.Size = new System.Drawing.Size(270, 106);
            this.LblTarjeta.TabIndex = 9;
            this.LblTarjeta.Text = "titulo";
            this.LblTarjeta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnFallo
            // 
            this.BtnFallo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnFallo.BackColor = System.Drawing.Color.Silver;
            this.BtnFallo.Cantidad = 10;
            this.BtnFallo.ColorFondo = System.Drawing.Color.Silver;
            this.BtnFallo.ColorLetra = System.Drawing.Color.Black;
            this.BtnFallo.FlatAppearance.BorderSize = 0;
            this.BtnFallo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.BtnFallo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.BtnFallo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFallo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnFallo.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFallo.ForeColor = System.Drawing.Color.Black;
            this.BtnFallo.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.BtnFallo.IconColor = System.Drawing.Color.Black;
            this.BtnFallo.IconSize = 45;
            this.BtnFallo.Location = new System.Drawing.Point(177, 255);
            this.BtnFallo.Margin = new System.Windows.Forms.Padding(0);
            this.BtnFallo.ModoComportamiento = Celebrity.Forms.ComportamientoBoton.Oscurecer;
            this.BtnFallo.Name = "BtnFallo";
            this.BtnFallo.Rotation = 0D;
            this.BtnFallo.Size = new System.Drawing.Size(80, 60);
            this.BtnFallo.TabIndex = 8;
            this.BtnFallo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFallo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFallo.UseVisualStyleBackColor = false;
            this.BtnFallo.Click += new System.EventHandler(this.BtnFallo_Click);
            // 
            // LblSeparador
            // 
            this.LblSeparador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.TlpContenido.SetColumnSpan(this.LblSeparador, 2);
            this.LblSeparador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblSeparador.Font = new System.Drawing.Font("Open Sans", 11F);
            this.LblSeparador.Location = new System.Drawing.Point(15, 223);
            this.LblSeparador.Margin = new System.Windows.Forms.Padding(0);
            this.LblSeparador.Name = "LblSeparador";
            this.LblSeparador.Size = new System.Drawing.Size(270, 2);
            this.LblSeparador.TabIndex = 3;
            this.LblSeparador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSeparador2
            // 
            this.LblSeparador2.AutoSize = true;
            this.LblSeparador2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.TlpContenido.SetColumnSpan(this.LblSeparador2, 2);
            this.LblSeparador2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblSeparador2.Location = new System.Drawing.Point(15, 115);
            this.LblSeparador2.Margin = new System.Windows.Forms.Padding(0);
            this.LblSeparador2.Name = "LblSeparador2";
            this.LblSeparador2.Size = new System.Drawing.Size(270, 2);
            this.LblSeparador2.TabIndex = 4;
            // 
            // BtnAcierto
            // 
            this.BtnAcierto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAcierto.BackColor = System.Drawing.Color.Gray;
            this.BtnAcierto.Cantidad = 10;
            this.BtnAcierto.ColorFondo = System.Drawing.Color.Gray;
            this.BtnAcierto.ColorLetra = System.Drawing.Color.White;
            this.BtnAcierto.FlatAppearance.BorderSize = 0;
            this.BtnAcierto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.BtnAcierto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnAcierto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAcierto.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnAcierto.Font = new System.Drawing.Font("Open Sans", 22F, System.Drawing.FontStyle.Bold);
            this.BtnAcierto.ForeColor = System.Drawing.Color.White;
            this.BtnAcierto.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.BtnAcierto.IconColor = System.Drawing.Color.White;
            this.BtnAcierto.IconSize = 55;
            this.BtnAcierto.Location = new System.Drawing.Point(42, 255);
            this.BtnAcierto.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAcierto.ModoComportamiento = Celebrity.Forms.ComportamientoBoton.Oscurecer;
            this.BtnAcierto.Name = "BtnAcierto";
            this.BtnAcierto.Rotation = 0D;
            this.BtnAcierto.Size = new System.Drawing.Size(80, 60);
            this.BtnAcierto.TabIndex = 5;
            this.BtnAcierto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAcierto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAcierto.UseVisualStyleBackColor = false;
            this.BtnAcierto.Click += new System.EventHandler(this.BtnAcierto_Click);
            // 
            // Cronometro
            // 
            this.Cronometro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cronometro.BackColor = System.Drawing.Color.White;
            this.TlpContenido.SetColumnSpan(this.Cronometro, 2);
            this.Cronometro.Duracion = 30;
            this.Cronometro.Font = new System.Drawing.Font("Open Sans", 12F);
            this.Cronometro.Location = new System.Drawing.Point(120, 25);
            this.Cronometro.Margin = new System.Windows.Forms.Padding(0);
            this.Cronometro.Name = "Cronometro";
            this.Cronometro.Padding = new System.Windows.Forms.Padding(5);
            this.Cronometro.Size = new System.Drawing.Size(60, 60);
            this.Cronometro.TabIndex = 11;
            // 
            // UcTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.Controls.Add(this.TlpContenido);
            this.Name = "UcTarjeta";
            this.TlpContenido.ResumeLayout(false);
            this.TlpContenido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpContenido;
        private System.Windows.Forms.Label LblTarjeta;
        private CustomControls.CustomButton BtnFallo;
        private System.Windows.Forms.Label LblSeparador;
        private System.Windows.Forms.Label LblSeparador2;
        private CustomControls.CustomButton BtnAcierto;
        private UserControls.UcCrono Cronometro;
    }
}
