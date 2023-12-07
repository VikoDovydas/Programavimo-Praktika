namespace AcademicSystem
{
    partial class StudentRegistrationForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.btnRegisterStudent = new System.Windows.Forms.Button();
            this.btnBackToAdminPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Vardas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Pavardė";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Studento įregistravimas:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Dėstomas dalykas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Grupė";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(176, 90);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(194, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(176, 127);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(194, 20);
            this.txtSurname.TabIndex = 6;
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(176, 162);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(194, 20);
            this.txtGroup.TabIndex = 7;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(176, 204);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(194, 20);
            this.txtSubject.TabIndex = 8;
            // 
            // btnRegisterStudent
            // 
            this.btnRegisterStudent.Location = new System.Drawing.Point(209, 250);
            this.btnRegisterStudent.Name = "btnRegisterStudent";
            this.btnRegisterStudent.Size = new System.Drawing.Size(120, 35);
            this.btnRegisterStudent.TabIndex = 9;
            this.btnRegisterStudent.Text = "Įregistruoti";
            this.btnRegisterStudent.UseVisualStyleBackColor = true;
            this.btnRegisterStudent.Click += new System.EventHandler(this.btnRegisterStudent_Click);
            // 
            // btnBackToAdminPage
            // 
            this.btnBackToAdminPage.Location = new System.Drawing.Point(12, 483);
            this.btnBackToAdminPage.Name = "btnBackToAdminPage";
            this.btnBackToAdminPage.Size = new System.Drawing.Size(133, 51);
            this.btnBackToAdminPage.TabIndex = 11;
            this.btnBackToAdminPage.Text = "Atgal";
            this.btnBackToAdminPage.UseVisualStyleBackColor = true;
            this.btnBackToAdminPage.Click += new System.EventHandler(this.btnBackToAdminPage_Click);
            // 
            // StudentRegistrationForm
            // 
            this.ClientSize = new System.Drawing.Size(742, 546);
            this.Controls.Add(this.btnBackToAdminPage);
            this.Controls.Add(this.btnRegisterStudent);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtGroup);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Name = "StudentRegistrationForm";
            this.Load += new System.EventHandler(this.StudentRegistrationForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Button btnRegisterStudent;
        private System.Windows.Forms.Button btnBackToAdminPage;
    }
}