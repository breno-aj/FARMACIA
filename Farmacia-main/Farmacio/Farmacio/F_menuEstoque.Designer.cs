namespace Farmacio
{
    partial class F_menuEstoque
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
            this.btnanalise = new System.Windows.Forms.Button();
            this.btnestoque = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "ESTOQUE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnanalise
            // 
            this.btnanalise.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnanalise.Location = new System.Drawing.Point(37, 128);
            this.btnanalise.Margin = new System.Windows.Forms.Padding(2);
            this.btnanalise.Name = "btnanalise";
            this.btnanalise.Size = new System.Drawing.Size(109, 27);
            this.btnanalise.TabIndex = 7;
            this.btnanalise.Text = "REPOSIÇÃO";
            this.btnanalise.UseVisualStyleBackColor = true;
            // 
            // btnestoque
            // 
            this.btnestoque.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnestoque.Location = new System.Drawing.Point(37, 81);
            this.btnestoque.Margin = new System.Windows.Forms.Padding(2);
            this.btnestoque.Name = "btnestoque";
            this.btnestoque.Size = new System.Drawing.Size(109, 27);
            this.btnestoque.TabIndex = 6;
            this.btnestoque.Text = "ESTOQUE";
            this.btnestoque.UseVisualStyleBackColor = true;
            // 
            // F_menuEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Farmacio.Properties.Resources.vecteezy_curve_light_blue_background_abstract_;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnanalise);
            this.Controls.Add(this.btnestoque);
            this.Name = "F_menuEstoque";
            this.Text = "F_menuEstoque";
            this.Load += new System.EventHandler(this.F_menuEstoque_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnanalise;
        private System.Windows.Forms.Button btnestoque;
    }
}