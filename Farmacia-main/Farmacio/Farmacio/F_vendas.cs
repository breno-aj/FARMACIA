using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacio
{
    public partial class F_vendas : Form
    {
        public F_vendas(F_menuVendendor f)
        {
            InitializeComponent();
            f.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void F_vendas_Load(object sender, EventArgs e)
        {

        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            string produto = Convert.ToString (tbxprodutos.Text);
            Double quantidade = Convert.ToDouble (cbxquantidade.Text);
            Double preco = Convert.ToDouble (tbxpreco.Text);
            Double total = Convert.ToDouble (preco * quantidade);

            MessageBox.Show("Total: R$ " + total.ToString());
        }

        private void btnfinalizar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
