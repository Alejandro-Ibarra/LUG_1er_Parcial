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
    public class BLDescuentosCalculados : IGestor<BEDescuentoCalculado>
    {
        public BLDescuentosCalculados()
        {
            oMDesc = new MDescuentosCalculados();
        }
        
        MDescuentosCalculados oMDesc;

        public bool Guardar(BEDescuentoCalculado oBEDesc)
        {
            return oMDesc.Guardar(oBEDesc);
        }

        public bool Baja(BEDescuentoCalculado oBEDesc)
        {
            return oMDesc.Baja(oBEDesc);
        }

        public BEDescuentoCalculado ListarObjeto(BEDescuentoCalculado oBEDesc)
        {
            return oMDesc.ListarObjeto(oBEDesc);
        }

        public List<BEDescuentoCalculado> ListarTodo()
        {
            return oMDesc.ListarTodo();
        }
    }
}
