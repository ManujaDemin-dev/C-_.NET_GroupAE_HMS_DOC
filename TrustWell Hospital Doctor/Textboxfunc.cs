using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrustWell_Hospital_Doctor
{
    public class Textboxfunc
    {
        private static bool lastKeyWasEnter = false;

        public static void HandleEnterBullets(Control control, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && control is TextBoxBase textBox)
            {
                if (lastKeyWasEnter)
                {
                    // Double Enter pressed, insert bullet on new line
                    textBox.SelectedText = "\n\u2022 ";
                    lastKeyWasEnter = false;
                    e.SuppressKeyPress = true; // Prevent default behavior
                }
                else
                {
                    lastKeyWasEnter = true;
                }
            }
            else
            {
                lastKeyWasEnter = false;
            }
        }
    }
}
