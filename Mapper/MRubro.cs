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
    public class MRubro
    {
        Conexion oConexion;

        public List<BERubro> ListarTodo()
        {
            oConexion = new Conexion();
            DataSet oDataSet = oConexion.LeerDataSet("Select * from Rubro;");
            List<BERubro> ListaDeRubros = new List<BERubro>();
            try
            {
                if (oDataSet.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow fila in oDataSet.Tables[0].Rows)
                    {
                        BERubro oBERubro = new BERubro();
                        oBERubro.Codigo = Convert.ToInt32(fila[0]);
                        oBERubro.Nombre = fila[1].ToString();
                        ListaDeRubros.Add(oBERubro);
                    }
                }
                else
                { ListaDeRubros = null; }
            }
            catch (Exception ex)
            { throw ex; }

            return ListaDeRubros;
        }
    }
}
