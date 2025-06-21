namespace Unicom_TIC_Management_System
{
    partial class StudentInfo
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
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UpdateStudent = new System.Windows.Forms.Button();
            this.DeleteStudent = new System.Windows.Forms.Button();
            this.AddStudent = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.panel2.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStudents
            // 
            this.dgvStudents.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(132, 82);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(542, 544);
            this.dgvStudents.TabIndex = 0;
            this.dgvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(15, 0, 16, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Size = new System.Drawing.Size(174, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student Info";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BackgroundImage = global::Unicom_TIC_Management_System.Properties.Resources.th;
            this.panel2.Controls.Add(this.UpdateStudent);
            this.panel2.Controls.Add(this.DeleteStudent);
            this.panel2.Controls.Add(this.AddStudent);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(108, 638);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // UpdateStudent
            // 
            this.UpdateStudent.Location = new System.Drawing.Point(3, 141);
            this.UpdateStudent.Name = "UpdateStudent";
            this.UpdateStudent.Size = new System.Drawing.Size(93, 23);
            this.UpdateStudent.TabIndex = 7;
            this.UpdateStudent.Text = "Update Student";
            this.UpdateStudent.UseVisualStyleBackColor = true;
            // 
            // DeleteStudent
            // 
            this.DeleteStudent.Location = new System.Drawing.Point(3, 97);
            this.DeleteStudent.Name = "DeleteStudent";
            this.DeleteStudent.Size = new System.Drawing.Size(93, 23);
            this.DeleteStudent.TabIndex = 6;
            this.DeleteStudent.Text = "Delete Student";
            this.DeleteStudent.UseVisualStyleBackColor = true;
            // 
            // AddStudent
            // 
            this.AddStudent.Location = new System.Drawing.Point(3, 34);
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Size = new System.Drawing.Size(93, 23);
            this.AddStudent.TabIndex = 5;
            this.AddStudent.Text = "Add Student";
            this.AddStudent.UseVisualStyleBackColor = true;
            this.AddStudent.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.dgvStudents);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1022, 638);
            this.MainPanel.TabIndex = 5;
            // 
            // StudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 638);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MainPanel);
            this.Name = "StudentInfo";
            this.Text = "StudentInfo";
            this.Load += new System.EventHandler(this.StudentInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.panel2.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddStudent;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button DeleteStudent;
        private System.Windows.Forms.Button UpdateStudent;
    }
}