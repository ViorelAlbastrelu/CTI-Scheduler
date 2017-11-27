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
        public static Export export;
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

        private void exportAnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startExport("Anul");
        }

        private void exportProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startExport("Profesorul");
        }

        private void exportGrupaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startExport("Grupa");
        }

        private void exportDisciplinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startExport("Disciplina");
        }

        public void StartSchedule(int anStudiu)
        {
            scheduler = new Scheduler(controller,this, anStudiu);
            scheduler.Show();
            Hide();
        }

        public void startExport(string nume)
        {
            export = new Export(controller, this, nume);
            export.Show();
            Hide();

        }

        private void Start_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void informatiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Informatii().Show();

        }
    }
}
