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
using System.Xml.Linq;
using WindowsFormsApp1;

namespace TrustWell_Hospital_Doctor
{
    public partial class Test2: Form
    {
        private int patientId;

        public Test2(int patientId)
        {
            InitializeComponent();
            this.patientId = patientId;
        }

        private void Test2_Load(object sender, EventArgs e)
        {
        }

        private void cuiButton1_MouseClick(object sender, MouseEventArgs e)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            int value;
            if (!int.TryParse(textBox1.Text, out value))
            {
                MessageBox.Show("Please enter a valid number in the textbox.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            int typeid = 29;
            try
            {
                string query = @"INSERT INTO TestReports (PatientID, TestType, value, Date, CreatedAt) VALUES (@patientId, @typeid, @value, @date, NOW())";

                MySqlParameter[] parameters = {
                new MySqlParameter("@patientId", patientId),
                new MySqlParameter("@typeid", typeid),
                new MySqlParameter("@value", value),
                new MySqlParameter("@date", date)

            };

                Database.ExecuteNonQuery(query, parameters);


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            this.Hide();
        }
    }
    }

