using CTISchedule.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTISchedule
{
	public partial class Start : Form
	{

        private static CTIScheduleDBEntities db = new CTIScheduleDBEntities();
        private Controller controller = new Controller(db);
        public static Scheduler scheduler;
        public static Start start;
        public Start()
		{
			InitializeComponent();
		}

		private void Start_Load(object sender, EventArgs e)
		{
            if (scheduler != null) scheduler.Close();
		}

		private void btnYear_Click(object sender, EventArgs e)
		{
			switch ((sender as Button).Text) {
				case "Anul Universitar I":
					StartSchedule(1);
					break;
				case "Anul Universitar II":
					StartSchedule(2);
					break;
				case "Anul Universitar III":
					StartSchedule(3);
					break;
				case "Anul Universitar IV":
					StartSchedule(4);
					break;
			}
		}

        public void StartSchedule(int anStudiu)
        {
            scheduler = new Scheduler(controller,this, anStudiu);
            scheduler.Show();
            Hide();
        }

        private void Start_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

	}
}
