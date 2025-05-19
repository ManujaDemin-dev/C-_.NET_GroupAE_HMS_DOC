using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace TrustWell_Hospital_Doctor
{
    public partial class Report1: Form
    {
        private string report;
        public Report1(string report)
        {
            InitializeComponent();
            this.report = report;

            webView21.EnsureCoreWebView2Async(null).ContinueWith(t =>
            {
                this.Invoke(new Action(() =>
                {
                    string pdfurl = report;


                    webView21.CoreWebView2.Navigate(pdfurl);
                }));
            });
        }
    }
}
 