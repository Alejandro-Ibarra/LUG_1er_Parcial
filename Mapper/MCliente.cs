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
            if (oBECliente.TarjetaNac != null)
            {
                foreach (BETarjetaNacional Tarj in oBECliente.TarjetaNac)
                {
                    string Consulta = " Update Tarjetas SET Estado = 'Baja'  where Codigo = " + Tarj.Codigo + "";
                    oConexion.Escribir(Consulta);
                }
            }
            if (oBECliente.TarjetaInt != null)
            {
                foreach (BETarjetaInternacional Tarj in oBECliente.TarjetaInt)
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
                        oBECliente.Nombre = fila[1].ToString();
                        oBECliente.Apellido = fila[2].ToString();
                        oBECliente.DNI = Convert.ToInt32(fila[3]);
                        oBECliente.FechaNacimiento = Convert.ToDateTime(fila[4]);
                        DataSet oDataSetTarjetaInt;
                        string ConsultaSqlTarjetaInt = " Select Tarjetas.Codigo,Numero,Vencimiento,PorcentajeDescuento,Estado,Rubro,TipoNacProv,Provincia from Tarjetas, Cliente_Tarjeta" +
                            " where Cliente_Tarjeta.CoDTarjeta = Tarjetas.Codigo and Cliente_Tarjeta.CodCliente = " + oBECliente.Codigo + "and Tarjetas.Provincia IS NULL";
                        oDataSetTarjetaInt = oConexion.LeerDataSet(ConsultaSqlTarjetaInt);
                        if (oDataSetTarjetaInt.Tables[0].Rows.Count > 0)
                        {
                            List<BETarjetaInternacional> ListaTarjetasInt = new List<BETarjetaInternacional>();
                            foreach (DataRow fila2 in oDataSetTarjetaInt.Tables[0].Rows)
                            {
                                
                                    BETarjetaInternacional oBEtarjetaInt = new BETarjetaInternacional();
                                    oBEtarjetaInt.Codigo = Convert.ToInt32(fila2[0]);
                                    oBEtarjetaInt.Numero = Convert.ToInt32(fila2[1]);
                                    oBEtarjetaInt.Vencimiento = Convert.ToDateTime(fila2[2]);
                                    oBEtarjetaInt.Descuento = Convert.ToInt32(fila2[3]);
                                    oBEtarjetaInt.Estado = fila2[4].ToString();
                                    oBEtarjetaInt.Rubro = fila2[5].ToString();
                                    oBEtarjetaInt.Pais = fila2[6].ToString();
                                    ListaTarjetasInt.Add(oBEtarjetaInt);
                            }
                            oBECliente.TarjetaInt = ListaTarjetasInt;


                            DataSet oDataSetTarjetaNac;
                            string ConsultaSqlTarjetaNac = " Select Tarjetas.Codigo,Numero,Vencimiento,PorcentajeDescuento,Estado,Rubro,TipoNacProv,Provincia from Tarjetas, Cliente_Tarjeta" +
                                " where Cliente_Tarjeta.CoDTarjeta = Tarjetas.Codigo and Cliente_Tarjeta.CodCliente = " + oBECliente.Codigo + "and Tarjetas.Provincia IS NOT NULL";
                            oDataSetTarjetaNac = oConexion.LeerDataSet(ConsultaSqlTarjetaNac);
                            if (oDataSetTarjetaNac.Tables[0].Rows.Count > 0)
                            {
                                List<BETarjetaNacional> ListaTarjetasNac = new List<BETarjetaNacional>();
                                foreach (DataRow fila2 in oDataSetTarjetaNac.Tables[0].Rows)
                                {
                                    BETarjetaNacional oBETarjetaNac = new BETarjetaNacional();
                                    oBETarjetaNac.Codigo = Convert.ToInt32(fila2[0]);
                                    oBETarjetaNac.Numero = Convert.ToInt32(fila2[1]);
                                    oBETarjetaNac.Vencimiento = Convert.ToDateTime(fila2[2]);
                                    oBETarjetaNac.Descuento = Convert.ToInt32(fila2[3]);
                                    oBETarjetaNac.Estado = fila2[4].ToString();
                                    oBETarjetaNac.Rubro = fila2[5].ToString();
                                    oBETarjetaNac.Pais = fila2[6].ToString();
                                    oBETarjetaNac.Provincia = fila2[7].ToString();
                                    ListaTarjetasNac.Add(oBETarjetaNac);
                                }
                                oBECliente.TarjetaNac = ListaTarjetasNac;
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return oBECliente;
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
                        DataSet oDataSetTarjetaInt;
                        string ConsultaSqlTarjetaInt = " Select Tarjetas.Codigo,Numero,Vencimiento,PorcentajeDescuento,Estado,Rubro,TipoNacProv,Provincia from Tarjetas, Cliente_Tarjeta" +
                            " where Cliente_Tarjeta.CoDTarjeta = Tarjetas.Codigo and Cliente_Tarjeta.CodCliente = " + oBECliente.Codigo + "and Tarjetas.Provincia IS NULL";
                        oDataSetTarjetaInt = oConexion.LeerDataSet(ConsultaSqlTarjetaInt);
                        if (oDataSetTarjetaInt.Tables[0].Rows.Count > 0)
                        {
                            List<BETarjetaInternacional> ListaTarjetasInt = new List<BETarjetaInternacional>();
                            foreach (DataRow fila2 in oDataSetTarjetaInt.Tables[0].Rows)
                            {

                                BETarjetaInternacional oBEtarjetaInt = new BETarjetaInternacional();
                                oBEtarjetaInt.Codigo = Convert.ToInt32(fila2[0]);
                                oBEtarjetaInt.Numero = Convert.ToInt32(fila2[1]);
                                oBEtarjetaInt.Vencimiento = Convert.ToDateTime(fila2[2]);
                                oBEtarjetaInt.Descuento = Convert.ToInt32(fila2[3]);
                                oBEtarjetaInt.Estado = fila2[4].ToString();
                                oBEtarjetaInt.Rubro = fila2[5].ToString();
                                oBEtarjetaInt.Pais = fila2[6].ToString();
                                ListaTarjetasInt.Add(oBEtarjetaInt);
                            }
                            oBECliente.TarjetaInt = ListaTarjetasInt;


                            DataSet oDataSetTarjetaNac;
                            string ConsultaSqlTarjetaNac = " Select Tarjetas.Codigo,Numero,Vencimiento,PorcentajeDescuento,Estado,Rubro,TipoNacProv,Provincia from Tarjetas, Cliente_Tarjeta" +
                                " where Cliente_Tarjeta.CoDTarjeta = Tarjetas.Codigo and Cliente_Tarjeta.CodCliente = " + oBECliente.Codigo + "and Tarjetas.Provincia IS NOT NULL";
                            oDataSetTarjetaNac = oConexion.LeerDataSet(ConsultaSqlTarjetaNac);
                            if (oDataSetTarjetaNac.Tables[0].Rows.Count > 0)
                            {
                                List<BETarjetaNacional> ListaTarjetasNac = new List<BETarjetaNacional>();
                                foreach (DataRow fila2 in oDataSetTarjetaNac.Tables[0].Rows)
                                {
                                    BETarjetaNacional oBETarjetaNac = new BETarjetaNacional();
                                    oBETarjetaNac.Codigo = Convert.ToInt32(fila2[0]);
                                    oBETarjetaNac.Numero = Convert.ToInt32(fila2[1]);
                                    oBETarjetaNac.Vencimiento = Convert.ToDateTime(fila2[2]);
                                    oBETarjetaNac.Descuento = Convert.ToInt32(fila2[3]);
                                    oBETarjetaNac.Estado = fila2[4].ToString();
                                    oBETarjetaNac.Rubro = fila2[5].ToString();
                                    oBETarjetaNac.Pais = fila2[6].ToString();
                                    oBETarjetaNac.Provincia = fila2[7].ToString();
                                    ListaTarjetasNac.Add(oBETarjetaNac);
                                }
                                oBECliente.TarjetaNac = ListaTarjetasNac;
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
