namespace Celebrity.Forms.UserControls
{
    partial class UcEquipos
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
            this.TtAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.TlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.Btn = new Celebrity.Forms.CustomControls.CustomButton();
            this.Flp = new System.Windows.Forms.FlowLayoutPanel();
            this.TlpPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpPrincipal
            // 
            this.TlpPrincipal.ColumnCount = 2;
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.TlpPrincipal.Controls.Add(this.Btn, 1, 0);
            this.TlpPrincipal.Controls.Add(this.Flp, 0, 0);
            this.TlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.TlpPrincipal.Name = "TlpPrincipal";
            this.TlpPrincipal.RowCount = 1;
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpPrincipal.Size = new System.Drawing.Size(198, 27);
            this.TlpPrincipal.TabIndex = 0;
            // 
            // Btn
            // 
            this.Btn.BackColor = System.Drawing.Color.DimGray;
            this.Btn.Cantidad = 10;
            this.Btn.ColorFondo = System.Drawing.Color.DimGray;
            this.Btn.ColorLetra = System.Drawing.Color.White;
            this.Btn.FlatAppearance.BorderSize = 0;
            this.Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Btn.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn.ForeColor = System.Drawing.Color.White;
            this.Btn.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.Btn.IconColor = System.Drawing.Color.White;
            this.Btn.IconSize = 27;
            this.Btn.Location = new System.Drawing.Point(171, 0);
            this.Btn.Margin = new System.Windows.Forms.Padding(0);
            this.Btn.ModoComportamiento = Celebrity.Forms.ComportamientoBoton.Oscurecer;
            this.Btn.Name = "Btn";
            this.Btn.Rotation = 0D;
            this.Btn.Size = new System.Drawing.Size(27, 27);
            this.Btn.TabIndex = 1;
            this.Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn.UseVisualStyleBackColor = false;
            this.Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Flp
            // 
            this.Flp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Flp.Location = new System.Drawing.Point(1, 1);
            this.Flp.Margin = new System.Windows.Forms.Padding(1);
            this.Flp.Name = "Flp";
            this.Flp.Size = new System.Drawing.Size(169, 25);
            this.Flp.TabIndex = 2;
            // 
            // UcEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.TlpPrincipal);
            this.Name = "UcEquipos";
            this.Size = new System.Drawing.Size(198, 27);
            this.TlpPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip TtAyuda;
        private System.Windows.Forms.TableLayoutPanel TlpPrincipal;
        private CustomControls.CustomButton Btn;
        private System.Windows.Forms.FlowLayoutPanel Flp;
    }
}
