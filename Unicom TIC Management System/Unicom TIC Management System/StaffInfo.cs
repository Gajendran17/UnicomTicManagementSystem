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
           
            MainPanel1.Controls.Clear();

           
            StaffCreateAccount staffCreateAccountForm = new StaffCreateAccount();
            
            staffCreateAccountForm.TopLevel = false;           
            staffCreateAccountForm.FormBorderStyle = FormBorderStyle.None;  
            staffCreateAccountForm.Dock = DockStyle.Fill;         
            
            MainPanel1.Controls.Add(staffCreateAccountForm);
            staffCreateAccountForm.Show();
        }
        private DeshBoard _dashboard;

        public StaffInfo(DeshBoard dashboard)
        {
            InitializeComponent();
            _dashboard = dashboard;
        }


        private void DeleteStaff_Click(object sender, EventArgs e)
        {
            DeshBoard dashboard = Application.OpenForms["DeshBoard"] as DeshBoard;

            if (dashboard != null)
            {
                
                StaffInfo staffInfoForm = new StaffInfo(dashboard)
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };

                Panel mainPanel = dashboard.GetMainPanel();
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(staffInfoForm);
                staffInfoForm.Show();
                staffInfoForm.LoadStaff(); 
            }
            else
            {
                MessageBox.Show("Dashboard form not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count > 0)
            {
                
                var selectedRow = dgvStaff.SelectedRows[0];

                var selectedStaff = selectedRow.DataBoundItem as Staff;

                if (selectedStaff != null)
                {
                    
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

                        name.Text = "";
                        ID.Text = "";
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
            if (dgvStaff.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvStaff.SelectedRows[0];

                
                ID.Text = selectedRow.Cells["StaffID"].Value.ToString();
                name.Text = selectedRow.Cells["StaffName"].Value.ToString();
               
                
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
