namespace AcademicSystem
{
    partial class LecturerForm
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
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.StudentIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSaveGrades = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentIdColumn});
            this.dataGridViewStudents.Location = new System.Drawing.Point(12, 129);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.Size = new System.Drawing.Size(776, 168);
            this.dataGridViewStudents.TabIndex = 0;
            this.dataGridViewStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudents_CellValueChanged);
            // 
            // StudentIdColumn
            // 
            this.StudentIdColumn.HeaderText = "Student ID";
            this.StudentIdColumn.Name = "StudentIdColumn";
            // 
            // btnSaveGrades
            // 
            this.btnSaveGrades.Location = new System.Drawing.Point(330, 323);
            this.btnSaveGrades.Name = "btnSaveGrades";
            this.btnSaveGrades.Size = new System.Drawing.Size(131, 41);
            this.btnSaveGrades.TabIndex = 1;
            this.btnSaveGrades.Text = "Išsaugoti";
            this.btnSaveGrades.UseVisualStyleBackColor = true;
            this.btnSaveGrades.Click += new System.EventHandler(this.btnSaveGrades_Click);
            // 
            // LecturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveGrades);
            this.Controls.Add(this.dataGridViewStudents);
            this.Name = "LecturerForm";
            this.Text = "LecturerForm";
            this.Load += new System.EventHandler(this.LecturerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentIdColumn;
        private System.Windows.Forms.Button btnSaveGrades;
    }
}