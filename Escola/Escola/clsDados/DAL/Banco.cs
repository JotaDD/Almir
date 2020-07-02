using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.clsDados.DAL
{
    public class Banco
    {

        public static string stringDeConexao {

            get {
                string conexao = "Data Source=JOAO-SOFT9\\SQLEXPRESS;Initial Catalog=Escola;User ID=sa;Password=inovafarmaI";


                return conexao;
            }
        
        
        }

    }
}
