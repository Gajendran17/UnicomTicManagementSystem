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

namespace Unicom_TIC_Management_System
{
    public partial class MainLogin : Form
    {
        public MainLogin()
        {
            InitializeComponent();
            comboBox1.Items.Add("Staff");
            comboBox1.Items.Add("Lecturer");
            comboBox1.Items.Add("Student");

           // comboBox1.SelectedItem = "Student";

            comboBox1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Show();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            AdminConroller adminController = new AdminConroller();

            if (adminController.Login(username, password))
            {
                MessageBox.Show("Login Successful! Welcome Admin.");
                // Proceed to admin dashboard or next form
                DeshBoard form2 = new DeshBoard();
                this.Hide();

                // Show the form (non-modal)
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }

            
        }

        private void MainLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (!initialized)
            //    return;

            string selectedItem = comboBox1.SelectedItem.ToString();

            switch (selectedItem)
            {
                case "Staff":
                    new StaffCreateAccount().Show();
                    break;
                case "Lecturer":
                    new LecturerAccountCreation().Show();
                    break;
                case "Student":
                    new StudenAccountCreate().Show();
                    break;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
