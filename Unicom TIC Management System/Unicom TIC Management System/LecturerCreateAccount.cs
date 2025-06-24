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
            var controller = new SubjectController();
            var subjects = controller.GetAllSubject();

            Subject.DataSource = null;
            Subject.DataSource = subjects;
            Subject.ValueMember = "SubjectId";
            Subject.DisplayMember = "SubjectName";
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            
            User user = new User
            {
                userName = LcUName.Text.Trim(),
                password = LcPword.Text.Trim(),
                UserRole = "Lecturer"
            };

            UserController userController = new UserController();
            int newUserId = userController.AddUser(user);

            
            Lecture lecturer = new Lecture
            {
                Name = LcFullName.Text.Trim(),
                NIC = LcNICtxt.Text.Trim(),
                Phone = LcPhnum.Text.Trim(),
                UserID = newUserId,
                SubjectID = Subject.SelectedValue is int id ? id : (int?)null
            };

            _LectureController.AddLecturer(lecturer);

            
            ClearAllTextBoxes(this);
        }

        private void LcFullName_TextChanged(object sender, EventArgs e) { }

        private void Subject_SelectedIndexChanged(object sender, EventArgs e) { }

        private void Reset_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxes(this);
        }

        public void ClearAllTextBoxes(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox tb)
                {
                    tb.Clear();
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
