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

namespace TrustWell_Hospital_Doctor
{
    public partial class Dashbord1: UserControl
    {
        private int docId;

        public Dashbord1(int docId)      
        {
            InitializeComponent();
            this.docId = docId;
            LoadAppointments();
            this.gunaDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);


        }

        private void Dashbord1_Load(object sender, EventArgs e)
        {
            docId = UserSession.DocId;
        }

        private void LoadAppointments()
        {
            try
            {
                string todayFormatted = DateTime.Now.ToString("dddd, MMMM d, yyyy");
                string query = @"
                 SELECT 
                        Appointments.PatientID, 
                        Patients.PatientName, 
                        Patients.ContactNumber, 
                        Appointments.Appoinmentnumber 
                    FROM 
                        Appointments
                    INNER JOIN 
                        Patients ON Appointments.PatientID = Patients.PatientID
                    WHERE 
                        Appointments.DoctorID = @DoctorID
                        AND Appointments.AppointmentDate = @Today
                        AND Appointments.Status = 'Scheduled'";

                MySqlParameter[] parameters =
                {
                new MySqlParameter("@DoctorID", docId),
                new MySqlParameter("@Today", todayFormatted)
            };

                string countQuery = @"
                SELECT COUNT(*) 
                FROM Appointments 
                WHERE DoctorID = @DoctorID AND AppointmentDate = @Today AND Status = 'Completed'";
                DataTable count = Database.ExecuteQuery(countQuery, parameters);

                label4.Text = count.Rows.Count.ToString();


                DataTable dt = Database.ExecuteQuery(query, parameters);
                label2.Text = dt.Rows.Count.ToString();

                if (dt.Rows.Count == 0)
                {
                    label7.Text = "No appointments today yet";
                    label7.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                    label7.ForeColor = Color.DarkRed;

                    return;
                }
                else
                {
                    gunaDataGridView1.DataSource = dt;
                }

                if (!gunaDataGridView1.Columns.Contains("StartButton"))
                {
                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                    btn.HeaderText = "Action";
                    btn.Name = "StartButton";
                    btn.Text = "Start";
                    btn.UseColumnTextForButtonValue = true;
                
                    gunaDataGridView1.Columns.Add(btn);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading appointments: " + ex.Message);
            }


            
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gunaDataGridView1.Columns[e.ColumnIndex].Name == "StartButton" && e.RowIndex >= 0)
            {
                try
                {
                    int patientId = Convert.ToInt32(gunaDataGridView1.Rows[e.RowIndex].Cells["PatientID"].Value);
                    Patients startForm = new Patients(patientId, docId);
                    startForm.Show();

                    Form parentForm = this.FindForm();
                    if (parentForm != null)
                    {
                        parentForm.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening start form: " + ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
