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
    public class BLProvincias
    {
        public BLProvincias()
        {
            oMProvincias = new MProvincias();
        }

        MProvincias oMProvincias;

        public List<BEProvincias> ListarTodo()
        {
            return oMProvincias.ListarTodo();
        }
    }
}
