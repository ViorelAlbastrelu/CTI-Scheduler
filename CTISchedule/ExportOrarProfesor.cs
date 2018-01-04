using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CTISchedule
{
    public partial class ExportOrarProfesor : UserControl
    {
        private string[] zile = new string[] { "Luni", "Marti", "Miercuri", "Joi", "Vineri" };
        private string[] oraStart = new string[] { "08:00:00", "10:00:00", "12:00:00", "14:00:00", "16:00:00", "18:00:00" };
        private string connectionString = ConfigurationManager.ConnectionStrings["CTISchedule.Properties.Settings.CTIScheduleDBConnectionString"].ConnectionString;
        public ExportOrarProfesor(string name)
        {
            InitializeComponent();
            string query = $@"select Zile.Nume, Modul.OraStart, Profesor.Nume,Disciplina.An, Disciplina.Nume, Activitate.Nume, Sala.Nume, Grupa.Nume
                            from Profesor
                            join Modul on Modul.IdProfesor = Profesor.Id
                            join Zile on Zile.Id = Modul.IdZi
                            join Disciplina on Disciplina.Id = Modul.IdDisciplina
                            join Activitate on Activitate.Id = Modul.IdActivitate
                            join Sala on Sala.Id = Modul.IdSala
                            join SubGrupa on SubGrupa.Id = Modul.IdSubGrupa
                            join Grupa on Grupa.Id = SubGrupa.IdGrupa
                            where Profesor.Nume = '{name}'";
            sqlInterogation(query);
        }

        private void sqlInterogation(string sqlQuery)
        {
            Label[] labels = new Label[] {this.Luni08, this.Luni10, this.Luni12, this.Luni14, this.Luni16, this.Luni18,
            this.Marti08, this.Marti10, this.Marti12, this.Marti14, this.Marti16, this.Marti18,
            this.Miercuri08, this.Miercuri10, this.Miercuri12, this.Miercuri14, this.Miercuri16, this.Miercuri18,
            this.Joi08, this.Joi10, this.Joi12, this.Joi14, this.Joi16, this.Joi18,
            this.Vineri08, this.Vineri10, this.Vineri12, this.Vineri14, this.Vineri16, this.Vineri18};
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
                        for (int j = 0; j < zile.Length; j++)
                        {
                            for(int k=0; k < oraStart.Length; k++)
                            {
                                for (int z = 0; z < labels.Length; z++)
                                {
                                    if (reader.GetValue(0).ToString() == zile[j] && reader.GetValue(1).ToString() == oraStart[k] && 
                                        (labels[z].Name == reader.GetValue(0).ToString() + reader.GetValue(1).ToString().Substring(0,2) ))
                                    {
                                        if (i == 3)
                                        {
                                            labels[z].Text += "Anul " + reader.GetValue(i) + "\n";
                                        }
                                        if (i >= 4)
                                        {
                                            Console.WriteLine(reader.GetValue(i));
                                            labels[z].Text += reader.GetValue(i) + "\n";
                                            if (i == count - 1)
                                            {
                                                Console.WriteLine("END OF LINE");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                connection.Close();
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
