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
	public partial class Scheduler : Form
	{

        private Controller _controller;
        private int _anStudiu;
        private Start _start;

        public Scheduler(Controller controller, Start start, int anStudiu)
		{
			InitializeComponent();

            _controller = controller;
            _anStudiu = anStudiu;
            _start = start;

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
            panelProfesori.BringToFront();
		}

        private void Scheduler_Load(object sender, EventArgs e)
        {

        }

        private void orarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelSchedule.BringToFront();
        }

        private void Scheduler_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ctischeduleDataSetZile.Zile' table. You can move, or remove it, as needed.
            this.zileTableAdapter.Fill(this.ctischeduleDataSetZile.Zile);
            // TODO: This line of code loads data into the 'ctischeduleDataSetSala.Sala' table. You can move, or remove it, as needed.
            this.salaTableAdapter.Fill(this.ctischeduleDataSetSala.Sala);
            // TODO: This line of code loads data into the 'ctischeduleDataSetActivitate.Activitate' table. You can move, or remove it, as needed.
            this.activitateTableAdapter.Fill(this.ctischeduleDataSetActivitate.Activitate);
            // TODO: This line of code loads data into the 'ctischeduleDataSet.Profesor' table. You can move, or remove it, as needed.
            this.profesorTableAdapter.Fill(this.ctischeduleDataSet.Profesor);
            // TODO: This line of code loads data into the 'ctischeduleDataSetDisciplina.Disciplina' table. You can move, or remove it, as needed.
            this.disciplinaTableAdapter.Fill(this.ctischeduleDataSetDisciplina.Disciplina);

        }

        private void btnSaveProfesor_Click(object sender, EventArgs e)
        {
            int Id = 0;
            if (txtIdProfesor.Text != "") Id = int.Parse(txtIdProfesor.Text);
            Profesor profesorReq = new Profesor()
            {
                Id = Id,
                Nume = txtNumeProfesor.Text,
                Prenume = txtPrenumeProfesor.Text,
            };
            var profesor = _controller.AddUpdateProfesor(profesorReq);
            if (profesor != null)
            {
                txtNumeProfesor.Text = null;
                txtPrenumeProfesor.Text = null;
                this.profesorTableAdapter.Fill(this.ctischeduleDataSet.Profesor);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnCancelProfesor_Click(object sender, EventArgs e)
        {
            txtIdProfesor.Clear();
            txtNumeProfesor.Clear();
            txtPrenumeProfesor.Clear();
        }

        private void btnDeleteProfesor_Click(object sender, EventArgs e)
        {
            if(txtIdProfesor.Text != "")
            {
                _controller.DeleteProfesor(int.Parse(txtIdProfesor.Text));
                this.profesorTableAdapter.Fill(this.ctischeduleDataSet.Profesor);
            }
            else
            {
                MessageBox.Show("Va rugam sa selectati un profesor.");
            }
        }

        private void clearDisciplina()
        {
            txtIdDisciplina.Clear();
            txtCredite.Clear();
            txtNumeDisciplina.Clear();
            cboxDAnStudiu.SelectedIndex = -1;
        }

        private void btnCancelDisciplina_Click(object sender, EventArgs e)
        {
            this.clearDisciplina();
        }

        private void btnDeleteDisciplina_Click(object sender, EventArgs e)
        {
            if(txtIdDisciplina.Text != "")
            {
                _controller.DeleteDisciplina(int.Parse(txtIdDisciplina.Text));
                this.disciplinaTableAdapter.Fill(this.ctischeduleDataSetDisciplina.Disciplina);
            }
            else
            {
                MessageBox.Show("Va rugam sa selectati o disciplina.");
            }
            
        }

        private void btnSaveDisciplina_Click(object sender, EventArgs e)
        {
            int Id = 0;
            if (txtIdDisciplina.Text != "") Id = int.Parse(txtIdDisciplina.Text);
            Disciplina disciplinaReq = new Disciplina()
            {
                Id = Id,
                Nume = txtNumeDisciplina.Text,
                Credite = int.Parse(txtCredite.Text),
                An = int.Parse(cboxDAnStudiu.SelectedItem.ToString())
            };
            var disciplina = _controller.AddUpdateDisciplina(disciplinaReq);
            if (disciplina != null)
            {
                this.disciplinaTableAdapter.Fill(this.ctischeduleDataSetDisciplina.Disciplina);
                this.clearDisciplina();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void disciplineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelDiscipline.BringToFront();
        }

        private void Scheduler_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            _start.Show();
        }

		private void orar1_Load(object sender, EventArgs e)
		{
			orar1.VerticalScroll.Maximum = 10;
			orar1.HorizontalScroll.Maximum = 10;
			orar1.VerticalScroll.Enabled = false;
			orar1.VerticalScroll.Visible = false;
			orar1.AutoScroll = true;
		}
	}
}
