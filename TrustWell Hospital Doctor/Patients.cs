using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace TrustWell_Hospital_Doctor
{
    public partial class Patients : Form
    {
        private int DocId;
        private int patientId;
        private string query;
        private MySqlParameter[] param;

        public Patients(int patientId, int docId)
        {
            InitializeComponent();
            this.patientId = patientId;
            this.cuiButton2.Click += new System.EventHandler(this.cuiButton2_Click);
            this.cuiButton3.Click += new System.EventHandler(this.cuiButton3_Click);
            this.cuiButton4.Click += new System.EventHandler(this.cuiButton4_Click);
            this.cuiButton5.Click += new System.EventHandler(this.cuiButton5_Click);
            DocId = docId;

            // Initialize query and parameters here to avoid referencing non-static fields in field initializers
            query = "SELECT PatientName, Gender, DateOfBirth, patientAge, ContactNumber, Email, Address FROM Patients WHERE PatientID = @pid";
            param = new MySqlParameter[]
            {
                    new MySqlParameter("@pid", this.patientId)
            };

            DataTable dt = Database.ExecuteQuery(query, param);
            if (dt != null)
            {
                string name = dt.Rows[0]["PatientName"].ToString();
                string gender = dt.Rows[0]["Gender"].ToString();
                string dob = dt.Rows[0]["DateOfBirth"].ToString();
                string contact = dt.Rows[0]["ContactNumber"].ToString();
                string email = dt.Rows[0]["Email"].ToString();
                string address = dt.Rows[0]["Address"].ToString();

                label2.Text = $"{name}'s Appointment";
                label14.Text = gender;
                label12.Text = contact;
                label11.Text = email;
                label8.Text = address;
            }
        }

        private void LoadUserControl(UserControl uc)
        {
            panel3.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Add(uc);
        }

        private void Patients_Load(object sender, EventArgs e)
        {
            // this.label2.Text = patientId.ToString();
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
        private void cuiButton7_Click(object sender, EventArgs e)
        {
            LoadUserControl(new allergies());
        }

        private void cuiLabel1_Load(object sender, EventArgs e)
        {
        }

        private void cuiButton6_Click(object sender, EventArgs e)
        {

        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            Newprescription newprescription = new Newprescription();
            newprescription.StartPosition = FormStartPosition.CenterScreen;
            //newprescription.ShowDialog();
            newprescription.Show();
        }

        private void cuiButton3_Click_1(object sender, EventArgs e)
        {

        }

        
    }
}
