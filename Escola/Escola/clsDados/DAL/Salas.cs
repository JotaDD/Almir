using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Escola.clsDados.DAL
{
    public class Salas
    {
        public DataTable Select()
        {
            SqlConnection con = new SqlConnection(Banco.stringDeConexao);
            DataTable consulta = new DataTable();
            string sql = "SELECT * FROM Salas order by Serie";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(consulta);

            return consulta;
        }

        public void Insert(Model.Salas oSalas)
        {
            SqlConnection con = new SqlConnection(Banco.stringDeConexao);
            string sql = "INSERT INTO Salas (Aluno,Serie, Periodo, Turma) VALUES (@Aluno,@Serie, @Periodo, @Turma)";
            SqlCommand cmd = new SqlCommand(sql, con);
            //            cmd.Parameters.AddWithValue("@Codigo", oSalas.Codigo);
            cmd.Parameters.AddWithValue("@Aluno", oSalas.Aluno);
            cmd.Parameters.AddWithValue("@Serie", oSalas.Serie);
            cmd.Parameters.AddWithValue("@Periodo", oSalas.Periodo);
            cmd.Parameters.AddWithValue("@Turma", oSalas.Turma);
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


        public void Update(Model.Salas oSalas)
        {
            SqlConnection con = new SqlConnection(Banco.stringDeConexao);
            string sql = "UPDATE Salas SET Aluno = @Aluno, Serie= @Serie ,Periodo=@Periodo,Turma=@Turma WHERE Codigo= @Codigo";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Codigo", oSalas.Codigo);
            cmd.Parameters.AddWithValue("@Aluno", oSalas.Aluno);
            cmd.Parameters.AddWithValue("@Serie", oSalas.Serie);
            cmd.Parameters.AddWithValue("@Periodo", oSalas.Periodo);
            cmd.Parameters.AddWithValue("@Turma", oSalas.Turma); con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        public void Delete(Model.Salas oSalas)
        {
            SqlConnection con = new SqlConnection(Banco.stringDeConexao);
            string sql = "DELETE Salas WHERE Codigo = @Codigo";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Codigo", oSalas.Codigo);
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
