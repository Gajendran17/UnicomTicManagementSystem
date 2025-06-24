using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;
using Unicom_TIC_Management_System.Data;
using Unicom_TIC_Management_System.Model;

namespace Unicom_TIC_Management_System.Controller
{
    internal class LectureController
    {
        public void AddLecturer(Lecture lecture)
        {
            using (SQLiteConnection conn = DBConfig.GetConnection())
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
INSERT INTO Lecturer 
  (FullName, LcNIC, PhNum, UserID, SubjectID)
VALUES
  (@FullName, @LcNIC, @PhNum, @UserID, @SubjectID);
";
                cmd.Parameters.AddWithValue("@FullName", lecture.Name);
                cmd.Parameters.AddWithValue("@LcNIC", lecture.NIC);
                cmd.Parameters.AddWithValue("@PhNum", lecture.Phone);
                cmd.Parameters.AddWithValue("@UserID", lecture.UserID.HasValue ? (object)lecture.UserID.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@SubjectID", lecture.SubjectID.HasValue ? (object)lecture.SubjectID.Value : DBNull.Value);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Lecturer inserted successfully.");
            }
        }

        public List<Lecture> GetAllLecturers()
        {
            List<Lecture> lecturers = new List<Lecture>();
            using (var conn = DBConfig.GetConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT LecturerID, FullName, LcNIC, PhNum, UserID, SubjectID FROM Lecturer";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lecturers.Add(new Lecture
                        {
                            LecturerID = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            NIC = reader.GetString(2),
                            Phone = reader.GetString(3),
                            UserID = reader.IsDBNull(4) ? (int?)null : reader.GetInt32(4),
                            SubjectID = reader.IsDBNull(5) ? (int?)null : reader.GetInt32(5)
                        });
                    }
                }
            }
            return lecturers;
        }



        public void DeleteLecture(int lecturerId)
        {
            using (var conn = DBConfig.GetConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "DELETE FROM Lecturer WHERE LecturerID = @id";
                cmd.Parameters.AddWithValue("@id", lecturerId);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Lecturer deleted successfully.");
            }
        }
    }
}
