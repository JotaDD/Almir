using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Escola.clsDados.BLL
{
    public class Professor
    {
        DAL.Professor dalProf = new DAL.Professor();

        public void Insert(Model.Professor oProf)
        {
            if (oProf.Nome == "")
            {
                throw new Exception("Campo Obrigatório!");
            }
            dalProf.Insert(oProf);
        }

        public void Update(Model.Professor oProf)
        {
            if (oProf.Nome != "")
                dalProf.Update(oProf);
        }

        public void Delete(Model.Professor oProf)
        {
            if (oProf.Codigo > 0)
                dalProf.Delete(oProf);
        }
    }
}

