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

    

    public partial class Dashbord: Form
    {
        DateTimeUpdater dateTime1 = new DateTimeUpdater();
        public Dashbord()
        {
            InitializeComponent();
         

        }

        private void LoadUserControl(UserControl uc)
        {
            panel3.Controls.Clear();   
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Add(uc);
        }


        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            LoadUserControl(new Dashbord1(UserSession.DocId));
        }

        private void cuiButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            login loginForm = new login();
            loginForm.Show();
            //this.Close();

        }

        private void Dashbord_Load(object sender, EventArgs e)
        {

            dateTime1.StartDateTimeClock(label9, label1);
            this.label2.Text = $"Welcome, Dr. {UserSession.Username}";
            LoadUserControl(new Dashbord1(UserSession.DocId));

            string query = @"SELECT Doc_specialization.Specialization AS SpecializationName 
                 FROM Doc_specialization 
                 JOIN Doctors ON Doc_specialization.specialization_id = Doctors.Specialization 
                 WHERE DoctorID = @docid";

            MySqlParameter[] parameters = {
                new MySqlParameter("@docid", UserSession.DocId)
            };

            DataTable specializationData = Database.ExecuteQuery(query, parameters);

            foreach (DataRow row in specializationData.Rows)
            {
                label4.Text = row["SpecializationName"].ToString();
            }

            UserSession.specialization = label4.Text;
        }

       
    }
}
