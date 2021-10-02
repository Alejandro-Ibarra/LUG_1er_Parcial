using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class BETarjeta : BEEntity
    {
        public int Numero { get; set; }
        public DateTime Vencimiento { get; set; }
        public int Saldo { get; set; }
        public int Descuento { get; set; }
        public string Estado { get; set; }
        public string Rubro { get; set; }
        public string Pais { get; set; }

    }
}
