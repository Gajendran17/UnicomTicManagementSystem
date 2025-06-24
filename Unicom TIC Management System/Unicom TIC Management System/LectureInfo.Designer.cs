namespace Unicom_TIC_Management_System
{
    partial class LectureInfo
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
            this.dgvLecture = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MainPanel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DeleteStaff = new System.Windows.Forms.Button();
            this.AddStaff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecture)).BeginInit();
            this.panel1.SuspendLayout();
            this.MainPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLecture
            // 
            this.dgvLecture.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvLecture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLecture.Location = new System.Drawing.Point(149, 232);
            this.dgvLecture.Name = "dgvLecture";
            this.dgvLecture.Size = new System.Drawing.Size(525, 394);
            this.dgvLecture.TabIndex = 0;
            this.dgvLecture.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLecture_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(15, 0, 16, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Size = new System.Drawing.Size(173, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lecture Info";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.ID);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 139);
            this.panel1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(562, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(407, 33);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(266, 20);
            this.ID.TabIndex = 11;
            this.ID.Text = " ";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(407, 67);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(266, 20);
            this.name.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // MainPanel1
            // 
            this.MainPanel1.Controls.Add(this.dgvLecture);
            this.MainPanel1.Controls.Add(this.label2);
            this.MainPanel1.Controls.Add(this.panel1);
            this.MainPanel1.Controls.Add(this.panel3);
            this.MainPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel1.Location = new System.Drawing.Point(0, 0);
            this.MainPanel1.Name = "MainPanel1";
            this.MainPanel1.Size = new System.Drawing.Size(800, 450);
            this.MainPanel1.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 450);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BackgroundImage = global::Unicom_TIC_Management_System.Properties.Resources.th;
            this.panel2.Controls.Add(this.DeleteStaff);
            this.panel2.Controls.Add(this.AddStaff);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 450);
            this.panel2.TabIndex = 8;
            // 
            // DeleteStaff
            // 
            this.DeleteStaff.Location = new System.Drawing.Point(4, 116);
            this.DeleteStaff.Name = "DeleteStaff";
            this.DeleteStaff.Size = new System.Drawing.Size(93, 23);
            this.DeleteStaff.TabIndex = 6;
            this.DeleteStaff.Text = " Delete Lecture";
            this.DeleteStaff.UseVisualStyleBackColor = true;
            this.DeleteStaff.Click += new System.EventHandler(this.DeleteStaff_Click);
            // 
            // AddStaff
            // 
            this.AddStaff.Location = new System.Drawing.Point(3, 34);
            this.AddStaff.Name = "AddStaff";
            this.AddStaff.Size = new System.Drawing.Size(93, 23);
            this.AddStaff.TabIndex = 5;
            this.AddStaff.Text = " Add Lecture";
            this.AddStaff.UseVisualStyleBackColor = true;
            this.AddStaff.Click += new System.EventHandler(this.AddStaff_Click);
            // 
            // LectureInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MainPanel1);
            this.Name = "LectureInfo";
            this.Text = "LectureInfo";
            this.Load += new System.EventHandler(this.LectureInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MainPanel1.ResumeLayout(false);
            this.MainPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLecture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DeleteStaff;
        private System.Windows.Forms.Button AddStaff;
        private System.Windows.Forms.Panel MainPanel1;
        private System.Windows.Forms.Panel panel3;
    }
}