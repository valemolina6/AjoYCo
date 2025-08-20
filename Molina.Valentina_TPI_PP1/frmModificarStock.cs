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
    public partial class frmModificarStock : Form
    {
        public frmModificarStock()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            clsProductos x = new clsProductos();
            x.AgregarStockProducto(cmbArticulos, txtUnidades);
        }

        private void frmModificarStock_Load(object sender, EventArgs e)
        {
            clsProductos x = new clsProductos();
            x.Listar(cmbArticulos);
        }

        private void btnEliminarStock_Click(object sender, EventArgs e)
        {
            clsProductos x = new clsProductos();
            x.EliminarStockProducto(cmbArticulos, txtUnidades);
        }
    }
}
