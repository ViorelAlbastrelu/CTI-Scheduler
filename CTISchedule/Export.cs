using iText.IO.Font;
using iText.Kernel.Font;
using iText.Layout.Borders;
using System;
using iText.Layout.Properties;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iText.Layout.Element;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Kernel.Geom;
using System.IO;
using iText.IO.Image;
using CTISchedule.Models;
using System.Data.SqlClient;
using System.Configuration;

namespace CTISchedule
{
    public partial class Export : Form
    {

        private Start _start;
        private string _name;
        private string connectionString = ConfigurationManager.ConnectionStrings["CTISchedule.Properties.Settings.CTIScheduleDBConnectionString"].ConnectionString;
        public Export(Controller controller, Start start, string name)
        {
            InitializeComponent();
            _start = start;
            _name = name;
            this.activeLabel.Text = _name;
            if (name == "Anul")
            {
                string query = "SELECT anstudiu FROM generatie";
                sqlInterogation(query);

            }

            if (name == "Profesorul")
            {
                string query = "SELECT nume FROM profesor";
                sqlInterogation(query);
            }

            if (name == "Grupa")
            {
                string query = "SELECT nume FROM grupa";
                sqlInterogation(query);
            }

            if (name == "Disciplina")
            {
                string query = "SELECT nume FROM disciplina";
                sqlInterogation(query);
            }

            if (name == "Sala")
            {
                string query = "SELECT nume FROM sala";
                sqlInterogation(query);
            }
        }

        private void sqlInterogation(string sqlQuery)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand();
                SqlDataReader reader;
                command.CommandText = sqlQuery;
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                connection.Open();
                reader = command.ExecuteReader();
                int count = reader.FieldCount;
                while (reader.Read())
                {
                    for (int i = 0; i < count; i++)
                    {
                        this.activeComboBox.Items.Add(reader.GetValue(i));
                    }
                }
                connection.Close();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void exportFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            _start.Show();
        }
        
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            _start.Show();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            if (activeComboBox.SelectedItem != null)
            {
                if (_name == "Profesorul")
                {
                    ExportOrarProfesor exportOrarProfesor = new ExportOrarProfesor((string) activeComboBox.SelectedItem);
                    string startupPath = Environment.CurrentDirectory;
                    string newPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(startupPath, "..\\..\\..\\"));
                    string imgName = "OrarProfesorImage.jpg";
                    string pdfName = "Orar Profesor " + activeComboBox.SelectedItem + ".pdf";

                    using (Graphics graphics = exportOrarProfesor.CreateGraphics())
                    {

                        using (Bitmap bitmapImage = new Bitmap(exportOrarProfesor.Width, exportOrarProfesor.Height, graphics))
                        {
                            exportOrarProfesor.DrawToBitmap(bitmapImage, new System.Drawing.Rectangle(0, 0, exportOrarProfesor.Width, exportOrarProfesor.Height));
                            bitmapImage.Save(newPath + imgName);
                        }
                    }

                    if (File.Exists(newPath + imgName))
                    {
                        string orarImagePath = newPath + "\\" + imgName;
                        var pdf = new PdfDocument(new PdfWriter(newPath + "\\" + pdfName));
                        var document = new Document(pdf, PageSize.A3);
                        iText.Layout.Element.Image orarImage = new iText.Layout.Element.Image(ImageDataFactory.Create(orarImagePath));
                        orarImage.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                        orarImage.SetWidthPercent(100);
                        document.Add(orarImage);
                        document.Close();
                        File.Delete(newPath + "\\" + imgName);
                        MessageBox.Show("The schedule has been exported successfully in the folder " + newPath);
                    }
                }
                if (_name == "Sala")
                {
                    ExportOrarSala exportOrarSala = new ExportOrarSala((string)activeComboBox.SelectedItem);
                    string startupPath = Environment.CurrentDirectory;
                    string newPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(startupPath, "..\\..\\..\\"));
                    string imgName = "OrarSalaImage.jpg";
                    string pdfName = "Orar Sala " + activeComboBox.SelectedItem + ".pdf";

                    using (Graphics graphics = exportOrarSala.CreateGraphics())
                    {

                        using (Bitmap bitmapImage = new Bitmap(exportOrarSala.Width, exportOrarSala.Height, graphics))
                        {
                            exportOrarSala.DrawToBitmap(bitmapImage, new System.Drawing.Rectangle(0, 0, exportOrarSala.Width, exportOrarSala.Height));
                            bitmapImage.Save(newPath + imgName);
                        }
                    }

                    if (File.Exists(newPath + imgName))
                    {
                        string orarImagePath = newPath + "\\" + imgName;
                        var pdf = new PdfDocument(new PdfWriter(newPath + "\\" + pdfName));
                        var document = new Document(pdf, PageSize.A1);
                        iText.Layout.Element.Image orarImage = new iText.Layout.Element.Image(ImageDataFactory.Create(orarImagePath));
                        orarImage.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                        orarImage.SetWidthPercent(100);
                        document.Add(orarImage);
                        document.Close();
                        File.Delete(newPath + "\\" + imgName);
                        MessageBox.Show("The schedule has been exported successfully in the folder " + newPath);
                    }
                }
                if (_name == "Grupa")
                {
                    ExportOrarGrupa exportOrarGrupa = new ExportOrarGrupa((string)activeComboBox.SelectedItem);
                    string startupPath = Environment.CurrentDirectory;
                    string newPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(startupPath, "..\\..\\..\\"));
                    string imgName = "OrarGrupaImage.jpg";
                    string pdfName = "Orar Grupa " + activeComboBox.SelectedItem + ".pdf";

                    using (Graphics graphics = exportOrarGrupa.CreateGraphics())
                    {

                        using (Bitmap bitmapImage = new Bitmap(exportOrarGrupa.Width, exportOrarGrupa.Height, graphics))
                        {
                            exportOrarGrupa.DrawToBitmap(bitmapImage, new System.Drawing.Rectangle(0, 0, exportOrarGrupa.Width, exportOrarGrupa.Height));
                            bitmapImage.Save(newPath + imgName);
                        }
                    }

                    if (File.Exists(newPath + imgName))
                    {
                        string orarImagePath = newPath + "\\" + imgName;
                        var pdf = new PdfDocument(new PdfWriter(newPath + "\\" + pdfName));
                        var document = new Document(pdf, PageSize.A3);
                        iText.Layout.Element.Image orarImage = new iText.Layout.Element.Image(ImageDataFactory.Create(orarImagePath));
                        orarImage.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                        orarImage.SetWidthPercent(100);
                        document.Add(orarImage);
                        document.Close();
                        File.Delete(newPath + "\\" + imgName);
                        MessageBox.Show("The schedule has been exported successfully in the folder " + newPath);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selectati " + _name);
            }
        }

    }
}
