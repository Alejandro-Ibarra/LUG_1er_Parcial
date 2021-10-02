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
    public class MTarjetaNacional : IGestor<BETarjetaNacional>
    {
        Conexion oConexion;
        
        public bool Guardar(BETarjetaNacional oBETarjeta)
        {
            string ConsultaSql;
            if (oBETarjeta.Codigo == 0)
            {
                ConsultaSql = "Insert into Tarjetas (Numero,Vencimiento,PorcentajeDescuento,Estado,Rubro,TipoNacProv,Provincia) " +
                    "values('" + oBETarjeta.Numero + "', '" + oBETarjeta.Vencimiento + "', " + oBETarjeta.Descuento + ",'" + oBETarjeta.Estado + "', '" + oBETarjeta.Rubro + "', " + oBETarjeta.Pais + "', " + oBETarjeta.Provincia + "' ) ";
            }
            else
            {
                ConsultaSql = "Update Tarjetas SET Numero = '" + oBETarjeta.Numero + "', Vencimiento = '" + oBETarjeta.Vencimiento + "', PorcentajeDescuento = '" + oBETarjeta.Descuento +
                    "', Estado = '" + oBETarjeta.Estado + "', Rubro = '" + oBETarjeta.Rubro + "', TipoNacProv = '" + oBETarjeta.Pais + "', Provincia = '" + oBETarjeta.Provincia + "' where codigo = " + oBETarjeta.Codigo + "";
            }
            oConexion = new Conexion();
            return oConexion.Escribir(ConsultaSql);
        }

        public BETarjetaNacional ListarObjeto(BETarjetaNacional oBETarjeta)
        {
            oConexion = new Conexion();
            string Consulta = "SELECT Codigo,Numero,Vencimiento,PorcentajeDescuento,Estado,Rubro,TipoNacProv,Provincia FROM Tarjetas where Codigo =" + oBETarjeta.Codigo;
            DataSet oDataSet = oConexion.LeerDataSet(Consulta);

            if (oDataSet.Tables[0].Rows.Count > 0)
            {
                BETarjetaNacional oBETarjInt = new BETarjetaNacional();
                foreach (DataRow fila in oDataSet.Tables[0].Rows)
                {

                    oBETarjInt.Codigo = Convert.ToInt32(fila[0]);
                    oBETarjInt.Numero = Convert.ToInt32(fila[1]);
                    oBETarjInt.Vencimiento = Convert.ToDateTime(fila[2]);
                    oBETarjInt.Descuento = Convert.ToInt32(fila[3]);
                    oBETarjInt.Estado = fila[4].ToString();
                    oBETarjInt.Rubro = fila[5].ToString();
                    oBETarjInt.Pais = fila[6].ToString();
                    oBETarjInt.Provincia= fila[7].ToString();
                }
                return oBETarjInt;
            }
            else { return null; }
        }

        public List<BETarjetaNacional> ListarTodo()
        {
            throw new NotImplementedException();
        }

        public bool Baja(BETarjetaNacional oBETarjeta)
        {
            throw new NotImplementedException();
        }
    }
}
