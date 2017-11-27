using CTISchedule.Models;
using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Layout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private int pid;

        public Scheduler(Controller controller, Start start, int anStudiu)
		{
			InitializeComponent();

            _controller = controller;
            _anStudiu = anStudiu;
            _start = start;
		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

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

        private void saliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2Sala.BringToFront();
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
            // TODO: This line of code loads data into the 'ctischeduleDataSetDisciplinaMain.Disciplina' table. You can move, or remove it, as needed.
            this.disciplinaTableAdapter1.Fill(this.ctischeduleDataSetDisciplinaMain.Disciplina);
            // TODO: This line of code loads data into the 'ctischeduleDataSetActivitate.Activitate' table. You can move, or remove it, as needed.
            this.activitateTableAdapter.Fill(this.ctischeduleDataSetActivitate.Activitate);
            // TODO: This line of code loads data into the 'ctischeduleDataSetSala.Sala' table. You can move, or remove it, as needed.
            this.salaTableAdapter.Fill(this.ctischeduleDataSetSala.Sala);
            // TODO: This line of code loads data into the 'ctischeduleDataSetDisciplina.Disciplina' table. You can move, or remove it, as needed.
            this.disciplinaTableAdapter.Fill(this.ctischeduleDataSetDisciplina.Disciplina);
            // TODO: This line of code loads data into the 'ctischeduleDataSetProfesor.Profesor' table. You can move, or remove it, as needed.
            this.profesorTableAdapter.Fill(this.ctischeduleDataSetProfesor.Profesor);
            // TODO: This line of code loads data into the 'ctischeduleDataSetZile.Zile' table. You can move, or remove it, as needed.
        }

        private void btnSaveProfesor_Click(object sender, EventArgs e)
        {
            int Id = 0;
            if (txtIdProfesor.Text != "") Id = int.Parse(txtIdProfesor.Text);
            Profesor profesorReq = new Profesor()
            {
                Id = Id,
                Nume = txtNumeProfesor.Text,
                Titlu = txtTitluProfesor.Text,
            };
            var profesor = _controller.AddUpdateProfesor(profesorReq);
            if (profesor != null)
            {
                txtNumeProfesor.Text = null;
                txtTitluProfesor.Text = null;
                this.profesorTableAdapter.Fill(this.ctischeduleDataSetProfesor.Profesor);
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
            txtTitluProfesor.Clear();
        }

        private void btnDeleteProfesor_Click(object sender, EventArgs e)
        {
            if(txtIdProfesor.Text != "")
            {
                _controller.DeleteProfesor(int.Parse(txtIdProfesor.Text));
                this.profesorTableAdapter.Fill(this.ctischeduleDataSetProfesor.Profesor);
            }
            else
            {
                MessageBox.Show("Va rugam sa selectati un profesor.");
            }
        }

        private void clearDisciplina()
        {
            txtIdDisciplina.Clear();
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
                An = int.Parse(cboxDAnStudiu.SelectedItem.ToString()),
                NumeScurt = txtNumeScurt.Text,
                Semestru = int.Parse(txtSemestru.Text)
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

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orar exportSchedule = new Orar();
            Orar intermediateSchedule = new Orar();
            string startupPath = Environment.CurrentDirectory;
            string newPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(startupPath, "..\\..\\..\\"));

            orar1 = intermediateSchedule;
            exportSchedule = intermediateSchedule;
            exportSchedule = orar1;

            exportSchedule.Size = new Size(orar1.Width, 1240);

            using (Graphics graphics = exportSchedule.CreateGraphics())
            {

                using (Bitmap bitmapImage = new Bitmap(exportSchedule.Width, exportSchedule.Height, graphics))
                {
                    exportSchedule.DrawToBitmap(bitmapImage, new System.Drawing.Rectangle(0, 0, exportSchedule.Width, exportSchedule.Height));
                    bitmapImage.Save(newPath + "ScheduleImage.jpg");
                }
            }

            if (File.Exists(newPath + "ScheduleImage.jpg"))
            {
                string orarImagePath = newPath + "\\ScheduleImage.jpg";
                var pdf = new PdfDocument(new PdfWriter(newPath + "\\Schedule.pdf"));
                var document = new Document(pdf);
                iText.Layout.Element.Image orarImage = new iText.Layout.Element.Image(ImageDataFactory.Create(orarImagePath));
                orarImage.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                orarImage.SetWidthPercent(80);
                document.Add(orarImage);
                document.Close();
                File.Delete(newPath + "\\ScheduleImage.jpg");
                MessageBox.Show("The schedule has been exported successfully in the folder " + newPath);
            }
            exportSchedule.Dispose();
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

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void UpdateDisciplineProfesor()
		{
			if (int.TryParse(txtIdProfesor.Text.ToString(), out pid) && pid > 0)
			{
				try
				{
                    //this.disciplinaTableAdapter.FillByProfesorId(this.ctischeduleDataSetDisciplina.Disciplina,pid);

                    lboxPDiscipline.DataSource = _controller.UpdateProfesorDisciplina(pid, _anStudiu).ToList();
					lboxPDiscipline.DisplayMember = "Nume";
				}
				catch (Exception) { }
			}
		}

		private void UpdateAvailableDiscipline()
		{
			if (int.TryParse(txtIdProfesor.Text.ToString(), out pid) && pid > 0)
			{
				try
				{
					cboxPDiscipline.DataSource = _controller.GetAvailableProfeosrDisciplinas(pid, _anStudiu).ToList();
					cboxPDiscipline.DisplayMember = "Nume";
				}
				catch (Exception) { }
			}
		}

		private void UpdateProfesorModule()
		{

            UpdateDisciplineProfesor();
			UpdateAvailableDiscipline();
			cboxPDiscipline.Text = "";
		}

		private void txtIdProfesor_TextChanged(object sender, EventArgs e)
		{
			UpdateProfesorModule();
		}

		private void lboxPDiscipline_DoubleClick(object sender, EventArgs e)
		{
			if (int.TryParse(txtIdProfesor.Text.ToString(), out pid) && pid > 0)
			{
				_controller.DeleteLinkDisciplinaProfesor(pid, (lboxPDiscipline.SelectedItem as ProfesorList).Id);
				UpdateProfesorModule();
			}
		}

		private void btnLinkProfesorDisciplina_Click(object sender, EventArgs e)
		{
			if (int.TryParse(txtIdProfesor.Text.ToString(), out pid) && pid > 0)
			{
				try
				{
                    _controller.LinkDisciplinaProfesor(pid, int.Parse(cboxPDiscipline.SelectedValue.ToString()));
                }
                catch (Exception) { }
			}
			UpdateProfesorModule();
		}

        private void onlyLetter_Restriction(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void onlyDigit_Restriction(object sender, KeyPressEventArgs e)
        {
            if(!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            //int Idsala = 1;
            //if (txtIdSala.Text != "")
            //    Idsala = int.Parse(txtIdSala.Text);
            MessageBox.Show(activitatesala.SelectedValue.ToString());
            Sala sala = new Sala()
            {
              //      Id = Idsala,
                    Nume= numesala.Text,
                    Capacitate= int.Parse(capacitatesala.Text),
                    Activitate= int.Parse(activitatesala.SelectedValue.ToString()), 

            };

          //  var salarq = _controller.;
      //      if (disciplina != null)
        //    {
        //        this.disciplinaTableAdapter.Fill(this.ctischeduleDataSetDisciplina.Disciplina);
        //        this.clearDisciplina();
        //    }
        //    else
       //     {
       //         MessageBox.Show("Error");
      //      }

            _controller.AddSala(sala);
        }


        // Stergere Sala
        private void button5_Click(object sender, EventArgs e)
        {
            if (txtIdSala.Text != "")
            {
                _controller.DeleteDisciplina(int.Parse(txtIdSala.Text));
             //   this.disciplinaTableAdapter.Fill(this.ctischeduleDataSetDisciplina.Disciplina);
            }
            else
            {
                MessageBox.Show("Va rugam sa selectati o sala.");
            }
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            numesala.Clear();
            activitatesala.SelectedIndex = -1;
            capacitatesala.Clear();
        }

        private void dgvDiscipline_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
