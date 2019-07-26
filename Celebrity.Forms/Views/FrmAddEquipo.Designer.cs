namespace Celebrity.Forms.Views
{
    partial class FrmAddEquipo
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
            this.Tlp = new System.Windows.Forms.TableLayoutPanel();
            this.Tbx = new System.Windows.Forms.TextBox();
            this.ColorSelector = new System.Windows.Forms.ColorDialog();
            this.Btn = new Celebrity.Forms.CustomControls.CustomButton();
            this.Tlp.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tlp
            // 
            this.Tlp.ColumnCount = 2;
            this.Tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tlp.Controls.Add(this.Btn, 0, 0);
            this.Tlp.Controls.Add(this.Tbx, 1, 0);
            this.Tlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp.Location = new System.Drawing.Point(1, 39);
            this.Tlp.Margin = new System.Windows.Forms.Padding(0);
            this.Tlp.Name = "Tlp";
            this.Tlp.Padding = new System.Windows.Forms.Padding(15);
            this.Tlp.RowCount = 1;
            this.Tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tlp.Size = new System.Drawing.Size(248, 72);
            this.Tlp.TabIndex = 2;
            // 
            // Tbx
            // 
            this.Tbx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tbx.Location = new System.Drawing.Point(69, 22);
            this.Tbx.Margin = new System.Windows.Forms.Padding(0);
            this.Tbx.Name = "Tbx";
            this.Tbx.Size = new System.Drawing.Size(160, 27);
            this.Tbx.TabIndex = 0;
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
            this.Btn.IconChar = FontAwesome.Sharp.IconChar.EyeDropper;
            this.Btn.IconColor = System.Drawing.Color.White;
            this.Btn.IconSize = 27;
            this.Btn.Location = new System.Drawing.Point(15, 15);
            this.Btn.Margin = new System.Windows.Forms.Padding(0);
            this.Btn.ModoComportamiento = Celebrity.Forms.ComportamientoBoton.Oscurecer;
            this.Btn.Name = "Btn";
            this.Btn.Rotation = 0D;
            this.Btn.Size = new System.Drawing.Size(40, 40);
            this.Btn.TabIndex = 2;
            this.Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn.UseVisualStyleBackColor = false;
            this.Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // FrmAddEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(250, 150);
            this.Controls.Add(this.Tlp);
            this.Name = "FrmAddEquipo";
            this.Text = "Añadir equipo";
            this.Titulo = "Añadir equipo";
            this.Controls.SetChildIndex(this.Tlp, 0);
            this.Tlp.ResumeLayout(false);
            this.Tlp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Tlp;
        private System.Windows.Forms.TextBox Tbx;
        private System.Windows.Forms.ColorDialog ColorSelector;
        private CustomControls.CustomButton Btn;
    }
}
