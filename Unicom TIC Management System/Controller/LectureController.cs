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
    internal class LectureController
    {
        //internal static void AddLecturer(object lecturer)
        //{
        //    throw new NotImplementedException();
        //}

        public void AddLecturer(Lecture lecture )
        {
            using (SQLiteConnection conn = DBConfig.GetConnection())
            {
                string query = "INSERT INTO Student (Name,NIC,Phone,Address) VALUES (@Name,@NIC,@Phone,@Address)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", lecture.Name);
                    cmd.Parameters.AddWithValue("@NIC", lecture.NIC);
                    cmd.Parameters.AddWithValue("@Phone", lecture.Phone);
                    cmd.Parameters.AddWithValue("@Address", lecture.Address);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Inserted Successfully ");
                }
            }
        }

        public List<Lecture> GetAllLecture(List<Lecture> lecturer)
        {
           // List<Lecture> lecture = new List<Lecture>();

            using (var conn = DBConfig.GetConnection())
            {
                string query = "SELECT * FROM Student";
                SQLiteCommand command = new SQLiteCommand(query, conn);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Lecture lec = new Lecture
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            NIC = reader.GetString(2),
                            Phone = reader.GetString(3),
                            UserName = reader.GetString(4),
                            Address = reader.GetString(4),

                            
                        };
                        lecturer.Add(lec);

                    }
                }

            }

            return lecturer;
        }
    }
}
