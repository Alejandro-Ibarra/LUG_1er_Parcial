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
    public class BLCompra : IGestor<BEDescuentoCalculado>
    {
        public BLCompra()
        {
            oMCompra = new MDescuentosCalculados();
        }

        MDescuentosCalculados oMCompra;

        public bool Guardar(BEDescuentoCalculado oBECompra)
        {
            return oMCompra.Guardar(oBECompra);
        }

        public bool Baja(BEDescuentoCalculado oBECompra)
        {
            return oMCompra.Baja(oBECompra);
        }

        public BEDescuentoCalculado ListarObjeto(BEDescuentoCalculado oBECompra)
        {
            return oMCompra.ListarObjeto(oBECompra);
        }

        public List<BEDescuentoCalculado> ListarTodo()
        {
            return oMCompra.ListarTodo();
        }
    }
}
