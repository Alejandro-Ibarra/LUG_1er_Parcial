using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;
using BusinessEntity;
using DataAccess;

namespace Mapper
{
    public class MTarjeta : IGestor<BETarjeta>
    {
        Conexion oConexion;

        public bool Baja(BETarjeta oBEtarjeta)
        {
            oConexion = new Conexion();
  
            string consulta1 = "  select  count (CoDTarjeta) from Clientes where CoDTarjeta = '" + oBEtarjeta.Codigo + "'";

            bool aux = oConexion.LeerAsociacion(consulta1);

            if (aux == true)
            {
                string Consulta2 = " Update Clientes SET CoDTarjeta = 'null'  where Codigo = " + oBEtarjeta.Codigo + "";
                oConexion.Escribir(Consulta2);
            }

            string Consultaq2 = "Delete from Tarjetas where Codigo = " + oBEtarjeta.Codigo + "";
            return oConexion.Escribir(Consultaq2);
        }

        public bool Guardar(BETarjeta oBEtarjeta)
        {
            throw new NotImplementedException();
        }

        public BETarjeta ListarObjeto(BETarjeta oBEtarjeta)
        {
            throw new NotImplementedException();
        }

        public List<BETarjeta> ListarTodo()
        {
            BETarjeta oBEtarjeta;
            List<BETarjeta> ListaTarjetas = new List<BETarjeta>();
            DataSet oDataSetTarjetas;
            oConexion = new Conexion();
            oDataSetTarjetas = oConexion.LeerDataSet("SELECT Codigo,Numero,Vencimiento,PorcentajeDescuento,Estado,Rubro,TipoNacProv,Provincia FROM Tarjetas");
            if (oDataSetTarjetas.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in oDataSetTarjetas.Tables[0].Rows)
                {
                    if (fila[7].ToString() == "Internacional")
                    {
                        oBEtarjeta = new BETarjetaInternacional();
                    }
                    else
                    {
                        BETarjetaNacional oBEtarjetaN = new BETarjetaNacional();
                        oBEtarjetaN.Provincia = fila[7].ToString();
                        oBEtarjeta = new BETarjetaNacional();
                        oBEtarjeta = oBEtarjetaN;

                    }
                    oBEtarjeta.Codigo = Convert.ToInt32(fila[0]);
                    oBEtarjeta.Numero = Convert.ToInt32(fila[1]);
                    oBEtarjeta.Vencimiento = Convert.ToDateTime(fila[2]);
                    oBEtarjeta.Descuento = Convert.ToInt32(fila[3]);
                    oBEtarjeta.Estado = fila[4].ToString();
                    oBEtarjeta.Rubro = fila[5].ToString();
                    oBEtarjeta.Pais = fila[6].ToString();

                    ListaTarjetas.Add(oBEtarjeta);
                }
            }
            return ListaTarjetas;
        }
    }
}
