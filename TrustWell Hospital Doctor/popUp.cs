using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrustWell_Hospital_Doctor
{
    public partial class popUp: Form
    {
        public popUp(string date, string docName, string prescription)
        {
            InitializeComponent();

            label1.Text = "Date                : " + date;
            label2.Text = "Doctor Name : " + docName;
            gunaTextBox2.Text = prescription;
        }

        private void popUp_Load(object sender, EventArgs e)
        {
            gunaTextBox2.SelectionStart = gunaTextBox2.Text.Length;
            gunaTextBox2.SelectionLength = 0;
        }
    }
}
