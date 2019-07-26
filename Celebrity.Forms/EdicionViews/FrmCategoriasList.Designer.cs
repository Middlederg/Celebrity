namespace Celebrity.Forms.EdicionViews
{
    partial class FrmCategoriasList
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
            this.BtnOk = new Celebrity.Forms.CustomControls.CustomButton();
            this.BtnCategorias = new Celebrity.Forms.CustomControls.CustomButton();
            this.TbxBuscar = new System.Windows.Forms.TextBox();
            this.LblBuscar = new System.Windows.Forms.Label();
            this.Lvw = new System.Windows.Forms.ListView();
            this.ColNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TlpCentral.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpCentral
            // 
            this.TlpCentral.ColumnCount = 3;
            this.TlpCentral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.TlpCentral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpCentral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.TlpCentral.Controls.Add(this.BtnOk, 0, 2);
            this.TlpCentral.Controls.Add(this.BtnCategorias, 2, 0);
            this.TlpCentral.Controls.Add(this.TbxBuscar, 1, 0);
            this.TlpCentral.Controls.Add(this.LblBuscar, 0, 0);
            this.TlpCentral.Controls.Add(this.Lvw, 0, 1);
            this.TlpCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpCentral.Location = new System.Drawing.Point(0, 38);
            this.TlpCentral.Margin = new System.Windows.Forms.Padding(0);
            this.TlpCentral.Name = "TlpCentral";
            this.TlpCentral.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.TlpCentral.RowCount = 3;
            this.TlpCentral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.TlpCentral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpCentral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TlpCentral.Size = new System.Drawing.Size(300, 400);
            this.TlpCentral.TabIndex = 2;
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
            // BtnCategorias
            // 
            this.BtnCategorias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCategorias.BackColor = System.Drawing.Color.DimGray;
            this.BtnCategorias.Cantidad = 10;
            this.BtnCategorias.ColorFondo = System.Drawing.Color.DimGray;
            this.BtnCategorias.ColorLetra = System.Drawing.Color.White;
            this.BtnCategorias.FlatAppearance.BorderSize = 0;
            this.BtnCategorias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.BtnCategorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.BtnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCategorias.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnCategorias.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCategorias.ForeColor = System.Drawing.Color.White;
            this.BtnCategorias.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.BtnCategorias.IconColor = System.Drawing.Color.White;
            this.BtnCategorias.IconSize = 25;
            this.BtnCategorias.Location = new System.Drawing.Point(263, 20);
            this.BtnCategorias.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCategorias.ModoComportamiento = Celebrity.Forms.ComportamientoBoton.Oscurecer;
            this.BtnCategorias.Name = "BtnCategorias";
            this.BtnCategorias.Rotation = 0D;
            this.BtnCategorias.Size = new System.Drawing.Size(27, 27);
            this.BtnCategorias.TabIndex = 0;
            this.BtnCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCategorias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCategorias.UseVisualStyleBackColor = false;
            this.BtnCategorias.Click += new System.EventHandler(this.BtnAddCategorias_Click);
            // 
            // TbxBuscar
            // 
            this.TbxBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbxBuscar.Location = new System.Drawing.Point(70, 20);
            this.TbxBuscar.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.TbxBuscar.MaxLength = 100;
            this.TbxBuscar.Name = "TbxBuscar";
            this.TbxBuscar.Size = new System.Drawing.Size(183, 27);
            this.TbxBuscar.TabIndex = 8;
            this.TbxBuscar.TextChanged += new System.EventHandler(this.FiltrarTextChanged);
            // 
            // LblBuscar
            // 
            this.LblBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblBuscar.AutoSize = true;
            this.LblBuscar.Location = new System.Drawing.Point(13, 23);
            this.LblBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(54, 20);
            this.LblBuscar.TabIndex = 9;
            this.LblBuscar.Text = "Filtrar:";
            // 
            // Lvw
            // 
            this.Lvw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColNombre});
            this.TlpCentral.SetColumnSpan(this.Lvw, 3);
            this.Lvw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lvw.Location = new System.Drawing.Point(10, 57);
            this.Lvw.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.Lvw.Name = "Lvw";
            this.Lvw.Size = new System.Drawing.Size(280, 273);
            this.Lvw.TabIndex = 10;
            this.Lvw.UseCompatibleStateImageBehavior = false;
            this.Lvw.View = System.Windows.Forms.View.Details;
            this.Lvw.DoubleClick += new System.EventHandler(this.OnDoubleClick);
            // 
            // ColNombre
            // 
            this.ColNombre.Text = "Nombre";
            this.ColNombre.Width = 210;
            // 
            // FrmCategoriasList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.Cerrable = true;
            this.ClientSize = new System.Drawing.Size(300, 438);
            this.Controls.Add(this.TlpCentral);
            this.Maximizable = true;
            this.Minimizable = true;
            this.Name = "FrmCategoriasList";
            this.Text = "Editar categorías";
            this.Titulo = "Editar categorías";
            this.Controls.SetChildIndex(this.TlpCentral, 0);
            this.TlpCentral.ResumeLayout(false);
            this.TlpCentral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpCentral;
        private CustomControls.CustomButton BtnOk;
        private CustomControls.CustomButton BtnCategorias;
        private System.Windows.Forms.TextBox TbxBuscar;
        private System.Windows.Forms.Label LblBuscar;
        private System.Windows.Forms.ListView Lvw;
        private System.Windows.Forms.ColumnHeader ColNombre;
    }
}
