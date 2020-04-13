namespace Celebrity.Forms.Views
{
    partial class FrmBaseDialog
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
            this.TlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.BtnCancel = new Celebrity.Forms.CustomControls.CustomButton();
            this.BtnOk = new Celebrity.Forms.CustomControls.CustomButton();
            this.TlpBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpBotones
            // 
            this.TlpBotones.ColumnCount = 3;
            this.TlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.TlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.TlpBotones.Controls.Add(this.BtnCancel, 2, 0);
            this.TlpBotones.Controls.Add(this.BtnOk, 1, 0);
            this.TlpBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TlpBotones.Location = new System.Drawing.Point(1, 311);
            this.TlpBotones.Margin = new System.Windows.Forms.Padding(0);
            this.TlpBotones.Name = "TlpBotones";
            this.TlpBotones.RowCount = 1;
            this.TlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.TlpBotones.Size = new System.Drawing.Size(248, 38);
            this.TlpBotones.TabIndex = 1;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCancel.BackColor = System.Drawing.Color.DimGray;
            this.BtnCancel.Cantidad = 10;
            this.BtnCancel.ColorFondo = System.Drawing.Color.DimGray;
            this.BtnCancel.ColorLetra = System.Drawing.Color.White;
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.BtnCancel.IconColor = System.Drawing.Color.White;
            this.BtnCancel.IconSize = 21;
            this.BtnCancel.Location = new System.Drawing.Point(208, 4);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCancel.ModoComportamiento = Celebrity.Forms.ComportamientoBoton.Oscurecer;
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Rotation = 0D;
            this.BtnCancel.Size = new System.Drawing.Size(34, 30);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnOk
            // 
            this.BtnOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnOk.BackColor = System.Drawing.Color.DimGray;
            this.BtnOk.Cantidad = 10;
            this.BtnOk.ColorFondo = System.Drawing.Color.DimGray;
            this.BtnOk.ColorLetra = System.Drawing.Color.White;
            this.BtnOk.FlatAppearance.BorderSize = 0;
            this.BtnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.BtnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOk.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOk.ForeColor = System.Drawing.Color.White;
            this.BtnOk.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BtnOk.IconColor = System.Drawing.Color.White;
            this.BtnOk.IconSize = 21;
            this.BtnOk.Location = new System.Drawing.Point(163, 4);
            this.BtnOk.Margin = new System.Windows.Forms.Padding(0);
            this.BtnOk.ModoComportamiento = Celebrity.Forms.ComportamientoBoton.Oscurecer;
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Rotation = 0D;
            this.BtnOk.Size = new System.Drawing.Size(34, 30);
            this.BtnOk.TabIndex = 6;
            this.BtnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnOk.UseVisualStyleBackColor = false;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // FrmBaseDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.Cerrable = true;
            this.ClientSize = new System.Drawing.Size(250, 350);
            this.Controls.Add(this.TlpBotones);
            this.Maximizable = true;
            this.Minimizable = true;
            this.Name = "FrmBaseDialog";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.Controls.SetChildIndex(this.TlpBotones, 0);
            this.TlpBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpBotones;
        private CustomControls.CustomButton BtnOk;
        private CustomControls.CustomButton BtnCancel;
    }
}
