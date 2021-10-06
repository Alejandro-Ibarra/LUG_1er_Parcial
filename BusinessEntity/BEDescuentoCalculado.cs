using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class BEDescuentoCalculado : BEEntity
    {
        public int NumeroTarjeta { get; set; }
        public string Tipo { get; set; }
        public double DescuentoOtorgado { get; set; }
    }
}
