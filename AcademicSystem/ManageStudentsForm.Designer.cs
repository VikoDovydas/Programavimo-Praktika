namespace AcademicSystem
{
    partial class ManageStudentsForm
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.DeleteButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBackToAdminPage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeleteButtonColumn});
            this.dataGridView2.Location = new System.Drawing.Point(12, 116);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(738, 253);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // DeleteButtonColumn
            // 
            this.DeleteButtonColumn.HeaderText = "Action";
            this.DeleteButtonColumn.Name = "DeleteButtonColumn";
            this.DeleteButtonColumn.Text = "Delete";
            // 
            // btnBackToAdminPage
            // 
            this.btnBackToAdminPage.Location = new System.Drawing.Point(12, 392);
            this.btnBackToAdminPage.Name = "btnBackToAdminPage";
            this.btnBackToAdminPage.Size = new System.Drawing.Size(113, 40);
            this.btnBackToAdminPage.TabIndex = 2;
            this.btnBackToAdminPage.Text = "Atgal";
            this.btnBackToAdminPage.UseVisualStyleBackColor = true;
            this.btnBackToAdminPage.Click += new System.EventHandler(this.btnBackToAdminPage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Priregistruoti studentai:";
            // 
            // ManageStudentsForm
            // 
            this.ClientSize = new System.Drawing.Size(789, 511);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBackToAdminPage);
            this.Controls.Add(this.dataGridView2);
            this.Name = "ManageStudentsForm";
            this.Load += new System.EventHandler(this.ManageStudentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnBackToAdminPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteButtonColumn;
    }
}