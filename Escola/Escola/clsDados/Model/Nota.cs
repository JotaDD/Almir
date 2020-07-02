using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.clsDados.Model
{
    public class Nota
    {
        public int Codigo { get; set; }
        public string Disciplina { get; set; }
        public string Aluno { get; set; }
        public float Nota1 { get; set; }
        public float Nota2 { get; set; }
        public float Total1 { get; set; }
        public float Total2 { get; set; }
        public string Situacao { get; set; }
        

    }
}
