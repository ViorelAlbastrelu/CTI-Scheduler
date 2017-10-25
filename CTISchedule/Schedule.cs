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
	public partial class Schedule : Form
	{

		private Controller _controller;

		public Schedule(Controller controller)
		{
			InitializeComponent();
			_controller = controller;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'cTIScheduleDBProfesor.Profesor' table. You can move, or remove it, as needed.

		}

		private void tabPage1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnSubmitProfesor_Click(object sender, EventArgs e)
		{
			ProfesorReq profesorReq = new ProfesorReq()
			{
				Nume = txtNumeProfesor.Text,
				Prenume = txtPrenumeProfesor.Text,
				Email = txtEmailProfesor.Text,
				Titlu = txtTitluProfesor.Text
			};
			if (_controller.AddProfesor(profesorReq))
			{
				txtNumeProfesor.Text = null;
				txtPrenumeProfesor.Text = null;
				txtEmailProfesor.Text = null;
				txtTitluProfesor.Text = null;
				MessageBox.Show("Success");
			}
			else
			{
				MessageBox.Show("Error");
			}
		}
	}
}
