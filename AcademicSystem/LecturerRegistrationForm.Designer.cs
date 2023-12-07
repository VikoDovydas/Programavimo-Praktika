namespace AcademicSystem
{
    partial class LecturerRegistrationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBackToAdminPage = new System.Windows.Forms.Button();
            this.btnRegisterLecturer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dėstytojo registravimas:";
            // 
            // btnBackToAdminPage
            // 
            this.btnBackToAdminPage.Location = new System.Drawing.Point(15, 380);
            this.btnBackToAdminPage.Name = "btnBackToAdminPage";
            this.btnBackToAdminPage.Size = new System.Drawing.Size(90, 46);
            this.btnBackToAdminPage.TabIndex = 1;
            this.btnBackToAdminPage.Text = "Atgal";
            this.btnBackToAdminPage.UseVisualStyleBackColor = true;
            this.btnBackToAdminPage.Click += new System.EventHandler(this.btnBackToAdminPage_Click);
            // 
            // btnRegisterLecturer
            // 
            this.btnRegisterLecturer.Location = new System.Drawing.Point(177, 204);
            this.btnRegisterLecturer.Name = "btnRegisterLecturer";
            this.btnRegisterLecturer.Size = new System.Drawing.Size(104, 41);
            this.btnRegisterLecturer.TabIndex = 2;
            this.btnRegisterLecturer.Text = "Įregistruoti";
            this.btnRegisterLecturer.UseVisualStyleBackColor = true;
            this.btnRegisterLecturer.Click += new System.EventHandler(this.btnRegisterLecturer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vardas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pavardė";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dėstomas dalykas";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(126, 82);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(207, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(126, 116);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(207, 20);
            this.txtSurname.TabIndex = 7;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(126, 152);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(207, 20);
            this.txtSubject.TabIndex = 8;
            // 
            // LecturerRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegisterLecturer);
            this.Controls.Add(this.btnBackToAdminPage);
            this.Controls.Add(this.label1);
            this.Name = "LecturerRegistrationForm";
            this.Text = "LecturerRegistrationForm";
            this.Load += new System.EventHandler(this.LecturerRegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBackToAdminPage;
        private System.Windows.Forms.Button btnRegisterLecturer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtSubject;
    }
}