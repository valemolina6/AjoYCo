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
    public partial class frmUbicacion : Form
    {
        public frmUbicacion()
        {
            InitializeComponent();
        }

        private async void frmUbicacion_Load(object sender, EventArgs e)
        {
            await wvUbicacion.EnsureCoreWebView2Async(null);
            string url = $"https://www.google.com.ar/maps/place/Ajo+%26+Co/@-31.4137112,-64.1882447,17z/data=!3m1!4b1!4m6!3m5!1s0x943288a5b997710b:0xc217726e49c4dfdf!8m2!3d-31.4137158!4d-64.1856698!16s%2Fg%2F11dfgpvl27?hl=es&entry=ttu&g_ep=EgoyMDI1MDcyMy4wIKXMDSoASAFQAw%3D%3D";
            wvUbicacion.Source = new Uri(url);
        }
    }
}
