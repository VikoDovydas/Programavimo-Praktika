using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AcademicSystem
{
    public partial class ManageLecturersForm : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-620UHD6;Initial Catalog=AcademicSystemDB;Integrated Security=True";

        public ManageLecturersForm()
        {
            InitializeComponent();
            LoadLecturers();
        }

        private void LoadLecturers()
        {
            string query = "SELECT * FROM Lecturers";

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
                        dataGridViewLecturers.Columns.Clear();
                        dataGridViewLecturers.AutoGenerateColumns = true;
                        dataGridViewLecturers.DataSource = dataTable;

                        // Add a button column for deletion
                        if (!dataGridViewLecturers.Columns.Contains("DeleteButtonColumn"))
                        {
                            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                            deleteButtonColumn.Name = "DeleteButtonColumn";
                            deleteButtonColumn.HeaderText = "Action";
                            dataGridViewLecturers.Columns.Add(deleteButtonColumn);
                        }

                        
                    }
                }
            }
        }

        private void dataGridViewLecturers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("CellContentClick event fired!");

            if (e.ColumnIndex == dataGridViewLecturers.Columns["DeleteButtonColumn"].Index && e.RowIndex >= 0)
            {
                int lecturerIdToDelete = Convert.ToInt32(dataGridViewLecturers.Rows[e.RowIndex].Cells["LecturerId"].Value);
                Console.WriteLine($"Deleting lecturer with ID: {lecturerIdToDelete}");
                DeleteLecturer(lecturerIdToDelete);
            }
        }

        private void DeleteLecturer(int lecturerId)
        {
            Console.WriteLine($"Deleting lecturer with ID: {lecturerId}");
            // Implement the deletion logic in the database
            string deleteQuery = $"DELETE FROM Lecturers WHERE LecturerId = {lecturerId}";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

            // Refresh the DataGridView after deletion
            LoadLecturers();
        }

        private void ManageLecturersForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBackToAdminPage_Click(object sender, EventArgs e)
        {
            this.Close();

            // Open the AdminPage form
            AdminPage adminPage = new AdminPage();
            adminPage.Show();
        }
    }
}
