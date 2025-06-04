namespace Farmacio
{
    partial class F_menuVendendor
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnvendas = new System.Windows.Forms.Button();
            this.btnestoque = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "VENDEDOR";
            // 
            // btnvendas
            // 
            this.btnvendas.Location = new System.Drawing.Point(27, 66);
            this.btnvendas.Margin = new System.Windows.Forms.Padding(2);
            this.btnvendas.Name = "btnvendas";
            this.btnvendas.Size = new System.Drawing.Size(109, 27);
            this.btnvendas.TabIndex = 9;
            this.btnvendas.Text = "vendas";
            this.btnvendas.UseVisualStyleBackColor = true;
            this.btnvendas.Click += new System.EventHandler(this.btnvendas_Click);
            // 
            // btnestoque
            // 
            this.btnestoque.Location = new System.Drawing.Point(27, 107);
            this.btnestoque.Margin = new System.Windows.Forms.Padding(2);
            this.btnestoque.Name = "btnestoque";
            this.btnestoque.Size = new System.Drawing.Size(109, 27);
            this.btnestoque.TabIndex = 6;
            this.btnestoque.Text = "Metas";
            this.btnestoque.UseVisualStyleBackColor = true;
            this.btnestoque.Click += new System.EventHandler(this.btnestoque_Click);
            // 
            // F_menuVendendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Farmacio.Properties.Resources.vecteezy_curve_light_blue_background_abstract_;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnvendas);
            this.Controls.Add(this.btnestoque);
            this.Name = "F_menuVendendor";
            this.Text = "F_menuVendendor";
            this.Load += new System.EventHandler(this.F_menuVendendor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnvendas;
        private System.Windows.Forms.Button btnestoque;
    }
}