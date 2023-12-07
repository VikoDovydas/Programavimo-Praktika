using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AcademicSystem
{
    public partial class StudentForm : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-620UHD6;Initial Catalog=AcademicSystemDB;Integrated Security=True";
        private string studentUsername;
        private string studentPassword;

        public StudentForm(string username, string password)
        {
            InitializeComponent();

            // Store student information when the form is created
            studentUsername = username;
            studentPassword = password;

            LoadGrades();
        }

        private void LoadGrades()
        {
            string query = "SELECT Subject, Grade FROM Students WHERE Username = @username AND Password = @password";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", studentUsername);
                    command.Parameters.AddWithValue("@password", studentPassword);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Set up the columns in the DataGridView
                        dataGridViewGrades.Columns.Clear();
                        dataGridViewGrades.AutoGenerateColumns = true;
                        dataGridViewGrades.DataSource = dataTable;

                        
                    }
                }
            }
        }


        

        private void StudentForm_Load(object sender, EventArgs e)
        {
            
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
