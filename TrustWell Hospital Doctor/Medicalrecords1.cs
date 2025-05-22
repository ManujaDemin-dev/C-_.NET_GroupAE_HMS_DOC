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
using MySqlX.XDevAPI.Common;

namespace TrustWell_Hospital_Doctor
{
    public partial class Medicalrecords1: UserControl
    {
        private int patientId;
        private int DocId;
        public Medicalrecords1(int patientId, int docId)
        {
            InitializeComponent();
            gunaDataGridView1.CellContentClick += gunaDataGridView1_CellContentClick;
            gunaButton1.Click += gunaButton1_Click;
            gunaButton2.Click += gunaButton2_Click;
            gunaDateTimePicker1.ValueChanged += gunaDateTimePicker1_ValueChanged;   

            this.patientId = patientId;

            fillDoctorCombo();
            DocId = docId;
        }

        private void Medicalrecords1_Load(object sender, EventArgs e)
        {
            gunaDateTimePicker1.Format = DateTimePickerFormat.Custom;
            gunaDateTimePicker1.CustomFormat = " ";
            gunaDateTimePicker1.Checked = false;

            LoadMedicalData();
           

        }

        private void gunaDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            gunaDateTimePicker1.Format = DateTimePickerFormat.Custom;
            gunaDateTimePicker1.CustomFormat = "yyyy-MM-dd";
        }

        private void fillDoctorCombo()
        {
            string query = "SELECT DISTINCT DoctorName FROM Doctors";
            DataTable dt = Database.ExecuteQuery(query, null);
            gunaComboBox1.Items.Clear();
            gunaComboBox1.Items.Add("All");

            foreach (DataRow row in dt.Rows)
            {
                gunaComboBox1.Items.Add(row["DoctorName"].ToString());
            }
            gunaComboBox1.SelectedIndex = 0;
        }



        private void LoadMedicalData()
        {
            string query = @"SELECT 
               MedicalRecords.DoctorID,
               Doctors.DoctorName,
               MedicalRecords.Diagnosis,
               MedicalRecords.Observations,
               MedicalRecords.Treatment,
               MedicalRecords.CreatedAt  FROM MedicalRecords
               INNER JOIN Doctors ON MedicalRecords.DoctorID = Doctors.DoctorID
               WHERE MedicalRecords.PatientID = @pid";

            List<MySqlParameter> parameters = new List<MySqlParameter>();
            parameters.Add(new MySqlParameter("@pid", patientId));

            if (gunaDateTimePicker1.CustomFormat != " ")
            {
                query += " AND MedicalRecords.CreatedAt LIKE @date";
                parameters.Add(new MySqlParameter("@date", gunaDateTimePicker1.Value.ToString("yyyy-MM-dd") + "%"));
            }

            if (gunaComboBox1.SelectedItem != null && gunaComboBox1.SelectedItem.ToString() != "All")
            {
                query += " AND Doctors.DoctorName = @dname";
                parameters.Add(new MySqlParameter("@dname", gunaComboBox1.SelectedItem.ToString()));
            }

            try
            {
                DataTable dt = Database.ExecuteQuery(query, parameters.ToArray());
                gunaDataGridView1.DataSource = null; // clear previous
                gunaDataGridView1.Rows.Clear();
                gunaDataGridView1.Columns.Clear();

                if (dt.Rows.Count == 0)
                {
                    label4.ForeColor = Color.DarkRed;
                    label4.Text = "No medical records for this selection.";
                }

                else
                {
                    gunaDataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    gunaDataGridView1.MaximumSize = new Size(gunaDataGridView1.Width, 300); // Max height
                    gunaDataGridView1.ScrollBars = ScrollBars.Vertical;

                    gunaDataGridView1.Columns.Add("CreatedAt", "Date");
                    gunaDataGridView1.Columns.Add("DoctorName", "Doctor Name");
                    gunaDataGridView1.Columns.Add("Diagnosis", "Diagnosis");
                    gunaDataGridView1.Columns.Add("Observations", "Observations");
                    gunaDataGridView1.Columns.Add("Treatment", "Treatment");

                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn()
                    {
                        HeaderText = "Action",
                        Text = "View",
                        UseColumnTextForButtonValue = true
                    };
                    gunaDataGridView1.Columns.Add(btn);

                    foreach (DataRow row in dt.Rows)
                    {
                        gunaDataGridView1.Rows.Add(row["CreatedAt"], row["DoctorName"], row["Diagnosis"], row["Observations"], row["Treatment"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            label4.ForeColor = Color.DarkSlateGray;
            label4.Text = "Medical records for your selection.";
            LoadMedicalData();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            gunaDateTimePicker1.Format = DateTimePickerFormat.Custom;
            gunaDateTimePicker1.CustomFormat = " ";
            gunaDateTimePicker1.Checked = false;
            gunaComboBox1.SelectedIndex = 0;

            label4.ForeColor = Color.DarkSlateGray;
            label4.Text = "All Medical records.";
            LoadMedicalData();
            
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            addRecord popup = new addRecord(patientId, DocId);
            popup.StartPosition = FormStartPosition.CenterParent;

            DialogResult result = popup.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadMedicalData();
                MessageBox.Show("Record added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 5) // Assuming the button is in the 5th column
            {
                string date = gunaDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string doctorName = gunaDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string diagnosis = gunaDataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                string observations = gunaDataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                string treatments = gunaDataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

                MedicalRecordPopUp popup = new MedicalRecordPopUp(date, doctorName, diagnosis, observations, treatments);
                popup.StartPosition = FormStartPosition.CenterParent;
                popup.ShowDialog();

                

                
            }
        }
    }
}
