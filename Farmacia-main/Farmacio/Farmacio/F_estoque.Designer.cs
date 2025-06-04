namespace Farmacio
{
    partial class F_estoque
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
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Medicamentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Beleza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Higiene = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(492, 233);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Medicamentos,
            this.Beleza,
            this.Higiene});
            this.dataGridView1.Location = new System.Drawing.Point(132, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(514, 116);
            this.dataGridView1.TabIndex = 9;
            // 
            // Medicamentos
            // 
            this.Medicamentos.HeaderText = "Medicamentos";
            this.Medicamentos.MinimumWidth = 8;
            this.Medicamentos.Name = "Medicamentos";
            this.Medicamentos.Width = 150;
            // 
            // Beleza
            // 
            this.Beleza.HeaderText = "Beleza";
            this.Beleza.MinimumWidth = 8;
            this.Beleza.Name = "Beleza";
            this.Beleza.Width = 150;
            // 
            // Higiene
            // 
            this.Higiene.HeaderText = "Higiene";
            this.Higiene.MinimumWidth = 8;
            this.Higiene.Name = "Higiene";
            this.Higiene.Width = 150;
            // 
            // F_estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Farmacio.Properties.Resources.vecteezy_curve_light_blue_background_abstract_;
            this.ClientSize = new System.Drawing.Size(803, 455);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "F_estoque";
            this.Text = "F_estoque";
            this.Load += new System.EventHandler(this.F_estoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Beleza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Higiene;
    }
}