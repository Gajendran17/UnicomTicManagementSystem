namespace Unicom_TIC_Management_System
{
    partial class LecturerAccountCreation
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
            this.label5 = new System.Windows.Forms.Label();
            this.LcPhnum = new System.Windows.Forms.TextBox();
            this.PhNum = new System.Windows.Forms.Label();
            this.LcNICtxt = new System.Windows.Forms.TextBox();
            this.NIC = new System.Windows.Forms.Label();
            this.LcFullName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.LcPword = new System.Windows.Forms.TextBox();
            this.LcUName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Subject = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(162, 40);
            this.label5.MaximumSize = new System.Drawing.Size(2, 80);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(200, 0, 200, 0);
            this.label5.Size = new System.Drawing.Size(2, 2);
            this.label5.TabIndex = 24;
            this.label5.Text = "LECTURER";
            // 
            // LcPhnum
            // 
            this.LcPhnum.Location = new System.Drawing.Point(328, 179);
            this.LcPhnum.Name = "LcPhnum";
            this.LcPhnum.Size = new System.Drawing.Size(221, 20);
            this.LcPhnum.TabIndex = 29;
            // 
            // PhNum
            // 
            this.PhNum.AutoSize = true;
            this.PhNum.Location = new System.Drawing.Point(223, 179);
            this.PhNum.Name = "PhNum";
            this.PhNum.Size = new System.Drawing.Size(90, 13);
            this.PhNum.TabIndex = 28;
            this.PhNum.Text = "Phone Number   :";
            // 
            // LcNICtxt
            // 
            this.LcNICtxt.Location = new System.Drawing.Point(328, 132);
            this.LcNICtxt.Name = "LcNICtxt";
            this.LcNICtxt.Size = new System.Drawing.Size(221, 20);
            this.LcNICtxt.TabIndex = 27;
            // 
            // NIC
            // 
            this.NIC.AutoSize = true;
            this.NIC.Location = new System.Drawing.Point(226, 132);
            this.NIC.Name = "NIC";
            this.NIC.Size = new System.Drawing.Size(98, 13);
            this.NIC.TabIndex = 26;
            this.NIC.Text = "NIC Number       :   ";
            // 
            // LcFullName
            // 
            this.LcFullName.Location = new System.Drawing.Point(328, 95);
            this.LcFullName.Name = "LcFullName";
            this.LcFullName.Size = new System.Drawing.Size(221, 20);
            this.LcFullName.TabIndex = 25;
            this.LcFullName.TextChanged += new System.EventHandler(this.LcFullName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Full Name         :";
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(343, 387);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 21;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(484, 387);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 20;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // LcPword
            // 
            this.LcPword.Location = new System.Drawing.Point(328, 273);
            this.LcPword.Multiline = true;
            this.LcPword.Name = "LcPword";
            this.LcPword.Size = new System.Drawing.Size(221, 23);
            this.LcPword.TabIndex = 19;
            // 
            // LcUName
            // 
            this.LcUName.Location = new System.Drawing.Point(328, 228);
            this.LcUName.Multiline = true;
            this.LcUName.Name = "LcUName";
            this.LcUName.Size = new System.Drawing.Size(221, 23);
            this.LcUName.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Password           : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "User Name         : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Subject           : ";
            // 
            // Subject
            // 
            this.Subject.FormattingEnabled = true;
            this.Subject.Location = new System.Drawing.Point(328, 309);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(221, 21);
            this.Subject.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(288, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(271, 27);
            this.label6.TabIndex = 32;
            this.label6.Text = "Create Lecturer Account";
            // 
            // LecturerAccountCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 466);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LcPhnum);
            this.Controls.Add(this.PhNum);
            this.Controls.Add(this.LcNICtxt);
            this.Controls.Add(this.NIC);
            this.Controls.Add(this.LcFullName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.LcPword);
            this.Controls.Add(this.LcUName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LecturerAccountCreation";
            this.Text = "Lecturer";
            this.Load += new System.EventHandler(this.LecturerAccountCreation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LcPhnum;
        private System.Windows.Forms.Label PhNum;
        private System.Windows.Forms.TextBox LcNICtxt;
        private System.Windows.Forms.Label NIC;
        private System.Windows.Forms.TextBox LcFullName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox LcPword;
        private System.Windows.Forms.TextBox LcUName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Subject;
        private System.Windows.Forms.Label label6;
    }
}