using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom_TIC_Management_System.Controller;
using Unicom_TIC_Management_System.Data;
using Unicom_TIC_Management_System.Model;

namespace Unicom_TIC_Management_System
{
    public partial class StudenAccountCreate : Form
    {
        public StudenAccountCreate()
        {
            InitializeComponent();

            
        }

        private void CreatAccount_Load(object sender, EventArgs e)
        {
            LoadCoursesToComboBox();

        }
        private void LoadCoursesToComboBox()
        {
            CourseConroller controller = new CourseConroller();
            List<Course> courses = controller.GetAllCourses();

            CourseNameComboBox.DataSource = courses;
            CourseNameComboBox.ValueMember = "CourseID";
            CourseNameComboBox.DisplayMember = "CourseName";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                userName = StUName.Text,
                password = StPword.Text,
                UserRole = "Student"
            };

            UserController userController = new UserController();
            int userId = userController.AddUser(user); 
            Student student = new Student()
            {
                Name = StFullName.Text,
                NIC = StNICtxt.Text,
                Phone = StPhnum.Text,
                Address = StAddress.Text,
                UserName = StUName.Text,
                UserId = userId,
                CourseID = Convert.ToInt32(CourseNameComboBox.SelectedValue)
            };

            StudentController studentController = new StudentController();
            studentController.AddStudent(student);

            ClearAllTextBoxes(this); 

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxes(this); 

        }
        private void ClearAllTextBoxes(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Clear();
                }
                else if (ctrl.HasChildren)
                {
                    ClearAllTextBoxes(ctrl); 
                }
            }
        }

        private void GoBack_Click(object sender, EventArgs e)
        
        {
            this.Close();
            MainLogin mainLogin = new MainLogin();
            mainLogin.Show();
        }
    
    }
}
