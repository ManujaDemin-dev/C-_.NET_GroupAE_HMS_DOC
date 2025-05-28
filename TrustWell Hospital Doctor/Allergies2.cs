using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WindowsFormsApp1;

namespace TrustWell_Hospital_Doctor
{
    public partial class Allergies2 : UserControl
    {
        private int PatientID;

        public Allergies2(int patientID)
        {
            InitializeComponent();
            PatientID = patientID;
        }

        private void Allergies2_Load(object sender, EventArgs e)
        {
            // Optional: Load current data into the textboxes if needed
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnaddblood_Click(object sender, EventArgs e)
        {
            string bloodGroup = txtblood.Text.Trim();

            if (!string.IsNullOrWhiteSpace(bloodGroup))
            {
                string query = "UPDATE Patients SET BloodGroup = @bloodGroup WHERE PatientID = @patientId";

                MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@bloodGroup", bloodGroup),
                    new MySqlParameter("@patientId", PatientID)
                };

                Database.ExecuteQuery(query, parameters);

                MessageBox.Show("Blood group updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter a valid blood group.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnaddallergy_MouseClick(object sender, MouseEventArgs e)
        {
            string allergies = txtallergy.Text.Trim();

            if (!string.IsNullOrWhiteSpace(allergies))
            {
                string query = "UPDATE Patients SET Allergies = @allergic WHERE PatientID = @patientId";

                MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@allergic", allergies),
                    new MySqlParameter("@patientId", PatientID)
                };

                Database.ExecuteQuery(query, parameters);

                MessageBox.Show("Allergy info updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter a valid allergy.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnaddnote_MouseClick(object sender, MouseEventArgs e)
        {
            string Notes = txtnote.Text.Trim();

            if (!string.IsNullOrWhiteSpace(Notes))
            {
                string query = "UPDATE Patients SET Notes = @note WHERE PatientID = @patientId";

                MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@note", Notes),
                    new MySqlParameter("@patientId", PatientID)
                };

                Database.ExecuteQuery(query, parameters);

                MessageBox.Show("Note updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter a valid note.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
