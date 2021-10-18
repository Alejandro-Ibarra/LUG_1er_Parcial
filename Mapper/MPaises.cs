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
    public class MPaises : IGestor<BEPaises>
    {
        Conexion oConexion;

        public bool Baja(BEPaises Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEPaises Objeto)
        {
            throw new NotImplementedException();
        }

        public BEPaises ListarObjeto(BEPaises Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BEPaises> ListarTodo()
        {
            oConexion = new Conexion();
            DataSet oDataSet = oConexion.LeerDataSet("Select * from Paises;");
            List<BEPaises> ListaDePaises = new List<BEPaises>();
            try
            {
                if (oDataSet.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow fila in oDataSet.Tables[0].Rows)
                    {
                        BEPaises oBEPaises = new BEPaises();
                        oBEPaises.Codigo = Convert.ToInt32(fila[0]);
                        oBEPaises.Nombre = fila[1].ToString();
                        ListaDePaises.Add(oBEPaises);
                    }
                }
                else
                { ListaDePaises = null; }
            }
            catch (Exception ex)
            { throw ex; }

            return ListaDePaises;
        }
    }
}
