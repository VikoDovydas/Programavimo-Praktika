using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AcademicSystem
{
    public partial class Form1 : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-620UHD6;Initial Catalog=AcademicSystemDB;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (AuthenticateAdmin(username, password))
            {
                var adminForm = new AdminPage();
                adminForm.ShowDialog();
                this.Hide();
            }
            else if (AuthenticateStudent(username, password))
            {
                var studentForm = new StudentForm(username, password); // Pass username and password
                studentForm.ShowDialog();
                this.Hide();
            }
            else if (AuthenticateLecturer(username, password))
            {
                var lecturerForm = new LecturerForm(username, password); // Pass username and password
                lecturerForm.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private bool AuthenticateAdmin(string username, string password)
        {
            string query = "SELECT * FROM Users WHERE Username = @username AND Password = @password";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        return reader.Read();
                    }
                }
            }
        }


        private bool AuthenticateStudent(string username, string password)
        {
            string query = "SELECT * FROM Students WHERE Username = @username AND Password = @password";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        return reader.Read();
                    }
                }
            }
        }


        private bool AuthenticateLecturer(string username, string password)
        {
            string query = "SELECT * FROM Lecturers WHERE Username = @username AND Password = @password";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        return reader.Read();
                    }
                }
            }
        }



        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
