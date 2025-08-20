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
    public partial class frmCargarVenta : Form
    {
        public frmCargarVenta()
        {
            InitializeComponent();
        }

        private void grpVenta_Enter(object sender, EventArgs e)
        {

        }

        private void cmbDesde_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDesde_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void frmCargarVenta_Load(object sender, EventArgs e)
        {
            clsProductos x = new clsProductos();
            x.Listar(cmbArticulos);
            clsVentas z = new clsVentas();
            z.ListarMediosDePago(cmbTipoVenta);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            clsVentas x = new clsVentas();
            x.AgregarVentas(Calendario, cmbTipoVenta, cmbArticulos, txtUnidades, txtMonto);
        }
    }
}
