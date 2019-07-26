namespace Celebrity.Forms.UserControls
{
    partial class UcEquipo
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
            this.ToolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.customButton1 = new Celebrity.Forms.CustomControls.CustomButton();
            this.SuspendLayout();
            // 
            // customButton1
            // 
            this.customButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customButton1.BackColor = System.Drawing.Color.DimGray;
            this.customButton1.Cantidad = 10;
            this.customButton1.ColorFondo = System.Drawing.Color.DimGray;
            this.customButton1.ColorLetra = System.Drawing.Color.White;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.customButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.customButton1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.customButton1.IconColor = System.Drawing.Color.White;
            this.customButton1.IconSize = 12;
            this.customButton1.Location = new System.Drawing.Point(11, 0);
            this.customButton1.Margin = new System.Windows.Forms.Padding(0);
            this.customButton1.ModoComportamiento = Celebrity.Forms.ComportamientoBoton.Oscurecer;
            this.customButton1.Name = "customButton1";
            this.customButton1.Rotation = 0D;
            this.customButton1.Size = new System.Drawing.Size(12, 12);
            this.customButton1.TabIndex = 0;
            this.customButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.BtnClose);
            // 
            // UcEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.customButton1);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.Name = "UcEquipo";
            this.Size = new System.Drawing.Size(23, 23);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.CustomButton customButton1;
        private System.Windows.Forms.ToolTip ToolTipAyuda;
    }
}
