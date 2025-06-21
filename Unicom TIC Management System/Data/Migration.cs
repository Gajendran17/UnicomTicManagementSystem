using System;
using System.Data.SQLite;

namespace Unicom_TIC_Management_System.Data
{
    internal static class Migration
    {
        public static void CreateTables()
        {
            using (var conn = DBConfig.GetConnection())
            {
                var cmd = conn.CreateCommand();

                cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS User (
                        UserID INTEGER PRIMARY KEY,
                        UserName TEXT NOT NULL,
                        Password TEXT NOT NULL,
                        Role TEXT NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS Mentor (
                        MentorID INTEGER PRIMARY KEY,
                        MentorName TEXT NOT NULL,
                        NIC TEXT NOT NULL,
                        PhNum TEXT NOT NULL,
                        Address TEXT NOT NULL,
                        UserID INTEGER,
                        FOREIGN KEY(UserID) REFERENCES User(UserID)
                    );

                    CREATE TABLE IF NOT EXISTS Admin (
                        AdminID INTEGER PRIMARY KEY,
                        Name TEXT NOT NULL,
                        UserID INTEGER,
                        FOREIGN KEY(UserID) REFERENCES User(UserID)
                    );

                    CREATE TABLE IF NOT EXISTS Lecturer (
                        LecturerID INTEGER PRIMARY KEY,
                        FullName TEXT NOT NULL,
                        LcNIC TEXT NOT NULL,
                        PhNum TEXT NOT NULL,
                        UserID INTEGER,
                        SubjectID INTEGER,
                        FOREIGN KEY(UserID) REFERENCES User(UserID),
                        FOREIGN KEY(SubjectID) REFERENCES Subject(SubjectID)
                    );

                    CREATE TABLE IF NOT EXISTS Student (
                        StudentID INTEGER PRIMARY KEY,
                        Name TEXT NOT NULL,
                        NIC TEXT NOT NULL,
                        Phone TEXT NOT NULL,
                        Address TEXT NOT NULL,
                        CourseID INTEGER,
                        UserID INTEGER,
                        MentorID INTEGER,
                        FOREIGN KEY(CourseID) REFERENCES Course(CourseID),
                        FOREIGN KEY(UserID) REFERENCES User(UserID),
                        FOREIGN KEY(MentorID) REFERENCES Mentor(MentorID)
                    );

                    CREATE TABLE IF NOT EXISTS Course (
                        CourseID INTEGER PRIMARY KEY,
                        CourseName TEXT NOT NULL,
                        CourseType TEXT NOT NULL,
                        Duration TEXT NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS Subject (
                        SubjectID INTEGER PRIMARY KEY,
                        SubjectName TEXT NOT NULL,
                        CourseID INTEGER,
                        FOREIGN KEY(CourseID) REFERENCES Course(CourseID)
                    );

                    CREATE TABLE IF NOT EXISTS Room (
                        RoomID INTEGER PRIMARY KEY,
                        RoomName TEXT NOT NULL,
                        RoomType TEXT NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS Timetable (
                        TimetableID INTEGER PRIMARY KEY,
                        CourseID INTEGER,
                        SubjectID INTEGER,
                        TimeSlot TEXT NOT NULL,
                        RoomID INTEGER,
                        FOREIGN KEY(CourseID) REFERENCES Course(CourseID),
                        FOREIGN KEY(SubjectID) REFERENCES Subject(SubjectID),
                        FOREIGN KEY(RoomID) REFERENCES Room(RoomID)
                    );

                    CREATE TABLE IF NOT EXISTS Exam (
                        ExamID INTEGER PRIMARY KEY,
                        SubjectID INTEGER,
                        StudentID INTEGER,
                        FOREIGN KEY(SubjectID) REFERENCES Subject(SubjectID),
                        FOREIGN KEY(StudentID) REFERENCES Student(StudentID)
                    );

                    CREATE TABLE IF NOT EXISTS Mark (
                        MarkID INTEGER PRIMARY KEY,
                        StudentID INTEGER,
                        ExamID INTEGER,
                        Score INTEGER NOT NULL,
                        FOREIGN KEY(StudentID) REFERENCES Student(StudentID),
                        FOREIGN KEY(ExamID) REFERENCES Exam(ExamID)
                    );
                    ";


                cmd.ExecuteNonQuery();
            }
        }
    }
}
