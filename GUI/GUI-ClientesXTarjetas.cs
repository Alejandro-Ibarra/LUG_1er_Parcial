using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntity;
using BussinesLogic;

namespace GUI
{
    public partial class GUI_ClientesXTarjetas : Form
    {
        public GUI_ClientesXTarjetas()
        {
            InitializeComponent();
            oBLCliente = new BLCliente();
            oBECliente = new BECliente();
            oBETarjInt = new BETarjetaInternacional();
            oBETarjNac = new BETarjetaNacional();
            oBlTarjetaInt = new BLTarjetaInternacional();
            oBLTarjetaNac = new BLTarjetaNacional();

            CargarGrillaCliente();
            CargarGrillaTarjDispNac();
            CargarGrillaTarjDispInt();


        }
        BLCliente oBLCliente;
        BLTarjetaInternacional oBlTarjetaInt;
        BLTarjetaNacional oBLTarjetaNac;
        BECliente oBECliente;
        BETarjetaInternacional oBETarjInt;
        BETarjetaNacional oBETarjNac;

        private void GUI_ClientesXTarjetas_Load(object sender, EventArgs e)
        {
            
        }

        void CargarGrillaCliente()
        {
            this.DataGridView_Clientes.DataSource = null;
            this.DataGridView_Clientes.Rows.Clear();
            this.DataGridView_Clientes.DataSource = oBLCliente.ListarTodo();
            this.DataGridView_Clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        void CargarGrillaTarjDispNac()
        {
            this.DataGridView_Tarjetas_Nac_Disponibles.DataSource = null;
            this.DataGridView_Tarjetas_Nac_Disponibles.Rows.Clear();
            this.DataGridView_Tarjetas_Nac_Disponibles.DataSource = oBLTarjetaNac.ListarDisponibles();
            this.DataGridView_Tarjetas_Nac_Disponibles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        void CargarGrillaTarjDispInt()
        {
            this.DataGridView_Tarjetas_Int_Disponibles.DataSource = null;
            this.DataGridView_Tarjetas_Int_Disponibles.Rows.Clear();
            this.DataGridView_Tarjetas_Int_Disponibles.DataSource = oBlTarjetaInt.ListarDisponibles();
            this.DataGridView_Tarjetas_Int_Disponibles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        void CargarGrillaTarjCliNac(BECliente oBEcliente)
        {
            this.DataGridView_Tarjeta_De_Cliente_Nac.DataSource = null;
            this.DataGridView_Tarjeta_De_Cliente_Nac.Rows.Clear();
            this.DataGridView_Tarjeta_De_Cliente_Nac.DataSource = ListaCliTarjNac(oBECliente);
            this.DataGridView_Tarjeta_De_Cliente_Nac.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        void CargarGrillaTarjCliInt(BECliente oBEcliente)
        {
            this.DataGridView_Tarjeta_De_Cliente_Int.DataSource = null;
            this.DataGridView_Tarjeta_De_Cliente_Int.Rows.Clear();
            this.DataGridView_Tarjeta_De_Cliente_Int.DataSource = ListaCliTarjInt(oBECliente);
            this.DataGridView_Tarjeta_De_Cliente_Int.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        public List<BETarjetaNacional> ListaCliTarjNac(BECliente oBECliente)
        {
            List<BETarjetaNacional> ListaTarjNac = new List<BETarjetaNacional>();
            BECliente oBEClienteAux = oBLCliente.ListarObjeto(oBECliente);
            if (oBEClienteAux.Tarjeta != null)
            {
                foreach (BETarjeta tarj in oBEClienteAux.Tarjeta)
                {
                    if (tarj is BETarjetaNacional)
                    {
                        ListaTarjNac.Add((BETarjetaNacional)tarj);
                    }
                }
            }
            return ListaTarjNac;
        }

        public List<BETarjetaInternacional> ListaCliTarjInt(BECliente oBECliente)
        {
            List<BETarjetaInternacional> ListaTarjInt = new List<BETarjetaInternacional>();
            BECliente oBEClienteAux = oBLCliente.ListarObjeto(oBECliente);
            if (oBEClienteAux.Tarjeta != null)
            {
                foreach (BETarjeta tarj in oBEClienteAux.Tarjeta)
                {
                    if (tarj is BETarjetaInternacional)
                    {
                        ListaTarjInt.Add((BETarjetaInternacional)tarj);
                    }
                }
            }
            return ListaTarjInt;
        }

        private bool VerificarEstadoTarjeta(BECliente ClieAux)
        {
            bool aux = true;
            if (ClieAux.Tarjeta != null)
            {
                foreach (BETarjeta Tarj in ClieAux.Tarjeta)
                {
                    if (Tarj.Estado == "Alta")
                    {
                        aux = false;
                    }
                }
            }
           /* if (ClieAux2.TarjetaNac != null)
            {
                foreach (BETarjetaNacional TarjNac in ClieAux2.TarjetaNac)
                {
                    if (TarjNac.Estado != "Alta")
                    {
                        aux = false;
                    }
                }
            }*/
            return aux;
        }

        private void Button_Asignar_Click(object sender, EventArgs e)
        {
            oBECliente = (BECliente)DataGridView_Clientes.CurrentRow.DataBoundItem;
            BECliente oBEClienteAux = oBLCliente.ListarObjeto(oBECliente);
            BECliente oBEClienteAux2 = new BECliente();
            if (TextBox_Monto.Text != "")
            {
               
                if (VerificarEstadoTarjeta(oBEClienteAux) == true)
                {
                    if (DataGridView_Tarjetas_Int_Disponibles.SelectedRows.Count > 0)
                    {
                        oBETarjInt = (BETarjetaInternacional)DataGridView_Tarjetas_Int_Disponibles.CurrentRow.DataBoundItem;
                        if (oBETarjInt.Estado != "Baja")
                        {
                            oBETarjInt.Saldo = Convert.ToInt32(TextBox_Monto.Text);
                            oBETarjInt.Estado = "Alta";
                            oBlTarjetaInt.Guardar(oBETarjInt);
                            oBLCliente.AgregarTarjeta_Int_Cliente(oBEClienteAux, oBETarjInt);
                            CargarGrillaTarjDispInt();
                            oBEClienteAux2 = oBLCliente.ListarObjeto(oBEClienteAux);
                            CargarGrillaTarjCliInt(oBEClienteAux2);
                        }
                        else
                        {
                            MessageBox.Show("La tarjeta fue dada de baja, seleccione otra tarjeta");
                        }
                        
                    }
                    else if(DataGridView_Tarjetas_Nac_Disponibles.SelectedRows.Count > 0)
                    {
                        if (oBETarjNac.Estado != "Baja")
                        {
                            oBETarjNac = (BETarjetaNacional)DataGridView_Tarjetas_Nac_Disponibles.CurrentRow.DataBoundItem;
                            oBETarjNac.Saldo = Convert.ToInt32(TextBox_Monto.Text);
                            oBETarjNac.Estado = "Alta";
                            oBLTarjetaNac.Guardar(oBETarjNac);
                            oBLCliente.AgregarTarjeta_Nac_Cliente(oBEClienteAux, oBETarjNac);
                            CargarGrillaTarjDispNac();
                            oBEClienteAux2 = oBLCliente.ListarObjeto(oBEClienteAux);
                            CargarGrillaTarjCliNac(oBEClienteAux2);
                        }
                        else
                        {
                            MessageBox.Show("La tarjeta fue dada de baja, seleccione otra tarjeta");
                        }


                    }
                }
                else
                {
                    MessageBox.Show("El cliente ya tiene una tarjeta dada de alta o la tarjeta no se puede asignar");
                }

            }
            else
            {
                MessageBox.Show("Ingrese el monto a cargar a la tarjeta");
            }
            

        }

        private void Button_Borrar_Asignacion_Click(object sender, EventArgs e)
        {
            oBECliente = (BECliente)DataGridView_Clientes.CurrentRow.DataBoundItem;
            BECliente oBEClienteAux = oBLCliente.ListarObjeto(oBECliente);
            BECliente oBEClienteAux2 = new BECliente();
            if (DataGridView_Tarjeta_De_Cliente_Int.SelectedRows.Count > 0)
            {
                oBETarjInt = (BETarjetaInternacional)DataGridView_Tarjeta_De_Cliente_Int.CurrentRow.DataBoundItem;
                oBLCliente.QuitarTarjeta_Int_Cliente(oBEClienteAux, oBETarjInt);
                oBETarjInt.Estado = "Baja";
                oBETarjInt.Saldo = 0;
                oBlTarjetaInt.Guardar(oBETarjInt);
                oBEClienteAux2 = oBLCliente.ListarObjeto(oBEClienteAux);
            }
            else if (DataGridView_Tarjeta_De_Cliente_Nac.SelectedRows.Count > 0)
            {
                oBETarjNac = (BETarjetaNacional)DataGridView_Tarjeta_De_Cliente_Nac.CurrentRow.DataBoundItem;
                oBLCliente.QuitarTarjeta_Nac_Cliente(oBEClienteAux, oBETarjNac);
                oBETarjNac.Estado = "Baja";
                oBETarjNac.Saldo = 0;
                oBLTarjetaNac.Guardar(oBETarjNac);
                oBEClienteAux2 = oBLCliente.ListarObjeto(oBEClienteAux);
            }
            else
            {
                MessageBox.Show("Seleccione una tarjeta a borrar");
            }
            CargarGrillaCliente();
            CargarGrillaTarjCliNac(oBEClienteAux2);
            CargarGrillaTarjCliInt(oBEClienteAux2);
            CargarGrillaTarjDispNac();
            CargarGrillaTarjDispInt();
        }

        private void DataGridView_Tarjetas_Int_Disponibles_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridView_Tarjetas_Nac_Disponibles.ClearSelection();
        }

        private void DataGridView_Tarjetas_Nac_Disponibles_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridView_Tarjetas_Int_Disponibles.ClearSelection();
        }

        private void DataGridView_Tarjeta_De_Cliente_Int_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridView_Tarjeta_De_Cliente_Nac.ClearSelection();
        }

        private void DataGridView_Tarjeta_De_Cliente_Nac_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridView_Tarjeta_De_Cliente_Int.ClearSelection();
        }

        private void DataGridView_Clientes_MouseClick(object sender, MouseEventArgs e)
        {
            oBECliente = (BECliente)DataGridView_Clientes.CurrentRow.DataBoundItem;
            BECliente oBEClienteAux = oBLCliente.ListarObjeto(oBECliente);
            CargarGrillaTarjCliNac(oBEClienteAux);
            CargarGrillaTarjCliInt(oBEClienteAux);
        }
    }
}
