using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Escola.clsDados.BLL
{
    public class Aluno
    {
        DAL.Aluno dalAl = new DAL.Aluno();

        public void Insert(Model.Aluno oAluno)
        {
            if (oAluno.Nome == "")
            {
                throw new Exception("Campo Obrigatório!");
            }
            dalAl.Insert(oAluno);
        }

        public void Update(Model.Aluno oAluno)
        {
            if (oAluno.Nome != "")
                dalAl.Update(oAluno);
        }

        public void Delete(Model.Aluno oAluno)
        {
            if (oAluno.Codigo > 0)
                dalAl.Delete(oAluno);
        }
    }
}
