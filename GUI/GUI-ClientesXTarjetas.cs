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
            this.DataGridView_Tarjeta_De_Cliente_Nac.DataSource = ListarTarjCliNac(oBECliente);
            this.DataGridView_Tarjeta_De_Cliente_Nac.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        void CargarGrillaTarjCliInt(BECliente oBEcliente)
        {
            this.DataGridView_Tarjeta_De_Cliente_Int.DataSource = null;
            this.DataGridView_Tarjeta_De_Cliente_Int.Rows.Clear();
            this.DataGridView_Tarjeta_De_Cliente_Int.DataSource = ListarTarjCliInt(oBECliente);
            this.DataGridView_Tarjeta_De_Cliente_Int.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private List<BETarjetaNacional> ListarTarjCliNac(BECliente oAuXBeCliente)
        {
            BECliente oBECliente2 = oBLCliente.ListarObjeto(oAuXBeCliente);
            List<BETarjetaNacional> ListTarjNac = new List<BETarjetaNacional>();

            if (oBECliente2.TarjetaNac != null)
            {
                foreach (BETarjetaNacional TN in oBECliente2.TarjetaNac)
                {
                    ListTarjNac.Add(TN);
                }
            }
            return ListTarjNac;
        }
        private List<BETarjetaInternacional> ListarTarjCliInt(BECliente oAuXBeCliente)
        {
            BECliente oBECliente2 = oBLCliente.ListarObjeto(oAuXBeCliente);
            List<BETarjetaInternacional> ListTarjInt = new List<BETarjetaInternacional>();
            
            if (oBECliente2.TarjetaInt != null)
            {
                foreach (BETarjetaInternacional TN in oBECliente2.TarjetaInt)
                {
                    ListTarjInt.Add(TN);
                }
            }
            return ListTarjInt;
        }

        private void CargarTarjetasDeCliente(BECliente oBEcliente)
        {
            BECliente oBEClienteAux = oBLCliente.ListarObjeto(oBECliente);
            CargarGrillaTarjCliNac(oBEClienteAux);
            CargarGrillaTarjCliInt(oBEClienteAux);
        }

        private bool VerificarTarjetaDeAlta(BECliente ClieAux)
        {
            bool aux = true;
            ClieAux = oBLCliente.ListarObjeto(oBECliente);
            if (ClieAux.TarjetaInt != null)
            {
                foreach (BETarjetaInternacional TarjInt in ClieAux.TarjetaInt)
                {
                    if (TarjInt.Estado == "Alta")
                    {
                        aux = false;
                    }
                }
            }
            if (ClieAux.TarjetaNac != null)
            {
                foreach (BETarjetaNacional TarjNac in ClieAux.TarjetaNac)
                {
                    if (TarjNac.Estado == "Alta")
                    {
                        aux = false;
                    }
                }
            }
            return aux;
        }

        private void Button_Asignar_Click(object sender, EventArgs e)
        {
            oBECliente = (BECliente)DataGridView_Clientes.CurrentRow.DataBoundItem;
            if (TextBox_Monto.Text != "")
            {
               
                if (VerificarTarjetaDeAlta(oBECliente) == true)
                {
                    if (DataGridView_Tarjetas_Int_Disponibles.SelectedRows.Count > 0)
                    {
                        oBETarjInt = (BETarjetaInternacional)DataGridView_Tarjetas_Int_Disponibles.CurrentRow.DataBoundItem;
                        oBETarjInt.Saldo = Convert.ToInt32(TextBox_Monto.Text);
                        oBETarjInt.Estado = "Alta";
                        oBLCliente.AgregarTarjeta_Int_Cliente(oBECliente, oBETarjInt);
                        CargarGrillaTarjDispInt();
                    }
                    else if(DataGridView_Tarjetas_Nac_Disponibles.SelectedRows.Count > 0)
                    {
                        oBETarjNac = (BETarjetaNacional)DataGridView_Tarjetas_Nac_Disponibles.CurrentRow.DataBoundItem;
                        oBETarjNac.Saldo = Convert.ToInt32(TextBox_Monto.Text);
                        oBETarjInt.Estado = "Alta";
                        oBLCliente.AgregarTarjeta_Nac_Cliente(oBECliente, oBETarjNac);
                        CargarGrillaTarjDispNac();
                    }
                }
                else
                {
                    MessageBox.Show("El cliente ya tiene una tarjeta dada de alta");
                }
                CargarTarjetasDeCliente(oBECliente);
            }
            else
            {
                MessageBox.Show("Ingrese el monto a cargar a la tarjeta");
            }
            
        }


        private void Button_Borrar_Asignacion_Click(object sender, EventArgs e)
        {
            oBECliente = (BECliente)DataGridView_Clientes.CurrentRow.DataBoundItem;

            if (DataGridView_Tarjeta_De_Cliente_Int.SelectedRows.Count > 0)
            {
                oBETarjInt = (BETarjetaInternacional)DataGridView_Tarjeta_De_Cliente_Int.CurrentRow.DataBoundItem;
                oBLCliente.QuitarTarjeta_Int_Cliente(oBECliente, oBETarjInt);
            }
            else if (DataGridView_Tarjeta_De_Cliente_Nac.SelectedRows.Count > 0)
            {
                oBETarjNac = (BETarjetaNacional)DataGridView_Tarjeta_De_Cliente_Nac.CurrentRow.DataBoundItem;
                oBLCliente.QuitarTarjeta_Nac_Cliente(oBECliente, oBETarjNac);
            }
            else
            {
                MessageBox.Show("Seleccione una tarjeta a borrar");
            }
            CargarTarjetasDeCliente(oBECliente);
            CargarGrillaTarjCliInt(oBECliente);
            CargarGrillaTarjCliNac(oBECliente);
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
            CargarTarjetasDeCliente(oBECliente);
        }
    }
}
