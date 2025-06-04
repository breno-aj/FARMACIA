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
    public partial class F_financeiro : Form
    {
        public F_financeiro(F_menu f)
        {
            InitializeComponent();
            f.Visible = false;
        }

        private void F_financeiro_Load(object sender, EventArgs e)
        {

        }
    }
}
