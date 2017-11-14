using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTISchedule
{
    public partial class Orar : UserControl
    {
        public Orar()
        {
            InitializeComponent();
        }

        private void moduleCell_MouseEnter(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            l.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
        }

        private void moduleCell_MouseLeave(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            l.BackColor = System.Drawing.SystemColors.ControlLightLight;
        }
    }
}
