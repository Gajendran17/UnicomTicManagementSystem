using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom_TIC_Management_System.Controller;
using Unicom_TIC_Management_System.Model;

namespace Unicom_TIC_Management_System
{
    public partial class StudentInfo : Form
    {
        public StudentInfo()
        {
            InitializeComponent();
        }

        private void StudentInfo_Load(object sender, EventArgs e)
        {
           
        }
        internal void LoadStudents()
        {
            var studentController = new StudentController();
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = studentController.GetAllStudents();


        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();

            StudenAccountCreate studentInfo = new StudenAccountCreate
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            MainPanel.Controls.Add(studentInfo); 
            studentInfo.Show();
           
            dgvStudents.Hide();
            label2.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvStudents.SelectedRows.Count > 0)
            //{
            //    var row = dgvStudents.SelectedRows[0];
            //    var studentView = row.DataBoundItem as Student;


            //    if (studentView != null)
            //    {
            //        int SelectedStudentId = studentView.Id;
            //    }
            //}
        }
    }
}
