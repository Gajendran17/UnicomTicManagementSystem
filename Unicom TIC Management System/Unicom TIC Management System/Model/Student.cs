using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_TIC_Management_System.Model
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NIC { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserRole { get; set; }
        public int UserId { get; set; }
        public int CourseID { get; set; }

        public string CourseName { get; set; }

    }
}
