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

namespace TrustWell_Hospital_Doctor
{
    public partial class Newprescription: Form
    {
        private bool lastKeyWasEnter = false;
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
            //this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            this.Top = 0; // Align to top of the screen
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();

           

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {


            Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(bmp, new Rectangle(0, 0, panel1.Width, panel1.Height));
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lastKeyWasEnter)
                {
                    // Double Enter pressed insert bullet on new line
                    textBox1.SelectedText = "\n\u2022 ";
                    lastKeyWasEnter = false;
                    e.SuppressKeyPress = true; // Stop default Enter behavior
                }
                else
                {
                    lastKeyWasEnter = true;
                }
            }
            else
            {
                lastKeyWasEnter = false; // Reset if other key pressed
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
