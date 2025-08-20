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
    public partial class frmGenerarFactura : Form
    {
        public frmGenerarFactura()
        {
            InitializeComponent();
        }

        clsCliente cls = new clsCliente();

        private void frmGenerarFactura_Load(object sender, EventArgs e)
        {
            cls.Listar(cmbClientes);
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            cls.AgregarFactura(txtMontoTotal, cmbClientes);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prtVentana.ShowDialog();
            prtDocumento.PrinterSettings = prtVentana.PrinterSettings;
            prtDocumento.Print();
        }

        private void prtDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            cls.Imprimir(e, cmbClientes);
        }
    }
}
