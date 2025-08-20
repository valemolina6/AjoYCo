using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Molina.Valentina_TPI_PP1
{
    public partial class frmSistemaAjoYCo : Form
    {
        public frmSistemaAjoYCo()
        {
            InitializeComponent();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe Ventana = new frmAcercaDe();
            Ventana.ShowDialog();
        }

        private void agregarStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificarStock Ventana = new frmModificarStock();
            Ventana.ShowDialog();
        }

        private void consultarStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarStock Ventana = new frmConsultarStock();
            Ventana.ShowDialog();
        }

        private void cargarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargarVenta Ventana = new frmCargarVenta();
            Ventana.ShowDialog();
        }

        private void consultarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaVenta Ventana = new frmConsultaVenta();
            Ventana.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void cargarNuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAñadirNuevoProducto Ventana = new frmAñadirNuevoProducto();
            Ventana.ShowDialog();
        }

        private void verGraficosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void verGraficoDeTodasLasVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGraficos ventana = new frmGraficos();
            ventana.ShowDialog();
        }

        private void graficoVentasPorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGraficosXFecha ventana = new frmGraficosXFecha();
            ventana.ShowDialog();
        }

        private void ingresarNuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevoCliente frm = new frmNuevoCliente();
            frm.ShowDialog();
        }

        private void generarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGenerarFactura frm = new frmGenerarFactura();
            frm.ShowDialog();
        }

        private void ubicacionDelLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosLocal frm = new frmDatosLocal();
            frm.ShowDialog();
        }
    }
}
