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
    public partial class frmAñadirNuevoProducto : Form
    {
        public frmAñadirNuevoProducto()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            clsProductos x = new clsProductos();
            x.NombreProducto = txtNombre.Text;
            x.PrecioProducto = Convert.ToInt32(txtPrecio.Text);
            x.AgregarProducto();
            MessageBox.Show("Producto agregado");
            txtNombre.Text = "";
            txtPrecio.Text = "";
        }
    }
}
