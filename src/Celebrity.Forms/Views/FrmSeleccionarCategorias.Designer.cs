namespace Celebrity.Forms.Views
{
    partial class FrmSeleccionarCategorias
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
            this.TlpCentro = new System.Windows.Forms.TableLayoutPanel();
            this.CbxSelectAll = new System.Windows.Forms.CheckBox();
            this.Tvw = new System.Windows.Forms.TreeView();
            this.TlpCentro.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpCentro
            // 
            this.TlpCentro.ColumnCount = 1;
            this.TlpCentro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpCentro.Controls.Add(this.CbxSelectAll, 0, 0);
            this.TlpCentro.Controls.Add(this.Tvw, 0, 1);
            this.TlpCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpCentro.Location = new System.Drawing.Point(1, 39);
            this.TlpCentro.Margin = new System.Windows.Forms.Padding(0);
            this.TlpCentro.Name = "TlpCentro";
            this.TlpCentro.Padding = new System.Windows.Forms.Padding(10);
            this.TlpCentro.RowCount = 2;
            this.TlpCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlpCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpCentro.Size = new System.Drawing.Size(298, 222);
            this.TlpCentro.TabIndex = 2;
            // 
            // CbxSelectAll
            // 
            this.CbxSelectAll.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CbxSelectAll.AutoSize = true;
            this.CbxSelectAll.Font = new System.Drawing.Font("Open Sans", 10F);
            this.CbxSelectAll.Location = new System.Drawing.Point(76, 17);
            this.CbxSelectAll.Margin = new System.Windows.Forms.Padding(0);
            this.CbxSelectAll.Name = "CbxSelectAll";
            this.CbxSelectAll.Size = new System.Drawing.Size(146, 23);
            this.CbxSelectAll.TabIndex = 0;
            this.CbxSelectAll.Text = "Seleccionar todos";
            this.CbxSelectAll.UseVisualStyleBackColor = true;
            // 
            // Tvw
            // 
            this.Tvw.CheckBoxes = true;
            this.Tvw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tvw.Font = new System.Drawing.Font("Open Sans", 10F);
            this.Tvw.Location = new System.Drawing.Point(10, 40);
            this.Tvw.Margin = new System.Windows.Forms.Padding(0);
            this.Tvw.Name = "Tvw";
            this.Tvw.Size = new System.Drawing.Size(278, 172);
            this.Tvw.TabIndex = 1;
            // 
            // FrmSeleccionarCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Cerrable = true;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.TlpCentro);
            this.Maximizable = true;
            this.Minimizable = true;
            this.Name = "FrmSeleccionarCategorias";
            this.Text = "FrmSeleccionarCategorias";
            this.Controls.SetChildIndex(this.TlpCentro, 0);
            this.TlpCentro.ResumeLayout(false);
            this.TlpCentro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpCentro;
        private System.Windows.Forms.CheckBox CbxSelectAll;
        private System.Windows.Forms.TreeView Tvw;
    }
}