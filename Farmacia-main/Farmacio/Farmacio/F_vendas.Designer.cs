namespace Farmacio
{
    partial class F_vendas
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
            this.tbxprodutos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxpreco = new System.Windows.Forms.TextBox();
            this.rbncredito = new System.Windows.Forms.RadioButton();
            this.rbndebito = new System.Windows.Forms.RadioButton();
            this.rbndinheiro = new System.Windows.Forms.RadioButton();
            this.rbnpix = new System.Windows.Forms.RadioButton();
            this.grppagamento = new System.Windows.Forms.GroupBox();
            this.btnfinalizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnverificar = new System.Windows.Forms.Button();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxquantidade = new System.Windows.Forms.ComboBox();
            this.grppagamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbxprodutos
            // 
            this.tbxprodutos.Location = new System.Drawing.Point(15, 94);
            this.tbxprodutos.Margin = new System.Windows.Forms.Padding(2);
            this.tbxprodutos.Name = "tbxprodutos";
            this.tbxprodutos.Size = new System.Drawing.Size(114, 20);
            this.tbxprodutos.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(183, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Preço:";
            // 
            // tbxpreco
            // 
            this.tbxpreco.Location = new System.Drawing.Point(170, 94);
            this.tbxpreco.Margin = new System.Windows.Forms.Padding(2);
            this.tbxpreco.Name = "tbxpreco";
            this.tbxpreco.Size = new System.Drawing.Size(77, 20);
            this.tbxpreco.TabIndex = 7;
            // 
            // rbncredito
            // 
            this.rbncredito.AutoSize = true;
            this.rbncredito.BackColor = System.Drawing.Color.Transparent;
            this.rbncredito.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbncredito.Location = new System.Drawing.Point(17, 28);
            this.rbncredito.Margin = new System.Windows.Forms.Padding(2);
            this.rbncredito.Name = "rbncredito";
            this.rbncredito.Size = new System.Drawing.Size(65, 19);
            this.rbncredito.TabIndex = 8;
            this.rbncredito.TabStop = true;
            this.rbncredito.Text = "Crédito";
            this.rbncredito.UseVisualStyleBackColor = false;
            // 
            // rbndebito
            // 
            this.rbndebito.AutoSize = true;
            this.rbndebito.BackColor = System.Drawing.Color.Transparent;
            this.rbndebito.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbndebito.Location = new System.Drawing.Point(17, 57);
            this.rbndebito.Margin = new System.Windows.Forms.Padding(2);
            this.rbndebito.Name = "rbndebito";
            this.rbndebito.Size = new System.Drawing.Size(61, 19);
            this.rbndebito.TabIndex = 9;
            this.rbndebito.TabStop = true;
            this.rbndebito.Text = "Débito";
            this.rbndebito.UseVisualStyleBackColor = false;
            // 
            // rbndinheiro
            // 
            this.rbndinheiro.AutoSize = true;
            this.rbndinheiro.BackColor = System.Drawing.Color.Transparent;
            this.rbndinheiro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbndinheiro.Location = new System.Drawing.Point(17, 84);
            this.rbndinheiro.Margin = new System.Windows.Forms.Padding(2);
            this.rbndinheiro.Name = "rbndinheiro";
            this.rbndinheiro.Size = new System.Drawing.Size(72, 19);
            this.rbndinheiro.TabIndex = 10;
            this.rbndinheiro.TabStop = true;
            this.rbndinheiro.Text = "Dinheiro";
            this.rbndinheiro.UseVisualStyleBackColor = false;
            // 
            // rbnpix
            // 
            this.rbnpix.AutoSize = true;
            this.rbnpix.BackColor = System.Drawing.Color.Transparent;
            this.rbnpix.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnpix.Location = new System.Drawing.Point(20, 118);
            this.rbnpix.Margin = new System.Windows.Forms.Padding(2);
            this.rbnpix.Name = "rbnpix";
            this.rbnpix.Size = new System.Drawing.Size(41, 19);
            this.rbnpix.TabIndex = 11;
            this.rbnpix.TabStop = true;
            this.rbnpix.Text = "Pix";
            this.rbnpix.UseVisualStyleBackColor = false;
            // 
            // grppagamento
            // 
            this.grppagamento.BackgroundImage = global::Farmacio.Properties.Resources.vecteezy_curve_light_blue_background_abstract_;
            this.grppagamento.Controls.Add(this.rbndinheiro);
            this.grppagamento.Controls.Add(this.rbncredito);
            this.grppagamento.Controls.Add(this.rbndebito);
            this.grppagamento.Controls.Add(this.rbnpix);
            this.grppagamento.Location = new System.Drawing.Point(457, 92);
            this.grppagamento.Margin = new System.Windows.Forms.Padding(2);
            this.grppagamento.Name = "grppagamento";
            this.grppagamento.Padding = new System.Windows.Forms.Padding(2);
            this.grppagamento.Size = new System.Drawing.Size(237, 157);
            this.grppagamento.TabIndex = 12;
            this.grppagamento.TabStop = false;
            this.grppagamento.Text = "Formas de Pagamento";
            // 
            // btnfinalizar
            // 
            this.btnfinalizar.Location = new System.Drawing.Point(457, 265);
            this.btnfinalizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnfinalizar.Name = "btnfinalizar";
            this.btnfinalizar.Size = new System.Drawing.Size(70, 27);
            this.btnfinalizar.TabIndex = 13;
            this.btnfinalizar.Text = "Finalizar";
            this.btnfinalizar.UseVisualStyleBackColor = true;
            this.btnfinalizar.Click += new System.EventHandler(this.btnfinalizar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(308, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "PAGAMENTOS";
            // 
            // btnverificar
            // 
            this.btnverificar.Location = new System.Drawing.Point(624, 265);
            this.btnverificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnverificar.Name = "btnverificar";
            this.btnverificar.Size = new System.Drawing.Size(70, 27);
            this.btnverificar.TabIndex = 15;
            this.btnverificar.Text = "verificar";
            this.btnverificar.UseVisualStyleBackColor = true;
            // 
            // btnadicionar
            // 
            this.btnadicionar.Location = new System.Drawing.Point(170, 137);
            this.btnadicionar.Margin = new System.Windows.Forms.Padding(2);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(70, 27);
            this.btnadicionar.TabIndex = 16;
            this.btnadicionar.Text = "adicionar";
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(308, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Quant:";
            // 
            // cbxquantidade
            // 
            this.cbxquantidade.FormattingEnabled = true;
            this.cbxquantidade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbxquantidade.Location = new System.Drawing.Point(279, 92);
            this.cbxquantidade.Name = "cbxquantidade";
            this.cbxquantidade.Size = new System.Drawing.Size(121, 21);
            this.cbxquantidade.TabIndex = 20;
            // 
            // F_vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Farmacio.Properties.Resources.vecteezy_curve_light_blue_background_abstract_;
            this.ClientSize = new System.Drawing.Size(740, 417);
            this.Controls.Add(this.cbxquantidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.btnverificar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnfinalizar);
            this.Controls.Add(this.grppagamento);
            this.Controls.Add(this.tbxpreco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxprodutos);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "F_vendas";
            this.Text = "F_vendas";
            this.Load += new System.EventHandler(this.F_vendas_Load);
            this.grppagamento.ResumeLayout(false);
            this.grppagamento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxprodutos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxpreco;
        private System.Windows.Forms.RadioButton rbncredito;
        private System.Windows.Forms.RadioButton rbndebito;
        private System.Windows.Forms.RadioButton rbndinheiro;
        private System.Windows.Forms.RadioButton rbnpix;
        private System.Windows.Forms.GroupBox grppagamento;
        private System.Windows.Forms.Button btnfinalizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnverificar;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxquantidade;
    }
}