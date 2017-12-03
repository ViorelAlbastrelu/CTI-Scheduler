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
    public partial class ComponentaZi : UserControl
    {
        private Controller controller;
        private int tabIndex = 0;

        public ComponentaZi(Controller controller)
        {
            this.controller = controller;
            InitializeComponent();

            adaugaColoaneDinamic("luni");
        }

        public void adaugaColoaneDinamic(string zi)
        {
            tabelModuleZi.ColumnCount = controller.getCountSubgrupa(1);

            for (int i = 0; i < tabelModuleZi.ColumnCount; i++)
            {
                for (int j = 0; j < tabelModuleZi.RowCount; j++)
                {
                    tabelModuleZi.Controls.Add(setNewLabelForDay(zi, i, j), i, j);
                }
            }
        }

        private Label setNewLabelForDay(string zi, int i, int j)
        {
            Label label = new System.Windows.Forms.Label();
            label.AutoSize = true;
            label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            label.Dock = System.Windows.Forms.DockStyle.Fill;
            label.Name = zi + i + "" + j;
            label.Size = new System.Drawing.Size(176, 46);
            label.TabIndex = tabIndex++;
            label.MouseEnter += new System.EventHandler(this.moduleCell_MouseEnter);
            label.MouseLeave += new System.EventHandler(this.moduleCell_MouseLeave);
            return label;
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
