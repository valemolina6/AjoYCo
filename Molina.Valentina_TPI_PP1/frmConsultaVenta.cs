using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Molina.Valentina_TPI_PP1
{
    public partial class frmConsultaVenta : Form
    {
        public frmConsultaVenta()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsVentas x = new clsVentas();
            x.ConsultaVenta(dgvVentas, cmbTipoVenta, Calendar);
           lblCantidad.Text = x.CantidadVentas.ToString();
           lblMontoFinal.Text = x.MontoVentas.ToString("0.00");  
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            clsVentas x = new clsVentas();
            x.GenerarReporte(cmbTipoVenta, Calendar);
            MessageBox.Show("Reporte generado exitosamente");
        }

        private void DatosGrilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmConsultaVenta_Load(object sender, EventArgs e)
        {
            clsVentas x = new clsVentas();
            x.ListarMediosDePago(cmbTipoVenta);
        }

        private void grpDatos_Enter(object sender, EventArgs e)
        {

        }
    }
}
