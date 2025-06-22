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
    public partial class StaffCreateAccount : Form
    {
        public StaffCreateAccount()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                userName = SfUName.Text,
                password = SfPword.Text,
                UserRole = "Staff"
            };

           UserController userController = new UserController();
            int UserID = userController.AddUser(user);

            Staff staff = new Staff()
            {
                StaffName = SfUName.Text,
                StaffNIC = SfNICtxt.Text,
                StaffPhNum = SfPhnum.Text,
                UserID = UserID
            };

            StaffConroller staffConroller = new StaffConroller();
            staffConroller.AddStaff(staff);

        }


        private void StaffCreateAccount_Load(object sender, EventArgs e)
        {
            
        }

    }

    
}
