﻿using System;
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
    public partial class F_estoque : Form
    {
        public F_estoque(F_menu f)
        {

            InitializeComponent();
            f.Visible = false;

        }

        private void F_estoque_Load(object sender, EventArgs e)
        {



        }
    }
}
