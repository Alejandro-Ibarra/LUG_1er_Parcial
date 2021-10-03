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
            oBETarjetaInt = new BETarjetaInternacional();
            oBETarjetaNac = new BETarjetaNacional();
            oBLPaises = new BLPaises();
            oBLProvincias = new BLProvincias();

            this.DataGrid_ABM_Cliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_ABM_Tarjeta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        BLCliente oBLCliente;
        BLTarjeta oBLTarjeta;
        BLTarjetaInternacional oBLTarjetaInt;
        BLTarjetaNacional oBLTarjetaNac;
        BECliente oBECliente;
        BETarjeta oBETarjeta;
        BETarjetaInternacional oBETarjetaInt;
        BETarjetaNacional oBETarjetaNac;
        BLPaises oBLPaises;
        BLProvincias oBLProvincias;

        private void GUI_ABMClientesTarjetas_Load(object sender, EventArgs e)
        {
            CargarComboBoxEstadoTarj();
            CargarComboBoxPaises();
            CargarComboBoxProvincias();
            CargarComboBoxRubro();
        }

        private void Button_Alta_Cliente_Click(object sender, EventArgs e)
        {
            CargarGrillaCliente();
            CargarGrillaTarjeta();
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

        void CargarComboBoxPaises()
        {
            try
            {
                ComboBox_Pais.DataSource = null;
                ComboBox_Pais.DataSource = oBLPaises.ListarTodo();
                ComboBox_Pais.ValueMember = "Codigo";
                ComboBox_Pais.DisplayMember = "Nombre";
                ComboBox_Pais.Refresh();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void CargarComboBoxProvincias()
        {
            try
            {
                ComboBox_Provincia.DataSource = null;
                ComboBox_Provincia.DataSource = oBLProvincias.ListarTodo();
                ComboBox_Provincia.ValueMember = "Codigo";
                ComboBox_Provincia.DisplayMember = "Nombre";
                ComboBox_Provincia.Refresh();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void CargarComboBoxRubro()
        {
            try
            {
                List<string> Rubros = new List<string>();
                Rubros.Add("Libre");
                Rubros.Add("Indumentaria");
                Rubros.Add("Comestible");
                ComboBox_Rubro.DataSource = null;
                ComboBox_Rubro.DataSource = Rubros;
                ComboBox_Rubro.DisplayMember = "Nombre";
                ComboBox_Rubro.Refresh();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void CargarComboBoxEstadoTarj()
        {
            try
            {
                List<string> Estados = new List<string>();
                Estados.Add("Alta");
                Estados.Add("Baja");
                Estados.Add("Sin Saldo");
                Estados.Add("Vencida");

                ComboBox_Estado.DataSource = null;
                ComboBox_Estado.DataSource = Estados;
                ComboBox_Estado.DisplayMember = "Nombre";
                ComboBox_Estado.Refresh();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void CargarGrillaCliente()
        {
            this.DataGrid_ABM_Cliente.DataSource = null;
            this.DataGrid_ABM_Cliente.Rows.Clear();
            this.DataGrid_ABM_Cliente.DataSource = oBLCliente.ListarTodo();
            this.DataGrid_ABM_Cliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
        void CargarGrillaTarjeta()
        {
            List<BETarjeta> ListaTarjetas = new List<BETarjeta>();
            List<BETarjetaInternacional> ListaTarjetasInt = new List<BETarjetaInternacional>();
            List<BETarjetaNacional> ListaTarjetasNac = new List<BETarjetaNacional>();
            ListaTarjetasInt = oBLTarjetaInt.ListarTodo();
            ListaTarjetasNac = oBLTarjetaNac.ListarTodo();
            foreach (BETarjetaInternacional TarjInt in ListaTarjetasInt)
            {
                ListaTarjetas.Add(TarjInt);
            }
            foreach (BETarjetaNacional TarjNac in ListaTarjetasNac)
            {
                ListaTarjetas.Add(TarjNac);
            }
            
            this.DataGrid_ABM_Tarjeta.DataSource = null;
            this.DataGrid_ABM_Tarjeta.Rows.Clear();
            this.DataGrid_ABM_Tarjeta.DataSource = ListaTarjetas;
            this.DataGrid_ABM_Tarjeta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        void AsignarAObjetoTarjeta()
        {
            try
            {
                if (ComboBox_Pais.SelectedItem.ToString() != "Argentina")
                {
                    oBETarjetaInt.Numero = Convert.ToInt32(TextBox_Numero.Text);
                    oBETarjetaInt.Estado = ComboBox_Estado.SelectedItem.ToString();
                    oBETarjetaInt.Pais = ComboBox_Pais.SelectedItem.ToString();
                    oBETarjetaInt.Vencimiento = DateTimePicker_Tarjeta.Value.Date;
                    oBETarjetaInt.Rubro = ComboBox_Rubro.SelectedItem.ToString();
                }
                else
                {
                    oBETarjetaNac.Numero = Convert.ToInt32(TextBox_Numero.Text);
                    oBETarjetaNac.Estado = ComboBox_Estado.SelectedItem.ToString();
                    oBETarjetaNac.Pais = ComboBox_Pais.SelectedItem.ToString();
                    oBETarjetaNac.Vencimiento = DateTimePicker_Tarjeta.Value.Date;
                    oBETarjetaNac.Rubro = ComboBox_Rubro.SelectedItem.ToString();
                    oBETarjetaNac.Provincia = ComboBox_Provincia.SelectedItem.ToString();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        void AsignarAObjetoCliente()
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
        
        void AsignarTarjetaAControles(BETarjeta oBETarjeta)
        {
            try
            {
                if (oBETarjeta is BETarjetaInternacional)
                {
                    TextBox_Numero.Text = oBETarjetaInt.Numero.ToString();
                    TextBox_Monto.Text = oBETarjetaInt.Saldo.ToString();
                    DateTimePicker_Tarjeta.Value = oBETarjetaInt.Vencimiento;
                    ComboBox_Pais.DisplayMember = oBETarjetaInt.Pais;
                    ComboBox_Rubro.DisplayMember = oBETarjetaInt.Rubro;
                    ComboBox_Provincia.DisplayMember = null;
                }
                else
                {
                    oBETarjetaNac = (BETarjetaNacional)this.DataGrid_ABM_Cliente.CurrentRow.DataBoundItem;
                    TextBox_Numero.Text = oBETarjetaNac.Numero.ToString();
                    TextBox_Monto.Text = oBETarjetaNac.Saldo.ToString();
                    DateTimePicker_Tarjeta.Value = oBETarjetaNac.Vencimiento;
                    ComboBox_Pais.DisplayMember = oBETarjetaNac.Pais;
                    ComboBox_Rubro.DisplayMember = oBETarjetaNac.Rubro;
                    ComboBox_Provincia.DisplayMember = oBETarjetaNac.Provincia;
                }


            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        void AsignarClienteAControles(BECliente oBECliente)
        {
            
            TextBox_Cod_Cliente.Text = oBECliente.Codigo.ToString();
            TextBox_Nombre.Text = oBECliente.Nombre;
            TextBox_Apellido.Text = oBECliente.Apellido;
            TextBox_DNI.Text = oBECliente.DNI.ToString();
            DateTimePicker_Cliente.Value = oBECliente.FechaNacimiento;
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
            try
            {
                oBECliente = (BECliente)this.DataGrid_ABM_Cliente.CurrentRow.DataBoundItem;
                AsignarClienteAControles(oBECliente);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void DataGrid_ABM_Tarjeta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGrid_ABM_Tarjeta.Columns[8] == null)
            {
                oBETarjetaInt = (BETarjetaInternacional)this.DataGrid_ABM_Cliente.CurrentRow.DataBoundItem;
                AsignarTarjetaAControles(oBETarjetaInt);
            }
            else
            {
                oBETarjetaNac = (BETarjetaNacional)this.DataGrid_ABM_Cliente.CurrentRow.DataBoundItem;
                AsignarTarjetaAControles(oBETarjetaNac);
            }

        }
    }
}
