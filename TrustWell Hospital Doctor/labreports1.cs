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
using System.Diagnostics.Eventing.Reader;

namespace TrustWell_Hospital_Doctor
{
    public partial class labreports1 : UserControl
    {
        private int patientId;
        public labreports1(int patientId)
        {
            this.patientId = patientId;
            InitializeComponent();
            gunaDataGridView1.CellContentClick += gunaDataGridView1_CellContentClick;


        }

        private void labreports1_Load(object sender, EventArgs e)
        {
            string query = "SELECT DISTINCT * FROM Testtypes;";
            DataTable dt = Database.ExecuteQuery(query, null);

            gunaComboBox1.DisplayMember = "TestName";
            gunaComboBox1.ValueMember = "TestID";
            gunaComboBox1.DataSource = dt;
        }

        private void LoadHere()
        {
           
          
            int selectedTestType = Convert.ToInt32(gunaComboBox1.SelectedValue);

            string query = @"SELECT LabTests.TestId, Testtypes.TestName, LabTests.Report, LabTests.TestDate 
                            FROM LabTests JOIN Testtypes ON LabTests.TestType = Testtypes.TestID WHERE LabTests.Status = 'Done' 
                              AND PatientID = @patentid AND LabTests.TestType = @testType ORDER BY LabTests.TestDate DESC";



            MySqlParameter[] parameters = {
                 new MySqlParameter("@patentid", patientId),
                 new MySqlParameter("@testType", selectedTestType)  };

            DataTable dt = Database.ExecuteQuery(query, parameters);
            gunaDataGridView1.Columns.Clear(); 

            gunaDataGridView1.DataSource = dt;

            
            if (gunaDataGridView1.Columns.Contains("Report"))
                gunaDataGridView1.Columns["Report"].Visible = false;

            if (!gunaDataGridView1.Columns.Contains("ViewReport"))
            {
                DataGridViewButtonColumn viewButton = new DataGridViewButtonColumn();
                viewButton.Name = "ViewReport";
                viewButton.HeaderText = "Open Lab Report";
                viewButton.Text = "View Report";
                viewButton.UseColumnTextForButtonValue = true;
                gunaDataGridView1.Columns.Add(viewButton);
            }


        }


        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gunaDataGridView1.Columns[e.ColumnIndex].Name == "ViewReport" && e.RowIndex >= 0)
            {
                string report = gunaDataGridView1.Rows[e.RowIndex].Cells["Report"].Value?.ToString();

                if (!string.IsNullOrEmpty(report))
                {
                    Report1 reportForm = new Report1(report);
                    reportForm.Show();
                }
                else
                {
                   label3.Text = "No report data available for this test.";
                }
            }
        }

        private void cuiButton1_MouseClick(object sender, MouseEventArgs e)
        {
            LoadHere();
        }

        
    }
}
