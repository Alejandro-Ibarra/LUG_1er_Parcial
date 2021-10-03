using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Abstraccion;
using BusinessEntity;
using DataAccess;

namespace Mapper
{
    public class MCliente : IGestor<BECliente>
    {
        Conexion oConexion;

        public bool Guardar(BECliente oBECliente)
        {
            string ConsultaSql;
            if (oBECliente.Codigo == 0)
            {
                ConsultaSql = "Insert into Usuario (Nombre, Apellido,DNI, FechaNacimiento) " +
                    "values('" + oBECliente.Nombre + "', '" + oBECliente.Apellido + "', " + oBECliente.DNI + ",'" + oBECliente.FechaNacimiento + "' ) ";
            }
            else
            {
                ConsultaSql = "Update Usuario SET Nombre = '" + oBECliente.Nombre + "', Apellido = '" + oBECliente.Apellido + "', DNI = '" + oBECliente.DNI + "', FechaNacimiento = '" + oBECliente.FechaNacimiento + "' where codigo = " + oBECliente.Codigo + "";
            }
            oConexion = new Conexion();
            return oConexion.Escribir(ConsultaSql);
        }

        public bool Baja(BECliente oBECliente)
        {
            oConexion = new Conexion();
            if (oBECliente.Tarjeta != null)
            {
                foreach (BETarjeta Tarj in oBECliente.Tarjeta)
                {
                    string Consulta = " Update Tarjetas SET Estado = 'Baja'  where Codigo = " + Tarj.Codigo + "";
                    oConexion.Escribir(Consulta);
                }
            }
            string Consulta2 = "Delete from Cliente where Codigo = " + oBECliente.Codigo + "";
            return oConexion.Escribir(Consulta2);
        }

        public BECliente ListarObjeto(BECliente oBECliente)
        {
            throw new NotImplementedException();
        }

        public List<BECliente> ListarTodo()
        {
            List<BECliente> ListaClientes = new List<BECliente>();
            try
            {
                DataSet oDataSetCliente;
                oConexion = new Conexion();
                string ConsultaSqlCliente = "Select Codigo,Nombre,Apellido,DNI,FechaNacimiento from Clientes";
                oDataSetCliente = oConexion.LeerDataSet(ConsultaSqlCliente);
                
                
                if (oDataSetCliente.Tables[0].Rows.Count > 0)
                {
                    BECliente oBECliente = new BECliente();
                    BETarjeta oBEtarjeta;
                    foreach (DataRow fila in oDataSetCliente.Tables[0].Rows)
                    {
                        
                        oBECliente.Codigo = Convert.ToInt32(fila[0]);
                        oBECliente.Nombre = fila[1].ToString();
                        oBECliente.Apellido = fila[2].ToString();
                        oBECliente.DNI = Convert.ToInt32(fila[3]);
                        oBECliente.FechaNacimiento = Convert.ToDateTime(fila[4]);
                        ListaClientes.Add(oBECliente);
                    }
                    DataSet oDataSetTarjeta;
                    string ConsultaSqlTarjeta = "Select Tarjetas.Codigo,Numero,Vencimiento,PorcentajeDescuento,Estado,Rubro,TipoNacProv,Provincia from Tarjetas, Clientes where Clientes.CoDTarjeta = Tarjetas.Codigo;";
                    oDataSetTarjeta = oConexion.LeerDataSet(ConsultaSqlTarjeta);
                    if (oDataSetTarjeta.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow fila in oDataSetTarjeta.Tables[0].Rows)
                        {
                            if (fila[7].ToString() == "Internacional")
                            {
                                oBEtarjeta = new BETarjetaInternacional();
                            }
                            else 
                            {
                                BETarjetaNacional oBEtarjetaN = new BETarjetaNacional();
                                oBEtarjetaN.Provincia = fila[7].ToString();
                                oBEtarjeta = new BETarjetaNacional();
                                oBEtarjeta = oBEtarjetaN;

                            }
                            oBEtarjeta.Codigo = Convert.ToInt32(fila[0]);
                            oBEtarjeta.Numero = Convert.ToInt32(fila[1]);
                            oBEtarjeta.Vencimiento = Convert.ToDateTime(fila[2]);
                            oBEtarjeta.Descuento = Convert.ToInt32(fila[3]);
                            oBEtarjeta.Estado = fila[4].ToString();
                            oBEtarjeta.Rubro = fila[5].ToString();
                            oBEtarjeta.Pais = fila[6].ToString();
                            oBECliente.Tarjeta.Add(oBEtarjeta);
                        }
                    }
                    else
                    { oBECliente.Tarjeta = null; }
                }
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return ListaClientes;
        }

        public bool AgregarTarjeta_Cliente(BECliente oBECli, BETarjeta oBETarj)
        {
            string Consulta = "  INSERT INTO Cliente_Tarjeta(CodCliente, CodTarjeta) values (" + oBECli.Codigo + "," + oBETarj.Codigo + ")";
            oConexion = new Conexion();
            return oConexion.Escribir(Consulta);

        }

        public bool QuitarTarjeta_Cliente(BECliente oBECli, BETarjeta oBETarj)
        {
            string Consulta = "  Delete from Cliente_Tarjeta where CodCliente = " + oBECli.Codigo + " and CodTarjeta = " + oBETarj.Codigo + "";
            oConexion = new Conexion();
            return oConexion.Escribir(Consulta);
        }
    }
}
