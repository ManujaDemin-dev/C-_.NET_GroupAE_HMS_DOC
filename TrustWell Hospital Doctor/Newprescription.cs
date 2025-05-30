using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using TrustWell_Hospital_Doctor;



namespace TrustWell_Hospital_Doctor
{
    public partial class Newprescription: Form
    {
       
        private string name;
        private int patientid;
        private string age;
        private string contact;
        
        public Newprescription(int patientid, string name, string age, string contact)
        {
            InitializeComponent();
            this.name = name;
            this.age = age;
            this.patientid = patientid;
            this.contact = contact;
        }

        private void Newprescription_Load(object sender, EventArgs e)
        {
           
           
           label11.Text = DateTime.Now.ToString("yyyy-MM-dd  HH:mm"); 

            this.label2.Text = $"Dr. {UserSession.Username}";
            this.label3.Text = $"{UserSession.specialization}";
            this.label4.Text = $"Name :  {name}";
            this.label5.Text = $"Age :  {age} Years";
            this.label6.Text = $"Contact No : {contact}";
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.Focus();


            // Set height to full screen height (based on primary screen)
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
             this.AutoScaleMode = AutoScaleMode.Dpi;
            // Optionally center the form horizontally
            
            this.Top = 0; // Align to top of the screen

            
        }

        private void gunaButton1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                string medilist = textBox1.Text;

                if (string.IsNullOrWhiteSpace(medilist))
                {
                    MessageBox.Show("Medication list can't be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }
                string query = "INSERT INTO medicalprescription (PatientID, DoctorID, Distribution, mediList, CreatedAt) " +
                               "VALUES (@patientid, @docid, @dist, @medilist, NOW())";
                MySqlParameter[] parameters = { new MySqlParameter("@patientid", patientid),
                        new MySqlParameter("@docid", UserSession.DocId),
                        new MySqlParameter("@dist", "pending"),
                        new MySqlParameter("@medilist", medilist)
                    };

                Database.ExecuteNonQuery(query, parameters);

                printDocument1.Print();
                MessageBox.Show("Medical prescription is printed and sent to the pharmacy.");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {


            Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(bmp, new Rectangle(0, 0, panel1.Width, panel1.Height));
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

      
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
            Textboxfunc.HandleEnterBullets(textBox1, e);

        }

        private void gunaButton2_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                string medilist = textBox1.Text; 

                if (string.IsNullOrWhiteSpace(medilist))
                {
                    MessageBox.Show("Medication list can't be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }
                string query = "INSERT INTO medicalprescription (PatientID, DoctorID, Distribution, mediList, CreatedAt)  VALUES (@patientid, @docid, @dist, @medilist, NOW())";
                MySqlParameter[] parameters = { new MySqlParameter("@patientid", patientid),
                    new MySqlParameter("@docid", UserSession.DocId),
                    new MySqlParameter("@dist", "not"),
                    new MySqlParameter("@medilist",medilist)

                };

                Database.ExecuteNonQuery(query, parameters);

                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
                //printDocument1.Print();
                MessageBox.Show("Medical prescription is printed.");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
