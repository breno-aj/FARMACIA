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
    public partial class F_menu : Form
    {
        public F_menu(Form1 f)
        {
            InitializeComponent();
            f.Visible = false;
        }

        private void F_menu_Load(object sender, EventArgs e)
        {

        }

        private void btnestoque_Click(object sender, EventArgs e)
        {
            F_estoque janelaestoque = new F_estoque(this);
            janelaestoque.ShowDialog();
            this.Close();
        }

        private void btnanalise_Click(object sender, EventArgs e)
        {
            F_financeiro janelafinaceiro = new F_financeiro(this);
            janelafinaceiro.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_adm janelacadastro = new F_adm(this);
            janelacadastro.ShowDialog();
            this.Close();
        }
    }
}
