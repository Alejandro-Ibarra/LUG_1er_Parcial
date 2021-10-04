﻿using System;
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
                    "values('" + oBETarjeta.Numero + "', '" + oBETarjeta.Vencimiento + "', '" + oBETarjeta.Descuento + "','" + oBETarjeta.Estado + "', '" + oBETarjeta.Rubro + "', '" + oBETarjeta.Pais + "' ) ";
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
            BETarjetaInternacional oBEtarjetaInt = new BETarjetaInternacional();
       
            List<BETarjetaInternacional> ListaTarjetas = new List<BETarjetaInternacional>();
            DataSet oDataSetTarjetas;
            oConexion = new Conexion();
            oDataSetTarjetas = oConexion.LeerDataSet("SELECT Codigo,Numero,Vencimiento,PorcentajeDescuento,Estado,Rubro,TipoNacProv,Provincia FROM Tarjetas");
            if (oDataSetTarjetas.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in oDataSetTarjetas.Tables[0].Rows)
                {
                    if (fila[6].ToString() != "Argentina")
                    {
                        BETarjetaInternacional oBETarjetaInt2 = new BETarjetaInternacional();
                        oBETarjetaInt2.Codigo = Convert.ToInt32(fila[0]);
                        oBETarjetaInt2.Numero = Convert.ToInt32(fila[1]);
                        oBETarjetaInt2.Vencimiento = Convert.ToDateTime(fila[2]);
                        oBETarjetaInt2.Descuento = Convert.ToInt32(fila[3]);
                        oBETarjetaInt2.Estado = fila[4].ToString();
                        oBETarjetaInt2.Rubro = fila[5].ToString();
                        oBETarjetaInt2.Pais = fila[6].ToString();
                        ListaTarjetas.Add(oBETarjetaInt2);
                    }
                    
                }
            }
            return ListaTarjetas;
        }

        public bool Baja(BETarjetaInternacional oBETarjeta)
        {
            oConexion = new Conexion();

            string consulta1 = "  select count (CoDTarjeta) from Cliente_Tarjeta where CoDTarjeta = '" + oBETarjeta.Codigo + "'";
            bool aux = oConexion.LeerAsociacion(consulta1);

            if (aux == true)
            {
                string Consulta2 = "delete from Cliente_Tarjeta where CodTarjeta = '" + oBETarjeta.Codigo + "'";
                oConexion.Escribir(Consulta2);
                string Consulta3 = " Update Clientes SET CoDTarjeta = 'null'  where Codigo = '" + oBETarjeta.Codigo + "'";
                oConexion.Escribir(Consulta3);
            }

            string Consulta4 = "delete from Tarjetas where Codigo = '" + oBETarjeta.Codigo + "'";
            return oConexion.Escribir(Consulta4);
        }
    }
}
