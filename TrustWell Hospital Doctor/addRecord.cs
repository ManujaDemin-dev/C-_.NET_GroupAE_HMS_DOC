using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WindowsFormsApp1;


namespace TrustWell_Hospital_Doctor
{

    public partial class addRecord : Form
    {
        private int docId;
        private int patientId;
        public addRecord(int patientId, int docId)
        {
            InitializeComponent();
            this.patientId = patientId;
            this.docId = docId;
        }

        

        private void addRecord_Load(object sender, EventArgs e)
        {
            label8.Text = DateTime.Now.ToString("yyyy-MM-dd");
            label9.Text = patientId.ToString();
            label10.Text = docId.ToString();

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.diagnosis.Text))
            {
                MessageBox.Show("Please enter the diagnosis");
                this.diagnosis.Focus();
                return;
            }

            if(String.IsNullOrEmpty(this.observations.Text))
            {
                MessageBox.Show("Please enter the observations");
                this.observations.Focus();
                return;
            }
            if (String.IsNullOrEmpty(this.treatments.Text))
            {
                MessageBox.Show("Please enter the treatment");
                this.treatments.Focus();
                return;
            }

            if (this.observations.Text.Length > 500)
            {
                MessageBox.Show("Diagnosis is too long. Max 500 characters allowed.");
                return;
            }

            if (this.diagnosis.Text.Length > 200)
            {
                MessageBox.Show("Diagnosis is too long. Max 200 characters allowed.");
                return;
            }
            if (this.treatments.Text.Length > 500)
            {
                MessageBox.Show("Diagnosis is too long. Max 500 characters allowed.");
                return;
            }


            var result = MessageBox.Show("Submit this medical record?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;



            string diagnosis = this.diagnosis.Text.Trim();
            string observations = this.observations.Text.Trim();
            string treatments = this.treatments.Text.Trim();
            string date = DateTime.Now.ToString("yyyy-MM-dd");



            try
            {
                string query = "INSERT INTO MedicalRecords (PatientID, DoctorID, Diagnosis, Observations, Treatment, RecordDate) VALUES (@patientId, @docId, @diagnosis, @observations, @treatment, @date)";
                MySqlParameter[] parameters =
                {
                    new MySqlParameter("@patientId", patientId),
                    new MySqlParameter("@docId", docId),
                    new MySqlParameter("@diagnosis", diagnosis),
                    new MySqlParameter("@observations", observations),
                    new MySqlParameter("@treatment", treatments),
                    new MySqlParameter("@date", date)
                };
                Database.ExecuteNonQuery(query, parameters);

                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            

            

        }
    }
}