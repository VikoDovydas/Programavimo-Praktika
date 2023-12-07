using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AcademicSystem
{
    public partial class LecturerForm : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-620UHD6;Initial Catalog=AcademicSystemDB;Integrated Security=True";

        
        private string lecturerUsername;
        private string lecturerPassword;

        public LecturerForm(string username, string password)
        {
            InitializeComponent();

           
            lecturerUsername = username;
            lecturerPassword = password;
 
            LoadStudents();
        }

        private void LoadStudents()
        {
            string lecturerSubject = GetLecturerSubject(lecturerUsername, lecturerPassword);

            if (!string.IsNullOrEmpty(lecturerSubject))
            {
                string query = $"SELECT * FROM Students WHERE Subject = @subject";

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@subject", lecturerSubject);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                           
                            dataGridViewStudents.Columns.Clear();
                            dataGridViewStudents.AutoGenerateColumns = true;
                            dataGridViewStudents.DataSource = dataTable;

                            
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Failed to retrieve lecturer's subject.");
            }
        }



        private string GetLecturerSubject(string username, string password)
        {
            string query = "SELECT Subject FROM Lecturers WHERE Username = @username AND Password = @password";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    object result = command.ExecuteScalar();

                    return result?.ToString();
                }
            }
        }


        private void UpdateStudentGrade(int studentId, string newGrade)
        {
            // Convert the string grade to an integer
            if (int.TryParse(newGrade, out int gradeValue))
            {
               
                string connectionString = "Data Source=DESKTOP-620UHD6;Initial Catalog=AcademicSystemDB;Integrated Security=True";

              
                string updateQuery = "UPDATE Students SET Grade = @Grade WHERE StudentId = @StudentId";

               
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        // Add parameters
                        command.Parameters.AddWithValue("@Grade", gradeValue);
                        command.Parameters.AddWithValue("@StudentId", studentId);


                        command.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                // Handle the case where the provided grade is not a valid integer
                MessageBox.Show("Invalid grade format. Please enter a valid integer grade.");
            }
        }




        private void dataGridViewStudents_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        //
        }

        private void btnSaveGrades_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewStudents.Rows)
            {
                // Check if the Grade cell is not null or empty
                if (row.Cells["Grade"].Value != null && !string.IsNullOrEmpty(row.Cells["Grade"].Value.ToString()))
                {
                    // Get the student ID from the corresponding row
                    int studentId = Convert.ToInt32(row.Cells["StudentId"].Value);

                    // Get the new grade from the DataGridView
                    string newGrade = row.Cells["Grade"].Value.ToString();

                    // Update the database with the new grade
                    UpdateStudentGrade(studentId, newGrade);
                }
            }

            
            MessageBox.Show("Grades saved successfully.");
        }


        private void LecturerForm_Load(object sender, EventArgs e)
        {

        }



    }
}
