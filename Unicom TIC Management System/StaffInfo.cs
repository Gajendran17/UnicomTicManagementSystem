using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Unicom_TIC_Management_System.Controller;
using Unicom_TIC_Management_System.Model;

namespace Unicom_TIC_Management_System
{
    public partial class StaffInfo : Form
    {
        public StaffInfo()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        internal void LoadStaff()
        {
            var staffConroller = new StaffConroller();
            dgvStaff.DataSource = null;
            dgvStaff.DataSource = staffConroller.GetAllStaff();


        }

        private void AddStaff_Click(object sender, EventArgs e)
        {
           
            MainPanel.Controls.Clear();

           
            StaffCreateAccount staffCreateAccountForm = new StaffCreateAccount();
            
            staffCreateAccountForm.TopLevel = false;           
            staffCreateAccountForm.FormBorderStyle = FormBorderStyle.None;  
            staffCreateAccountForm.Dock = DockStyle.Fill;         
            
            MainPanel.Controls.Add(staffCreateAccountForm);
            staffCreateAccountForm.Show();
        }

        private void DeleteStaff_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();

           
            StaffInfo staffInfoForm = new StaffInfo();

           
            staffInfoForm.TopLevel = false;             
            staffInfoForm.FormBorderStyle = FormBorderStyle.None;  
            staffInfoForm.Dock = DockStyle.Fill;      

            MainPanel.Controls.Add(staffInfoForm);

            staffInfoForm.Show();

            staffInfoForm.LoadStaff();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count > 0)
            {
                // Get selected row
                var selectedRow = dgvStaff.SelectedRows[0];

                // Cast the DataBoundItem to Staff
                var selectedStaff = selectedRow.DataBoundItem as Staff;

                if (selectedStaff != null)
                {
                    // Confirm deletion
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this staff?",
                                                          "Confirm Deletion",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                       
                        StaffConroller controller = new StaffConroller();
                        controller.DeleteStaff(selectedStaff.StaffId); 

                        
                        LoadStaff();

                        MessageBox.Show("Staff deleted successfully.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a staff member to delete.");
            }
        }

        private void dgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvStaff_SelectionChanged(object sender, EventArgs e)
        {
           
        }


    }
}
