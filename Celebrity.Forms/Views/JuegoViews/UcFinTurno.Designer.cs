namespace Celebrity.Forms.JuegoViews
{
    partial class UcFinTurno
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
            this.LblSiguienteEquipo = new System.Windows.Forms.Label();
            this.LblMensaje = new System.Windows.Forms.Label();
            this.LblSeparador = new System.Windows.Forms.Label();
            this.LblNumeroAciertos = new System.Windows.Forms.Label();
            this.LblSeparador2 = new System.Windows.Forms.Label();
            this.BtnContinuar = new Celebrity.Forms.CustomControls.CustomButton();
            this.BtnTitulo = new Celebrity.Forms.CustomControls.CustomButton();
            this.TlpContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpContenido
            // 
            this.TlpContenido.ColumnCount = 1;
            this.TlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpContenido.Controls.Add(this.LblSiguienteEquipo, 0, 5);
            this.TlpContenido.Controls.Add(this.LblMensaje, 0, 4);
            this.TlpContenido.Controls.Add(this.LblSeparador, 0, 2);
            this.TlpContenido.Controls.Add(this.LblNumeroAciertos, 0, 3);
            this.TlpContenido.Controls.Add(this.LblSeparador2, 0, 0);
            this.TlpContenido.Controls.Add(this.BtnContinuar, 0, 6);
            this.TlpContenido.Controls.Add(this.BtnTitulo, 0, 1);
            this.TlpContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpContenido.Location = new System.Drawing.Point(0, 0);
            this.TlpContenido.Margin = new System.Windows.Forms.Padding(0);
            this.TlpContenido.Name = "TlpContenido";
            this.TlpContenido.Padding = new System.Windows.Forms.Padding(15);
            this.TlpContenido.RowCount = 7;
            this.TlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.TlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.TlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TlpContenido.Size = new System.Drawing.Size(300, 400);
            this.TlpContenido.TabIndex = 3;
            // 
            // LblSiguienteEquipo
            // 
            this.LblSiguienteEquipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblSiguienteEquipo.Font = new System.Drawing.Font("Open Sans", 12F);
            this.LblSiguienteEquipo.Location = new System.Drawing.Point(15, 266);
            this.LblSiguienteEquipo.Margin = new System.Windows.Forms.Padding(0);
            this.LblSiguienteEquipo.Name = "LblSiguienteEquipo";
            this.LblSiguienteEquipo.Size = new System.Drawing.Size(270, 69);
            this.LblSiguienteEquipo.TabIndex = 7;
            this.LblSiguienteEquipo.Text = "Ahora es el turno del equipo siguiente";
            this.LblSiguienteEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblMensaje
            // 
            this.LblMensaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblMensaje.Font = new System.Drawing.Font("Open Sans", 10F);
            this.LblMensaje.Location = new System.Drawing.Point(15, 197);
            this.LblMensaje.Margin = new System.Windows.Forms.Padding(0);
            this.LblMensaje.Name = "LblMensaje";
            this.LblMensaje.Size = new System.Drawing.Size(270, 69);
            this.LblMensaje.TabIndex = 6;
            this.LblMensaje.Text = "¡No está mal!";
            this.LblMensaje.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblSeparador
            // 
            this.LblSeparador.BackColor = System.Drawing.Color.DimGray;
            this.LblSeparador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblSeparador.Font = new System.Drawing.Font("Open Sans", 11F);
            this.LblSeparador.Location = new System.Drawing.Point(15, 155);
            this.LblSeparador.Margin = new System.Windows.Forms.Padding(0);
            this.LblSeparador.Name = "LblSeparador";
            this.LblSeparador.Size = new System.Drawing.Size(270, 2);
            this.LblSeparador.TabIndex = 3;
            this.LblSeparador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblNumeroAciertos
            // 
            this.LblNumeroAciertos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblNumeroAciertos.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Bold);
            this.LblNumeroAciertos.Location = new System.Drawing.Point(15, 167);
            this.LblNumeroAciertos.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.LblNumeroAciertos.Name = "LblNumeroAciertos";
            this.LblNumeroAciertos.Size = new System.Drawing.Size(270, 30);
            this.LblNumeroAciertos.TabIndex = 2;
            this.LblNumeroAciertos.Text = "3 tarjetas aceptadas";
            this.LblNumeroAciertos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.BtnContinuar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(100)))), ((int)(((byte)(160)))));
            this.BtnContinuar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(110)))), ((int)(((byte)(170)))));
            this.BtnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnContinuar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnContinuar.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContinuar.ForeColor = System.Drawing.Color.White;
            this.BtnContinuar.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.BtnContinuar.IconColor = System.Drawing.Color.White;
            this.BtnContinuar.IconSize = 26;
            this.BtnContinuar.Location = new System.Drawing.Point(15, 345);
            this.BtnContinuar.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.BtnContinuar.ModoComportamiento = Celebrity.Forms.ComportamientoBoton.Oscurecer;
            this.BtnContinuar.Name = "BtnContinuar";
            this.BtnContinuar.Rotation = 0D;
            this.BtnContinuar.Size = new System.Drawing.Size(270, 40);
            this.BtnContinuar.TabIndex = 5;
            this.BtnContinuar.Text = "Continuar";
            this.BtnContinuar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnContinuar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnContinuar.UseVisualStyleBackColor = false;
            this.BtnContinuar.Click += new System.EventHandler(this.BtnContinuar_Click);
            // 
            // BtnTitulo
            // 
            this.BtnTitulo.BackColor = System.Drawing.Color.Transparent;
            this.BtnTitulo.Cantidad = 10;
            this.BtnTitulo.ColorFondo = System.Drawing.Color.Transparent;
            this.BtnTitulo.ColorLetra = System.Drawing.Color.Black;
            this.BtnTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnTitulo.Enabled = false;
            this.BtnTitulo.FlatAppearance.BorderSize = 0;
            this.BtnTitulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(100)))), ((int)(((byte)(160)))));
            this.BtnTitulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(110)))), ((int)(((byte)(170)))));
            this.BtnTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTitulo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnTitulo.Font = new System.Drawing.Font("Open Sans", 22F);
            this.BtnTitulo.ForeColor = System.Drawing.Color.Black;
            this.BtnTitulo.IconChar = FontAwesome.Sharp.IconChar.HourglassEnd;
            this.BtnTitulo.IconColor = System.Drawing.Color.Black;
            this.BtnTitulo.IconSize = 50;
            this.BtnTitulo.Location = new System.Drawing.Point(15, 17);
            this.BtnTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.BtnTitulo.ModoComportamiento = Celebrity.Forms.ComportamientoBoton.Oscurecer;
            this.BtnTitulo.Name = "BtnTitulo";
            this.BtnTitulo.Rotation = 0D;
            this.BtnTitulo.Size = new System.Drawing.Size(270, 138);
            this.BtnTitulo.TabIndex = 8;
            this.BtnTitulo.Text = "Time\'s Up!";
            this.BtnTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnTitulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnTitulo.UseVisualStyleBackColor = false;
            // 
            // UcFinTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.Controls.Add(this.TlpContenido);
            this.Name = "UcFinTurno";
            this.Size = new System.Drawing.Size(300, 400);
            this.TlpContenido.ResumeLayout(false);
            this.TlpContenido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpContenido;
        private System.Windows.Forms.Label LblSiguienteEquipo;
        private System.Windows.Forms.Label LblMensaje;
        private System.Windows.Forms.Label LblSeparador;
        private System.Windows.Forms.Label LblNumeroAciertos;
        private System.Windows.Forms.Label LblSeparador2;
        private CustomControls.CustomButton BtnContinuar;
        private CustomControls.CustomButton BtnTitulo;
    }
}
