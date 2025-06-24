using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unicom_TIC_Management_System.Model
{
    public class publicMethods
    {
        private void ClearAllTextBoxes(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Clear();
                }
                else if (ctrl.HasChildren)
                {
                    ClearAllTextBoxes(ctrl); 
                }
            }
        }

    }
}
