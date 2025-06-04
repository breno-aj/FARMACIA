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
    public partial class F_menuVendendor : Form
    {
        public F_menuVendendor(Form1 f)
        {
            InitializeComponent();
            f.Visible = false;
        }

        public F_menuVendendor(F_metas f)
        {
            InitializeComponent();
            f.Visible = false;
        }

        private void F_menuVendendor_Load(object sender, EventArgs e)
        {

        }

        private void btnvendas_Click(object sender, EventArgs e)
        {
            
                F_vendas janelavendas = new F_vendas(this);
                janelavendas.ShowDialog();
                this.Close();
            
        }

        private void btnestoque_Click(object sender, EventArgs e)
        {
            F_metas janelametas = new F_metas(this);
            janelametas.ShowDialog();
            this.Close();
        }
    }
}
