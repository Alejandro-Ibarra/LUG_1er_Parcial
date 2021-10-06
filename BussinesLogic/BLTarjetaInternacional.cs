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
    public class BLTarjetaInternacional : BLTarjeta, IGestor<BETarjetaInternacional>
    {
        public BLTarjetaInternacional()
        {
            oMTarjetaInternacional = new MTarjetaInternacional();
        }

        MTarjetaInternacional oMTarjetaInternacional;

        public bool Baja(BETarjetaInternacional oBETarjeta)
        {
            return oMTarjetaInternacional.Baja(oBETarjeta);
        }

        public bool Guardar(BETarjetaInternacional oBETarjeta)
        {
            return oMTarjetaInternacional.Guardar(oBETarjeta);
        }

        public BETarjetaInternacional ListarObjeto(BETarjetaInternacional oBETarjeta)
        {
            return oMTarjetaInternacional.ListarObjeto(oBETarjeta);
        }
  
        public List<BETarjetaInternacional> ListarTodo()
        {
            return oMTarjetaInternacional.ListarTodo();
        }

        public List<BETarjetaInternacional> ListarDisponibles()
        {
            return oMTarjetaInternacional.ListarDisponible();
        }

        public override double ObtenerDescuento(double Monto)
        {
            return Monto * 0.70;
        }
    }
}
