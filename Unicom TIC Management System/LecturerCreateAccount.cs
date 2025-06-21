using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unicom_TIC_Management_System.Controller;
using Unicom_TIC_Management_System.Model;

namespace Unicom_TIC_Management_System
{
    public partial class LecturerAccountCreation : Form
    {
        private string LecturerName;
        private readonly LectureController _LectureController;
        public LecturerAccountCreation()
        {
            _LectureController = new LectureController();
            InitializeComponent();
        }

        private void LecturerAccountCreation_Load(object sender, EventArgs e)
        {
            LoadSubjectToComboBox();
        }

        private void LoadSubjectToComboBox()
        {
            SubjectController controller = new SubjectController();
            List<Subject> subjects = controller.GetAllSubject();

            Subject.DataSource = subjects;
            Subject.ValueMember = "CourseID";   
            Subject.DisplayMember = "Name";     
        }


        private void Submit_Click(object sender, EventArgs e)
        {
           Lecture lecturer = new Lecture();

            lecturer.Name = LcFullName.Text;
            lecturer.NIC = LcNICtxt.Text;
            lecturer.Phone = LcPhnum.Text;
            lecturer.UserName = LcUName.Text;
                lecturer.Address = LcPword.Text;


          
           
           //LectureController lectureController = new LectureController();
            _LectureController.AddLecturer(lecturer);

            
           

        }

        private void LcFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Subject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
