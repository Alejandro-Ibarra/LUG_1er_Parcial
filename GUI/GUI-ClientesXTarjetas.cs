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

        private void DataGridView_Clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            oBECliente = (BECliente)DataGridView_Clientes.CurrentRow.DataBoundItem;

            this.DataGridView_Tarjeta_De_Cliente_Nac.DataSource = null;
            this.DataGridView_Tarjeta_De_Cliente_Nac.Rows.Clear();
            this.DataGridView_Tarjeta_De_Cliente_Nac.DataSource = ListarTarjCliNac(oBECliente);
            this.DataGridView_Tarjeta_De_Cliente_Nac.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            this.DataGridView_Tarjeta_De_Cliente_Int.DataSource = null;
            this.DataGridView_Tarjeta_De_Cliente_Int.Rows.Clear();
            this.DataGridView_Tarjeta_De_Cliente_Int.DataSource = ListarTarjCliInt(oBECliente);
            this.DataGridView_Tarjeta_De_Cliente_Int.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            
            
        }

        private void Button_Asignar_Click(object sender, EventArgs e)
        {
            CargarGrillaTarjDispNac();
            CargarGrillaTarjDispInt();
        }
    }
}
