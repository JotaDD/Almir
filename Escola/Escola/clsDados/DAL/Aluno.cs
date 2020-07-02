using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Escola.clsDados.DAL
{
    public class Aluno
    {
        public DataTable Select()
        {
            SqlConnection con = new SqlConnection(Banco.stringDeConexao);
            DataTable consulta = new DataTable();
            string sql = "SELECT * FROM Aluno order by Nome";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(consulta);

            return consulta;
        }

        public void Insert(Model.Aluno oAluno)
        {
            SqlConnection con = new SqlConnection(Banco.stringDeConexao);
            string sql = "INSERT INTO Aluno (DataCadastro,Nome, Rg, Cpf,,Responsavel,Telefone,Rua) VALUES (@DataCadastro,@Nome, @Rg, @Cpf,@Responsavel,@Telefone)";
            SqlCommand cmd = new SqlCommand(sql, con);
            //cmd.Parameters.AddWithValue("@Codigo",oAluno.Codigo);
            cmd.Parameters.AddWithValue("@Nome", oAluno.Nome);
            cmd.Parameters.AddWithValue("@Rg", oAluno.Rg);
            cmd.Parameters.AddWithValue("@Cpf", oAluno.Cpf);
            cmd.Parameters.AddWithValue("@Telefone", oAluno.Telefone);
            cmd.Parameters.AddWithValue("@Responsavel", oAluno.Responsavel);
            cmd.Parameters.AddWithValue("@DataCadastro", oAluno.DataCadastro);
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


        public void Update(Model.Aluno oAluno)
        {
            SqlConnection con = new SqlConnection(Banco.stringDeConexao);
            string sql = "UPDATE Aluno SET Rg = @Rg, Cpf= @Cpf ,Responsavel=@Responsavel ,Telefone=@Telefone,DataCadastro=@DataCadastro WHERE Nome = @Nome";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Codigo", oAluno.Codigo);
            cmd.Parameters.AddWithValue("@Nome", oAluno.Nome);
            cmd.Parameters.AddWithValue("@Rg", oAluno.Rg);
            cmd.Parameters.AddWithValue("@Cpf", oAluno.Cpf);
            cmd.Parameters.AddWithValue("@Telefone", oAluno.Telefone);
            cmd.Parameters.AddWithValue("@Responsavel", oAluno.Responsavel);
            cmd.Parameters.AddWithValue("@DataCadastro", oAluno.DataCadastro);
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

        public void Delete(Model.Aluno oAluno)
        {
            SqlConnection con = new SqlConnection(Banco.stringDeConexao);
            string sql = "DELETE Aluno WHERE Codigo = @Codigo";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Codigo", oAluno.Codigo);
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
