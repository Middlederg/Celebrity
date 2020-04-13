namespace Celebrity.Forms.EdicionViews
{
    partial class FrmConcepto
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
            this.TbxCategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FlpTags = new System.Windows.Forms.FlowLayoutPanel();
            this.TlpDificultad = new System.Windows.Forms.TableLayoutPanel();
            this.RbtDificil = new System.Windows.Forms.RadioButton();
            this.RbtMedia = new System.Windows.Forms.RadioButton();
            this.RbtFacil = new System.Windows.Forms.RadioButton();
            this.CatErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.TlpCentro.SuspendLayout();
            this.TlpDificultad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // TlpCentro
            // 
            this.TlpCentro.ColumnCount = 1;
            this.TlpCentro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpCentro.Controls.Add(this.TbxCategoria, 0, 4);
            this.TlpCentro.Controls.Add(this.label2, 0, 3);
            this.TlpCentro.Controls.Add(this.TbxNombre, 0, 1);
            this.TlpCentro.Controls.Add(this.label1, 0, 0);
            this.TlpCentro.Controls.Add(this.FlpTags, 0, 5);
            this.TlpCentro.Controls.Add(this.TlpDificultad, 0, 2);
            this.TlpCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpCentro.Location = new System.Drawing.Point(1, 39);
            this.TlpCentro.Name = "TlpCentro";
            this.TlpCentro.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.TlpCentro.RowCount = 6;
            this.TlpCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TlpCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlpCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlpCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TlpCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpCentro.Size = new System.Drawing.Size(248, 272);
            this.TlpCentro.TabIndex = 2;
            // 
            // TbxCategoria
            // 
            this.TbxCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TbxCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TbxCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbxCategoria.Location = new System.Drawing.Point(13, 143);
            this.TbxCategoria.Name = "TbxCategoria";
            this.TbxCategoria.Size = new System.Drawing.Size(222, 27);
            this.TbxCategoria.TabIndex = 3;
            this.TbxCategoria.TextChanged += new System.EventHandler(this.OnCategoriasTextChanged);
            this.TbxCategoria.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(13, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categorías:";
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
            // FlpTags
            // 
            this.FlpTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlpTags.Location = new System.Drawing.Point(13, 183);
            this.FlpTags.Name = "FlpTags";
            this.FlpTags.Size = new System.Drawing.Size(222, 66);
            this.FlpTags.TabIndex = 4;
            // 
            // TlpDificultad
            // 
            this.TlpDificultad.ColumnCount = 3;
            this.TlpDificultad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TlpDificultad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TlpDificultad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TlpDificultad.Controls.Add(this.RbtDificil, 2, 0);
            this.TlpDificultad.Controls.Add(this.RbtMedia, 1, 0);
            this.TlpDificultad.Controls.Add(this.RbtFacil, 0, 0);
            this.TlpDificultad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpDificultad.Location = new System.Drawing.Point(10, 80);
            this.TlpDificultad.Margin = new System.Windows.Forms.Padding(0);
            this.TlpDificultad.Name = "TlpDificultad";
            this.TlpDificultad.RowCount = 1;
            this.TlpDificultad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpDificultad.Size = new System.Drawing.Size(228, 30);
            this.TlpDificultad.TabIndex = 5;
            // 
            // RbtDificil
            // 
            this.RbtDificil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RbtDificil.AutoSize = true;
            this.RbtDificil.Location = new System.Drawing.Point(157, 0);
            this.RbtDificil.Margin = new System.Windows.Forms.Padding(0);
            this.RbtDificil.Name = "RbtDificil";
            this.RbtDificil.Size = new System.Drawing.Size(66, 24);
            this.RbtDificil.TabIndex = 2;
            this.RbtDificil.TabStop = true;
            this.RbtDificil.Text = "Difícil";
            this.RbtDificil.UseVisualStyleBackColor = true;
            // 
            // RbtMedia
            // 
            this.RbtMedia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RbtMedia.AutoSize = true;
            this.RbtMedia.Location = new System.Drawing.Point(79, 0);
            this.RbtMedia.Margin = new System.Windows.Forms.Padding(0);
            this.RbtMedia.Name = "RbtMedia";
            this.RbtMedia.Size = new System.Drawing.Size(70, 24);
            this.RbtMedia.TabIndex = 1;
            this.RbtMedia.TabStop = true;
            this.RbtMedia.Text = "Media";
            this.RbtMedia.UseVisualStyleBackColor = true;
            // 
            // RbtFacil
            // 
            this.RbtFacil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RbtFacil.AutoSize = true;
            this.RbtFacil.Location = new System.Drawing.Point(9, 0);
            this.RbtFacil.Margin = new System.Windows.Forms.Padding(0);
            this.RbtFacil.Name = "RbtFacil";
            this.RbtFacil.Size = new System.Drawing.Size(58, 24);
            this.RbtFacil.TabIndex = 0;
            this.RbtFacil.TabStop = true;
            this.RbtFacil.Text = "Fácil";
            this.RbtFacil.UseVisualStyleBackColor = true;
            // 
            // CatErrorProvider
            // 
            this.CatErrorProvider.ContainerControl = this;
            // 
            // FrmConcepto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.Cerrable = true;
            this.ClientSize = new System.Drawing.Size(250, 350);
            this.Controls.Add(this.TlpCentro);
            this.Maximizable = true;
            this.Minimizable = true;
            this.Name = "FrmConcepto";
            this.Text = "Concepto";
            this.Titulo = "Concepto";
            this.Controls.SetChildIndex(this.TlpCentro, 0);
            this.TlpCentro.ResumeLayout(false);
            this.TlpCentro.PerformLayout();
            this.TlpDificultad.ResumeLayout(false);
            this.TlpDificultad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpCentro;
        private System.Windows.Forms.TextBox TbxNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider CatErrorProvider;
        private System.Windows.Forms.TextBox TbxCategoria;
        private System.Windows.Forms.FlowLayoutPanel FlpTags;
        private System.Windows.Forms.TableLayoutPanel TlpDificultad;
        private System.Windows.Forms.RadioButton RbtDificil;
        private System.Windows.Forms.RadioButton RbtMedia;
        private System.Windows.Forms.RadioButton RbtFacil;
    }
}
