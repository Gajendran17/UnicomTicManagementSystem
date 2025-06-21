

using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom_TIC_Management_System.Data;
using Unicom_TIC_Management_System.Model;

namespace Unicom_TIC_Management_System.Controller
{
    internal class SubjectController
    {
        public void AddSbject(Subject subject)
        {
            using (SQLiteConnection conn = DBConfig.GetConnection())
            {
               string query = "INSERT INTO Subject (SubjectName,CourseID) VALUES (@SubjectName,@CourseID)";
                try
                {
                   using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SubjectName", subject.SubjectName);
                        cmd.Parameters.AddWithValue("@CourseID", subject.CourseID);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Inserted Successfully");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public List<Subject> GetSubjects()
        {
            List<Subject> subjects = new List<Subject>();

            using (var conn = DBConfig.GetConnection())
            {
                string query = "SELECT * FROM Subject";
                SQLiteCommand command = new SQLiteCommand(query, conn);

                using ( var reader  = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Subject subject = new Subject
                        {
                            SubjectId = reader.GetInt32(0),
                            SubjectName = reader.GetString(1),
                            CourseID = reader.GetInt32(2)
                        }; 

                        subjects.Add(subject);  
                    }
                }
            }

            return subjects;
        }

        public List<Subject> GetAllSubject()
        {
            List<Subject> subjects = new List<Subject>();

            using (var conn = DBConfig.GetConnection())
            {
                string query = "SELECT SubjectID, SubjectName FROM Subject";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var subject = new Subject
                            {
                                CourseID = Convert.ToInt32(reader["SubjectID"]),  
                                Name = reader["SubjectName"].ToString()
                            };
                            subjects.Add(subject);
                        }
                    }
                }
            }

            return subjects;
        }

    }
}
