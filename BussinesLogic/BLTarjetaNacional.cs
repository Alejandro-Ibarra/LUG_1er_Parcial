using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using Abstraccion;


namespace BussinesLogic
{
    class BLTarjetaNacional : BLTarjeta, IGestor<BETarjeta>
    {
        public bool Baja(BETarjeta Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BETarjeta Objeto)
        {
            throw new NotImplementedException();
        }

        public BETarjeta ListarObjeto(BETarjeta Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BETarjeta> ListarTodo()
        {
            throw new NotImplementedException();
        }
    }
}
