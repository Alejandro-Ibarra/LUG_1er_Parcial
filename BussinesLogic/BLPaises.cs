using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;
using BusinessEntity;
using Mapper;

namespace BussinesLogic
{
    public class BLPaises : IGestor<BEPaises>
    {
        public BLPaises()
        {
            oMpaises = new MPaises();
        }

        MPaises oMpaises;
        

        public bool Baja(BEPaises oBEPais)
        {
            return oMpaises.Baja(oBEPais);
        }

        public bool Guardar(BEPaises oBEPais)
        {
            return oMpaises.Guardar(oBEPais);
        }

        public BEPaises ListarObjeto(BEPaises oBEPais)
        {
            return oMpaises.ListarObjeto(oBEPais);
        }

        public List<BEPaises> ListarTodo()
        {
            return oMpaises.ListarTodo();
        }
    }
}
