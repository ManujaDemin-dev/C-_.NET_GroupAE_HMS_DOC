using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace TrustWell_Hospital_Doctor
{
    public partial class labreports1 : UserControl
    {
        private int patientId;
        public labreports1(int patientId)
        {
            this.patientId = patientId;
            InitializeComponent();
        }

        private void labreports1_Load(object sender, EventArgs e)
        {
            string query = "SELECT DISTINCT * FROM Testtypes;";
            DataTable dt = Database.ExecuteQuery(query, null);

            gunaComboBox1.DisplayMember = "TestName";
            gunaComboBox1.ValueMember = "TestID";
            gunaComboBox1.DataSource = dt;
        }

        private void cuiButton1_MouseClick(object sender, MouseEventArgs e)
        {
            string inputTestId = textBox1.Text.Trim();
            int selectedTestType = Convert.ToInt32(gunaComboBox1.SelectedValue);

            string query = @"
        SELECT LabTests.TestID, Testtypes.TestName, LabTests.Report, LabTests.TestDate 
        FROM LabTests 
        JOIN Testtypes ON LabTests.TestType = Testtypes.TestID 
        WHERE LabTests.Status = 'Done' AND PatientID =@patentid
        AND (LabTests.TestID = @testId OR LabTests.TestType = @testType)";

            MySqlParameter[] param = {
                 new MySqlParameter("@patentid", patientId),
        new MySqlParameter("@testId", inputTestId),
        new MySqlParameter("@testType", selectedTestType)
         };

            DataTable dt = Database.ExecuteQuery(query, param);

            flowLayoutPanel1.Controls.Clear(); 

            foreach (DataRow row in dt.Rows)
            {
                Panel card = new Panel
                {
                    Width = 250,
                    Height = 150,
                    BackColor = Color.LightGray,
                    Margin = new Padding(10),
                    Tag = row["Report"].ToString()
                };

                Label lblName = new Label
                {
                    Text = "Test Name: " + row["TestName"].ToString(),
                    AutoSize = true,
                    Top = 10,
                    Left = 10
                };

                Label lblID = new Label
                {
                    Text = "Test ID: " + row["TestID"].ToString(),
                    AutoSize = true,
                    Top = 40,
                    Left = 10
                };

                Label lblDate = new Label
                {
                    Text = "Test Date: " + Convert.ToDateTime(row["TestDate"]).ToShortDateString(),
                    AutoSize = true,
                    Top = 70,
                    Left = 10
                };

                Button btnOpen = new Button
                {
                    Text = "View Report",
                    Width = 100,
                    Top = 100,
                    Left = 10
                };

                btnOpen.Click += (s, args) =>
                {
                    string report = card.Tag.ToString();
                    Report1 reportForm = new Report1(report);
                    reportForm.Show();
                };

                card.Controls.Add(lblName);
                card.Controls.Add(lblID);
                card.Controls.Add(lblDate);
                card.Controls.Add(btnOpen);
                flowLayoutPanel1.Controls.Add(card);
            }
        }
    }
}
