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
            oBLDesc = new BLDescuentosCalculados();
            oBEDesc = new BEDescuentoCalculado();

            this.DataGrid_ABM_Cliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_ABM_Tarjeta_Nac.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_ABM_Tarjeta_Int.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        BLCliente oBLCliente;
        BLTarjetaInternacional oBLTarjetaInt;
        BLTarjetaNacional oBLTarjetaNac;
        BECliente oBECliente;
        BETarjeta oBETarjeta;
        BETarjetaInternacional oBETarjetaInt;
        BETarjetaNacional oBETarjetaNac;
        BLPaises oBLPaises;
        BLProvincias oBLProvincias;
        BLDescuentosCalculados oBLDesc;
        BEDescuentoCalculado oBEDesc;

        private void GUI_ABMClientesTarjetas_Load(object sender, EventArgs e)
        {
            
            CargarComboBoxPaises();
            CargarComboBoxProvincias();
            CargarComboBoxRubro();
            CargarGrillaCliente();
            CargarGrillaTarjetaInt();
            CargarGrillaTarjetaNac();
            
        }

        private void Button_Alta_Cliente_Click(object sender, EventArgs e)
        {
            //try
            //{
                AsignarAObjetoCliente();
            oBECliente.Codigo = 0;
            oBLCliente.Guardar(oBECliente);
                Limpiar();
                CargarGrillaCliente();
            //}
            //catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Button_Mod_Cliente_Click(object sender, EventArgs e)
        {
            //try
            //{
            AsignarAObjetoCliente();
            oBECliente.Codigo = Convert.ToInt32(TextBox_Cod_Cliente.Text);
            oBLCliente.Guardar(oBECliente);
                Limpiar();
                CargarGrillaCliente();
            //}
            //catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Button_Baja_Cliente_Click(object sender, EventArgs e)
        {
            //try
            //{
            AsignarAObjetoCliente();
                DialogResult Respuesta;
                Respuesta = MessageBox.Show("¿Confirma la eleminación del Cliente?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Respuesta == DialogResult.Yes)
            {
                oBLCliente.Baja(oBECliente);
                    CargarGrillaCliente();
                    Limpiar();
                }
            //}
            //catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Button_Alta_Tarjeta_Click(object sender, EventArgs e)
        {
            try
            {
                AsignarAObjetoTarjeta();
                if (ComboBox_Pais.Text == "Argentina")
                {
                    oBETarjetaNac.Codigo = 0;
                    oBETarjetaNac.Estado = "null";
                    oBETarjetaNac.Saldo = 0;
                    oBLTarjetaNac.Guardar(oBETarjetaNac);
                }
                else
                {
                    oBETarjetaInt.Codigo = 0;
                    oBETarjetaNac.Estado = "null";
                    oBETarjetaInt.Saldo = 0;
                    oBLTarjetaInt.Guardar(oBETarjetaInt);
                }
                Limpiar();
                CargarGrillaTarjetaInt();
                CargarGrillaTarjetaNac();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Button_Modificar_Tarjeta_Click(object sender, EventArgs e)
        {
            try
            {
                AsignarAObjetoTarjeta();
                if (ComboBox_Pais.Text == "Argentina")
                {
                    oBETarjetaNac.Codigo = Convert.ToInt32(TextBox_Cod_tarjeta.Text);
                    oBLTarjetaNac.Guardar(oBETarjetaNac);
                }
                else
                {
                    oBETarjetaInt.Codigo = Convert.ToInt32(TextBox_Cod_tarjeta.Text);
                    oBLTarjetaInt.Guardar(oBETarjetaInt);
                }
                Limpiar();
                CargarGrillaTarjetaInt();
                CargarGrillaTarjetaNac();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Button_Borrar_Tarjeta_Click(object sender, EventArgs e)
        {
            try
            {
                AsignarAObjetoTarjeta();
                DialogResult Respuesta;
                Respuesta = MessageBox.Show("¿Confirma la eleminación de la Tarjeta?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Respuesta == DialogResult.Yes)
                {
                    if (ComboBox_Pais.SelectedItem.ToString() != "Argentina")
                    {
                        oBLTarjetaInt.Baja(oBETarjetaInt);
                    }
                    else
                    {
                        oBLTarjetaNac.Baja(oBETarjetaNac);
                    } 
                }
                CargarGrillaTarjetaInt();
                CargarGrillaTarjetaNac();
                Limpiar();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        void CargarComboBoxPaises()
        {
            try
            {
                ComboBox_Pais.DataSource = null;

                List<BEPaises> ListaPaises = oBLPaises.ListarTodo();
                List<string> NombresPaises = new List<string>();
                foreach (BEPaises Prov in ListaPaises)
                {
                    NombresPaises.Add(Prov.Nombre);
                }
                ComboBox_Pais.DataSource = NombresPaises;
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
                List<BEProvincias> ListaProvincias = oBLProvincias.ListarTodo();
                List<string> NombresProvincias = new List<string>();
                foreach (BEProvincias Prov in ListaProvincias)
                {
                    NombresProvincias.Add(Prov.Nombre);
                }
                ComboBox_Provincia.DataSource = NombresProvincias;
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

        void CargarGrillaCliente()
        {
            this.DataGrid_ABM_Cliente.DataSource = null;
            this.DataGrid_ABM_Cliente.Rows.Clear();
            this.DataGrid_ABM_Cliente.DataSource = oBLCliente.ListarTodo();
            this.DataGrid_ABM_Cliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        void CargarGrillaTarjetaInt()
        {
            List<BETarjetaInternacional> ListaTarjetasInt = new List<BETarjetaInternacional>();
            ListaTarjetasInt = oBLTarjetaInt.ListarTodo();
            this.DataGrid_ABM_Tarjeta_Int.DataSource = null;
            this.DataGrid_ABM_Tarjeta_Int.Rows.Clear();
            this.DataGrid_ABM_Tarjeta_Int.DataSource = ListaTarjetasInt;
            this.DataGrid_ABM_Tarjeta_Nac.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        void CargarGrillaTarjetaNac()
        {
            List<BETarjetaNacional> ListaTarjetasNac = oBLTarjetaNac.ListarTodo();
            this.DataGrid_ABM_Tarjeta_Nac.DataSource = null;
            this.DataGrid_ABM_Tarjeta_Nac.Rows.Clear();
            this.DataGrid_ABM_Tarjeta_Nac.DataSource = ListaTarjetasNac;
            this.DataGrid_ABM_Tarjeta_Nac.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        void AsignarAObjetoTarjeta()
        {
            try
            {
                if (ComboBox_Pais.SelectedItem.ToString() != "Argentina")
                {
                    oBETarjetaInt.Numero = Convert.ToInt32(TextBox_Numero.Text);
                    //oBETarjetaInt.Estado = ComboBox_Estado.SelectedItem.ToString();
                    oBETarjetaInt.Pais = ComboBox_Pais.SelectedItem.ToString();
                    oBETarjetaInt.Vencimiento = DateTimePicker_Tarjeta.Value;
                    oBETarjetaInt.Rubro = ComboBox_Rubro.SelectedItem.ToString();
                }
                else
                {
                    oBETarjetaNac.Numero = Convert.ToInt32(TextBox_Numero.Text);
                    //oBETarjetaNac.Estado = ComboBox_Estado.SelectedItem.ToString();
                    oBETarjetaNac.Pais = ComboBox_Pais.SelectedItem.ToString();
                    oBETarjetaNac.Vencimiento = DateTimePicker_Tarjeta.Value;
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
                    oBETarjetaInt = (BETarjetaInternacional)this.DataGrid_ABM_Tarjeta_Int.CurrentRow.DataBoundItem;
                    TextBox_Cod_tarjeta.Text = oBETarjetaInt.Codigo.ToString();
                    TextBox_Numero.Text = oBETarjetaInt.Numero.ToString();
                    TextBox_Monto.Text = oBETarjetaInt.Saldo.ToString();
                    DateTimePicker_Tarjeta.Value = oBETarjetaInt.Vencimiento;
                    ComboBox_Pais.SelectedItem = oBETarjetaInt.Pais;
                    ComboBox_Rubro.SelectedItem = oBETarjetaInt.Rubro;
                    ComboBox_Provincia.SelectedItem = null;
                }
                else
                {
                    oBETarjetaNac = (BETarjetaNacional)this.DataGrid_ABM_Tarjeta_Nac.CurrentRow.DataBoundItem;
                    TextBox_Cod_tarjeta.Text = oBETarjetaNac.Codigo.ToString();
                    TextBox_Numero.Text = oBETarjetaNac.Numero.ToString();
                    TextBox_Monto.Text = oBETarjetaNac.Saldo.ToString();
                    DateTimePicker_Tarjeta.Value = oBETarjetaNac.Vencimiento;
                    ComboBox_Pais.SelectedItem = oBETarjetaNac.Pais;
                    ComboBox_Rubro.SelectedItem = oBETarjetaNac.Rubro;
                    ComboBox_Provincia.SelectedItem = oBETarjetaNac.Provincia;
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

        private void CalcularTarjetaMayorDescuento()
        {
            List<BEDescuentoCalculado> ListaDescuentos = oBLDesc.ListarTodo();
            List<BETarjetaNacional> ListaTarjetasNac = oBLTarjetaNac.ListarTodo();
            List<BETarjetaInternacional> ListaTarjetasInt = oBLTarjetaInt.ListarTodo();
            double aux1 = 0;
            double aux = 0;
            int numeroTarjeta = 0;
            BETarjeta oBETarjAux = new BETarjeta();
            if (ListaDescuentos != null)
            {
                foreach (BEDescuentoCalculado oBEDesAux in ListaDescuentos)
                {
                    aux1 += oBEDesAux.DescuentoOtorgado;
                    numeroTarjeta = oBEDesAux.NumeroTarjeta;
                    foreach (BEDescuentoCalculado oBEDesAux2 in ListaDescuentos)
                    {
                        if (oBEDesAux.NumeroTarjeta == oBEDesAux2.NumeroTarjeta && oBEDesAux.DescuentoOtorgado != oBEDesAux2.DescuentoOtorgado)
                        {
                                aux1 += oBEDesAux2.DescuentoOtorgado;
                        }
                    }
                    if (aux1 > aux)
                    {
                        aux = aux1;
                        aux1 = 0;
                    }
                }
                TextBox_Tarj_Mayor_Desc.Text = "La tarjeta con mayor descuento es " + numeroTarjeta.ToString() + " con el descuento de " + aux + ".";
            }
            else
            {
                TextBox_Tarj_Mayor_Desc.Text = "No hay descuentos acumulados";
            }
        }

        private void TarjetaMenorMonto()
        {
            BETarjeta oBETarjAux = new BETarjeta();
            oBETarjAux.Saldo = 999999;
            List<BETarjetaNacional> ListaTarjetasNac = oBLTarjetaNac.ListarTodo();
            List<BETarjetaInternacional> ListaTarjetasInt = oBLTarjetaInt.ListarTodo();
            if (ListaTarjetasNac != null)
            {
                foreach (BETarjetaNacional oBETarjNacAux in ListaTarjetasNac)
                {
                    if (oBETarjNacAux.Saldo < oBETarjAux.Saldo && oBETarjNacAux.Saldo != 0)
                    {
                        oBETarjAux = oBETarjNacAux;
                    }
                }
            }
            if (ListaTarjetasInt != null)
            {
                foreach (BETarjetaInternacional oBETarjIntAux in ListaTarjetasInt)
                {
                    if (oBETarjIntAux.Saldo < oBETarjAux.Saldo && oBETarjIntAux.Saldo != 0)
                    {
                        oBETarjAux = oBETarjIntAux;
                    }
                }
            }
            TextBox_Tarj_Menor_Imp.Text = "La tarjeta de menor importe es " + oBETarjAux.Numero + " con un saldo de "+ oBETarjAux.Saldo +".";
        }


        private void HabilitarComboProvincia()
        {
            if (ComboBox_Pais.SelectedItem.ToString() == "Argentina")
            {
                ComboBox_Provincia.Enabled = true;
                CargarComboBoxProvincias();
            }
            else
            {
                ComboBox_Provincia.Enabled = false;
            }
        }

        private void ComboBox_Pais_SelectedValueChanged(object sender, EventArgs e)
        {
            HabilitarComboProvincia();
        }

        private void DataGrid_ABM_Cliente_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                oBECliente = (BECliente)this.DataGrid_ABM_Cliente.CurrentRow.DataBoundItem;
                AsignarClienteAControles(oBECliente);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void DataGrid_ABM_Tarjeta_Nac_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                DataGrid_ABM_Tarjeta_Int.ClearSelection();
                oBETarjetaNac = (BETarjetaNacional)this.DataGrid_ABM_Tarjeta_Nac.CurrentRow.DataBoundItem;
                AsignarTarjetaAControles(oBETarjetaNac);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void DataGrid_ABM_Tarjeta_Int_MouseClick(object sender, MouseEventArgs e)
        {
            DataGrid_ABM_Tarjeta_Nac.ClearSelection();
            oBETarjetaInt = (BETarjetaInternacional)this.DataGrid_ABM_Tarjeta_Int.CurrentRow.DataBoundItem;
            AsignarTarjetaAControles(oBETarjetaInt);
        }

        private void ButtonMenorSaldo_Click(object sender, EventArgs e)
        {
            TarjetaMenorMonto();
        }

        private void Button_Mayores_Descuentos_Click(object sender, EventArgs e)
        {
            CalcularTarjetaMayorDescuento();
        }
    }
}
