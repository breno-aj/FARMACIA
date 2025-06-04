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
    public partial class F_metas : Form
    {
        public F_metas(F_menuVendendor f)
        {
            InitializeComponent();
            f.Visible = false;
        }

        private void F_metas_Load(object sender, EventArgs e)
        {

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            F_menuVendendor janelametas = new F_menuVendendor(this);
            janelametas.ShowDialog();
            this.Close();
        }
    }
}
