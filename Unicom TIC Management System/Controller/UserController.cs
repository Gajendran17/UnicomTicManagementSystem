using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;
using Unicom_TIC_Management_System.Data;
using Unicom_TIC_Management_System.Model;

namespace Unicom_TIC_Management_System.Controller
{
    internal class UserController
    {
        public int AddUser(User user)
        {
            using (SQLiteConnection conn = DBConfig.GetConnection())
            {
                string query = "INSERT INTO User (UserName, Password, Role) VALUES (@UserName, @Password, @Role); SELECT last_insert_rowid();";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", user.userName);
                    cmd.Parameters.AddWithValue("@Password", user.password);
                    cmd.Parameters.AddWithValue("@Role", user.UserRole);

                    // ExecuteScalar returns the value of the first column of the first row
                    int userId = Convert.ToInt32(cmd.ExecuteScalar());
                    return userId;
                }
            }
        }


        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            using (var conn = DBConfig.GetConnection())
            {
                string query = "SELECT * FROM User";
                SQLiteCommand command = new SQLiteCommand(query, conn);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        User user = new User
                        {
                            userId = reader["UserId"].ToString(),
                            userName = reader["UserName"].ToString(),
                            password = reader["Password"].ToString(),
                            UserRole = reader["Role"].ToString()
                        };

                        users.Add(user);
                    }
                }
            }

            return users;
        }
    }
}
