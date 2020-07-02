using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Escola.clsDados.DAL
{
    public class Nota
    {
        public DataTable Select()
        {
            SqlConnection con = new SqlConnection(Banco.stringDeConexao);
            DataTable consulta = new DataTable();
            string sql = "SELECT * FROM Nota order by Aluno";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(consulta);

            return consulta;
        }

        public void Insert(Model.Nota oNota)
        {
            SqlConnection con = new SqlConnection(Banco.stringDeConexao);
            string sql = "INSERT INTO Nota (Disciplina,Aluno,Nota1,Total1,Nota2,Total2,Situacao) VALUES (@Disciplina,@Aluno,@Nota1,@Total1,@Nota2,@Total2,@Situacao)";
            SqlCommand cmd = new SqlCommand(sql, con);
            //cmd.Parameters.AddWithValue("@Codigo",oNota.Codigo);
            cmd.Parameters.AddWithValue("@Disciplina", oNota.Disciplina);
            cmd.Parameters.AddWithValue("@Aluno", oNota.Aluno);
            cmd.Parameters.AddWithValue("@Nota1", oNota.Nota1);
            cmd.Parameters.AddWithValue("@Total1", oNota.Total1);
            cmd.Parameters.AddWithValue("@Nota2", oNota.Nota2);
            cmd.Parameters.AddWithValue("@Total2", oNota.Total2);
            cmd.Parameters.AddWithValue("@Situacao", oNota.Situacao);
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


        public void Update(Model.Nota oNota)
        {
            SqlConnection con = new SqlConnection(Banco.stringDeConexao);
            string sql = "UPDATE Nota SET Disciplina=@Disciplina,Aluno=@Aluno,Nota1=@Nota1,Total1=@Total1,Nota2=@Nota2,Total2=@Total2,Situacao=@Situacao WHERE Codigo = @Codigo";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Codigo", oNota.Codigo);
            cmd.Parameters.AddWithValue("@Disciplina", oNota.Disciplina);
            cmd.Parameters.AddWithValue("@Aluno", oNota.Aluno);
            cmd.Parameters.AddWithValue("@Nota1", oNota.Nota1);
            cmd.Parameters.AddWithValue("@Total1", oNota.Total1);
            cmd.Parameters.AddWithValue("@Nota2", oNota.Nota2);
            cmd.Parameters.AddWithValue("@Total2", oNota.Total2);
            cmd.Parameters.AddWithValue("@Situacao", oNota.Situacao);
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

        public void Delete(Model.Nota oNota)
        {
            SqlConnection con = new SqlConnection(Banco.stringDeConexao);
            string sql = "DELETE Nota WHERE Codigo = @Codigo";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Codigo", oNota.Codigo);
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
