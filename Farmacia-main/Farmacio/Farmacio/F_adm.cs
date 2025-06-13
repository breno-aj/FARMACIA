using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacio
{
    public partial class F_adm : Form
    {
        public F_adm(F_menu f)
        {
            InitializeComponent();
            f.Visible = false;
        }

        private void F_adm_Load(object sender, EventArgs e)
        {

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();

        }

        private void btncadrastar_Click(object sender, EventArgs e)
        {
            // Conectar ao banco de dados
            // codigo de cadastro de funcionarios
            string strconn = ("Data Source=SOB041987L4B1PC\\SQLEXPRESS; " +
                               "Initial Catalog=Senac;Integrated Security=true");
            SqlConnection conn = new SqlConnection(strconn);
            string sql = "INSERT INTO funcionarios (nome, cpf, data de nascimento, e-mail, cargos, usuario, senha) " +
                "VALEU (@nome, @cpf, @datanascimento, @email, @cargos, @usuario, @senha)";
            try
            {
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.Parameters.Add(new SqlParameter("@nome", tbxnome.Text));
                comando.Parameters.Add(new SqlParameter("@cpf", tbxcpf.Text));
                comando.Parameters.Add(new SqlParameter("@datanascimento", tbxdata.Text));
                comando.Parameters.Add(new SqlParameter("@email", tbxemail.Text));
                comando.Parameters.Add(new SqlParameter("@cargos", cbxcargos.Text));
                comando.Parameters.Add(new SqlParameter("@usuario", tbxusuario.Text));
                comando.Parameters.Add(new SqlParameter("@senha", tbxsenha.Text));

                conn.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("Funcionario Cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Não foi possivel  cadastrar", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
