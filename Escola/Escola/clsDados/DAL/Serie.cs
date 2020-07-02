using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Escola.clsDados.DAL
{
    public class Serie
    {
        public DataTable Select()
        {
            SqlConnection con = new SqlConnection(Banco.stringDeConexao);
            DataTable consulta = new DataTable();
            string sql = "SELECT * FROM Serie order by Codigo";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(consulta);

            return consulta;
        }

        public void Insert(Model.Serie oSerie)
        {
            SqlConnection con = new SqlConnection(Banco.stringDeConexao);
            string sql = "INSERT INTO Aluno (Descricao) VALUES (@Descricao)";
            SqlCommand cmd = new SqlCommand(sql, con);
            //cmd.Parameters.AddWithValue("@Codigo",oSerie.Codigo);
            cmd.Parameters.AddWithValue("@Descricao", oSerie.Descricao);
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


        public void Update(Model.Serie oSerie)
        {
            SqlConnection con = new SqlConnection(Banco.stringDeConexao);
            string sql = "UPDATE Serie SET Descricao= @Descricao WHERE Codigo = @Codigo";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Codigo", oSerie.Codigo);
            cmd.Parameters.AddWithValue("@Descricao", oSerie.Descricao);
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

        public void Delete(Model.Serie oSerie)
        {
            SqlConnection con = new SqlConnection(Banco.stringDeConexao);
            string sql = "DELETE Serie WHERE Codigo = @Codigo";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Codigo", oSerie.Codigo);
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
