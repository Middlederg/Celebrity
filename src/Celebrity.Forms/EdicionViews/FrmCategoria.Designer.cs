namespace Celebrity.Forms.EdicionViews
{
    partial class FrmCategoria
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
            this.TlpCentro = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbPadre = new System.Windows.Forms.ComboBox();
            this.CbxPrincipal = new System.Windows.Forms.CheckBox();
            this.CatErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.TlpCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // TlpCentro
            // 
            this.TlpCentro.ColumnCount = 1;
            this.TlpCentro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpCentro.Controls.Add(this.label2, 0, 2);
            this.TlpCentro.Controls.Add(this.TbxNombre, 0, 1);
            this.TlpCentro.Controls.Add(this.label1, 0, 0);
            this.TlpCentro.Controls.Add(this.CmbPadre, 0, 3);
            this.TlpCentro.Controls.Add(this.CbxPrincipal, 0, 4);
            this.TlpCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpCentro.Location = new System.Drawing.Point(1, 39);
            this.TlpCentro.Name = "TlpCentro";
            this.TlpCentro.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.TlpCentro.RowCount = 6;
            this.TlpCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TlpCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TlpCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlpCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpCentro.Size = new System.Drawing.Size(248, 272);
            this.TlpCentro.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categoría padre:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // TbxNombre
            // 
            this.TbxNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbxNombre.Location = new System.Drawing.Point(13, 43);
            this.TbxNombre.Name = "TbxNombre";
            this.TbxNombre.Size = new System.Drawing.Size(222, 27);
            this.TbxNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // CmbPadre
            // 
            this.CmbPadre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmbPadre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPadre.FormattingEnabled = true;
            this.CmbPadre.Location = new System.Drawing.Point(13, 103);
            this.CmbPadre.Name = "CmbPadre";
            this.CmbPadre.Size = new System.Drawing.Size(222, 28);
            this.CmbPadre.TabIndex = 3;
            // 
            // CbxPrincipal
            // 
            this.CbxPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CbxPrincipal.AutoSize = true;
            this.CbxPrincipal.Location = new System.Drawing.Point(45, 143);
            this.CbxPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.CbxPrincipal.Name = "CbxPrincipal";
            this.CbxPrincipal.Size = new System.Drawing.Size(157, 24);
            this.CbxPrincipal.TabIndex = 4;
            this.CbxPrincipal.Text = "Categoría principal";
            this.CbxPrincipal.UseVisualStyleBackColor = true;
            this.CbxPrincipal.CheckedChanged += new System.EventHandler(this.CbxPrincipal_CheckedChanged);
            // 
            // CatErrorProvider
            // 
            this.CatErrorProvider.ContainerControl = this;
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.Cerrable = true;
            this.ClientSize = new System.Drawing.Size(250, 350);
            this.Controls.Add(this.TlpCentro);
            this.Maximizable = true;
            this.Minimizable = true;
            this.Name = "FrmCategoria";
            this.Text = "Categoría";
            this.Titulo = "Categoría";
            this.Controls.SetChildIndex(this.TlpCentro, 0);
            this.TlpCentro.ResumeLayout(false);
            this.TlpCentro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpCentro;
        private System.Windows.Forms.TextBox TbxNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbPadre;
        private System.Windows.Forms.ErrorProvider CatErrorProvider;
        private System.Windows.Forms.CheckBox CbxPrincipal;
    }
}
