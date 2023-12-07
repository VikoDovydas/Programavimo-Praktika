using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicSystem
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void btnGoToRegistrationForm_Click(object sender, EventArgs e)
        {
           
           StudentRegistrationForm registrationForm = new StudentRegistrationForm();
           registrationForm.Show();
           this.Close();

        }
        private void btnViewStudentList_Click(object sender, EventArgs e)
        {
            
            ManageStudentsForm studentListForm = new ManageStudentsForm();
            studentListForm.Show();
        }
        private void btnGoToLecturerRegistrationForm_Click(object sender, EventArgs e)
        {
            
            LecturerRegistrationForm lecturerRegistrationForm = new LecturerRegistrationForm();
            lecturerRegistrationForm.Show();
            this.Close();
        }

        private void btnGoToManageLecturersForm_Click(object sender, EventArgs e)
        {
            
            ManageLecturersForm manageLecturersForm = new ManageLecturersForm();
            manageLecturersForm.Show();
            this.Close();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {

        }
    }

}
