using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_TIC_Management_System.Model
{
    internal class Course
    {
        public int CourseID { get; set; }
        public string Name { get; set; }
        public string CourseType { get; set; }
        public string Duration { get; set; }

        public string CourseName => Name;

    }
}
