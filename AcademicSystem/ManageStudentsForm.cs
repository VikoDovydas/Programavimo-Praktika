using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AcademicSystem
{
    public partial class ManageStudentsForm : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-620UHD6;Initial Catalog=AcademicSystemDB;Integrated Security=True";

        public ManageStudentsForm()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void LoadStudents()
        {
            string query = "SELECT * FROM Students";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Set up the columns in the DataGridView
                        dataGridView2.Columns.Clear();
                        dataGridView2.AutoGenerateColumns = true;
                        dataGridView2.DataSource = dataTable;

                        
                        if (!dataGridView2.Columns.Contains("DeleteButtonColumn"))
                        {
                            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                            deleteButtonColumn.Name = "DeleteButtonColumn";
                            deleteButtonColumn.HeaderText = "Action";
                            dataGridView2.Columns.Add(deleteButtonColumn);
                        }

                      
                    }
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("CellContentClick event fired!");

            if (e.ColumnIndex == dataGridView2.Columns["DeleteButtonColumn"].Index && e.RowIndex >= 0)
            {
                int studentIdToDelete = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["StudentId"].Value);
                Console.WriteLine($"Deleting student with ID: {studentIdToDelete}");
                DeleteStudent(studentIdToDelete);
            }
        }


        private void DeleteStudent(int studentId)
        {
            Console.WriteLine($"Deleting student with ID: {studentId}");
            // Implement the deletion logic in the database
            string deleteQuery = $"DELETE FROM Students WHERE StudentId = {studentId}";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

            // Refresh the DataGridView after deletion
            LoadStudents();
        }


        private void ManageStudentsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBackToAdminPage_Click(object sender, EventArgs e)
        {

            this.Close();

           
            AdminPage adminPage = new AdminPage();
            adminPage.Show();
        }
    }
}
