using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Web;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WindowsFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TrustWell_Hospital_Doctor;
using Guna.UI.WinForms;


namespace TrustWell_Hospital_Doctor
{
    public partial class Allergies2 : UserControl
    {
        private int PatientID;
        private string Allergyies;
        private string Notes;
        private string Coniccon;
        public Allergies2(int patientID, string allergy, string note, string Conicc)
        {
            InitializeComponent();
            PatientID = patientID;
            Allergyies = allergy;
            Notes = note;
            Coniccon = Conicc;
        }

        private void Allergies2_Load(object sender, EventArgs e)
        {
            textBox1.Text = Allergyies;
            textBox3.Text = Notes;
            textBox2.Text = Coniccon;
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
            string allergies = textBox1.Text.Trim();

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
            string Notes = textBox3.Text.Trim();

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

        private void gunaButton1_MouseClick(object sender, MouseEventArgs e)
        {

            string Coniccon = textBox2.Text.Trim();

            if (!string.IsNullOrWhiteSpace(Coniccon))
            {
                string query = "UPDATE Patients SET chronic = @conic WHERE PatientID = @patientId";

                MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@conic", Coniccon),
                    new MySqlParameter("@patientId", PatientID)
                };

                Database.ExecuteQuery(query, parameters);

                MessageBox.Show("chronic conditions are updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter a valid chronic conditions.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            Textboxfunc.HandleEnterBullets(textBox2, e);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            Textboxfunc.HandleEnterBullets(textBox1, e);
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            Textboxfunc.HandleEnterBullets(textBox3, e);
        }

        //private void txtnote_TextChanged(object sender, EventArgs e)
        //{

        //}


    }
}
