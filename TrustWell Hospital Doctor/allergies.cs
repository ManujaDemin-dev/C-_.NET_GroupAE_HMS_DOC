using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; 
using WindowsFormsApp1;
using Guna.UI.WinForms;


namespace TrustWell_Hospital_Doctor
{
    public partial class allergies : UserControl
    {
        private int PatientID;
        private string Notes;
        private string Allergy;
        private string Conicc;

        public allergies(int patientId)
        {
            InitializeComponent();
            this.PatientID = patientId;

            LoadAllAllergyData();
            LoadnoteData();
            LoadChronic();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void allergytextbox_TextChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void LoadAllAllergyData()
        {
            string query = "SELECT Allergies FROM Patients WHERE PatientID = @patientId";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@patientId", PatientID)
            };

            DataTable dt = Database.ExecuteQuery(query, parameters);

            StringBuilder allerg = new StringBuilder();

            foreach (DataRow row in dt.Rows)
            {
                string allergy = row["Allergies"]?.ToString();
                if (!string.IsNullOrWhiteSpace(allergy))
                    allerg.AppendLine(allergy);
            }
            textbox3.Text = allerg.ToString();
            Allergy = allerg.ToString();

        }

        private void LoadnoteData()
        {
            string query = "SELECT Notes FROM Patients WHERE PatientID = @patientId";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@patientId", PatientID)
            };

            DataTable dt = Database.ExecuteQuery(query, parameters);

            StringBuilder noted = new StringBuilder();

            foreach (DataRow row in dt.Rows)
            {
                string note = row["Notes"]?.ToString();
                if (!string.IsNullOrWhiteSpace(note))
                    noted.AppendLine(note);
            }

           textBox1.Text = noted.ToString();
             Notes = noted.ToString();
        }
        private void LoadChronic()
        {
            string query = "SELECT chronic FROM Patients WHERE PatientID = @patientId";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@patientId", PatientID)
            };

            DataTable dt = Database.ExecuteQuery(query, parameters);

            StringBuilder allerg = new StringBuilder();

            foreach (DataRow row in dt.Rows)
            {
                string chronic = row["chronic"]?.ToString();
                if (!string.IsNullOrWhiteSpace(chronic))
                    allerg.AppendLine(chronic);
            }
            textBox2.Text = allerg.ToString();
            Conicc = allerg.ToString();

        }

        private void LoadUserControl(UserControl uc)
        {
            panel1.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);
        }
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Allergies2(PatientID, Allergy, Notes, Conicc));
        }

        private void notestxtbox_Click(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
