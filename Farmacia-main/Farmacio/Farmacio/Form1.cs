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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            string usuario = tbxusuario.Text.Trim();
            string senha = tbxsenha.Text.Trim();
            string perfil = cbxperfil.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha) || string.IsNullOrEmpty(perfil))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (perfil.Equals("administrador", StringComparison.OrdinalIgnoreCase))
            {
                F_menu janelaDiretor = new F_menu(this);
                janelaDiretor.ShowDialog();
                this.Close();
            }

            if (perfil.Equals("vendedor", StringComparison.OrdinalIgnoreCase))
            {
                F_menuVendendor janelavendedor = new F_menuVendendor(this);
                janelavendedor.ShowDialog();
                this.Close();
            }

            if (perfil.Equals("Estoquista", StringComparison.OrdinalIgnoreCase))
            {
                F_menuEstoque janelaEstoque = new F_menuEstoque(this);
                janelaEstoque.ShowDialog();
                this.Close();
            }

            else
            {
                MessageBox.Show("Perfil inválido ou sem permissão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}
