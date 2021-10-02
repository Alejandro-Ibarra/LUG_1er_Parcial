using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aBMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_ABMClientesTarjetas GUI_ABM = new GUI_ABMClientesTarjetas();
            GUI_ABM.MdiParent = this;
            GUI_ABM.Show();
        }

        private void tarjetasPorClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_ClientesXTarjetas GUI_Tarj = new GUI_ClientesXTarjetas();
            GUI_Tarj.MdiParent = this;
            GUI_Tarj.Show();

        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_Compras GUI_Compras = new GUI_Compras();
            GUI_Compras.MdiParent = this;
            GUI_Compras.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
