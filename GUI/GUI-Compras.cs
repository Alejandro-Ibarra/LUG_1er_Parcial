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
    public partial class GUI_Compras : Form
    {
        public GUI_Compras()
        {
            InitializeComponent();
            oBLCliente = new BLCliente();
            oBECliente = new BECliente();
            oBETarjInt = new BETarjetaInternacional();
            oBETarjNac = new BETarjetaNacional();
            oBlTarjetaInt = new BLTarjetaInternacional();
            oBLTarjetaNac = new BLTarjetaNacional();
            CargarGrillaClientes();
        }

        BLCliente oBLCliente;
        BLTarjetaInternacional oBlTarjetaInt;
        BLTarjetaNacional oBLTarjetaNac;
        BECliente oBECliente;
        BETarjetaInternacional oBETarjInt;
        BETarjetaNacional oBETarjNac;

        void CargarGrillaClientes()
        {
            this.DataGridView_Clientes.DataSource = null;
            this.DataGridView_Clientes.Rows.Clear();
            this.DataGridView_Clientes.DataSource = oBLCliente.ListarTodo();
            this.DataGridView_Clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void Button_Realizar_Compra_Click(object sender, EventArgs e)
        {
            
        }

        private List<BETarjeta> DevolverTarCliente(BECliente oAuXBeCliente)
        {
            List<BETarjeta> ListTarjInt = new List<BETarjeta>();

            if (oAuXBeCliente.Tarjeta != null)
            {
                foreach (BETarjetaInternacional TN in oAuXBeCliente.Tarjeta)
                {
                    ListTarjInt.Add(TN);
                }
            }
            return ListTarjInt;
        }
        /*
        private List<BETarjetaNacional> DevolverTarjNacCliente(BECliente oAuXBeCliente)
        {
            List<BETarjetaNacional> ListTarjNac = new List<BETarjetaNacional>();

            if (oAuXBeCliente.TarjetaNac != null)
            {
                foreach (BETarjetaNacional TN in oAuXBeCliente.TarjetaNac)
                {
                    ListTarjNac.Add(TN);
                }
            }
            return ListTarjNac;
        }
        */
        private void AsignarTarjetaATextBox(BECliente ClieAux)
        {
            BECliente ClieAux2 = oBLCliente.ListarObjeto(ClieAux);
            if (ClieAux2.Tarjeta != null)
            {
                foreach (BETarjeta Tarj in ClieAux2.Tarjeta)
                {
                    if (Tarj.Estado == "Alta")
                    {
                        TextBox_Numero_Tarjeta.Text = Tarj.Numero.ToString();
                        TextBox_Saldo_Tarjeta.Text = Tarj.Saldo.ToString();
                    }
                }
            }
            /*
            if (ClieAux2.TarjetaNac != null)
            {
                foreach (BETarjetaNacional TarjNac in ClieAux2.TarjetaNac)
                {
                    if (TarjNac.Estado != "Alta")
                    {

                    }
                }
            }*/
        }

        private void DataGridView_Clientes_MouseClick(object sender, MouseEventArgs e)
        {
            oBECliente = (BECliente)DataGridView_Clientes.CurrentRow.DataBoundItem;
            AsignarTarjetaATextBox(oBECliente);
        }
    }
}
