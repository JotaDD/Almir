using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.clsDados.Model
{
    public class Aluno
    {
        public int Codigo { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Nome { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Responsavel { get; set; }

    }
}
