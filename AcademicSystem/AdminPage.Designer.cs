namespace AcademicSystem
{
    partial class AdminPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGoToRegistrationForm = new System.Windows.Forms.Button();
            this.btnViewStudentList = new System.Windows.Forms.Button();
            this.btnGoToLecturerRegistrationForm = new System.Windows.Forms.Button();
            this.btnGoToManageLecturersForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGoToRegistrationForm
            // 
            this.btnGoToRegistrationForm.Location = new System.Drawing.Point(30, 22);
            this.btnGoToRegistrationForm.Name = "btnGoToRegistrationForm";
            this.btnGoToRegistrationForm.Size = new System.Drawing.Size(85, 50);
            this.btnGoToRegistrationForm.TabIndex = 0;
            this.btnGoToRegistrationForm.Text = "Studento registravimas";
            this.btnGoToRegistrationForm.UseVisualStyleBackColor = true;
            this.btnGoToRegistrationForm.Click += new System.EventHandler(this.btnGoToRegistrationForm_Click);
            // 
            // btnViewStudentList
            // 
            this.btnViewStudentList.Location = new System.Drawing.Point(30, 95);
            this.btnViewStudentList.Name = "btnViewStudentList";
            this.btnViewStudentList.Size = new System.Drawing.Size(85, 53);
            this.btnViewStudentList.TabIndex = 1;
            this.btnViewStudentList.Text = "Studentų sąrašas";
            this.btnViewStudentList.UseVisualStyleBackColor = true;
            this.btnViewStudentList.Click += new System.EventHandler(this.btnViewStudentList_Click);
            // 
            // btnGoToLecturerRegistrationForm
            // 
            this.btnGoToLecturerRegistrationForm.Location = new System.Drawing.Point(30, 172);
            this.btnGoToLecturerRegistrationForm.Name = "btnGoToLecturerRegistrationForm";
            this.btnGoToLecturerRegistrationForm.Size = new System.Drawing.Size(85, 56);
            this.btnGoToLecturerRegistrationForm.TabIndex = 2;
            this.btnGoToLecturerRegistrationForm.Text = "Destytojo registravimas";
            this.btnGoToLecturerRegistrationForm.UseVisualStyleBackColor = true;
            this.btnGoToLecturerRegistrationForm.Click += new System.EventHandler(this.btnGoToLecturerRegistrationForm_Click);
            // 
            // btnGoToManageLecturersForm
            // 
            this.btnGoToManageLecturersForm.Location = new System.Drawing.Point(30, 248);
            this.btnGoToManageLecturersForm.Name = "btnGoToManageLecturersForm";
            this.btnGoToManageLecturersForm.Size = new System.Drawing.Size(85, 56);
            this.btnGoToManageLecturersForm.TabIndex = 3;
            this.btnGoToManageLecturersForm.Text = "Destytojų sąrašas";
            this.btnGoToManageLecturersForm.UseVisualStyleBackColor = true;
            this.btnGoToManageLecturersForm.Click += new System.EventHandler(this.btnGoToManageLecturersForm_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGoToManageLecturersForm);
            this.Controls.Add(this.btnGoToLecturerRegistrationForm);
            this.Controls.Add(this.btnViewStudentList);
            this.Controls.Add(this.btnGoToRegistrationForm);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGoToRegistrationForm;
        private System.Windows.Forms.Button btnViewStudentList;
        private System.Windows.Forms.Button btnGoToLecturerRegistrationForm;
        private System.Windows.Forms.Button btnGoToManageLecturersForm;
    }
}