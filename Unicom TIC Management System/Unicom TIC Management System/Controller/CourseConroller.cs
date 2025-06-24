using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;
using Unicom_TIC_Management_System.Data;
using Unicom_TIC_Management_System.Model;

namespace Unicom_TIC_Management_System.Controller
{
    internal class CourseConroller
    {
        public void AddCouse(Course course)
        {
            using (SQLiteConnection conn = DBConfig.GetConnection()) // fix: use your DBConfig connection
            {
                string query = "INSERT INTO Course (CourseName, CourseType, Duration) VALUES (@Name, @CourseType, @Duration)";

                try
                {
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", course.Name);
                        cmd.Parameters.AddWithValue("@CourseType", course.CourseType);
                        cmd.Parameters.AddWithValue("@Duration", course.Duration);

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

        public List<Course> GetCourses()
        {
            List<Course> courses = new List<Course>();

            using (var conn = DBConfig.GetConnection())
            {
                string query = "SELECT * FROM Course"; 
                SQLiteCommand command = new SQLiteCommand(query, conn);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Course course = new Course
                        {
                            CourseID = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            CourseType = reader.GetString(2),
                            Duration = reader.GetString(3) 
                        };

                        courses.Add(course);
                    }
                }
            }

            return courses;
        }
        public List<Course> GetAllCourses()
        {
            List<Course> courses = new List<Course>();

            using (var conn = DBConfig.GetConnection())
            {
                string query = "SELECT CourseName, CourseID FROM Course"; 
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Course course = new Course
                            {
                                CourseID = Convert.ToInt32(reader["CourseID"]),
                                Name = reader["CourseName"].ToString()
                            };
                            courses.Add(course);
                        }
                    }
                }
            }

            return courses;
        }


    }
}
