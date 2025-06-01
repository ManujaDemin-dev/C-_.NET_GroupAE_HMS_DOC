using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
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
        private string name;
        private string p_age;
        private string contact;
        //private DateTime dob;
        private int appoinmentId;

        DateTimeUpdater dateTime1 = new DateTimeUpdater();

        public Patients(int patientId, int docId, int appoinmentID)
        {
            InitializeComponent();
            this.patientId = patientId;

            
            DocId = docId;
            appoinmentId = appoinmentID;

            // Initialize query and parameters here to avoid referencing non-static fields in field initializers
            query = "SELECT PatientName, Gender, DateOfBirth, patientAge, ContactNumber, Email, Address, Bloodgroup FROM Patients WHERE PatientID = @pid";
            param = new MySqlParameter[]
            {
                    new MySqlParameter("@pid", this.patientId)
            };

            DataTable dt = Database.ExecuteQuery(query, param);
            if (dt != null)
            {
                name = dt.Rows[0]["PatientName"].ToString();
                string gender = dt.Rows[0]["Gender"].ToString();
                DateTime dob = (DateTime)dt.Rows[0]["DateOfBirth"];
                contact = dt.Rows[0]["ContactNumber"].ToString();
                string email = dt.Rows[0]["Email"].ToString();
                string address = dt.Rows[0]["Address"].ToString();
                string Bloodgroup = dt.Rows[0]["Bloodgroup"].ToString();

                DateTime today = DateTime.Today;
             
                int age = today.Year - dob.Year;
                if (dob.Date > today.AddYears(-age))
                {
                    age--;
                }
               
                p_age = Convert.ToString(age);

                label13.Text = $"{p_age} Years";
                label2.Text = $"{name}'s Appointment";
                label14.Text = gender;
                label12.Text = contact;
                label6.Text = email;
                label11.Text = address;
                label15.Text = Bloodgroup;
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
            LoadUserControl(new allergies(patientId));
            dateTime1.StartDateTimeClock(label16, label17);
        }

        private void cuiButton7_Click(object sender, EventArgs e)
        {
            LoadUserControl(new allergies(patientId));
        }

        private void cuiLabel1_Load(object sender, EventArgs e)
        {
        }

        private void cuiButton6_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show($"Are you going to Complete the {name}'s Appoinment", "Confirm Exit",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                string query = "UPDATE Appointments SET Status = 'Completed', CreatedAt = NOW() WHERE AppointmentID = @AppointmentID";
                MySqlParameter[] parameters = new MySqlParameter[] {
                new MySqlParameter("@AppointmentID", appoinmentId) };
                Database.ExecuteNonQuery(query, parameters);

                Dashbord form1 = new Dashbord();
                form1.Show();

                foreach (Form openForm in Application.OpenForms.Cast<Form>().ToList())
                {
                    if (!(openForm is Dashbord))
                    {
                        openForm.Hide();
                    }
                }
                MessageBox.Show("Appointment is Completed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

            }

        }

        private void cuiButton1_MouseClick(object sender, MouseEventArgs e)
        {
            Newprescription newprescription = new Newprescription(patientId, name, p_age, contact);
            newprescription.StartPosition = FormStartPosition.CenterScreen;
            //newprescription.ShowDialog();
            newprescription.Show();
        }

        private void cuiButton3_MouseClick(object sender, MouseEventArgs e)
        {
            LoadUserControl(new Oldprescription1(patientId));
        }

        private void cuiButton2_MouseClick(object sender, MouseEventArgs e)
        {
            LoadUserControl(new Medicalrecords1(patientId, DocId));
        }

        private void cuiButton5_MouseClick(object sender, MouseEventArgs e)
        {
            LoadUserControl(new Test1(patientId));
        }

        private void cuiButton4_MouseClick(object sender, MouseEventArgs e)
        {
            LoadUserControl(new labreports1(patientId));
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
