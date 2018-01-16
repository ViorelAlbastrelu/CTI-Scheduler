using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace CTISchedule
{
    public partial class FormModul : UserControl
    {
        List<string> test = new List<string>();
        int returnValue;
        private string connectionString = ConfigurationManager.ConnectionStrings["CTISchedule.Properties.Settings.CTIScheduleDBConnectionString"].ConnectionString;
        public FormModul()
        {
            InitializeComponent();
            string queryProfesor = "SELECT nume FROM profesor";
            string queryDisciplina = "SELECT nume FROM disciplina";
            string queryActivitate = "SELECT nume FROM activitate";
            string querySala = "SELECT nume FROM sala";
            string queryZiua = "SELECT nume FROM zile";
            sqlInterogation(queryProfesor, optProfesor);
            sqlInterogation(queryDisciplina, optDisciplina);
            sqlInterogation(queryActivitate, optActivitate);
            sqlInterogation(querySala, optSala);
            sqlInterogation(queryZiua, optZiua);

        }

        private void btnSaveModule_Click(object sender, EventArgs e)
        {
            string queryDisciplina = $"SELECT id FROM disciplina where Disciplina.nume = '{optDisciplina.SelectedItem}'";
            string queryActivitate = $"Select id from activitate where Activitate.nume = '{optActivitate.SelectedItem}'";
            string queryProfesor = $"Select id from profesor where Profesor.nume = '{optProfesor.SelectedItem}'";
            string querySala = $"Select id from sala where sala.nume = '{optSala.SelectedItem}'";
            string queryZiua = $"Select id from zile where zile.nume = '{optZiua.SelectedItem}'";
            int idDisciplina = sqlInterogationForInsert(queryDisciplina);
            int idActivitate = sqlInterogationForInsert(queryActivitate);
            int idProfesor = sqlInterogationForInsert(queryProfesor);
            int idSala = sqlInterogationForInsert(querySala);
            int idZiua = sqlInterogationForInsert(queryZiua);
            if (optModul.SelectedItem.ToString() == "I")
            {
                string queryInsert = $@"INSERT Modul (IdZi, IdDisciplina, IdActivitate, IdProfesor, IdSubgrupa, IdSala, OraStart, OraStop, SaptPara) 
                                    VALUES ({idZiua}, {idDisciplina}, {idActivitate}, {idProfesor}, 1, {idSala}, '08:00:00', '10:00:00', null)";
                sqlInsert(queryInsert);

            }
            if (optModul.SelectedItem.ToString() == "II")
            {
                string queryInsert = $@"INSERT Modul (IdZi, IdDisciplina, IdActivitate, IdProfesor, IdSubgrupa, IdSala, OraStart, OraStop, SaptPara) 
                                    VALUES ({idZiua}, {idDisciplina}, {idActivitate}, {idProfesor}, 1, {idSala}, '10:00:00', '12:00:00', null)";
                sqlInsert(queryInsert);
            }
            if (optModul.SelectedItem.ToString() == "III")
            {
                string queryInsert = $@"INSERT Modul (IdZi, IdDisciplina, IdActivitate, IdProfesor, IdSubgrupa, IdSala, OraStart, OraStop, SaptPara) 
                                    VALUES ({idZiua}, {idDisciplina}, {idActivitate}, {idProfesor}, 1, {idSala}, '12:00:00', '14:00:00', null)";
                sqlInsert(queryInsert);
            }
            if (optModul.SelectedItem.ToString() == "IV")
            {
                string queryInsert = $@"INSERT Modul (IdZi, IdDisciplina, IdActivitate, IdProfesor, IdSubgrupa, IdSala, OraStart, OraStop, SaptPara) 
                                    VALUES ({idZiua}, {idDisciplina}, {idActivitate}, {idProfesor}, 1, {idSala}, '14:00:00', '16:00:00', null)";
                sqlInsert(queryInsert);
            }
            if (optModul.SelectedItem.ToString() == "V")
            {
                string queryInsert = $@"INSERT Modul (IdZi, IdDisciplina, IdActivitate, IdProfesor, IdSubgrupa, IdSala, OraStart, OraStop, SaptPara) 
                                    VALUES ({idZiua}, {idDisciplina}, {idActivitate}, {idProfesor}, 1, {idSala}, '16:00:00', '18:00:00', null)";
                sqlInsert(queryInsert);
            }
            if (optModul.SelectedItem.ToString() == "VI")
            {
                string queryInsert = $@"INSERT Modul (IdZi, IdDisciplina, IdActivitate, IdProfesor, IdSubgrupa, IdSala, OraStart, OraStop, SaptPara) 
                                    VALUES ({idZiua}, {idDisciplina}, {idActivitate}, {idProfesor}, 1, {idSala}, '18:00:00', '20:00:00', null)";
                sqlInsert(queryInsert);
            }
            test.Add(optActivitate.SelectedItem.ToString());
            test.Add(optDisciplina.SelectedItem.ToString());
            test.Add(optProfesor.SelectedItem.ToString());
            test.Add(optSala.SelectedItem.ToString());
            test.Add(optZiua.SelectedItem.ToString());
            test.Add(optModul.SelectedItem.ToString());
        }
        public List<string> PassArr {
            get { return test; }
        }

        private void sqlInterogation(string sqlQuery, ComboBox numeBox)
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
                        numeBox.Items.Add(reader.GetValue(i));
                    }
                }
                connection.Close();
            }
        }
        private int sqlInterogationForInsert(string sqlQuery)
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
                    returnValue = (int)reader.GetValue(0);
                }
                connection.Close();
            }
            return returnValue;
        }
        private void sqlInsert(string sqlQuery)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = sqlQuery;
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        private void btnDeleteModule_Click(object sender, EventArgs e)
        {
            //if (txtIdProfesor.Text != "") //todo modul id
            //{
            //    _controller.DeleteModul(int.Parse(txtIdProfesor.Text));
            //    this.clearForModul();
            //}
            //else
            //{
            //    MessageBox.Show("Va rugam sa selectati un profesor.");
            //}
        }

        private void btnCancelModule_Click(object sender, EventArgs e)
        {

        }

        private void clearForModul()
        {
            //TODO add lines to clear components if necessary
        }
    }
}