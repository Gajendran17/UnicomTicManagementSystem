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
    public partial class SubjectForm : Form
    {
        public SubjectForm()
        {
            InitializeComponent();
        }

        private void SubjectForm_Load(object sender, EventArgs e)
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


        private void CsNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SubjectNameTxt.Text) || CourseNameComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please fill all subject details.");
                return;
            }

            Subject subject = new Subject()
            {
                SubjectName = SubjectNameTxt.Text.Trim(),
                CourseID = Convert.ToInt32(CourseNameComboBox.SelectedValue) 
            };

            SubjectController controller = new SubjectController();
            controller.AddSbject(subject);
        }

        private void CourseNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
