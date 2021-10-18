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
            oBLTarjetaInt = new BLTarjetaInternacional();
            oBLTarjetaNac = new BLTarjetaNacional();
            oBLDesc = new BLDescuentosCalculados();
            oBEDesc = new BEDescuentoCalculado();
            CargarGrillaClientes();
        }

        BLCliente oBLCliente;
        BLTarjetaInternacional oBLTarjetaInt;
        BLTarjetaNacional oBLTarjetaNac;
        BECliente oBECliente;
        BETarjetaInternacional oBETarjInt;
        BETarjetaNacional oBETarjNac;
        BLDescuentosCalculados oBLDesc;
        BEDescuentoCalculado oBEDesc;

        void CargarGrillaClientes()
        {
            this.DataGridView_Clientes.DataSource = null;
            this.DataGridView_Clientes.Rows.Clear();
            this.DataGridView_Clientes.DataSource = oBLCliente.ListarTodo();
            this.DataGridView_Clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void Button_Realizar_Compra_Click(object sender, EventArgs e)
        {
            oBETarjInt = null;
            oBETarjNac = null;
            BECliente oBEClienteAux = (BECliente)DataGridView_Clientes.CurrentRow.DataBoundItem;
            oBECliente = oBLCliente.ListarObjeto(oBECliente);
            BETarjeta oBEtarjeta = TarjetaDeAlta(oBECliente);
            List<BETarjetaInternacional> ListaTarjetasInt = oBLTarjetaInt.ListarTodo();
            List<BETarjetaNacional> ListaTarjetasNac = oBLTarjetaNac.ListarTodo();

            int MontoCompra = Convert.ToInt32(TextBox_Monto_compra.Text);
            int MontoTarjeta = Convert.ToInt32(TextBox_Saldo_Tarjeta.Text);

            if (oBEtarjeta != null)
            {
                foreach (BETarjetaInternacional oBETarjIntAux in ListaTarjetasInt)
                {
                    if (oBEtarjeta.Codigo == oBETarjIntAux.Codigo)
                    {
                        oBETarjInt = oBETarjIntAux;
                    }
                }
                foreach (BETarjetaNacional oBETarjNacAux in ListaTarjetasNac)
                {
                    if (oBEtarjeta.Codigo == oBETarjNacAux.Codigo)
                    {
                        oBETarjNac = oBETarjNacAux;
                    }
                }
                if (MontoCompra <= MontoTarjeta)
                {
                    if (oBETarjInt != null)
                    {
                        oBEDesc.DescuentoOtorgado = oBLTarjetaInt.ObtenerDescuento(MontoCompra);
                        oBEDesc.NumeroTarjeta = oBETarjInt.Numero;
                        oBEDesc.Tipo = "Internacional";
                        oBLDesc.Guardar(oBEDesc);

                        oBETarjInt.Saldo = oBETarjInt.Saldo - MontoCompra;
                        if (oBETarjInt.Saldo == 0)
                        {
                            oBETarjInt.Estado = "Sin Saldo";
                        }
                        oBLTarjetaInt.Guardar(oBETarjInt);
                    }
                    else if (oBETarjNac != null)
                    {
                        oBEDesc.DescuentoOtorgado = oBLTarjetaNac.ObtenerDescuento(MontoCompra);
                        oBEDesc.NumeroTarjeta = oBETarjNac.Numero;
                        oBEDesc.Tipo = "Nacional";
                        oBLDesc.Guardar(oBEDesc);
                        oBETarjNac.Saldo = oBETarjNac.Saldo - MontoCompra;
                        if (oBETarjNac.Saldo == 0)
                        {
                            oBETarjNac.Estado = "Sin Saldo";
                        }
                        oBLTarjetaNac.Guardar(oBETarjNac);
                    }
                }
                else
                {
                    MessageBox.Show("No hay saldo suficiente");
                }
            }
            else
            {
                MessageBox.Show("El cliente no tiene tarjeta dada de alta");
            }
            Limpiar();
        }

        private void AsignarTarjetaATextBox(BECliente ClieAux)
        {
            BECliente ClieAux2 = oBLCliente.ListarObjeto(ClieAux);
            BETarjeta oBETarjAux = TarjetaDeAlta(ClieAux2);
            if (oBETarjAux != null)
            {
                TextBox_Numero_Tarjeta.Text = oBETarjAux.Numero.ToString();
                TextBox_Saldo_Tarjeta.Text = oBETarjAux.Saldo.ToString();
            }
            else
            {
                TextBox_Numero_Tarjeta.Text = "NO";
                TextBox_Saldo_Tarjeta.Text = "NO";
            }
            
          
        }

        private BETarjeta TarjetaDeAlta(BECliente ClieAux)
        {
            BETarjeta oBETarjAux = null;
            if (ClieAux.Tarjeta != null)
            {
                foreach (BETarjeta Tarj in ClieAux.Tarjeta)
                {
                    if (Tarj.Estado == "Alta")
                    {
                        oBETarjAux = Tarj;
                    }
                }
            }
            return oBETarjAux;
        }

        private void DataGridView_Clientes_MouseClick(object sender, MouseEventArgs e)
        {
            oBECliente = (BECliente)DataGridView_Clientes.CurrentRow.DataBoundItem;
            AsignarTarjetaATextBox(oBECliente);
        }

        void Limpiar()
        {
            List<TextBox> ListTxtBox = new List<TextBox>();
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Text = String.Empty;
                }
            }
        }
    }
}
