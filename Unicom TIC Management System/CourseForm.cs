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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Unicom_TIC_Management_System
{
    public partial class CourseForm : Form
    {
        

        public string Duration { get; private set; }
        public string CourseType { get; private set; }
        public int CourseID { get; internal set; }

        public CourseForm()
        {
            InitializeComponent();
           

            CourseTypebox.Items.Add("Diploma");
            CourseTypebox.Items.Add("HND");
            CourseTypebox.Items.Add("BSc(Hons)");

            CourseTypebox.SelectedIndex = 0;

            CourseDuration.Items.Add("1 Year");
            CourseDuration.Items.Add("2 years");
            CourseDuration.Items.Add("4 years");

            CourseDuration.SelectedIndex = 0;
    

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CsNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void CourseType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CourseDuration_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(CsNametxt.Text) ||
                    CourseTypebox.SelectedItem == null ||
                    CourseDuration.SelectedItem == null)
                {
                    MessageBox.Show("Please fill all course details.");
                    return;
                }

                Course course = new Course()
                {
                    Name = CsNametxt.Text.Trim(),
                    CourseType = CourseTypebox.SelectedItem.ToString(), 
                    Duration = CourseDuration.SelectedItem.ToString()    
                };

                CourseConroller courseConroller = new CourseConroller();
                courseConroller.AddCouse(course);
                LoadCourse(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving course: " + ex.Message);
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Course_Load(object sender, EventArgs e)
        {
            LoadCourse();
        }
        internal void LoadCourse()
        {
            try
            {
                CourseConroller controller = new CourseConroller();
                List<Course> courseList = controller.GetCourses();

                dataGridView1.DataSource = null;
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = courseList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load courses: " + ex.Message);
            }
        }

    }
}
