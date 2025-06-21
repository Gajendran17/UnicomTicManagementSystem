namespace Unicom_TIC_Management_System
{
    partial class DeshBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeshBoard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Out = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Addmin = new System.Windows.Forms.Button();
            this.Staff = new System.Windows.Forms.Button();
            this.Lecturer = new System.Windows.Forms.Button();
            this.Student = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.BackgroundImage = global::Unicom_TIC_Management_System.Properties.Resources.th;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Out);
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.Addmin);
            this.panel1.Controls.Add(this.Staff);
            this.panel1.Controls.Add(this.Lecturer);
            this.panel1.Controls.Add(this.Student);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 475);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Out
            // 
            this.Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Out.Location = new System.Drawing.Point(69, 413);
            this.Out.Name = "Out";
            this.Out.Size = new System.Drawing.Size(64, 25);
            this.Out.TabIndex = 6;
            this.Out.Text = "Out";
            this.Out.UseVisualStyleBackColor = true;
            this.Out.Click += new System.EventHandler(this.Out_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(3, 413);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(49, 25);
            this.Back.TabIndex = 5;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Addmin
            // 
            this.Addmin.Location = new System.Drawing.Point(12, 217);
            this.Addmin.Name = "Addmin";
            this.Addmin.Size = new System.Drawing.Size(110, 20);
            this.Addmin.TabIndex = 3;
            this.Addmin.Text = "Addmin";
            this.Addmin.UseVisualStyleBackColor = true;
            // 
            // Staff
            // 
            this.Staff.Location = new System.Drawing.Point(12, 180);
            this.Staff.Name = "Staff";
            this.Staff.Size = new System.Drawing.Size(110, 20);
            this.Staff.TabIndex = 2;
            this.Staff.Text = "Staff";
            this.Staff.UseVisualStyleBackColor = true;
            // 
            // Lecturer
            // 
            this.Lecturer.Location = new System.Drawing.Point(12, 137);
            this.Lecturer.Name = "Lecturer";
            this.Lecturer.Size = new System.Drawing.Size(110, 20);
            this.Lecturer.TabIndex = 1;
            this.Lecturer.Text = "Lecturer";
            this.Lecturer.UseVisualStyleBackColor = true;
            this.Lecturer.Click += new System.EventHandler(this.button2_Click);
            // 
            // Student
            // 
            this.Student.Location = new System.Drawing.Point(12, 100);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(110, 20);
            this.Student.TabIndex = 0;
            this.Student.Text = "Student";
            this.Student.UseVisualStyleBackColor = true;
            this.Student.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.BackgroundImage = global::Unicom_TIC_Management_System.Properties.Resources.th;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Location = new System.Drawing.Point(139, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 67);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // MainPanel
            // 
            this.MainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainPanel.BackgroundImage")));
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainPanel.Controls.Add(this.panel4);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.ForeColor = System.Drawing.Color.Black;
            this.MainPanel.Location = new System.Drawing.Point(139, 67);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(615, 408);
            this.MainPanel.TabIndex = 2;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 390);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(611, 14);
            this.panel4.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 20);
            this.button1.TabIndex = 7;
            this.button1.Text = "Corse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DeshBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Unicom_TIC_Management_System.Properties.Resources.th;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(754, 475);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DeshBoard";
            this.Text = "DeshBoard";
            this.panel1.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Student;
        private System.Windows.Forms.Button Addmin;
        private System.Windows.Forms.Button Staff;
        private System.Windows.Forms.Button Lecturer;
        private System.Windows.Forms.Button Out;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button button1;
    }
}