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
    public partial class frmAcercaDe : Form
    {
        public frmAcercaDe()
        {
            InitializeComponent();
        }

        private void btnWpp_Click(object sender, EventArgs e)
        {
            frmWpp frm = new frmWpp();
            frm.ShowDialog();
        }
    }
}
