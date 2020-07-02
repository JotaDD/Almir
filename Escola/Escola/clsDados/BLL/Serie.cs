using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.clsDados.BLL
{
    public class Serie
    {
        DAL.Serie dalSerie = new DAL.Serie();

        public void Insert(Model.Serie oSerie)
        {
            if (oSerie.Descricao == "")
            {
                throw new Exception("Campo Obrigatório!");
            }
            dalSerie.Insert(oSerie);
        }

        public void Update(Model.Serie oSerie) {

            if (oSerie.Descricao != "")
                dalSerie.Update(oSerie);
    
        }

        public void Delete(Model.Serie oSerie) {

            if (oSerie.Codigo > 0)
                dalSerie.Delete(oSerie);

        }

        











    }
}
