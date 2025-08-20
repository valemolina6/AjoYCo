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
    public partial class frmInstagram : Form
    {
        public frmInstagram()
        {
            InitializeComponent();
        }

        private void wvInstagram_Click(object sender, EventArgs e)
        {

        }

        private async void frmInstagram_Load(object sender, EventArgs e)
        {
            await wvInstagram.EnsureCoreWebView2Async(null);
            string url = $"https://www.instagram.com/ajoyco.ropa/";
            wvInstagram.Source = new Uri(url);
        }
    }
}
