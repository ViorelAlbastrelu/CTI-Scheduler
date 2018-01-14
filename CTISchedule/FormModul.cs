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
    public partial class FormModul : UserControl
    {
        private Controller _controller;
    

        public FormModul(Controller controller)
        {
            _controller = new Controller();
            InitializeComponent();
        }

        private void btnSaveModule_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteModule_Click(object sender, EventArgs e)
        {
            if (txtIdProfesor.Text != "") //todo modul id
            {
                _controller.DeleteModul(int.Parse(txtIdProfesor.Text));
                this.clearForModul();
            }
            else
            {
                MessageBox.Show("Va rugam sa selectati un profesor.");
            }
        }

        private void btnCancelModule_Click(object sender, EventArgs e)
        {

        }

        private void clearForModul()
        {
            //TODO add lines to clear components if necessary 
        }
    }
}
