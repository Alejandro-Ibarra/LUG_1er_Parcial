using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BusinessEntity;

namespace DataAccess
{
    public class Conexion
    {

        private SqlConnection oConexion = new SqlConnection(ConfigurationManager.ConnectionStrings["MiCadenaDeConexion"].ToString());


        public DataSet LeerDataSet(string Consulta_SQL)
        {
            DataSet oDataSet = new DataSet();
            try
            {
                SqlDataAdapter oDataAdapter = new SqlDataAdapter(Consulta_SQL, oConexion);
                oDataAdapter.Fill(oDataSet);
            }
            catch (SqlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
            finally
            {
                oConexion.Close();
            }
            return oDataSet;
        }

        public bool Escribir(string Consulta_SQL)
        {
            oConexion.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = Consulta_SQL;
            command.Connection = oConexion;
            try
            {
                int respuesta = command.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
            finally
            {
                oConexion.Close();
            }
        }

        public bool LeerAsociacion(string Consulta_SQL)
        {
            oConexion.Open();
            SqlCommand command = new SqlCommand(Consulta_SQL, oConexion);
            command.CommandType = CommandType.Text;
            try
            {
                int Respuesta = Convert.ToInt32(command.ExecuteScalar());
                if (Respuesta > 0)
                { return true; }
                else
                { return false; }
            }
            catch (SqlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
            finally
            {
                oConexion.Close();
            }
        }
    }
}
