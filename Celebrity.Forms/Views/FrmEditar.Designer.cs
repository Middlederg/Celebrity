namespace Celebrity.Forms.Views
{
    partial class FrmEditar
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
            this.TlpCentral = new System.Windows.Forms.TableLayoutPanel();
            this.BtnOk = new Celebrity.Forms.CustomControls.CustomButton();
            this.BtnConceptos = new Celebrity.Forms.CustomControls.CustomButton();
            this.BtnCategorias = new Celebrity.Forms.CustomControls.CustomButton();
            this.TlpCentral.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpCentral
            // 
            this.TlpCentral.ColumnCount = 1;
            this.TlpCentral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpCentral.Controls.Add(this.BtnOk, 0, 5);
            this.TlpCentral.Controls.Add(this.BtnConceptos, 0, 1);
            this.TlpCentral.Controls.Add(this.BtnCategorias, 0, 0);
            this.TlpCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpCentral.Location = new System.Drawing.Point(0, 38);
            this.TlpCentral.Margin = new System.Windows.Forms.Padding(0);
            this.TlpCentral.Name = "TlpCentral";
            this.TlpCentral.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.TlpCentral.RowCount = 6;
            this.TlpCentral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TlpCentral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TlpCentral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TlpCentral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TlpCentral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TlpCentral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TlpCentral.Size = new System.Drawing.Size(300, 362);
            this.TlpCentral.TabIndex = 1;
            // 
            // BtnOk
            // 
            this.BtnOk.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.BtnOk.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.BtnOk.IconColor = System.Drawing.Color.White;
            this.BtnOk.IconSize = 21;
            this.BtnOk.Location = new System.Drawing.Point(10, 301);
            this.BtnOk.Margin = new System.Windows.Forms.Padding(0);
            this.BtnOk.ModoComportamiento = Celebrity.Forms.ComportamientoBoton.Oscurecer;
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Rotation = 0D;
            this.BtnOk.Size = new System.Drawing.Size(100, 25);
            this.BtnOk.TabIndex = 7;
            this.BtnOk.Text = "Volver";
            this.BtnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnOk.UseVisualStyleBackColor = false;
            // 
            // BtnConceptos
            // 
            this.BtnConceptos.BackColor = System.Drawing.Color.DimGray;
            this.BtnConceptos.Cantidad = 10;
            this.BtnConceptos.ColorFondo = System.Drawing.Color.DimGray;
            this.BtnConceptos.ColorLetra = System.Drawing.Color.White;
            this.BtnConceptos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnConceptos.FlatAppearance.BorderSize = 0;
            this.BtnConceptos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.BtnConceptos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.BtnConceptos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConceptos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnConceptos.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConceptos.ForeColor = System.Drawing.Color.White;
            this.BtnConceptos.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.BtnConceptos.IconColor = System.Drawing.Color.White;
            this.BtnConceptos.IconSize = 32;
            this.BtnConceptos.Location = new System.Drawing.Point(10, 83);
            this.BtnConceptos.Margin = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.BtnConceptos.ModoComportamiento = Celebrity.Forms.ComportamientoBoton.Oscurecer;
            this.BtnConceptos.Name = "BtnConceptos";
            this.BtnConceptos.Rotation = 0D;
            this.BtnConceptos.Size = new System.Drawing.Size(280, 38);
            this.BtnConceptos.TabIndex = 1;
            this.BtnConceptos.Text = "Conceptos";
            this.BtnConceptos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConceptos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConceptos.UseVisualStyleBackColor = false;
            this.BtnConceptos.Click += new System.EventHandler(this.BtnConceptos_Click);
            // 
            // BtnCategorias
            // 
            this.BtnCategorias.BackColor = System.Drawing.Color.DimGray;
            this.BtnCategorias.Cantidad = 10;
            this.BtnCategorias.ColorFondo = System.Drawing.Color.DimGray;
            this.BtnCategorias.ColorLetra = System.Drawing.Color.White;
            this.BtnCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCategorias.FlatAppearance.BorderSize = 0;
            this.BtnCategorias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.BtnCategorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.BtnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCategorias.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnCategorias.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCategorias.ForeColor = System.Drawing.Color.White;
            this.BtnCategorias.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.BtnCategorias.IconColor = System.Drawing.Color.White;
            this.BtnCategorias.IconSize = 32;
            this.BtnCategorias.Location = new System.Drawing.Point(10, 30);
            this.BtnCategorias.Margin = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.BtnCategorias.ModoComportamiento = Celebrity.Forms.ComportamientoBoton.Oscurecer;
            this.BtnCategorias.Name = "BtnCategorias";
            this.BtnCategorias.Rotation = 0D;
            this.BtnCategorias.Size = new System.Drawing.Size(280, 38);
            this.BtnCategorias.TabIndex = 0;
            this.BtnCategorias.Text = "Categorías";
            this.BtnCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCategorias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCategorias.UseVisualStyleBackColor = false;
            this.BtnCategorias.Click += new System.EventHandler(this.BtnCategorias_Click);
            // 
            // FrmEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Cerrable = true;
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.TlpCentral);
            this.Maximizable = true;
            this.Minimizable = true;
            this.Name = "FrmEditar";
            this.Text = "Edición";
            this.Titulo = "Edición";
            this.Controls.SetChildIndex(this.TlpCentral, 0);
            this.TlpCentral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpCentral;
        private CustomControls.CustomButton BtnConceptos;
        private CustomControls.CustomButton BtnCategorias;
        private CustomControls.CustomButton BtnOk;
    }
}