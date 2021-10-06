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
            return oMTarjetaNacional.Baja(oBEtarjeta);
        }

        public bool Guardar(BETarjetaNacional oBEtarjeta)
        {
            return oMTarjetaNacional.Guardar(oBEtarjeta);
        }

        public BETarjetaNacional ListarObjeto(BETarjetaNacional oBEtarjeta)
        {
            return oMTarjetaNacional.ListarObjeto(oBEtarjeta);
        }

        public List<BETarjetaNacional> ListarTodo()
        {
            return oMTarjetaNacional.ListarTodo();
        }

        public List<BETarjetaNacional> ListarDisponibles()
        {
            return oMTarjetaNacional.ListarDisponibles();
        }

        public override double ObtenerDescuento(double Monto)
        {
            return Monto * 0.75;
        }
    }
}
