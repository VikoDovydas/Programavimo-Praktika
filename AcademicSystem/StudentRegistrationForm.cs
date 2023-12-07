using System.Data.SqlClient;
using System.Windows.Forms;
using System;



namespace AcademicSystem
{
    public partial class StudentRegistrationForm : Form
    {
        public StudentRegistrationForm()
        {
            InitializeComponent();
        }

        private void StudentRegistrationForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRegisterStudent_Click(object sender, EventArgs e)
        {
            // Get the values from the textboxes
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string group = txtGroup.Text;
            string subject = txtSubject.Text;

            // Generate username and password from name and surname
            string username = name.ToLower();
            string password = surname.ToLower(); 

            
            if (RegisterStudent(name, surname, group, subject, username, password))
            {
                // Display a success message
                MessageBox.Show($"Student Registered:\nName: {name}\nSurname: {surname}\nGroup: {group}\nSubject: {subject}");

                // Close the registration form
                this.Close();
            }
            else
            {
              
                MessageBox.Show("Failed to register the student. Please try again.");
            }
        }


        private bool RegisterStudent(string name, string surname, string group, string subject, string username, string password)
        {
            // Connection string for your database
            string connectionString = "Data Source=DESKTOP-620UHD6;Initial Catalog=AcademicSystemDB;Integrated Security=True";

            // SQL query to insert data into the Students table
            string query = "INSERT INTO Students (Name, Surname, GroupName, Subject, Username, Password) " +
                           "VALUES (@Name, @Surname, @Group, @Subject, @Username, @Password)";

            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    
                    connection.Open();

                    // Create a SqlCommand object with the query and connection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Surname", surname);
                        command.Parameters.AddWithValue("@Group", group);
                        command.Parameters.AddWithValue("@Subject", subject);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        
                        command.ExecuteNonQuery();

                        
                        Console.WriteLine("Student registered successfully.");

                        
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show($"Error during registration: {ex.Message}");

                    
                    return false;
                }
            }
        }

        private void btnBackToAdminPage_Click(object sender, EventArgs e)
        {
            
            this.Close();

            
            AdminPage adminPage = new AdminPage();
            adminPage.Show();
        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void StudentRegistrationForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
