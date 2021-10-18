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
                ConsultaSql = "Insert into Clientes (Nombre,Apellido,DNI,FechaNacimiento) " +
                    "values('" + oBECliente.Nombre + "', '" + oBECliente.Apellido + "', " + oBECliente.DNI + ",'" + oBECliente.FechaNacimiento + "' ) ";
            }
            else
            {
                ConsultaSql = "Update Clientes SET Nombre = '" + oBECliente.Nombre + "', Apellido = '" + oBECliente.Apellido + "', DNI = '" + oBECliente.DNI + "', FechaNacimiento = '" + oBECliente.FechaNacimiento + "' where codigo = " + oBECliente.Codigo + "";
            }
            oConexion = new Conexion();
            return oConexion.Escribir(ConsultaSql);
        }

        public bool Baja(BECliente oBECliente)
        {
            oConexion = new Conexion();
            if (oBECliente.Tarjeta != null)
            {
                foreach (BETarjetaNacional Tarj in oBECliente.Tarjeta)
                {
                    string Consulta = " Update Tarjetas SET Estado = 'Baja'  where Codigo = " + Tarj.Codigo + "";
                    oConexion.Escribir(Consulta);
                }
            }
            string Consulta2 = "Delete from Clientes where Codigo = " + oBECliente.Codigo + "";
            return oConexion.Escribir(Consulta2);
        }

        public BECliente ListarObjeto(BECliente oBECliente)
        {
            BECliente oBEClienteAux = new BECliente();
            try
            {
                DataSet oDataSetCliente;
                oConexion = new Conexion();
                string ConsultaSqlCliente = "Select Codigo,Nombre,Apellido,DNI,FechaNacimiento from Clientes where Codigo = " + oBECliente.Codigo + "";
                oDataSetCliente = oConexion.LeerDataSet(ConsultaSqlCliente);
                if (oDataSetCliente.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow fila in oDataSetCliente.Tables[0].Rows)
                    {
                        oBEClienteAux.Codigo = Convert.ToInt32(fila[0]);
                        oBEClienteAux.Nombre = fila[1].ToString();
                        oBEClienteAux.Apellido = fila[2].ToString();
                        oBEClienteAux.DNI = Convert.ToInt32(fila[3]);
                        oBEClienteAux.FechaNacimiento = Convert.ToDateTime(fila[4]);
                        DataSet oDataSetTarjeta;
                        string ConsultaSqlTarjeta = " Select Tarjetas.Codigo,Numero,Vencimiento,Estado,Rubro,TipoNacProv,Saldo,Provincia from Tarjetas, Cliente_Tarjeta" +
                            " where Cliente_Tarjeta.CoDTarjeta = Tarjetas.Codigo and Cliente_Tarjeta.CodCliente = " + oBECliente.Codigo + "";
                        oDataSetTarjeta = oConexion.LeerDataSet(ConsultaSqlTarjeta);
                        
                        if (oDataSetTarjeta.Tables[0].Rows.Count > 0)
                        {
                            List<BETarjeta> ListaTarjetas = new List<BETarjeta>();
                            foreach (DataRow fila2 in oDataSetTarjeta.Tables[0].Rows)
                            {
                                //string prueba = fila2[6].ToString();
                                if (fila2[7].ToString() == "")
                                {
                                    BETarjetaInternacional oBETarjetaInt = new BETarjetaInternacional();
                                    oBETarjetaInt.Codigo = Convert.ToInt32(fila2[0]);
                                    oBETarjetaInt.Numero = Convert.ToInt32(fila2[1]);
                                    oBETarjetaInt.Vencimiento = Convert.ToDateTime(fila2[2]);
                                    oBETarjetaInt.Estado = fila2[3].ToString();
                                    oBETarjetaInt.Rubro = fila2[4].ToString();
                                    oBETarjetaInt.Pais = fila2[5].ToString();
                                    if (fila2[6].ToString() != "")
                                    {
                                        oBETarjetaInt.Saldo = Convert.ToInt32(fila2[6]);
                                    }
                                    
                                    ListaTarjetas.Add(oBETarjetaInt);
                                }
                                else
                                {
                                    BETarjetaNacional oBETarjetaNac = new BETarjetaNacional();
                                    oBETarjetaNac.Codigo = Convert.ToInt32(fila2[0]);
                                    oBETarjetaNac.Numero = Convert.ToInt32(fila2[1]);
                                    oBETarjetaNac.Vencimiento = Convert.ToDateTime(fila2[2]);
                                    oBETarjetaNac.Estado = fila2[3].ToString();
                                    oBETarjetaNac.Rubro = fila2[4].ToString();
                                    oBETarjetaNac.Pais = fila2[5].ToString();
                                    if (fila2[6].ToString() != "")
                                    {
                                        oBETarjetaNac.Saldo = Convert.ToInt32(fila2[6]);
                                    }
                                    oBETarjetaNac.Provincia = fila2[7].ToString();
                                    ListaTarjetas.Add(oBETarjetaNac);
                                }
                                oBEClienteAux.Tarjeta = ListaTarjetas;
                            }
                        }
                        
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return oBEClienteAux;
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
                    foreach (DataRow fila in oDataSetCliente.Tables[0].Rows)
                    {
                        BECliente oBECliente = new BECliente();
                        oBECliente.Codigo = Convert.ToInt32(fila[0]);
                        oBECliente.Nombre = fila[1].ToString();
                        oBECliente.Apellido = fila[2].ToString();
                        oBECliente.DNI = Convert.ToInt32(fila[3]);
                        oBECliente.FechaNacimiento = Convert.ToDateTime(fila[4]);
                        DataSet oDataSetTarjeta;
                        string ConsultaSqlTarjeta = " Select Tarjetas.Codigo,Numero,Vencimiento,Estado,Rubro,TipoNacProv,Provincia,Saldo from Tarjetas, Cliente_Tarjeta" +
                            " where Cliente_Tarjeta.CoDTarjeta = Tarjetas.Codigo and Cliente_Tarjeta.CodCliente = " + oBECliente.Codigo + "";
                        oDataSetTarjeta = oConexion.LeerDataSet(ConsultaSqlTarjeta);
                        if (oDataSetTarjeta.Tables[0].Rows.Count > 0)
                        {
                            List<BETarjeta> ListaTarjetas = new List<BETarjeta>();
                            foreach (DataRow fila2 in oDataSetTarjeta.Tables[0].Rows)
                            {
                                if (fila2[7] == null)
                                {
                                    BETarjetaInternacional oBETarjetaInt = new BETarjetaInternacional();
                                    oBETarjetaInt.Codigo = Convert.ToInt32(fila2[0]);
                                    oBETarjetaInt.Numero = Convert.ToInt32(fila2[1]);
                                    oBETarjetaInt.Vencimiento = Convert.ToDateTime(fila2[2]);
                                    oBETarjetaInt.Estado = fila2[3].ToString();
                                    oBETarjetaInt.Rubro = fila2[4].ToString();
                                    oBETarjetaInt.Pais = fila2[5].ToString();
                                    if (fila2[7].ToString() != "")
                                    {
                                        oBETarjetaInt.Saldo = Convert.ToInt32(fila2[7]);
                                    }
                                    ListaTarjetas.Add(oBETarjetaInt);
                                }
                                else
                                {
                                    BETarjetaNacional oBETarjetaNac = new BETarjetaNacional();
                                    oBETarjetaNac.Codigo = Convert.ToInt32(fila2[0]);
                                    oBETarjetaNac.Numero = Convert.ToInt32(fila2[1]);
                                    oBETarjetaNac.Vencimiento = Convert.ToDateTime(fila2[2]);
                                    oBETarjetaNac.Estado = fila2[4].ToString();
                                    oBETarjetaNac.Rubro = fila2[5].ToString();
                                    oBETarjetaNac.Pais = fila2[6].ToString();
                                    oBETarjetaNac.Provincia = fila2[7].ToString();
                                    if (fila2[7].ToString() != "")
                                    {
                                        oBETarjetaNac.Saldo = Convert.ToInt32(fila2[7]);
                                    }
                                    ListaTarjetas.Add(oBETarjetaNac);
                                } 
                            }
                        }
                        ListaClientes.Add(oBECliente);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return ListaClientes;
        }

        public bool AgregarTarjeta_Int_Cliente(BECliente oBECli, BETarjetaInternacional oBETarj)
        {
            string Consulta = "  INSERT INTO Cliente_Tarjeta(CodCliente, CodTarjeta) values (" + oBECli.Codigo + "," + oBETarj.Codigo + ")";
            oConexion = new Conexion();
            return oConexion.Escribir(Consulta);

        }

        public bool AgregarTarjeta_Nac_Cliente(BECliente oBECli, BETarjetaNacional oBETarj)
        {
            string Consulta = "  INSERT INTO Cliente_Tarjeta(CodCliente, CodTarjeta) values (" + oBECli.Codigo + "," + oBETarj.Codigo + ")";
            oConexion = new Conexion();
            return oConexion.Escribir(Consulta);
        }

        public bool QuitarTarjeta_Int_Cliente(BECliente oBECli, BETarjetaInternacional oBETarj)
        {
            string Consulta = "  Delete from Cliente_Tarjeta where CodCliente = " + oBECli.Codigo + " and CodTarjeta = " + oBETarj.Codigo + "";
            oConexion = new Conexion();
            return oConexion.Escribir(Consulta); 
        }

        public bool QuitarTarjeta_Nac_Cliente(BECliente oBECli, BETarjetaNacional oBETarj)
        {
            string Consulta = "  Delete from Cliente_Tarjeta where CodCliente = " + oBECli.Codigo + " and CodTarjeta = " + oBETarj.Codigo + "";
            oConexion = new Conexion();
            return oConexion.Escribir(Consulta);
        }

        
    }
}
