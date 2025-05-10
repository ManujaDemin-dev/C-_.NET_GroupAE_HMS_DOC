using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrustWell_Hospital_Doctor
{
    public partial class labreports1: UserControl
    {
        private int patientId;
        public labreports1(int patientId)
        {   
            this.patientId = patientId;
            InitializeComponent();
        }
    }
}
