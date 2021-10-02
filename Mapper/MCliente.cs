using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;
using BusinessEntity;

namespace Mapper
{
    public class MCliente : IGestor<BECliente>
    {
        public bool Guardar(BECliente Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Baja(BECliente Objeto)
        {
            throw new NotImplementedException();
        }

        public BECliente ListarObjeto(BECliente Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BECliente> ListarTodo()
        {
            throw new NotImplementedException();
        }
    }
}
