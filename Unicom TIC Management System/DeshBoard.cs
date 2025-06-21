using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unicom_TIC_Management_System
{
    public partial class DeshBoard : Form
    {
        public DeshBoard()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            StudentInfo studentForm = new StudentInfo();    

            studentForm.TopLevel = false;
            studentForm.FormBorderStyle = FormBorderStyle.None;
            studentForm.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(studentForm);
            studentForm.Show();
            studentForm.LoadStudents();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            MainLogin gog = new MainLogin();
            gog.Show(); 
        }

        private void Out_Click(object sender, EventArgs e)
        {
            this.Close();
            MainLogin gog = new MainLogin();
            gog.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            CourseForm courseForm = new CourseForm();

            courseForm.TopLevel = false;
            courseForm.FormBorderStyle = FormBorderStyle.None;
            courseForm.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(courseForm);
            courseForm.Show();
            courseForm.LoadCourse();
        }

    }
    
}
