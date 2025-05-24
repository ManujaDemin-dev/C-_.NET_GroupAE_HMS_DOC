using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WindowsFormsApp1;
using MySql.Data.MySqlClient;

namespace TrustWell_Hospital_Doctor
{
    public partial class Test1: UserControl
    {
        private int patientId;
        private DataTable allTestData;
        public Test1(int patientId)
        {
            InitializeComponent();
            this.patientId = patientId;
        }


        private void Test1_Load(object sender, EventArgs e)

        {

            gunaNumeric1.Value = DateTime.Now.Year;
            gunaNumeric1.Minimum = 2022;
            gunaNumeric1.Maximum = 2200;

            string query = "SELECT DISTINCT * FROM Testtypes WHERE Type = '1value'";
            DataTable dt = Database.ExecuteQuery(query, null);

            gunaComboBox1.DisplayMember = "TestName";
            gunaComboBox1.ValueMember = "TestID";
            gunaComboBox1.DataSource = dt;

            gunaDataGridView1.Visible = false;
        }

        private void cuiButton1_MouseClick(object sender, MouseEventArgs e)
        {
            if (gunaComboBox1.SelectedValue == null)
            {
                MessageBox.Show("Please select a test type.");
                return;
            }

            string selectedTestType = gunaComboBox1.SelectedValue.ToString();
            string query = "SELECT value, Date FROM TestReports WHERE PatientID = @patientId AND TestType = @testType";
            MySqlParameter[] parameters = { new MySqlParameter("@patientId", patientId),
                    new MySqlParameter("@testType", selectedTestType) };

            allTestData = Database.ExecuteQuery(query, parameters);
            DrawChart(allTestData, selectedTestType);
            gunaDataGridView1.DataSource = allTestData;
            gunaDataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            gunaDataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11);
        }

        private void DrawChart(DataTable dt, string testType)
        {
            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisX.Title = "Date";
            chart1.ChartAreas[0].AxisY.Title = "Value";
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -75;
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.TitleFont = new Font("Segoe UI", 12, FontStyle.Bold);
            chart1.ChartAreas[0].AxisY.TitleFont = new Font("Segoe UI", 12, FontStyle.Bold);
            chart1.ChartAreas[0].Area3DStyle.Enable3D = false;

            Series series = new Series(testType)
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 2,
                Color = Color.Blue,
                MarkerStyle = MarkerStyle.Circle,
                MarkerColor = Color.Red,
                MarkerSize = 7
            };

            foreach (DataRow row in dt.Rows)
            {
                if (float.TryParse(row["value"].ToString(), out float val))
                {
                    string dateStr = Convert.ToDateTime(row["Date"]).ToString("yyyy-MM-dd");
                    series.Points.AddXY(dateStr, val);
                }
            }

            chart1.Series.Add(series);
        }


        private void cuiButton2_MouseClick(object sender, MouseEventArgs e)
        {
            Test2 pop = new Test2(patientId);
            pop.ShowDialog();
        }

        private void cuiButton3_MouseClick(object sender, MouseEventArgs e)
        {

            if (!gunaDataGridView1.Visible)
            {
                gunaDataGridView1.Visible = true;
                gunaDataGridView1.BringToFront(); 
            }
            else
            {
                gunaDataGridView1.Visible = false;
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void cuiButton4_MouseClick(object sender, MouseEventArgs e)
        {
            if (allTestData == null)
            {
                MessageBox.Show("Load chart data first.");
                return;
            }
           

            int selectedYear = (int)gunaNumeric1.Value;

            DataTable filteredData = allTestData.Clone();

            // Filter rows by year using DateTime parsing
            foreach (DataRow row in allTestData.Rows)
            {
                if (DateTime.TryParse(row["Date"].ToString(), out DateTime date))
                {
                    if (date.Year == selectedYear)
                    {
                        filteredData.ImportRow(row);
                    }
                }
            }



            string selectedTestType = gunaComboBox1.SelectedValue?.ToString() ?? "Filtered";
            DrawChart(filteredData, selectedTestType);
            gunaDataGridView1.DataSource = filteredData;
        }

        private void cuiButton5_MouseClick(object sender, MouseEventArgs e)
        {
            if (allTestData == null || allTestData.Rows.Count == 0)
            {
                MessageBox.Show("No data to reset. Load chart data first.");
                return;
            }

            string selectedTestType = gunaComboBox1.SelectedValue?.ToString() ?? "All Data";
            DrawChart(allTestData, selectedTestType);
            gunaDataGridView1.DataSource = allTestData;
        }
    }
}
