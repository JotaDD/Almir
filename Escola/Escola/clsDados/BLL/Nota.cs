using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Escola.clsDados.BLL
{
    public class Nota
    {
        DAL.Nota dalNota = new DAL.Nota();

        public void Insert(Model.Nota oNo)
        {
            if (oNo.Disciplina == "")
            {
                throw new Exception("Campo Obrigatório!");
            }
            dalNota.Insert(oNo);
        }

        public void Update(Model.Nota oNo)
        {
            if (oNo.Disciplina != "")
                dalNota.Update(oNo);
        }

        public void Delete(Model.Nota oNo)
        {
            if (oNo.Codigo > 0)
                dalNota.Delete(oNo);
        }
    }
}
