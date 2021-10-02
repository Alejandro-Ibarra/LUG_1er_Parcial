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
    public class MTarjetaInternacional : IGestor<BETarjetaInternacional>
    {
        Conexion oConexion;

        public bool Guardar(BETarjetaInternacional oBETarjeta)
        {
            string ConsultaSql;
            if (oBETarjeta.Codigo == 0)
            {
                ConsultaSql = "Insert into Tarjetas (Numero,Vencimiento,PorcentajeDescuento,Estado,Rubro,TipoNacProv) " +
                    "values('" + oBETarjeta.Numero + "', '" + oBETarjeta.Vencimiento + "', " + oBETarjeta.Descuento + ",'" + oBETarjeta.Estado + "', '" + oBETarjeta.Rubro + "', " + oBETarjeta.Pais + "' ) ";
            }
            else
            {
                ConsultaSql = "Update Tarjetas SET Numero = '" + oBETarjeta.Numero + "', Vencimiento = '" + oBETarjeta.Vencimiento + "', PorcentajeDescuento = '" + oBETarjeta.Descuento + 
                    "', Estado = '" + oBETarjeta.Estado + "', Rubro = '" + oBETarjeta.Rubro + "', TipoNacProv = '" + oBETarjeta.Pais + "' where codigo = " + oBETarjeta.Codigo + "";
            }
            oConexion = new Conexion();
            return oConexion.Escribir(ConsultaSql);
        }

        public BETarjetaInternacional ListarObjeto(BETarjetaInternacional oBETarjeta)
        {
            oConexion = new Conexion();
            string Consulta = "SELECT Codigo,Numero,Vencimiento,PorcentajeDescuento,Estado,Rubro,TipoNacProv FROM Tarjetas where Codigo =" + oBETarjeta.Codigo;
            DataSet oDataSet = oConexion.LeerDataSet(Consulta);

            if (oDataSet.Tables[0].Rows.Count > 0)
            {
                BETarjetaInternacional oBETarjInt = new BETarjetaInternacional();
                foreach (DataRow fila in oDataSet.Tables[0].Rows)
                {

                    oBETarjInt.Codigo = Convert.ToInt32(fila[0]);
                    oBETarjInt.Numero = Convert.ToInt32(fila[1]);
                    oBETarjInt.Vencimiento = Convert.ToDateTime(fila[2]);
                    oBETarjInt.Descuento = Convert.ToInt32(fila[3]);
                    oBETarjInt.Estado = fila[4].ToString();
                    oBETarjInt.Rubro = fila[5].ToString();
                    oBETarjInt.Pais = fila[6].ToString();
                }
                return oBETarjInt;
            }
            else { return null; }
        }

        public List<BETarjetaInternacional> ListarTodo()
        {
            throw new NotImplementedException();
        }

        public bool Baja(BETarjetaInternacional oBETarjeta)
        {
            throw new NotImplementedException();
        }
    }
}
