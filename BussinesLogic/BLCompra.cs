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
    public class BLCompra : IGestor<BECompra>
    {
        public BLCompra()
        {
            oMCompra = new MCompra();
        }

        MCompra oMCompra;

        public bool Guardar(BECompra oBECompra)
        {
            return oMCompra.Guardar(oBECompra);
        }

        public bool Baja(BECompra oBECompra)
        {
            return oMCompra.Baja(oBECompra);
        }

        public BECompra ListarObjeto(BECompra oBECompra)
        {
            return oMCompra.ListarObjeto(oBECompra);
        }

        public List<BECompra> ListarTodo()
        {
            return oMCompra.ListarTodo();
        }
    }
}
