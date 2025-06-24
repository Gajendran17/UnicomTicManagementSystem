using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
          
            if (dgvStudents.SelectedRows.Count > 0)
            {
                var selectedRow = dgvStudents.SelectedRows[0];

                
                var selectedStudent = selectedRow.DataBoundItem as Student;
                name.Text = selectedStudent.Name;
                if (selectedStudent != null)
                {
                   
                    name.Text = selectedStudent.Name;
                   

                    ID.Text =  selectedStudent.Id.ToString(); 

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this student?",
                                                          "Confirm Deletion",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        
                        StudentController controller = new StudentController();
                        controller.DeleteStudent(selectedStudent.Id);

                        
                        LoadStudents();

                        
                        name.Clear();
                        ID.Clear();
                    }
                }
            }
            else
            {
                
                MessageBox.Show("Please select a student to delete.");
            }
        }

        private void dgvStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
               
                var selectedRow = dgvStudents.SelectedRows[0];

                
                var selectedStudent = selectedRow.DataBoundItem as Student;

                if (selectedStudent != null)
                {
                    
                    name.Text = selectedStudent.Name;  
                    ID.Text = selectedStudent.Id.ToString();  
                }
            }
            else
            {
                
                name.Clear();
                ID.Clear();
            }
        }

        private void DeleteStudent_Click(object sender, EventArgs e)
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

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
