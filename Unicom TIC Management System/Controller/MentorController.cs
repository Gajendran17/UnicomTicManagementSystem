using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicom_TIC_Management_System.Data;

namespace Unicom_TIC_Management_System.Controller
{
    internal class MentorController
    {
        public void AddMentor(Mentor mentor)
        {
            using (SQLiteConnection conn = DBConfig.GetConnection())
            {
                string query = "INSERT INTO Mentor (MentorName, PhNum, Address,) VALUES (@MentorName, @PhNum, @Address,)";
             
            
            }
        }
    }
}
