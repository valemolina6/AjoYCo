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
    public partial class frmWpp : Form
    {
        public frmWpp()
        {
            InitializeComponent();
        }

        private async void frmWpp_Load(object sender, EventArgs e)
        {
            await wvWpp.EnsureCoreWebView2Async(null);
            string url = $"https://wa.me/543513593293";
            wvWpp.Source = new Uri(url);
        }
    }
}
