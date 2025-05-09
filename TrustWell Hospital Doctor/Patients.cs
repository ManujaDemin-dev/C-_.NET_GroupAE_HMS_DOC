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
    public partial class Patients: Form
    {
        private int patientId;
        public Patients(int patientId)
        {
            InitializeComponent();
            this.patientId = patientId;
            this.cuiButton1.Click += new System.EventHandler(this.button2_Click);
            this.cuiButton3.Click += new System.EventHandler(this.button3_Click);
            this.cuiButton4.Click += new System.EventHandler(this.button4_Click);
            this.cuiButton5.Click += new System.EventHandler(this.button5_Click);
            this.cuiButton1.Click += new System.EventHandler(this.button1_Click);
        }
        private void LoadUserControl(UserControl uc)
        {
            panel3.Controls.Clear();   
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Add(uc);
        }
        private void Patients_Load(object sender, EventArgs e)
        {
            this.label2.Text = patientId.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            
            LoadUserControl(new labreports1());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Medicalrecords1());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Oldprescription1(patientId));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Test1());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////////////
        }

        private void cuiButton2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cuiPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
