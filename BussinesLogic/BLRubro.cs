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
    public class BLRubro
    {
        public BLRubro()
        {
            oMRubro = new MRubro();
        }

        MRubro oMRubro;

        public List<BERubro> ListarTodo()
        {
            return oMRubro.ListarTodo();
        }
    }
}
