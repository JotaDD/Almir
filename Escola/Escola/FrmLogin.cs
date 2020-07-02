using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Escola
{
    public partial class FrmLogin : Form
    {
        clsDados.Model.Usuarios oUsu = new clsDados.Model.Usuarios();
        clsDados.DAL.Usuarios dalUsu = new clsDados.DAL.Usuarios();
        SqlConnection con = new SqlConnection(clsDados.DAL.Banco.stringDeConexao);



        public FrmLogin()
        {
            InitializeComponent();
        }
        public void logar()
        {
            label4.Text = "";
            string usuario, senha;
            try
            {
                usuario = txtUsuario.Text;
                senha = txtSenha.Text;
                string SQL = "Select Codigo from Usuarios where Usuario=@Usuario and Senha=@Senha ";
                SqlCommand cmd = new SqlCommand(SQL, con);
                cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = usuario;
                cmd.Parameters.Add("@Senha", SqlDbType.VarChar).Value = senha;
                con.Open();
                int valor = (int)cmd.ExecuteScalar();
                if (valor > 0)
                {
                    con.Close();

                    string SQL1 = "Select Permissao from Usuarios where Usuario like '" + usuario + "%'";
                    SqlCommand cmd1 = new SqlCommand(SQL1, con);

                    con.Open();
                    string n = (string)cmd1.ExecuteScalar();


                    this.Visible = false;
                    txtUsuario.Text = "";
                    txtSenha.Text = "";
                    txtUsuario.Focus();
                    
                   /* bool resultado;
                    
                    if (resultado = string.Compare(n, "Administrador") == 0)
                    {
                        con.Close();
                        //FrmMenu frm = new FrmMenu();
                        //frm.Show();
                    }
                   */
                   
                }
                else
                {
                    con.Close();
                    MessageBox.Show("Usuário e Senha inválida!");
                    txtUsuario.Text = "";
                    txtSenha.Text = "";
                    txtUsuario.Focus();
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error + " Erro no Banco de Dados!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" && txtSenha.Text == "")
            {
                label4.Text = "Usuario e Senha são obrigatórios";
                txtUsuario.Focus();

            }

            else
            {
                logar();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void labelUsuario_Click(object sender, EventArgs e)
        {

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
