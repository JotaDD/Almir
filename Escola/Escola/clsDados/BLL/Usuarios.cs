using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.clsDados.BLL
{
    public class Usuarios
    {
        DAL.Usuarios dalUsu = new DAL.Usuarios();

        public void Insert(Model.Usuarios oUsu)
        {
            if(oUsu.Usuario == "")
            {
                throw new Exception("Campo Usuário Obrigatório!");
            }
            dalUsu.Insert(oUsu);
        }

        public void Update (Model.Usuarios oUsu)
        {
            if (oUsu.Usuario != "")
                dalUsu.Update(oUsu);
;        }

        public void Delete(Model.Usuarios oUsu)
        {
            if (oUsu.Codigo > 0)
                dalUsu.Delete(oUsu);
        }


    }
}
