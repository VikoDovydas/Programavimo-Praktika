namespace AcademicSystem
{
    partial class ManageLecturersForm
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
            this.dataGridViewLecturers = new System.Windows.Forms.DataGridView();
            this.LecturerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLecturers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Priregistruoti dėstytojai:";
            // 
            // btnBackToAdminPage
            // 
            this.btnBackToAdminPage.Location = new System.Drawing.Point(17, 371);
            this.btnBackToAdminPage.Name = "btnBackToAdminPage";
            this.btnBackToAdminPage.Size = new System.Drawing.Size(106, 49);
            this.btnBackToAdminPage.TabIndex = 1;
            this.btnBackToAdminPage.Text = "Atgal";
            this.btnBackToAdminPage.UseVisualStyleBackColor = true;
            this.btnBackToAdminPage.Click += new System.EventHandler(this.btnBackToAdminPage_Click);
            // 
            // dataGridViewLecturers
            // 
            this.dataGridViewLecturers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLecturers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LecturerName});
            this.dataGridViewLecturers.Location = new System.Drawing.Point(17, 106);
            this.dataGridViewLecturers.Name = "dataGridViewLecturers";
            this.dataGridViewLecturers.Size = new System.Drawing.Size(710, 189);
            this.dataGridViewLecturers.TabIndex = 2;
            this.dataGridViewLecturers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLecturers_CellContentClick);
            // 
            // LecturerName
            // 
            this.LecturerName.HeaderText = "Name";
            this.LecturerName.Name = "LecturerName";
            // 
            // ManageLecturersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewLecturers);
            this.Controls.Add(this.btnBackToAdminPage);
            this.Controls.Add(this.label1);
            this.Name = "ManageLecturersForm";
            this.Text = "ManageLecturersForm";
            this.Load += new System.EventHandler(this.ManageLecturersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLecturers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBackToAdminPage;
        private System.Windows.Forms.DataGridView dataGridViewLecturers;
        private System.Windows.Forms.DataGridViewTextBoxColumn LecturerName;
    }
}