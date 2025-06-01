using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TrustWell_Hospital_Doctor
{
    class Class1
    {
    }

    public class DateTimeUpdater
    {
        private Timer timer;

        public void StartDateTimeClock(Label Date,Label Time)
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (s, e) =>
            {
                Date.Text = DateTime.Now.ToString("yyyy-MM-dd");
                Time.Text = DateTime.Now.ToString("hh:mm tt");
               
               
            };
            timer.Start();
        }
    }


}
