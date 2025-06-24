using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom_TIC_Management_System.Data;
using Unicom_TIC_Management_System.Model;

namespace Unicom_TIC_Management_System.Controller
{
    internal class StaffConroller
    {
        public void AddStaff(Staff staff)
        {
            using (SQLiteConnection conn = DBConfig.GetConnection())
            {
                string query = " INSERT INTO Staff (StaffName, StaffNIC, StaffPhNum, UserID) VALUES (@Name, @NIC, @PhNum, @UserId)";
                try
                {
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", staff.StaffName);
                        cmd.Parameters.AddWithValue("@NIC", staff.StaffNIC);
                        cmd.Parameters.AddWithValue("@PhNum", staff.StaffPhNum);
                        cmd.Parameters.AddWithValue("@UserId", staff.UserID);


                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Staff Inserted Successfully");
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        public List<Staff> GetAllStaff()
        {
            List<Staff> staffList = new List<Staff>();   

            using (var conn = DBConfig.GetConnection())
            {
                string query = "SELECT * FROM Staff";
                SQLiteCommand command = new SQLiteCommand(query, conn);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Staff staff = new Staff
                        {
                           StaffId = reader.GetInt32(0),
                           StaffName = reader.GetString(1),
                           StaffNIC = reader.GetString(2),
                           StaffPhNum = reader.GetString(3),
                           
                        };
                        staffList.Add(staff);
                    }
                }
            }

            return staffList;
        }

        public void DeleteStaff(int id)
        {
            using (var conn = DBConfig.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Staff WHERE StaffID = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        
    }
}
