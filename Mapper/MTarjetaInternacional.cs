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
    public class MTarjetaInternacional : IGestor<BETarjeta>
    {
        Conexion oConexion;

        public bool Guardar(BETarjeta oBETarjeta)
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

        public bool Baja(BETarjeta Objeto)
        {
            throw new NotImplementedException();
        }

        public BETarjeta ListarObjeto(BETarjeta Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BETarjeta> ListarTodo()
        {
            List<BETarjeta> ListaTarjetas = new List<BETarjeta>();
            DataSet oDataSetTarjetas;
            oConexion = new Conexion();
            string ConsultaSQL = "SELECT Codigo,Numero,Vencimiento,PorcentajeDescuento,Estado,Rubro,TipoNacProv,Provincia FROM Tarjetas";
            oDataSetTarjetas = oConexion.LeerDataSet(ConsultaSQL);
            if (oDataSetTarjetas.Tables[0].Rows.Count > 0)
            {

                foreach (DataRow fila in oDataSetTarjetas.Tables[0].Rows)
                {
                    BETecnico oBETec = new BETecnico();
                    oBETec.Codigo = Convert.ToInt32(fila[0]);
                    oBETec.Nombre = fila[1].ToString();
                    oBETec.Apellido = fila["Apellido"].ToString();
                    oBETec.DNI = Convert.ToInt32(fila["DNI"]);
                    ListaTecnicos.Add(oBETec);
                }
            }
            return ListaTecnicos;
        }
    }
}
