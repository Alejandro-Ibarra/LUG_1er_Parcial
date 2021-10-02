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
    public class BLCliente : IGestor<BECliente>
    {
        public BLCliente()
        {
            oMCliente = new MCliente();
        }

        MCliente oMCliente;

        public bool Guardar(BECliente oBECliente)
        {
            return oMCliente.Guardar(oBECliente);
        }

        public bool Baja(BECliente oBECliente)
        {
            return oMCliente.Baja(oBECliente);
        }

        public List<BECliente> ListarTodo()
        {
            return oMCliente.ListarTodo();
        }

        public BECliente ListarObjeto(BECliente oBECliente)
        {
            return oMCliente.ListarObjeto(oBECliente);
        }
    }
}
