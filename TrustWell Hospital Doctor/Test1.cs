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
        public Test1(int patientId)
        {
            InitializeComponent();
            this.patientId = patientId;
        }


        private void Test1_Load(object sender, EventArgs e)
        {
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
            MySqlParameter[] parameters = {
        new MySqlParameter("@patientId", patientId),
        new MySqlParameter("@testType", selectedTestType)
    };

            DataTable dt = Database.ExecuteQuery(query, parameters);

            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisX.Title = "Date";
            chart1.ChartAreas[0].AxisY.Title = "Value";
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -75;
            chart1.ChartAreas[0].AxisX.Interval = 1;
            
            chart1.ChartAreas[0].AxisX.TitleFont = new Font("Segoe UI", 12, FontStyle.Bold);
            chart1.ChartAreas[0].AxisY.TitleFont = new Font("Segoe UI", 12, FontStyle.Bold);



            Series lineSeries = new Series(selectedTestType);
            lineSeries.ChartType = SeriesChartType.Line;
            lineSeries.BorderWidth = 2;
            lineSeries.Color = Color.Blue;
            lineSeries.MarkerStyle = MarkerStyle.Circle;
            lineSeries.MarkerColor = Color.Red;
            lineSeries.MarkerSize = 6;
            chart1.ChartAreas[0].Area3DStyle.Enable3D = false;



            foreach (DataRow row in dt.Rows)
            {
                string dateStr = Convert.ToDateTime(row["Date"]).ToString("yyyy-MM-dd");
                if (float.TryParse(row["value"].ToString(), out float val))
                {
                    lineSeries.Points.AddXY(dateStr, val);
                }
            }

            chart1.Series.Add(lineSeries);

            gunaDataGridView1.DataSource = dt;
           

            gunaDataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            gunaDataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11);
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
    }
}
