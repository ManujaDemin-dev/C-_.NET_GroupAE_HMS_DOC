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
        private int DocId;
        private int patientId;
        public Patients(int patientId, int docId)
        {
            InitializeComponent();
            this.patientId = patientId;
            this.cuiButton2.Click += new System.EventHandler(this.cuiButton2_Click);
            this.cuiButton3.Click += new System.EventHandler(this.cuiButton3_Click);
            this.cuiButton4.Click += new System.EventHandler(this.cuiButton4_Click);
            this.cuiButton5.Click += new System.EventHandler(this.cuiButton5_Click);
            DocId = docId;
            //this.cuiButton1.Click += new System.EventHandler(this.cuiButton1_Click);
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

        

        private void cuiButton4_Click(object sender, EventArgs e)
        {
            
            LoadUserControl(new labreports1(patientId));
        }

        private void cuiButton2_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Medicalrecords1(patientId, DocId));
        }

        private void cuiButton3_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Oldprescription1(patientId));
        }

        private void cuiButton5_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Test1(patientId));
        }

        

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cuiLabel1_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
