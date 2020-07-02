using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Escola.clsDados.BLL
{
    public class Salas
    {
        DAL.Salas dalAl = new DAL.Salas();

        public void Insert(Model.Salas oSalas)
        {
            if (oSalas.Aluno == "")
            {
                throw new Exception("Campo Obrigatório!");
            }
            dalAl.Insert(oSalas);
        }

        public void Update(Model.Salas oSalas)
        {
            if (oSalas.Aluno != "")
                dalAl.Update(oSalas);
        }

        public void Delete(Model.Salas oSalas)
        {
            if (oSalas.Codigo > 0)
                dalAl.Delete(oSalas);
        }
    }
}
