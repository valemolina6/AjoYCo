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
    public partial class frmConsultarStock : Form
    {
        public frmConsultarStock()
        {
            InitializeComponent();
        }
        clsProductos x = new clsProductos();

        private void frmConsultarStock_Load(object sender, EventArgs e)
        {
            x.Listar(cmbArticulos);
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            x.ConsultaStock(GrillaStock, cmbArticulos);

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            x.GenerarReporte(cmbArticulos);
            MessageBox.Show("Reporte generado correctamente");
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            prtVentana.ShowDialog();
            prtDocumento.PrinterSettings = prtVentana.PrinterSettings;
            prtDocumento.Print();
            MessageBox.Show("Reporte impreso correctamente");
        }

        private void prtDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            x.Imprimir(e);
        }
    }
}
