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
                ConsultaSql = "Insert into Tarjetas (Numero,Vencimiento,Estado,Rubro,TipoNacProv,Provincia) " +
                    "values('" + oBETarjeta.Numero + "', '" + oBETarjeta.Vencimiento + "', '" + oBETarjeta.Estado + "', '" + oBETarjeta.Rubro + "', '" + oBETarjeta.Pais + "', '" + oBETarjeta.Provincia + "' ) ";
            }
            else
            {
                ConsultaSql = "Update Tarjetas SET Numero = '" + oBETarjeta.Numero + "', Vencimiento = '" + oBETarjeta.Vencimiento + "', Estado = '" + oBETarjeta.Estado + "', Saldo = '" + oBETarjeta.Saldo + "', Rubro = '" + oBETarjeta.Rubro + "', TipoNacProv = '" + oBETarjeta.Pais + "', Provincia = '" + oBETarjeta.Provincia + "' where codigo = " + oBETarjeta.Codigo + "";
            }
            oConexion = new Conexion();
            return oConexion.Escribir(ConsultaSql);
        }

        public List<BETarjetaNacional> ListarDisponibles()
        {
            List<BETarjetaNacional> ListaTarjetas = new List<BETarjetaNacional>();
            DataSet oDataSetTarjetas;
            oConexion = new Conexion();
            oDataSetTarjetas = oConexion.LeerDataSet("SELECT Codigo,Numero,Vencimiento,Estado,Rubro,TipoNacProv,Provincia,Saldo FROM Tarjetas a full outer join Cliente_Tarjeta b on a.Codigo = b.CodTarjeta where a.Codigo IS NULL or b.CodTarjeta IS NULL and a.Provincia IS NOT NULL;");
            if (oDataSetTarjetas.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in oDataSetTarjetas.Tables[0].Rows)
                {
                    BETarjetaNacional oBETarjetaNac2 = new BETarjetaNacional();
                    oBETarjetaNac2.Codigo = Convert.ToInt32(fila[0]);
                    oBETarjetaNac2.Numero = Convert.ToInt32(fila[1]);
                    oBETarjetaNac2.Vencimiento = Convert.ToDateTime(fila[2]);
                    oBETarjetaNac2.Estado = fila[3].ToString();
                    oBETarjetaNac2.Rubro = fila[4].ToString();
                    oBETarjetaNac2.Pais = fila[5].ToString();
                    oBETarjetaNac2.Provincia = fila[6].ToString();
                    if (fila[7].ToString() != "")
                    {
                        oBETarjetaNac2.Saldo = Convert.ToInt32(fila[7]);
                    }

                    ListaTarjetas.Add(oBETarjetaNac2);
                    
                }
            }
            return ListaTarjetas;
        }

        public BETarjetaNacional ListarObjeto(BETarjetaNacional oBETarjeta)
        {
            oConexion = new Conexion();
            string Consulta = "SELECT Codigo,Numero,Vencimiento,Estado,Rubro,TipoNacProv,Provincia,Saldo FROM Tarjetas where Codigo =" + oBETarjeta.Codigo;
            DataSet oDataSet = oConexion.LeerDataSet(Consulta);

            if (oDataSet.Tables[0].Rows.Count > 0)
            {
                BETarjetaNacional oBETarjInt = new BETarjetaNacional();
                foreach (DataRow fila in oDataSet.Tables[0].Rows)
                {

                    oBETarjInt.Codigo = Convert.ToInt32(fila[0]);
                    oBETarjInt.Numero = Convert.ToInt32(fila[1]);
                    oBETarjInt.Vencimiento = Convert.ToDateTime(fila[2]);
                    oBETarjInt.Estado = fila[3].ToString();
                    oBETarjInt.Rubro = fila[4].ToString();
                    oBETarjInt.Pais = fila[5].ToString();
                    oBETarjInt.Provincia= fila[6].ToString();
                    if (fila[7].ToString() != "")
                    {
                        oBETarjInt.Saldo = Convert.ToInt32(fila[7]);
                    }
                }
                return oBETarjInt;
            }
            else { return null; }
        }

        public List<BETarjetaNacional> ListarTodo()
        {
            List<BETarjetaNacional> ListaTarjetas = new List<BETarjetaNacional>();
            DataSet oDataSetTarjetas;
            oConexion = new Conexion();
            oDataSetTarjetas = oConexion.LeerDataSet("SELECT Codigo,Numero,Vencimiento,Estado,Rubro,TipoNacProv,Provincia,Saldo FROM Tarjetas");
            if (oDataSetTarjetas.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in oDataSetTarjetas.Tables[0].Rows)
                {
                    if (fila[5].ToString() == "Argentina")
                    {
                        BETarjetaNacional oBETarjetaNac2 = new BETarjetaNacional();
                        oBETarjetaNac2.Codigo = Convert.ToInt32(fila[0]);
                        oBETarjetaNac2.Numero = Convert.ToInt32(fila[1]);
                        oBETarjetaNac2.Vencimiento = Convert.ToDateTime(fila[2]);
                        oBETarjetaNac2.Estado = fila[3].ToString();
                        oBETarjetaNac2.Rubro = fila[4].ToString();
                        oBETarjetaNac2.Pais = fila[5].ToString();
                        oBETarjetaNac2.Provincia = fila[6].ToString();
                        if (fila[7].ToString() != "")
                        {
                            oBETarjetaNac2.Saldo = Convert.ToInt32(fila[7]);
                        }
                        ListaTarjetas.Add(oBETarjetaNac2);
                    }
                }
            }
            return ListaTarjetas;
        }

        public bool Baja(BETarjetaNacional oBETarjeta)
        {
            oConexion = new Conexion();

            string consulta1 = "  select count (CoDTarjeta) from Cliente_Tarjeta where CoDTarjeta = '" + oBETarjeta.Codigo + "'";
            bool aux = oConexion.LeerAsociacion(consulta1);

            if (aux == true)
            {
                string Consulta2 = "delete from Cliente_Tarjeta where CodTarjeta = '" + oBETarjeta.Codigo + "'";
                oConexion.Escribir(Consulta2);
                string Consulta3 = " Update Clientes SET CoDTarjeta = 'null'  where Codigo = " + oBETarjeta.Codigo + "";
                oConexion.Escribir(Consulta3);
            }

            string Consultaq4 = "delete from Tarjetas where Codigo = " + oBETarjeta.Codigo + "";
            return oConexion.Escribir(Consultaq4);
        }
    }
}
