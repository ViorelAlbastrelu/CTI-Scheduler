using CTISchedule.Models;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections;
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
	public partial class Schedule_init : Form
	{

		private Controller _controller;

		public Schedule_init(Controller controller)
		{
			InitializeComponent();
			_controller = controller;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'cTIScheduleDBDataSet.Profesors' table. You can move, or remove it, as needed.
			this.profesorsTableAdapter.Fill(this.cTIScheduleDBDataSet.Profesors);
			// TODO: This line of code loads data into the 'cTIScheduleDBProfesor.Profesor' table. You can move, or remove it, as needed.

		}

		private void tabPage1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void AddProfesor()
		{
		}
		private void btnSubmitProfesor_Click(object sender, EventArgs e)
		{
			Console.Out.Write(txtIdProfesor.Text);
			Console.Out.Write(int.Parse(txtIdProfesor.Text));
			Profesor profesorReq = new Profesor()
			{
				Id = int.Parse(txtIdProfesor.Text),
				Nume = txtNumeProfesor.Text,
				Prenume = txtPrenumeProfesor.Text,
			};
			var profesor = _controller.AddUpdateProfesor(profesorReq);
			if (profesor != null)
			{
				txtNumeProfesor.Text = null;
				txtPrenumeProfesor.Text = null;
				txtEmailProfesor.Text = null;
				txtTitluProfesor.Text = null;
			}
			else
			{
				MessageBox.Show("Error");
			}
		}

		private void btnDeleteProfesor_Click(object sender, EventArgs e)
		{
			_controller.DeleteProfesor(int.Parse(txtIdProfesor.Text));
			profesorsTableAdapter.Fill(cTIScheduleDBDataSet.Profesors);
		}

		private void btnCancelProfesor_Click(object sender, EventArgs e)
		{
			txtNumeProfesor.Text = null;
			txtPrenumeProfesor.Text = null;
			txtEmailProfesor.Text = null;
			txtTitluProfesor.Text = null;
			txtIdProfesor.Text = "0";
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnCancelDataImport_Click(object sender, EventArgs e)
		{
			txtDataImport.Text = null;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			DialogResult result = openFileDialog.ShowDialog();
			if (result == DialogResult.OK)
			{
				txtDataImport.Text = openFileDialog.FileName;
			}
		}

		private void btnSubmitDataImport_Click(object sender, EventArgs e)
		{
			XSSFWorkbook hssfwb;
			using (FileStream file = new FileStream(txtDataImport.Text, FileMode.Open, FileAccess.Read))
			{
				hssfwb = new XSSFWorkbook(file);
			}

			ISheet sheet = hssfwb.GetSheetAt(0);
			IRow headerRow = sheet.GetRow(0);
			IEnumerator rows = sheet.GetRowEnumerator();
			int colCount = headerRow.LastCellNum;
			int rowCount = sheet.LastRowNum;
			bool init = false;
			while (rows.MoveNext())
			{
				IRow row = (XSSFRow)rows.Current;
				if (init)
				{
					Profesor profesor = new Profesor();
					for (int j = 0; j < colCount; j++)
					{
						ICell cell = row.GetCell(j);
						if (cell != null)
						{
							string cellContent = cell.ToString();
							switch (j) {
								case 0:
									profesor.Nume = cellContent;
									break;
								case 1:
									profesor.Prenume = cellContent;
									break;
							}
						}
					}
					var insertedProfesor = _controller.AddUpdateProfesor(profesor);
					importDetails.Text += "  " + insertedProfesor.Id + ". " + insertedProfesor.Nume + " " + insertedProfesor.Prenume + Environment.NewLine;
				}
				init = true;
			}
			MessageBox.Show("Importare Finalizat");
			txtDataImport.Text = null;
		}

		private void tabControl1_Click(object sender, EventArgs e)
		{
			profesorsTableAdapter.Fill(cTIScheduleDBDataSet.Profesors);
		}
	}
}
