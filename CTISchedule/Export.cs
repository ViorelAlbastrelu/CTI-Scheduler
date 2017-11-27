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

namespace CTISchedule
{
    public partial class Export : Form
    {
        private Start _start;
        private string _name;
        private string[] profesorsName;
        private int[] years;
        private string[] disciplines;
        private string[] groups;
        public Export(Controller controller, Start start, string name)
        {
            InitializeComponent();
            _start = start;
            _name = name;
            profesorsName = new string[] { "TUDORIE Cornelia", "COCU Adina" };
            years = new int[] { 1, 2, 3, 4 };
            disciplines = new string[] { "PIE", "PLF" };
            groups = new string[] { "Grupa 1", "Grupa 2", "Grupa 3", "Grupa 4" };

            this.activeLabel.Text = name;
            if (name == "Anul")
            {
                foreach(int year in years)
                {
                    this.activeComboBox.Items.Add(year);
                }
            }

            if (name == "Profesorul")
            {
                foreach (string profesorName in profesorsName)
                {
                    this.activeComboBox.Items.Add(profesorName);
                }
            }

            if (name == "Grupa")
            {
                foreach(string group in groups)
                {
                    this.activeComboBox.Items.Add(group);
                }
            }

            if (name == "Disciplina")
            {
                foreach(string discipline in disciplines)
                {
                    this.activeComboBox.Items.Add(discipline);
                }
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

        private Cell dayTableModule()
        {
            Table dayTable = new Table(new float[] { 100 });
            Cell dayCell = new Cell();
            dayTable.SetWidthPercent(100);
            dayTable.AddCell(new Cell().SetPaddingBottom(15).SetBorderBottom(Border.NO_BORDER).SetBorderLeft(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).Add("L"));
            dayTable.AddCell(new Cell().SetPaddingBottom(15).SetBorderBottom(Border.NO_BORDER).SetBorderLeft(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetBorderTop(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).Add("U"));
            dayTable.AddCell(new Cell().SetPaddingBottom(16).SetBorderBottom(Border.NO_BORDER).SetBorderLeft(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetBorderTop(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).Add("N"));
            dayTable.AddCell(new Cell().SetBorderTop(Border.NO_BORDER).SetBorderLeft(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).Add("I"));
            dayTable.AddCell(new Cell().SetPaddingTop(8).SetPaddingBottom(4.5F).SetBorderBottom(Border.NO_BORDER).SetBorderLeft(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).Add("M"));
            dayTable.AddCell(new Cell().SetPaddingBottom(4.5F).SetBorderBottom(Border.NO_BORDER).SetBorderLeft(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetBorderTop(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).Add("A"));
            dayTable.AddCell(new Cell().SetPaddingBottom(4.5F).SetBorderBottom(Border.NO_BORDER).SetBorderLeft(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetBorderTop(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).Add("R"));
            dayTable.AddCell(new Cell().SetPaddingBottom(4.5F).SetBorderBottom(Border.NO_BORDER).SetBorderLeft(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetBorderTop(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).Add("T"));
            dayTable.AddCell(new Cell().SetPaddingBottom(8).SetBorderTop(Border.NO_BORDER).SetBorderLeft(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).Add("I"));
            dayTable.AddCell(new Cell().SetBorderBottom(Border.NO_BORDER).SetBorderLeft(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).Add("M"));
            dayTable.AddCell(new Cell().SetBorderBottom(Border.NO_BORDER).SetBorderLeft(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetBorderTop(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).Add("I"));
            dayTable.AddCell(new Cell().SetBorderBottom(Border.NO_BORDER).SetBorderLeft(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetBorderTop(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).Add("E"));
            dayTable.AddCell(new Cell().SetBorderBottom(Border.NO_BORDER).SetBorderLeft(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetBorderTop(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).Add("R"));
            dayTable.AddCell(new Cell().SetBorderBottom(Border.NO_BORDER).SetBorderLeft(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetBorderTop(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).Add("C"));
            dayTable.AddCell(new Cell().SetBorderBottom(Border.NO_BORDER).SetBorderLeft(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetBorderTop(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).Add("U"));
            dayTable.AddCell(new Cell().SetBorderBottom(Border.NO_BORDER).SetBorderLeft(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetBorderTop(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).Add("R"));
            dayTable.AddCell(new Cell().SetBorderTop(Border.NO_BORDER).SetBorderLeft(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).Add("I"));
            dayTable.AddCell(new Cell().SetBorderBottom(Border.NO_BORDER).SetBorderLeft(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).Add("J"));
            dayTable.AddCell(new Cell().SetBorderBottom(Border.NO_BORDER).SetBorderLeft(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetBorderTop(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).Add("O"));
            dayTable.AddCell(new Cell().SetBorderTop(Border.NO_BORDER).SetBorderLeft(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).Add("I"));
            dayTable.AddCell(new Cell().SetBorderBottom(Border.NO_BORDER).SetBorderLeft(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).Add("V"));
            dayTable.AddCell(new Cell().SetBorderBottom(Border.NO_BORDER).SetBorderLeft(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetBorderTop(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).Add("I"));
            dayTable.AddCell(new Cell().SetBorderBottom(Border.NO_BORDER).SetBorderLeft(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetBorderTop(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).Add("N"));
            dayTable.AddCell(new Cell().SetBorderBottom(Border.NO_BORDER).SetBorderLeft(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetBorderTop(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).Add("E"));
            dayTable.AddCell(new Cell().SetBorderBottom(Border.NO_BORDER).SetBorderLeft(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetBorderTop(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).Add("R"));
            dayTable.AddCell(new Cell().SetBorderTop(Border.NO_BORDER).SetBorderLeft(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER).SetBorderBottom(Border.NO_BORDER).SetFontSize(10).Add("I"));
            dayCell.Add(new Cell().SetPaddingBottom(50).Add("Zi"));
            dayCell.Add(dayTable);
            return dayCell;
        }

        private Cell hourTableModule()
        {
            Table hourTable = new Table(new float[] { 100 });
            Cell hourCell = new Cell();
            hourCell.Add(new Cell().SetPaddingBottom(50).Add("Ora"));
            for (int i = 0; i < 4; i++)
            {
                hourTable.AddCell(new Cell().SetBorderLeft(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).Add("8-10"));
                hourTable.AddCell(new Cell().SetBorderLeft(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).Add("10-12"));
                hourTable.AddCell(new Cell().SetBorderLeft(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).Add("12-14"));
                hourTable.AddCell(new Cell().SetBorderLeft(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).Add("14-16"));
                hourTable.AddCell(new Cell().SetBorderLeft(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).Add("16-18"));
                hourTable.AddCell(new Cell().SetBorderLeft(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).Add("18-20"));
                if(i == 1)
                {
                    hourTable.AddCell(new Cell().SetPaddingTop(3.5f).SetPaddingBottom(3.5f).SetBorderLeft(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).Add("8-10"));
                    hourTable.AddCell(new Cell().SetPaddingTop(3).SetPaddingBottom(3).SetBorderLeft(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).Add("10-12"));
                    hourTable.AddCell(new Cell().SetPaddingTop(3).SetPaddingBottom(3).SetBorderLeft(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).Add("12-14"));
                    hourTable.AddCell(new Cell().SetPaddingTop(3).SetPaddingBottom(3).SetBorderLeft(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).Add("14-16"));
                    hourTable.AddCell(new Cell().SetPaddingTop(3).SetPaddingBottom(3).SetBorderLeft(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).Add("16-18"));
                    hourTable.AddCell(new Cell().SetPaddingTop(3.5f).SetPaddingBottom(3.5f).SetBorderLeft(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER).SetFontSize(10).Add("18-20"));
                }
            }
            hourCell.Add(hourTable);
            return hourCell;
        }
        private Cell yearTableModule()
        {
            Table groupTable = new Table(new float[] { 330, 330, 330 });
            Table subGroupTable = new Table(new float[] { 165, 165, 165, 165, 165, 165 });
            Cell cellGroup = new Cell();
            Cell cellSubGroup = new Cell();
            groupTable.AddCell("Grupa 1");
            groupTable.AddCell("Grupa 2");
            groupTable.AddCell("Grupa 3");
            subGroupTable.AddCell("Subgrupa a");
            subGroupTable.AddCell("Subgrupa b");
            subGroupTable.AddCell("Subgrupa a");
            subGroupTable.AddCell("Subgrupa b");
            subGroupTable.AddCell("Subgrupa a");
            subGroupTable.AddCell("Subgrupa b");
            cellGroup.Add("An");
            cellGroup.Add(groupTable);
            cellGroup.Add(subGroupTable);
            return cellGroup;
        }


        private void exportButton_Click(object sender, EventArgs e)
        {
            if (activeComboBox.SelectedItem != null)
            {
                if (_name == "Profesorul")
                {
                    string startupPath = Environment.CurrentDirectory;
                    string newPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(startupPath, "..\\..\\..\\"));
                    var pdf = new PdfDocument(new PdfWriter(newPath + "\\OrarProfesor.pdf"));
                    var document = new Document(pdf, PageSize.A3.Rotate());
                    Table table = new Table(new float[] { 100, 100, 990 });
                    table.AddCell(dayTableModule());
                    table.AddCell("Ora");
                    //table.AddCell(hourTableModule());
                    table.AddCell(yearTableModule());
                    document.Add(table);
                    document.Close();
                }
            }
            else
            {
                MessageBox.Show("Selectati " + _name);
            }
        }

    }
}
