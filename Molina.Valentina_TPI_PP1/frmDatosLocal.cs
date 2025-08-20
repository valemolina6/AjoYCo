using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;
using System.IO;

namespace Molina.Valentina_TPI_PP1
{
    public partial class frmDatosLocal : Form
    {
        public frmDatosLocal()
        {
            InitializeComponent();
        }

        private void frmDatosLocal_Load(object sender, EventArgs e)
        {

        }

        private void btnUbicacion_Click(object sender, EventArgs e)
        {
            frmUbicacion frm = new frmUbicacion();
            frm.ShowDialog();
        }

        private void btnInstagram_Click(object sender, EventArgs e)
        {
            frmInstagram frm = new frmInstagram();
            frm.ShowDialog();
        }
    }
}
