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
	public partial class Scheduler : Form
	{
		public Scheduler()
		{
			InitializeComponent();
			this.dgvScheduler.RowHeadersVisible = false;
			this.dgvScheduler.AllowUserToResizeRows = false;
			this.dgvScheduler.AllowUserToResizeColumns = false;
			this.dgvScheduler.Rows.Add("","I", "08:00 - 09:50");
			this.dgvScheduler.Rows.Add("","II", "10:00 - 11:50");
			this.dgvScheduler.Rows.Add("L","III", "12:00 - 13:50");
			this.dgvScheduler.Rows.Add("U","IV", "14:00 - 15:50");
			this.dgvScheduler.Rows.Add("","V", "16:00 - 17:50");
			this.dgvScheduler.Rows.Add("","VI", "18:00 - 19:50");
		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{
			dgvScheduler.CurrentCell.Selected = false;

		}

		private void dgvScheduler_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex > 2)
			{
			}
		}

		private void dgvScheduler_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			if (e.ColumnIndex == 0 && e.RowIndex % 5 != 0 && e.RowIndex != -1 )
			{
				e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
			}
		}

		private void profesoriToolStripMenuItem_Click(object sender, EventArgs e)
		{
			panelSchedule.Visible = false;
		}
	}
}
