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
    public class BLTarjeta : IGestor<BETarjeta>
    {
        public BLTarjeta()
        {
            oMTarjeta = new MTarjeta();
        }

        MTarjeta oMTarjeta;

        public bool Guardar(BETarjeta oBETarjeta)
        {
            return oMTarjeta.Guardar(oBETarjeta);
        }

        public bool Baja(BETarjeta oBETarjeta)
        {
            return oMTarjeta.Baja(oBETarjeta);
        }

        public BETarjeta ListarObjeto(BETarjeta oBETarjeta)
        {
            return oMTarjeta.ListarObjeto(oBETarjeta);
        }

        public List<BETarjeta> ListarTodo()
        {
            return oMTarjeta.ListarTodo();
        }
    }
}
