using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrustWell_Hospital_Doctor
{

    

    public partial class Dashbord: Form
    {
        private DateTimeDisplay dateTimeDisplay;
        public Dashbord()
        {
            InitializeComponent();
            this.Load += Dashbord_Load;
            this.button1.Click += new System.EventHandler(this.button1_Click);


            dateTimeDisplay = new DateTimeDisplay(label9, label1);

        }

        private void LoadUserControl(UserControl uc)
        {
            panel3.Controls.Clear();   
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Add(uc);
        }

        private void Dashbord_Load(object sender, EventArgs e)
        {
            LoadUserControl(new Dashbord1());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Dashbord1());
        }

       
    }
}
