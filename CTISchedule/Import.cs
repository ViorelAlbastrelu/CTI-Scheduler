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
    public partial class Import : Form
    {
        private Controller controller;
        public Import(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtImportPath.Text = openFileDialog.FileName;
            }
        }

        private void btnSaveImport_Click(object sender, EventArgs e)
        {
            controller.TruncateDB();
            XSSFWorkbook hssfwb;
            using (FileStream file = new FileStream(txtImportPath.Text, FileMode.Open, FileAccess.Read))
            {
                hssfwb = new XSSFWorkbook(file);
            }

            for (int sheetIndex = 0; sheetIndex < hssfwb.NumberOfSheets; sheetIndex++)
            {
                ISheet sheet = hssfwb.GetSheetAt(sheetIndex);
                IRow headerRow = sheet.GetRow(0);
                IEnumerator rows = sheet.GetRowEnumerator();
                int colCount = headerRow.LastCellNum;
                int rowCount = sheet.LastRowNum;
                bool init = true;
                while (rows.MoveNext())
                {
                    if (!init)
                    {
                        IRow row = (XSSFRow)rows.Current;
                        switch (sheetIndex)
                        {
                            //Discipline
                            case 0:
                                Disciplina disciplina = new Disciplina()
                                {
                                    Nume = row.GetCell(0).ToString(),
                                    NumeScurt = row.GetCell(1).ToString(),
                                    An = int.Parse(row.GetCell(2).ToString()),
                                    Semestru = int.Parse(row.GetCell(3).ToString())
                                };
                                int discplinaId = controller.AddUpdateDisciplina(disciplina).Id;
                                for (int i = 4; i <= 7; i++)
                                {
                                    int activityModules = int.Parse(row.GetCell(i).ToString());
                                    if (activityModules != 0)
                                    {
                                        int dActivityType = 0;
                                        switch (i)
                                        {
                                            case 4: dActivityType = 1;
                                                break;
                                            case 5: dActivityType = 2;
                                                break;
                                            case 6: dActivityType = 3;
                                                break;
                                            case 7: dActivityType = 4;
                                                break;
                                        }
                                        DisciplinaActivitate disciplinaActivitate = new DisciplinaActivitate()
                                        {
                                            Id_Disciplina = discplinaId,
                                            Id_Activitate = dActivityType,
                                            Nr_Module = activityModules
                                        };
                                        controller.AddDisciplinaActivitate(disciplinaActivitate);
                                    }
                                }
                                break;
                            case 1:
                                Profesor profesor = new Profesor()
                                {
                                    Nume = row.GetCell(0).ToString(),
                                    Titlu = row.GetCell(1).ToString()
                                };
                                controller.AddUpdateProfesor(profesor);
                                break;
                            case 2:
                                int activityType = 0;
                                switch (row.GetCell(2).ToString())
                                {
                                    case "curs": activityType = 1;
                                        break;
                                    case "seminar": activityType = 2;
                                        break;
                                    case "laborator": activityType = 3;
                                        break;
                                    case "proiect": activityType = 4;
                                        break;
                                }
                                Sala sala = new Sala()
                                {
                                    Nume = row.GetCell(0).ToString(),
                                    Capacitate = int.Parse(row.GetCell(1).ToString()),
                                    Activitate = activityType
                                };
                                controller.AddSala(sala);
                                break;
                            case 3:
                                var oldGrupa = controller.CheckIfExists(row.GetCell(1).ToString());
                                if(oldGrupa != null)
                                {
                                    controller.AddSubGrupa(new SubGrupa()
                                    {
                                        IdGrupa = oldGrupa.Id,
                                        Nume = row.GetCell(2).ToString()
                                    });
                                } else
                                {
                                    int generation = 0;
                                    switch (int.Parse(row.GetCell(0).ToString()))
                                    {
                                        case 1: generation = 1;
                                            break;
                                        case 2: generation = 2;
                                            break;
                                        case 3: generation = 3;
                                            break;
                                        case 4: generation = 4;
                                            break;
                                    }
                                    var newGrupa = new Grupa()
                                    {
                                        Nume = row.GetCell(1).ToString(),
                                        IdGeneratie = generation
                                    };
                                    controller.AddSubGrupa(new SubGrupa()
                                    {
                                        IdGrupa = controller.AddGrupa(newGrupa).Id,
                                        Nume = row.GetCell(2).ToString()
                                    });
                                }
                                break;
                        }
                    }
                    init = false;
                }
            }
            MessageBox.Show("Importare Finalizat");
            txtImportPath.Text = null;
        }
    }
}
