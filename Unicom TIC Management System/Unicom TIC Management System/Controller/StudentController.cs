
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
    internal class StudentController
    {
        public void AddStudent(Student student)
        {
            using (SQLiteConnection conn = DBConfig.GetConnection())
            {
                string query = "INSERT INTO Student (Name, NIC, Phone, Address, UserId,CourseID) VALUES (@Name, @NIC, @Phone, @Address, @UserId,@CourseID)";
                try
                {
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", student.Name);
                        cmd.Parameters.AddWithValue("@NIC", student.NIC);
                        cmd.Parameters.AddWithValue("@Phone", student.Phone);
                        cmd.Parameters.AddWithValue("@Address", student.Address);
                        cmd.Parameters.AddWithValue("@UserId", student.UserId);
                        cmd.Parameters.AddWithValue("@CourseID", student.CourseID);  


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

        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();

            using (var conn = DBConfig.GetConnection())
            {
                string query = "SELECT * FROM Student";
                SQLiteCommand command = new SQLiteCommand(query, conn);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Student student = new Student
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            NIC = reader.GetString(2),
                            Phone = reader.GetString(3),
                            Address = reader.GetString(4),
                        };
                        students.Add(student);
                    }
                }

            }

            return students;
        }

        public void DeleteStudent(int id)
        {
            using (var conn = DBConfig.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Student WHERE StudentID = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        
        

    }
}
