using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AcademicSystem
{
    public partial class LecturerRegistrationForm : Form
    {
        public LecturerRegistrationForm()
        {
            InitializeComponent();
        }

        private void LecturerRegistrationForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRegisterLecturer_Click(object sender, EventArgs e)
        {
            // Get the values from the textboxes
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string subject = txtSubject.Text;

            // Generate username and password from name and surname
            string username = name.ToLower(); // Use a more sophisticated logic if needed
            string password = surname.ToLower(); // Use a more sophisticated logic if needed

            
            if (RegisterLecturer(name, surname, subject, username, password))
            {
                
                MessageBox.Show($"Lecturer Registered:\nName: {name}\nSurname: {surname}\nSubject: {subject}");

                
                this.Close();
            }
            else
            {
                // Display an error message
                MessageBox.Show("Failed to register the lecturer. Please try again.");
            }
        }

        private bool RegisterLecturer(string name, string surname, string subject, string username, string password)
        {
            // Connection string for your database
            string connectionString = "Data Source=DESKTOP-620UHD6;Initial Catalog=AcademicSystemDB;Integrated Security=True";

            // SQL query to insert data into the Lecturers table
            string query = "INSERT INTO Lecturers (Name, Surname, Subject, Username, Password) " +
                           "VALUES (@Name, @Surname, @Subject, @Username, @Password)";

            // Create a SqlConnection object
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    
                    connection.Open();

                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Surname", surname);
                        command.Parameters.AddWithValue("@Subject", subject);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        // Execute the query
                        command.ExecuteNonQuery();

                      
                        Console.WriteLine("Lecturer registered successfully.");

                        // Return true indicating success
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show($"Error during registration: {ex.Message}");

                    // Return false indicating failure
                    return false;
                }
            }
        }

        private void btnBackToAdminPage_Click(object sender, EventArgs e)
        {
            /
            this.Close();

            // Open the AdminPage form
            AdminPage adminPage = new AdminPage();
            adminPage.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
