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
    public partial class frmNuevoCliente : Form
    {
        public frmNuevoCliente()
        {
            InitializeComponent();
        }

        clsCliente cls = new clsCliente();
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            cls.AgregarCliente(txtDNI,txtDomicilio,txtNombre,txtCorreo);
        }
    }
}
