using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrustWell_Hospital_Doctor
{
    public partial class MedicalRecordPopUp: Form
    {
        public MedicalRecordPopUp(string date, string doctorName, string diagnosis, string observation, string treatment)
        {
            InitializeComponent();
            
            label8.Text = date;
            label9.Text = doctorName;
            label2.Text = diagnosis;

            observations.Text = observation;
            treatments.Text = treatment;
        }

        private void MedicalRecordPopUp_Load(object sender, EventArgs e)
        {
            observations.SelectionStart = observations.Text.Length;
            observations.SelectionLength = 0;

           
        }
    }
}
