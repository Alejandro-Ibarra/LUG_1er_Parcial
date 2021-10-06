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
    public class MDescuentosCalculados : IGestor<BEDescuentoCalculado>
    {
        Conexion oConexion;

        public bool Guardar(BEDescuentoCalculado oBEDesc)
        {
            string ConsultaSql;
            if (oBEDesc.Codigo == 0)
            {
                ConsultaSql = "Insert into DescuentoOtorgado (NumeroTarjeta,Tipo,MontoDescuento) " +
                    "values('" + oBEDesc.NumeroTarjeta + "', '" + oBEDesc.Tipo + "','" + oBEDesc.DescuentoOtorgado + "' ) ";
            }
            else
            {
                ConsultaSql = "Update DescuentoOtorgado SET NumeroTarjeta = '" + oBEDesc.NumeroTarjeta + "', Tipo = '" + oBEDesc.Tipo + "', MontoDescuento = '" + oBEDesc.DescuentoOtorgado + "' where codigo = " + oBEDesc.Codigo + "";
            }
            oConexion = new Conexion();
            return oConexion.Escribir(ConsultaSql);
        }
        
        public bool Baja(BEDescuentoCalculado oBEDesc)
        { 
            oConexion = new Conexion();
            string Consulta2 = "Delete from DescuentoOtorgado where Codigo = " + oBEDesc.Codigo + "";
            return oConexion.Escribir(Consulta2);
        }

        public BEDescuentoCalculado ListarObjeto(BEDescuentoCalculado oBEDesc)
        {
            throw new NotImplementedException();
        }

        public List<BEDescuentoCalculado> ListarTodo()
        {
            oConexion = new Conexion();
            DataSet oDataSet = oConexion.LeerDataSet("Select Codigo,NumeroTarjeta,Tipo,MontoDescuento from DescuentoOtorgado;");
            List<BEDescuentoCalculado> ListaDeDescuentos = new List<BEDescuentoCalculado>();
            try
            {
                if (oDataSet.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow fila in oDataSet.Tables[0].Rows)
                    {
                        BEDescuentoCalculado oBEDesc = new BEDescuentoCalculado();
                        oBEDesc.Codigo = Convert.ToInt32(fila[0]);
                        oBEDesc.NumeroTarjeta = Convert.ToInt32(fila[1]);
                        oBEDesc.Tipo = fila[2].ToString();
                        oBEDesc.DescuentoOtorgado = Convert.ToInt32(fila[3]);
                        ListaDeDescuentos.Add(oBEDesc);
                    }
                }
                else
                { ListaDeDescuentos = null; }
            }
            catch (Exception ex)
            { throw ex; }

            return ListaDeDescuentos;
        }
    }
}
