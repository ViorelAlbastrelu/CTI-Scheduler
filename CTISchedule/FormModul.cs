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
        //private Controller _controller;

        private string connectionString = ConfigurationManager.ConnectionStrings["CTISchedule.Properties.Settings.CTIScheduleDBConnectionString"].ConnectionString;
        public FormModul()
        {
     //       _controller = new Controller();
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