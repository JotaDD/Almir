using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Escola.clsDados.DAL
{
    public class Professor
    {
        public DataTable Select()
        {
            SqlConnection con = new SqlConnection(Banco.stringDeConexao);
            DataTable consulta = new DataTable();
            string sql = "SELECT * FROM Professor order by Nome";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(consulta);

            return consulta;
        }

        public void Insert(Model.Professor oProfessor)
        {
            SqlConnection con = new SqlConnection(Banco.stringDeConexao);
            string sql = "INSERT INTO Professor (DataCadastro,Nome, Cpf,Telefone) VALUES (@DataCadastro,@Nome, @Cpf,@Telefone)";
            SqlCommand cmd = new SqlCommand(sql, con);
            //cmd.Parameters.AddWithValue("@Codigo",oProfessor.Codigo);
            cmd.Parameters.AddWithValue("@Nome", oProfessor.Nome);
            cmd.Parameters.AddWithValue("@Cpf", oProfessor.Cpf);
            cmd.Parameters.AddWithValue("@Telefone", oProfessor.Telefone);
            cmd.Parameters.AddWithValue("@DataCadastro", oProfessor.DataCadastro);
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


        public void Update(Model.Professor oProfessor)
        {
            SqlConnection con = new SqlConnection(Banco.stringDeConexao);
            string sql = "UPDATE Professor SET Cpf= @Cpf ,Telefone=@Telefone,DataCadastro=@DataCadastro WHERE Nome = @Nome";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Codigo", oProfessor.Codigo);
            cmd.Parameters.AddWithValue("@Nome", oProfessor.Nome);
            cmd.Parameters.AddWithValue("@Cpf", oProfessor.Cpf);
            cmd.Parameters.AddWithValue("@Telefone", oProfessor.Telefone);
            cmd.Parameters.AddWithValue("@DataCadastro", oProfessor.DataCadastro);
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

        public void Delete(Model.Professor oProfessor)
        {
            SqlConnection con = new SqlConnection(Banco.stringDeConexao);
            string sql = "DELETE Professor WHERE Codigo = @Codigo";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Codigo", oProfessor.Codigo);
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
