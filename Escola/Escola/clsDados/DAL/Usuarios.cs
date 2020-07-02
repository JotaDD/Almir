using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Escola.clsDados.DAL
{
    public class Usuarios
    {
        public DataTable Select()
        {
            SqlConnection con = new SqlConnection(Banco.stringDeConexao);
            DataTable consulta = new DataTable();
            string sql = "SELECT * FROM Usuarios order by Usuario";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(consulta);

            return consulta;
        }

        public void Insert(Model.Usuarios oUsuarios)
        {
            SqlConnection con = new SqlConnection(Banco.stringDeConexao);
            string sql = "INSERT INTO Usuarios (Usuario,Senha,Permissao) VALUES (@Usuario,@Senha,@Permissao)";
            SqlCommand cmd = new SqlCommand(sql, con);
            //            cmd.Parameters.AddWithValue("@Codigo", oUsuarios.Codigo);
            cmd.Parameters.AddWithValue("@Usuario", oUsuarios.Usuario);
            cmd.Parameters.AddWithValue("@Senha", oUsuarios.Senha);
            cmd.Parameters.AddWithValue("@Permissao", oUsuarios.Permissao);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }


        public void Update(Model.Usuarios oUsuarios)
        {
            SqlConnection con = new SqlConnection(Banco.stringDeConexao);
            string sql = "UPDATE Serie SET Usuario = @Usuario, Senha= @Senha,Permissao=@Permissao WHERE Codigo= @Codigo";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Codigo", oUsuarios.Codigo);
            cmd.Parameters.AddWithValue("@Usuario", oUsuarios.Usuario);
            cmd.Parameters.AddWithValue("@Senha", oUsuarios.Senha);
            cmd.Parameters.AddWithValue("@Permissao", oUsuarios.Permissao);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        public void Delete(Model.Usuarios oUsuarios)
        {
            SqlConnection con = new SqlConnection(Banco.stringDeConexao);
            string sql = "DELETE Usuarios WHERE Codigo = @Codigo";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Codigo", oUsuarios.Codigo);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }
    }
}
