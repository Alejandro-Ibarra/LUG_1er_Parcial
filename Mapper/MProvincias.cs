using BusinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;
using DataAccess;
using System.Data;

namespace Mapper
{
    public class MProvincias
    {
        Conexion oConexion;

        public List<BEProvincias> ListarTodo()
        {
            oConexion = new Conexion();
            DataSet oDataSet = oConexion.LeerDataSet("Select * from Provincias;");
            List<BEProvincias> ListaDeProvincias = new List<BEProvincias>();
            try
            {
                if (oDataSet.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow fila in oDataSet.Tables[0].Rows)
                    {
                        BEProvincias oBEProvincias = new BEProvincias();
                        oBEProvincias.Codigo = Convert.ToInt32(fila[0]);
                        oBEProvincias.Nombre = fila[1].ToString();
                        ListaDeProvincias.Add(oBEProvincias);
                    }
                }
                else
                { ListaDeProvincias = null; }
            }
            catch (Exception ex)
            { throw ex; }

            return ListaDeProvincias;
        }
    }
}
