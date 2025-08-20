using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Molina.Valentina_TPI_PP1
{
    public partial class frmGraficosXFecha : Form
    {
        public frmGraficosXFecha()
        {
            InitializeComponent();
        }

        clsVentas cls = new clsVentas();

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            cls.GraficarPorFecha(chGraficar, dtpDesde, dtpHasta, lblTotal);

        }

        private void chGraficar_Click(object sender, EventArgs e)
        {

        }
    }
}
