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
        
        private const string AdminUsername = "admin";
        private const string AdminPassword = "1234";

        public bool Login(string username, string password)
        {
            return username == AdminUsername && password == AdminPassword;
        }

        public void AddAdmin(int userId)
        {
            using (var conn = DBConfig.GetConnection())
            {
                using (var pragma = new SQLiteCommand("PRAGMA foreign_keys = ON;", conn))
                    pragma.ExecuteNonQuery();

                string query = @"
            INSERT INTO Admin (Name, UserID)
            VALUES (@Name, @UserID);";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", AdminUsername);
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Admin record created successfully");
                }
            }
        }
        


    }
}
