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
    public partial class frmGraficos : Form
    {
        public frmGraficos()
        {
            InitializeComponent();
        }

        clsVentas cls = new clsVentas();
        private void btnGraficar_Click(object sender, EventArgs e)
        {
            cls.Graficar(chGraficar);
        }

        private void chGraficar_Click(object sender, EventArgs e)
        {

        }
    }
}
