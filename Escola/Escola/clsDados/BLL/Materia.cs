using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Escola.clsDados.BLL
{
    public class Materia
    {
        DAL.Materia dalUMa = new DAL.Materia();

        public void Insert(Model.Materia oMa)
        {
            if (oMa.Disciplina == "")
            {
                throw new Exception("Campo Obrigatório!");
            }
            dalUMa.Insert(oMa);
        }

        public void Update(Model.Materia oMa)
        {
            if (oMa.Disciplina != "")
                dalUMa.Update(oMa);
        }

        public void Delete(Model.Materia oMa)
        {
            if (oMa.Codigo > 0)
                dalUMa.Delete(oMa);
        }
    }
}
