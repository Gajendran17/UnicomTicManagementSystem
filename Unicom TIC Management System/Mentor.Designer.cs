namespace Unicom_TIC_Management_System
{
    partial class Mentor
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
            this.MtPhnum = new System.Windows.Forms.TextBox();
            this.PhNum = new System.Windows.Forms.Label();
            this.MtNICtxt = new System.Windows.Forms.TextBox();
            this.NIC = new System.Windows.Forms.Label();
            this.MtFullName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.MtPword = new System.Windows.Forms.TextBox();
            this.MtUName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.label5.Location = new System.Drawing.Point(202, 40);
            this.label5.MaximumSize = new System.Drawing.Size(2, 80);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(200, 0, 200, 0);
            this.label5.Size = new System.Drawing.Size(2, 2);
            this.label5.TabIndex = 22;
            this.label5.Text = "STUDENT";
            // 
            // MtPhnum
            // 
            this.MtPhnum.Location = new System.Drawing.Point(368, 179);
            this.MtPhnum.Name = "MtPhnum";
            this.MtPhnum.Size = new System.Drawing.Size(221, 20);
            this.MtPhnum.TabIndex = 27;
            // 
            // PhNum
            // 
            this.PhNum.AutoSize = true;
            this.PhNum.Location = new System.Drawing.Point(263, 179);
            this.PhNum.Name = "PhNum";
            this.PhNum.Size = new System.Drawing.Size(90, 13);
            this.PhNum.TabIndex = 26;
            this.PhNum.Text = "Phone Number   :";
            // 
            // MtNICtxt
            // 
            this.MtNICtxt.Location = new System.Drawing.Point(368, 132);
            this.MtNICtxt.Name = "MtNICtxt";
            this.MtNICtxt.Size = new System.Drawing.Size(221, 20);
            this.MtNICtxt.TabIndex = 25;
            // 
            // NIC
            // 
            this.NIC.AutoSize = true;
            this.NIC.Location = new System.Drawing.Point(266, 132);
            this.NIC.Name = "NIC";
            this.NIC.Size = new System.Drawing.Size(98, 13);
            this.NIC.TabIndex = 24;
            this.NIC.Text = "NIC Number       :   ";
            // 
            // MtFullName
            // 
            this.MtFullName.Location = new System.Drawing.Point(368, 95);
            this.MtFullName.Name = "MtFullName";
            this.MtFullName.Size = new System.Drawing.Size(221, 20);
            this.MtFullName.TabIndex = 23;
            this.MtFullName.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Full Name         :";
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(383, 387);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 20;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(524, 387);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 19;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // MtPword
            // 
            this.MtPword.Location = new System.Drawing.Point(368, 273);
            this.MtPword.Multiline = true;
            this.MtPword.Name = "MtPword";
            this.MtPword.Size = new System.Drawing.Size(221, 23);
            this.MtPword.TabIndex = 18;
            this.MtPword.Text = " ";
            this.MtPword.TextChanged += new System.EventHandler(this.MtPword_TextChanged);
            // 
            // MtUName
            // 
            this.MtUName.Location = new System.Drawing.Point(368, 228);
            this.MtUName.Multiline = true;
            this.MtUName.Name = "MtUName";
            this.MtUName.Size = new System.Drawing.Size(221, 23);
            this.MtUName.TabIndex = 17;
            this.MtUName.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Password           : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "User Name         : ";
            // 
            // Mentor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MtPhnum);
            this.Controls.Add(this.PhNum);
            this.Controls.Add(this.MtNICtxt);
            this.Controls.Add(this.NIC);
            this.Controls.Add(this.MtFullName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.MtPword);
            this.Controls.Add(this.MtUName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Mentor";
            this.Text = "Mentor";
            this.Load += new System.EventHandler(this.Mentor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MtPhnum;
        private System.Windows.Forms.Label PhNum;
        private System.Windows.Forms.TextBox MtNICtxt;
        private System.Windows.Forms.Label NIC;
        private System.Windows.Forms.TextBox MtFullName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox MtPword;
        private System.Windows.Forms.TextBox MtUName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}