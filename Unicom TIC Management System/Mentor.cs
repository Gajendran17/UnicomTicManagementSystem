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
    public partial class Mentor : Form
    {
        public Mentor()
        {
            InitializeComponent();
        }

        private void Mentor_Load(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                userName = MtUName.Text,
                password = MtPword.Text,
                UserRole = "Mentor"
            };

            UserController userController = new UserController();
            int userId = userController.AddUser(user);
            Mentor mentor = new Mentor()
            {
           
            };
        }

        private void MtPword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
