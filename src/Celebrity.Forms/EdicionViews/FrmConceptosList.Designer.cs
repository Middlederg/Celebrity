namespace Celebrity.Forms.EdicionViews
{
    partial class FrmConceptosList
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
            this.TlpCentral = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnOk = new Celebrity.Forms.CustomControls.CustomButton();
            this.BtnAddConcepto = new Celebrity.Forms.CustomControls.CustomButton();
            this.TbxBuscar = new System.Windows.Forms.TextBox();
            this.LblBuscar = new System.Windows.Forms.Label();
            this.Lvw = new System.Windows.Forms.ListView();
            this.ColNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColDificultad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CmbCategoria = new System.Windows.Forms.ComboBox();
            this.TlpCentral.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpCentral
            // 
            this.TlpCentral.ColumnCount = 3;
            this.TlpCentral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpCentral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.TlpCentral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.TlpCentral.Controls.Add(this.label1, 1, 0);
            this.TlpCentral.Controls.Add(this.BtnOk, 0, 3);
            this.TlpCentral.Controls.Add(this.BtnAddConcepto, 2, 1);
            this.TlpCentral.Controls.Add(this.TbxBuscar, 0, 1);
            this.TlpCentral.Controls.Add(this.LblBuscar, 0, 0);
            this.TlpCentral.Controls.Add(this.Lvw, 0, 2);
            this.TlpCentral.Controls.Add(this.CmbCategoria, 1, 1);
            this.TlpCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpCentral.Location = new System.Drawing.Point(0, 38);
            this.TlpCentral.Margin = new System.Windows.Forms.Padding(0);
            this.TlpCentral.Name = "TlpCentral";
            this.TlpCentral.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.TlpCentral.RowCount = 4;
            this.TlpCentral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpCentral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.TlpCentral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpCentral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TlpCentral.Size = new System.Drawing.Size(300, 400);
            this.TlpCentral.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Categoría:";
            // 
            // BtnOk
            // 
            this.BtnOk.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnOk.BackColor = System.Drawing.Color.DimGray;
            this.BtnOk.Cantidad = 10;
            this.BtnOk.ColorFondo = System.Drawing.Color.DimGray;
            this.BtnOk.ColorLetra = System.Drawing.Color.White;
            this.TlpCentral.SetColumnSpan(this.BtnOk, 2);
            this.BtnOk.FlatAppearance.BorderSize = 0;
            this.BtnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.BtnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOk.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOk.ForeColor = System.Drawing.Color.White;
            this.BtnOk.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.BtnOk.IconColor = System.Drawing.Color.White;
            this.BtnOk.IconSize = 21;
            this.BtnOk.Location = new System.Drawing.Point(10, 345);
            this.BtnOk.Margin = new System.Windows.Forms.Padding(0);
            this.BtnOk.ModoComportamiento = Celebrity.Forms.ComportamientoBoton.Oscurecer;
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Rotation = 0D;
            this.BtnOk.Size = new System.Drawing.Size(100, 30);
            this.BtnOk.TabIndex = 7;
            this.BtnOk.Text = "Volver";
            this.BtnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnOk.UseVisualStyleBackColor = false;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnAddConcepto
            // 
            this.BtnAddConcepto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAddConcepto.BackColor = System.Drawing.Color.DimGray;
            this.BtnAddConcepto.Cantidad = 10;
            this.BtnAddConcepto.ColorFondo = System.Drawing.Color.DimGray;
            this.BtnAddConcepto.ColorLetra = System.Drawing.Color.White;
            this.BtnAddConcepto.FlatAppearance.BorderSize = 0;
            this.BtnAddConcepto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.BtnAddConcepto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.BtnAddConcepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddConcepto.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnAddConcepto.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddConcepto.ForeColor = System.Drawing.Color.White;
            this.BtnAddConcepto.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.BtnAddConcepto.IconColor = System.Drawing.Color.White;
            this.BtnAddConcepto.IconSize = 25;
            this.BtnAddConcepto.Location = new System.Drawing.Point(263, 40);
            this.BtnAddConcepto.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAddConcepto.ModoComportamiento = Celebrity.Forms.ComportamientoBoton.Oscurecer;
            this.BtnAddConcepto.Name = "BtnAddConcepto";
            this.BtnAddConcepto.Rotation = 0D;
            this.BtnAddConcepto.Size = new System.Drawing.Size(27, 27);
            this.BtnAddConcepto.TabIndex = 0;
            this.BtnAddConcepto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddConcepto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddConcepto.UseVisualStyleBackColor = false;
            this.BtnAddConcepto.Click += new System.EventHandler(this.BtnAddConceptoClick);
            // 
            // TbxBuscar
            // 
            this.TbxBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbxBuscar.Location = new System.Drawing.Point(10, 40);
            this.TbxBuscar.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.TbxBuscar.MaxLength = 100;
            this.TbxBuscar.Name = "TbxBuscar";
            this.TbxBuscar.Size = new System.Drawing.Size(123, 27);
            this.TbxBuscar.TabIndex = 8;
            this.TbxBuscar.TextChanged += new System.EventHandler(this.FiltrarTextChanged);
            // 
            // LblBuscar
            // 
            this.LblBuscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblBuscar.AutoSize = true;
            this.LblBuscar.Location = new System.Drawing.Point(10, 20);
            this.LblBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(54, 20);
            this.LblBuscar.TabIndex = 9;
            this.LblBuscar.Text = "Filtrar:";
            // 
            // Lvw
            // 
            this.Lvw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColNombre,
            this.ColDificultad});
            this.TlpCentral.SetColumnSpan(this.Lvw, 3);
            this.Lvw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lvw.Location = new System.Drawing.Point(10, 77);
            this.Lvw.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.Lvw.Name = "Lvw";
            this.Lvw.Size = new System.Drawing.Size(280, 253);
            this.Lvw.TabIndex = 10;
            this.Lvw.UseCompatibleStateImageBehavior = false;
            this.Lvw.View = System.Windows.Forms.View.Details;
            this.Lvw.DoubleClick += new System.EventHandler(this.OnDoubleClick);
            // 
            // ColNombre
            // 
            this.ColNombre.Text = "Nombre";
            this.ColNombre.Width = 190;
            // 
            // ColDificultad
            // 
            this.ColDificultad.Text = "Dificultad";
            this.ColDificultad.Width = 80;
            // 
            // CmbCategoria
            // 
            this.CmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCategoria.FormattingEnabled = true;
            this.CmbCategoria.Location = new System.Drawing.Point(143, 40);
            this.CmbCategoria.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.CmbCategoria.Name = "CmbCategoria";
            this.CmbCategoria.Size = new System.Drawing.Size(110, 28);
            this.CmbCategoria.TabIndex = 12;
            // 
            // FrmConceptosList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.Cerrable = true;
            this.ClientSize = new System.Drawing.Size(300, 438);
            this.Controls.Add(this.TlpCentral);
            this.Maximizable = true;
            this.Minimizable = true;
            this.Name = "FrmConceptosList";
            this.Text = "Editar conceptos";
            this.Titulo = "Editar conceptos";
            this.Controls.SetChildIndex(this.TlpCentral, 0);
            this.TlpCentral.ResumeLayout(false);
            this.TlpCentral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpCentral;
        private CustomControls.CustomButton BtnOk;
        private CustomControls.CustomButton BtnAddConcepto;
        private System.Windows.Forms.TextBox TbxBuscar;
        private System.Windows.Forms.Label LblBuscar;
        private System.Windows.Forms.ListView Lvw;
        private System.Windows.Forms.ColumnHeader ColNombre;
        private System.Windows.Forms.ColumnHeader ColDificultad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbCategoria;
    }
}
