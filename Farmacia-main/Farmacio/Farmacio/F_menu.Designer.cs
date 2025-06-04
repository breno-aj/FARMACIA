namespace Farmacio
{
    partial class F_menu
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
            this.btnestoque = new System.Windows.Forms.Button();
            this.btnanalise = new System.Windows.Forms.Button();
            this.btnprodutos = new System.Windows.Forms.Button();
            this.btnvendas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnestoque
            // 
            this.btnestoque.Location = new System.Drawing.Point(26, 62);
            this.btnestoque.Margin = new System.Windows.Forms.Padding(2);
            this.btnestoque.Name = "btnestoque";
            this.btnestoque.Size = new System.Drawing.Size(109, 27);
            this.btnestoque.TabIndex = 0;
            this.btnestoque.Text = "Estoque";
            this.btnestoque.UseVisualStyleBackColor = true;
            // 
            // btnanalise
            // 
            this.btnanalise.Location = new System.Drawing.Point(26, 109);
            this.btnanalise.Margin = new System.Windows.Forms.Padding(2);
            this.btnanalise.Name = "btnanalise";
            this.btnanalise.Size = new System.Drawing.Size(109, 27);
            this.btnanalise.TabIndex = 1;
            this.btnanalise.Text = "analise financeira";
            this.btnanalise.UseVisualStyleBackColor = true;
            // 
            // btnprodutos
            // 
            this.btnprodutos.Location = new System.Drawing.Point(26, 158);
            this.btnprodutos.Margin = new System.Windows.Forms.Padding(2);
            this.btnprodutos.Name = "btnprodutos";
            this.btnprodutos.Size = new System.Drawing.Size(109, 27);
            this.btnprodutos.TabIndex = 2;
            this.btnprodutos.Text = "produtos";
            this.btnprodutos.UseVisualStyleBackColor = true;
            // 
            // btnvendas
            // 
            this.btnvendas.Location = new System.Drawing.Point(26, 204);
            this.btnvendas.Margin = new System.Windows.Forms.Padding(2);
            this.btnvendas.Name = "btnvendas";
            this.btnvendas.Size = new System.Drawing.Size(109, 27);
            this.btnvendas.TabIndex = 3;
            this.btnvendas.Text = "vendas";
            this.btnvendas.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "ADM";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(334, 62);
            this.lblresultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(0, 13);
            this.lblresultado.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 247);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "CADASTRO";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // F_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Farmacio.Properties.Resources.vecteezy_curve_light_blue_background_abstract_;
            this.ClientSize = new System.Drawing.Size(786, 468);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnvendas);
            this.Controls.Add(this.btnprodutos);
            this.Controls.Add(this.btnanalise);
            this.Controls.Add(this.btnestoque);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "F_menu";
            this.Text = "F_menu";
            this.Load += new System.EventHandler(this.F_menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnestoque;
        private System.Windows.Forms.Button btnanalise;
        private System.Windows.Forms.Button btnprodutos;
        private System.Windows.Forms.Button btnvendas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Button button1;
    }
}