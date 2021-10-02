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
    class BLTarjetaInternacional : BLTarjeta, IGestor<BETarjetaInternacional>
    {
        public BLTarjetaInternacional()
        {
            oMTarjetaInternacional = new MTarjetaInternacional();
        }

        MTarjetaInternacional oMTarjetaInternacional;

        public bool Baja(BETarjetaInternacional oBETarjeta)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BETarjetaInternacional oBETarjeta)
        {
            return oMTarjetaInternacional.Guardar(oBETarjeta);
        }

        public BETarjetaInternacional ListarObjeto(BETarjetaInternacional ObjeoBETarjetato)
        {
            throw new NotImplementedException();
        }

        public List<BETarjetaInternacional> ListarTodo()
        {
            throw new NotImplementedException();
        }
    }
}
