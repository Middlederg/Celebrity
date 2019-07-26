namespace Celebrity.Forms.Views
{
    partial class FrmInicio
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
            this.TlpCentro = new System.Windows.Forms.TableLayoutPanel();
            this.BtnJugar = new Celebrity.Forms.CustomControls.CustomButton();
            this.BtnAtras = new Celebrity.Forms.CustomControls.CustomButton();
            this.NudRondas = new System.Windows.Forms.NumericUpDown();
            this.NudSegundos = new System.Windows.Forms.NumericUpDown();
            this.CategoriasSelector = new Celebrity.Forms.UserControls.UcEditLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DificultadSelector = new Celebrity.Forms.UserControls.UcEditLabel();
            this.EquiposSelector = new Celebrity.Forms.UserControls.UcEquipos();
            this.NudConceptos = new System.Windows.Forms.NumericUpDown();
            this.EpErrores = new System.Windows.Forms.ErrorProvider(this.components);
            this.TlpCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudRondas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudSegundos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudConceptos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // TlpCentro
            // 
            this.TlpCentro.ColumnCount = 2;
            this.TlpCentro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.TlpCentro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpCentro.Controls.Add(this.BtnJugar, 1, 7);
            this.TlpCentro.Controls.Add(this.BtnAtras, 0, 7);
            this.TlpCentro.Controls.Add(this.NudRondas, 1, 4);
            this.TlpCentro.Controls.Add(this.NudSegundos, 1, 3);
            this.TlpCentro.Controls.Add(this.CategoriasSelector, 1, 5);
            this.TlpCentro.Controls.Add(this.label6, 0, 4);
            this.TlpCentro.Controls.Add(this.label5, 0, 3);
            this.TlpCentro.Controls.Add(this.label4, 0, 2);
            this.TlpCentro.Controls.Add(this.label3, 0, 0);
            this.TlpCentro.Controls.Add(this.label2, 0, 5);
            this.TlpCentro.Controls.Add(this.label1, 0, 1);
            this.TlpCentro.Controls.Add(this.DificultadSelector, 1, 1);
            this.TlpCentro.Controls.Add(this.EquiposSelector, 1, 0);
            this.TlpCentro.Controls.Add(this.NudConceptos, 1, 2);
            this.TlpCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpCentro.Location = new System.Drawing.Point(0, 38);
            this.TlpCentro.Name = "TlpCentro";
            this.TlpCentro.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.TlpCentro.RowCount = 8;
            this.TlpCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TlpCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TlpCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TlpCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TlpCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TlpCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TlpCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TlpCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpCentro.Size = new System.Drawing.Size(300, 362);
            this.TlpCentro.TabIndex = 3;
            // 
            // BtnJugar
            // 
            this.BtnJugar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnJugar.BackColor = System.Drawing.Color.DimGray;
            this.BtnJugar.Cantidad = 10;
            this.BtnJugar.ColorFondo = System.Drawing.Color.DimGray;
            this.BtnJugar.ColorLetra = System.Drawing.Color.White;
            this.BtnJugar.FlatAppearance.BorderSize = 0;
            this.BtnJugar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.BtnJugar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.BtnJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnJugar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnJugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnJugar.ForeColor = System.Drawing.Color.White;
            this.BtnJugar.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.BtnJugar.IconColor = System.Drawing.Color.White;
            this.BtnJugar.IconSize = 21;
            this.BtnJugar.Location = new System.Drawing.Point(190, 317);
            this.BtnJugar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnJugar.ModoComportamiento = Celebrity.Forms.ComportamientoBoton.Oscurecer;
            this.BtnJugar.Name = "BtnJugar";
            this.BtnJugar.Rotation = 0D;
            this.BtnJugar.Size = new System.Drawing.Size(100, 25);
            this.BtnJugar.TabIndex = 14;
            this.BtnJugar.Text = "Jugar";
            this.BtnJugar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnJugar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnJugar.UseVisualStyleBackColor = false;
            this.BtnJugar.Click += new System.EventHandler(this.BtnJugar_Click);
            // 
            // BtnAtras
            // 
            this.BtnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAtras.BackColor = System.Drawing.Color.DimGray;
            this.BtnAtras.Cantidad = 10;
            this.BtnAtras.ColorFondo = System.Drawing.Color.DimGray;
            this.BtnAtras.ColorLetra = System.Drawing.Color.White;
            this.BtnAtras.FlatAppearance.BorderSize = 0;
            this.BtnAtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.BtnAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.BtnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtras.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtras.ForeColor = System.Drawing.Color.White;
            this.BtnAtras.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.BtnAtras.IconColor = System.Drawing.Color.White;
            this.BtnAtras.IconSize = 21;
            this.BtnAtras.Location = new System.Drawing.Point(10, 317);
            this.BtnAtras.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAtras.ModoComportamiento = Celebrity.Forms.ComportamientoBoton.Oscurecer;
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Rotation = 0D;
            this.BtnAtras.Size = new System.Drawing.Size(85, 25);
            this.BtnAtras.TabIndex = 13;
            this.BtnAtras.Text = "Volver";
            this.BtnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAtras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAtras.UseVisualStyleBackColor = false;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // NudRondas
            // 
            this.NudRondas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NudRondas.Location = new System.Drawing.Point(95, 160);
            this.NudRondas.Margin = new System.Windows.Forms.Padding(0);
            this.NudRondas.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NudRondas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudRondas.Name = "NudRondas";
            this.NudRondas.Size = new System.Drawing.Size(195, 27);
            this.NudRondas.TabIndex = 12;
            this.NudRondas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudRondas.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // NudSegundos
            // 
            this.NudSegundos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NudSegundos.Location = new System.Drawing.Point(95, 125);
            this.NudSegundos.Margin = new System.Windows.Forms.Padding(0);
            this.NudSegundos.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.NudSegundos.Name = "NudSegundos";
            this.NudSegundos.Size = new System.Drawing.Size(195, 27);
            this.NudSegundos.TabIndex = 11;
            this.NudSegundos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudSegundos.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // CategoriasSelector
            // 
            this.CategoriasSelector.BackColor = System.Drawing.Color.White;
            this.CategoriasSelector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CategoriasSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.CategoriasSelector.Font = new System.Drawing.Font("Open Sans", 12F);
            this.CategoriasSelector.Location = new System.Drawing.Point(95, 195);
            this.CategoriasSelector.Margin = new System.Windows.Forms.Padding(0);
            this.CategoriasSelector.Name = "CategoriasSelector";
            this.CategoriasSelector.Size = new System.Drawing.Size(195, 25);
            this.CategoriasSelector.TabIndex = 9;
            this.CategoriasSelector.Titulo = "label1";
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Open Sans", 10F);
            this.label6.Location = new System.Drawing.Point(10, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 33);
            this.label6.TabIndex = 8;
            this.label6.Text = "Rondas:";
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Open Sans", 10F);
            this.label5.Location = new System.Drawing.Point(10, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 33);
            this.label5.TabIndex = 7;
            this.label5.Text = "Segundos:";
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Open Sans", 10F);
            this.label4.Location = new System.Drawing.Point(10, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = "Conceptos:";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Open Sans", 10F);
            this.label3.Location = new System.Drawing.Point(10, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Equipos:";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(10, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categorías:";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Open Sans", 10F);
            this.label1.Location = new System.Drawing.Point(10, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dificultad:";
            // 
            // DificultadSelector
            // 
            this.DificultadSelector.BackColor = System.Drawing.Color.White;
            this.DificultadSelector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DificultadSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.DificultadSelector.Font = new System.Drawing.Font("Open Sans", 12F);
            this.DificultadSelector.Location = new System.Drawing.Point(95, 55);
            this.DificultadSelector.Margin = new System.Windows.Forms.Padding(0);
            this.DificultadSelector.Name = "DificultadSelector";
            this.DificultadSelector.Size = new System.Drawing.Size(195, 25);
            this.DificultadSelector.TabIndex = 3;
            this.DificultadSelector.Titulo = "label1";
            // 
            // EquiposSelector
            // 
            this.EquiposSelector.BackColor = System.Drawing.Color.White;
            this.EquiposSelector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EquiposSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.EquiposSelector.Font = new System.Drawing.Font("Open Sans", 12F);
            this.EquiposSelector.Location = new System.Drawing.Point(95, 20);
            this.EquiposSelector.Margin = new System.Windows.Forms.Padding(0);
            this.EquiposSelector.Name = "EquiposSelector";
            this.EquiposSelector.Size = new System.Drawing.Size(195, 27);
            this.EquiposSelector.TabIndex = 5;
            // 
            // NudConceptos
            // 
            this.NudConceptos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NudConceptos.Location = new System.Drawing.Point(95, 90);
            this.NudConceptos.Margin = new System.Windows.Forms.Padding(0);
            this.NudConceptos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudConceptos.Name = "NudConceptos";
            this.NudConceptos.Size = new System.Drawing.Size(195, 27);
            this.NudConceptos.TabIndex = 10;
            this.NudConceptos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudConceptos.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // EpErrores
            // 
            this.EpErrores.ContainerControl = this;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Cerrable = true;
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.TlpCentro);
            this.Maximizable = true;
            this.Minimizable = true;
            this.Name = "FrmInicio";
            this.Text = "Iniciar partida";
            this.Titulo = "Iniciar partida";
            this.Controls.SetChildIndex(this.TlpCentro, 0);
            this.TlpCentro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NudRondas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudSegundos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudConceptos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpErrores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpCentro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private UserControls.UcEditLabel DificultadSelector;
        private UserControls.UcEquipos EquiposSelector;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NudRondas;
        private System.Windows.Forms.NumericUpDown NudSegundos;
        private UserControls.UcEditLabel CategoriasSelector;
        private System.Windows.Forms.NumericUpDown NudConceptos;
        private CustomControls.CustomButton BtnJugar;
        private CustomControls.CustomButton BtnAtras;
        private System.Windows.Forms.ErrorProvider EpErrores;
    }
}