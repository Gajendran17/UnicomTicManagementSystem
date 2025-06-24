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
    public partial class LectureInfo : Form
    {
        private readonly DeshBoard _parentDashboard;

        public LectureInfo()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
        }

        private void AddStaff_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();


            LecturerAccountCreation lecturerAccountCreation = new LecturerAccountCreation
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            panel3.Controls.Add(lecturerAccountCreation);
            lecturerAccountCreation.Show();

            dgvLecture.Hide();
            label2.Hide();
            panel1.Hide();



        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DeleteStaff_Click(object sender, EventArgs e)
        {
           
            panel3.Controls.Clear();

            LectureInfo lectureInfoForm = new LectureInfo();

            panel3.Controls.Add(lectureInfoForm);

            lectureInfoForm.Show();

            
        }

        private void dgvLecture_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LectureInfo_Load(object sender, EventArgs e)
        {
           

        }

       



    }
}
