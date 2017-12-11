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

        //private Controller controller;
        private int tabIndex = 0;

        public ComponentaZi(string zi)
        {
            InitializeComponent();
            adaugaColoaneDinamic(zi);
        }

        public void adaugaColoaneDinamic(string zi)
        {
            //tabelModuleZi.ColumnCount = controller.getCountSubgrupa(1);
            tabelModuleZi.ColumnCount = 6;

            for (int i = 0; i < tabelModuleZi.ColumnCount; i++)
            {
                tabelModuleZi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                for (int j = 0; j < tabelModuleZi.RowCount; j++)
                {
                    tabelModuleZi.Controls.Add(setNewLabelForDay(zi, i, j), i, j);
                }
            }
        }

        private Label setNewLabelForDay(string zi, int i, int j)
        {
            Label label = new Label();
            label.Text = j + "" + i;
            label.AutoSize = true;
            label.BackColor = SystemColors.ControlLightLight;
            label.Dock = DockStyle.Fill;
            label.Name = zi + j + "" + i;
            label.Size = new Size(176, 46);
            label.TabIndex = tabIndex++;
            label.Margin = new Padding(0);
            label.MouseEnter += new EventHandler(this.moduleCell_MouseEnter);
            label.MouseLeave += new EventHandler(this.moduleCell_MouseLeave);
            return label;
        }

        private void moduleCell_MouseEnter(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            l.BackColor = SystemColors.GradientActiveCaption;
        }

        private void moduleCell_MouseLeave(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            l.BackColor = SystemColors.ControlLightLight;
        }
    }
}
