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
    public abstract class BLTarjeta 
    {
        public abstract double ObtenerDescuento(double Monto);
    }
}
