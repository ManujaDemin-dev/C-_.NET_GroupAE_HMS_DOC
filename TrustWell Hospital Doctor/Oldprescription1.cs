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
using System.Linq.Expressions;
using Mysqlx;


namespace TrustWell_Hospital_Doctor
{
    public partial class Oldprescription1: UserControl
    {
        private int patientId;
        public Oldprescription1(int patientId)
        {
            this.patientId = patientId;
            InitializeComponent();
            gunaDataGridView1.CellContentClick += gunaDataGridView1_CellContentClick;
            gunaDateTimePicker1.ValueChanged += gunaDateTimePicker1_ValueChanged;
            gunaButton1.Click += gunaButton1_Click;
            gunaButton2.Click += gunaButton2_Click;

            fillDoctorCombo();
            
        }

        private void fillDoctorCombo()
        {
            string query = "SELECT DISTINCT DoctorName FROM Doctors";
            DataTable dt = Database.ExecuteQuery(query, null);
            gunaComboBox1.Items.Clear();
            gunaComboBox1.Items.Add("All");

            foreach(DataRow row in dt.Rows)
            {
                gunaComboBox1.Items.Add(row["DoctorName"].ToString());
            }
            gunaComboBox1.SelectedIndex = 0;
        }

        private void LoadPrescriptionData()
        {
            string query = @"SELECT 
                medicalprescription.DoctorID,
                Doctors.DoctorName,
                medicalprescription.mediList,
                medicalprescription.CreatedAt  FROM medicalprescription
                INNER JOIN Doctors ON medicalprescription.DoctorID = Doctors.DoctorID
                WHERE medicalprescription.PatientID = @pid";

            List<MySqlParameter> parameters = new List<MySqlParameter>();
            parameters.Add(new MySqlParameter("@pid", patientId));

            if (gunaDateTimePicker1.CustomFormat != " ")
            {
                query += " AND medicalprescription.CreatedAt LIKE @date";
                parameters.Add(new MySqlParameter("@date", gunaDateTimePicker1.Value.ToString("yyyy-MM-dd") + "%"));
            }

            if (gunaComboBox1.SelectedItem != null && gunaComboBox1.SelectedItem.ToString() != "All")

            {
                query += " AND Doctors.DoctorName = @dname";
                parameters.Add(new MySqlParameter("@dname", gunaComboBox1.SelectedItem.ToString()));
            }

            try {

                DataTable dt = Database.ExecuteQuery(query, parameters.ToArray());
                gunaDataGridView1.DataSource = null; // clear previous
                gunaDataGridView1.Rows.Clear();
                gunaDataGridView1.Columns.Clear();

                if (dt.Rows.Count == 0)
                {
                    label4.ForeColor = Color.DarkRed;
                    label4.Text = "No prescriptions for this selection.";
                }

                else
                {

                   // gunaDataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                   // gunaDataGridView1.MaximumSize = new Size(gunaDataGridView1.Width, 300); // Max height
                    gunaDataGridView1.ScrollBars = ScrollBars.Vertical;

                    gunaDataGridView1.Columns.Add("CreatedAt", "Date");

                    gunaDataGridView1.Columns.Add("DoctorName", "Doctor Name");

                    gunaDataGridView1.Columns.Add("MediList", "Prescription");


                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn()
                    {
                        Text = "View",
                        UseColumnTextForButtonValue = true,
                        HeaderText = "View",
                    };
                    gunaDataGridView1.Columns.Add(btn);

                    foreach (DataRow row in dt.Rows)
                    {
                        gunaDataGridView1.Rows.Add(row["CreatedAt"], row["DoctorName"], row["mediList"]);
                        //gunaDataGridView1.Rows[gunaDataGridView1.Rows.Count - 1].Tag = row["PatientID"].ToString();
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

       private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && gunaDataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn ) 
            {
                string date = gunaDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string docName = gunaDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string prescription = gunaDataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                popUp pop = new popUp(date, docName, prescription);
                pop.ShowDialog();
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            label4.ForeColor = Color.DarkSlateGray;
            label4.Text = "Prescriptions for your selection.";
            LoadPrescriptionData();
        }

        private void Oldprescription1_Load(object sender, EventArgs e)
        {
            gunaDateTimePicker1.Format = DateTimePickerFormat.Custom;
            gunaDateTimePicker1.CustomFormat = " "; 
            gunaDateTimePicker1.Checked = false;

            LoadPrescriptionData();

        }

        private void gunaDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            gunaDateTimePicker1.Format = DateTimePickerFormat.Custom;
            gunaDateTimePicker1.CustomFormat = "yyyy-MM-dd";
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            gunaDateTimePicker1.Format = DateTimePickerFormat.Custom;
            gunaDateTimePicker1.CustomFormat = " ";
            gunaDateTimePicker1.Checked = false;
            gunaComboBox1.SelectedIndex = 0;

            label4.ForeColor = Color.DarkSlateGray;
            label4.Text = "All prescriptions";
            LoadPrescriptionData();
        }
    }
}
