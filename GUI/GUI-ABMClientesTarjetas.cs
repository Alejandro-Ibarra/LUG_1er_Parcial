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
    public partial class GUI_ABMClientesTarjetas : Form
    {
        public GUI_ABMClientesTarjetas()
        {
            InitializeComponent();
            oBLCliente = new BLCliente();
            oBLTarjetaInt = new BLTarjetaInternacional();
            oBLTarjetaNac = new BLTarjetaNacional();
            oBECliente = new BECliente();
            oBETarjeta = new BETarjeta();

            this.DataGrid_ABM_Cliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_ABM_Tarjeta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        BLCliente oBLCliente;
        BLTarjeta oBLTarjeta;
        BLTarjetaInternacional oBLTarjetaInt;
        BLTarjetaNacional oBLTarjetaNac;
        BECliente oBECliente;
        BETarjeta oBETarjeta;

        private void GUI_ABMClientesTarjetas_Load(object sender, EventArgs e)
        {

        }

        private void Button_Alta_Cliente_Click(object sender, EventArgs e)
        {
            CargarGrillaCliente();

        }

        private void Button_Mod_Cliente_Click(object sender, EventArgs e)
        {

        }

        private void Button_Baja_Cliente_Click(object sender, EventArgs e)
        {

        }

        private void Button_Alta_Tarjeta_Click(object sender, EventArgs e)
        {

        }

        private void Button_Modificar_Tarjeta_Click(object sender, EventArgs e)
        {

        }

        private void Button_Borrar_Tarjeta_Click(object sender, EventArgs e)
        {

        }



        void CargarGrillaCliente()
        {
            this.DataGrid_ABM_Cliente.DataSource = null;
            this.DataGrid_ABM_Cliente.DataSource = oBLCliente.ListarTodo();
            this.DataGrid_ABM_Cliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
        void CargarGrillaTarjeta()
        {
            this.DataGrid_ABM_Tarjeta.DataSource = null;
            this.DataGrid_ABM_Tarjeta.DataSource = oBLCliente.ListarTodo();
            this.DataGrid_ABM_Tarjeta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        void AsignarCliente()
        {
            try
            {
                oBECliente.Codigo = Convert.ToInt32(TextBox_Cod_Cliente.Text);
                oBECliente.Nombre = TextBox_Nombre.Text;
                oBECliente.Apellido = TextBox_Apellido.Text;
                oBECliente.DNI = Convert.ToInt32(TextBox_DNI.Text);
                oBECliente.FechaNacimiento = this.DateTimePicker_Cliente.Value;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        
        void AsignarTarjeta()
        {
            try
            {
                oBECliente.Codigo = Convert.ToInt32(TextBox_Cod_Cliente.Text);
                oBECliente.Nombre = TextBox_Nombre.Text;
                oBECliente.Apellido = TextBox_Apellido.Text;
                oBECliente.DNI = Convert.ToInt32(TextBox_DNI.Text);
                oBECliente.FechaNacimiento = this.DateTimePicker_Cliente.Value;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
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

        private void DataGrid_ABM_Cliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            oBECliente = (BECliente)this.DataGrid_ABM_Cliente.CurrentRow.DataBoundItem;
            TextBox_Cod_Cliente.Text = oBECliente.Codigo.ToString();
            TextBox_Nombre.Text = oBECliente.Nombre;
            TextBox_Apellido.Text = oBECliente.Apellido;
            TextBox_DNI.Text = oBECliente.DNI.ToString();
            DateTimePicker_Cliente.Value = oBECliente.FechaNacimiento;
        }

        private void DataGrid_ABM_Tarjeta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            oBETarjeta = (BETarjeta)this.DataGrid_ABM_Tarjeta.CurrentRow.DataBoundItem;
            TextBox_Numero.Text = oBETarjeta.Numero.ToString();
            TextBox_Monto.Text = oBETarjeta.Saldo.ToString();
            DateTimePicker_Tarjeta.Value = oBETarjeta.Vencimiento;

        }
    }
}
