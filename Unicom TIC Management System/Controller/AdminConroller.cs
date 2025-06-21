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
    internal class AdminConroller
    {
        // Hardcoded admin credentials
        private const string AdminUsername = "admin";
        private const string AdminPassword = "1234";

        public bool Login(string username, string password)
        {
            return username == AdminUsername && password == AdminPassword;
        }

        public void AddAdmin(Student student)
        {
            using (SQLiteConnection conn = DBConfig.GetConnection())
            {
                string query = "INSERT INTO Admin (Name,password) VALUES (@Name,@Password)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", AdminUsername);
                    cmd.Parameters.AddWithValue("@NIC", AdminPassword);
                   
                    cmd.ExecuteNonQuery();
                    
                }
            }
        }

    }
}
