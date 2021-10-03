using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using Abstraccion;
using Mapper;

namespace BussinesLogic
{
    public class BLTarjetaNacional : BLTarjeta, IGestor<BETarjetaNacional>
    {
        public BLTarjetaNacional()
        {
            oMTarjetaNacional= new MTarjetaNacional();
        }

        MTarjetaNacional oMTarjetaNacional;

        public bool Baja(BETarjetaNacional oBEtarjeta)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BETarjetaNacional oBEtarjeta)
        {
            return oMTarjetaNacional.Guardar(oBEtarjeta);
        }

        public BETarjetaNacional ListarObjeto(BETarjetaNacional oBEtarjeta)
        {
            throw new NotImplementedException();
        }

        public List<BETarjetaNacional> ListarTodo()
        {
            throw new NotImplementedException();
        }
    }
}
