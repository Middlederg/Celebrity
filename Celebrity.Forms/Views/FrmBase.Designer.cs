namespace Celebrity.Forms.Views
{
    partial class FrmBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.BtnMax = new Celebrity.Forms.CustomControls.CustomButton();
            this.BtnClose = new Celebrity.Forms.CustomControls.CustomButton();
            this.BtnMin = new Celebrity.Forms.CustomControls.CustomButton();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.ToolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.TlpPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpPrincipal
            // 
            this.TlpPrincipal.BackColor = System.Drawing.Color.DimGray;
            this.TlpPrincipal.ColumnCount = 5;
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.TlpPrincipal.Controls.Add(this.BtnMax, 3, 0);
            this.TlpPrincipal.Controls.Add(this.BtnClose, 4, 0);
            this.TlpPrincipal.Controls.Add(this.BtnMin, 2, 0);
            this.TlpPrincipal.Controls.Add(this.LblTitulo, 1, 0);
            this.TlpPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.TlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.TlpPrincipal.Name = "TlpPrincipal";
            this.TlpPrincipal.RowCount = 1;
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.TlpPrincipal.Size = new System.Drawing.Size(300, 38);
            this.TlpPrincipal.TabIndex = 0;
            // 
            // BtnMax
            // 
            this.BtnMax.BackColor = System.Drawing.Color.DimGray;
            this.BtnMax.Cantidad = 10;
            this.BtnMax.ColorFondo = System.Drawing.Color.DimGray;
            this.BtnMax.ColorLetra = System.Drawing.Color.White;
            this.BtnMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMax.FlatAppearance.BorderSize = 0;
            this.BtnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMax.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMax.ForeColor = System.Drawing.Color.White;
            this.BtnMax.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.BtnMax.IconColor = System.Drawing.Color.White;
            this.BtnMax.IconSize = 21;
            this.BtnMax.Location = new System.Drawing.Point(232, 0);
            this.BtnMax.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMax.ModoComportamiento = Celebrity.Forms.ComportamientoBoton.Oscurecer;
            this.BtnMax.Name = "BtnMax";
            this.BtnMax.Rotation = 0D;
            this.BtnMax.Size = new System.Drawing.Size(34, 38);
            this.BtnMax.TabIndex = 6;
            this.BtnMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMax.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMax.UseVisualStyleBackColor = false;
            this.BtnMax.Click += new System.EventHandler(this.BtnMaxClick);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.DimGray;
            this.BtnClose.Cantidad = 10;
            this.BtnClose.ColorFondo = System.Drawing.Color.DimGray;
            this.BtnClose.ColorLetra = System.Drawing.Color.White;
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.BtnClose.IconColor = System.Drawing.Color.White;
            this.BtnClose.IconSize = 21;
            this.BtnClose.Location = new System.Drawing.Point(266, 0);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClose.ModoComportamiento = Celebrity.Forms.ComportamientoBoton.Oscurecer;
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Rotation = 0D;
            this.BtnClose.Size = new System.Drawing.Size(34, 38);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnCloseClick);
            // 
            // BtnMin
            // 
            this.BtnMin.BackColor = System.Drawing.Color.DimGray;
            this.BtnMin.Cantidad = 10;
            this.BtnMin.ColorFondo = System.Drawing.Color.DimGray;
            this.BtnMin.ColorLetra = System.Drawing.Color.White;
            this.BtnMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMin.FlatAppearance.BorderSize = 0;
            this.BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMin.ForeColor = System.Drawing.Color.White;
            this.BtnMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.BtnMin.IconColor = System.Drawing.Color.White;
            this.BtnMin.IconSize = 21;
            this.BtnMin.Location = new System.Drawing.Point(198, 0);
            this.BtnMin.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMin.ModoComportamiento = Celebrity.Forms.ComportamientoBoton.Oscurecer;
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Rotation = 0D;
            this.BtnMin.Size = new System.Drawing.Size(34, 38);
            this.BtnMin.TabIndex = 5;
            this.BtnMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMin.UseVisualStyleBackColor = false;
            this.BtnMin.Click += new System.EventHandler(this.BtnMinClick);
            // 
            // LblTitulo
            // 
            this.LblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(10, 0);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(188, 38);
            this.LblTitulo.TabIndex = 7;
            this.LblTitulo.Text = "Título";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblTitulo.DoubleClick += new System.EventHandler(this.BarraSuperiorDobleClick);
            this.LblTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveFormMouseDown);
            // 
            // FrmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 438);
            this.Controls.Add(this.TlpPrincipal);
            this.Font = new System.Drawing.Font("Open Sans", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox = false;
            this.Name = "FrmBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmBase";
            this.TlpPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpPrincipal;
        private CustomControls.CustomButton BtnMax;
        private CustomControls.CustomButton BtnClose;
        private CustomControls.CustomButton BtnMin;
        private System.Windows.Forms.Label LblTitulo;
        protected System.Windows.Forms.ToolTip ToolTipAyuda;
    }
}