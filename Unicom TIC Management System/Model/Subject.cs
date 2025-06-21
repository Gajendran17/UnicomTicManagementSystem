using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_TIC_Management_System.Model
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public int CourseID {  get; set; }
        public string Name { get; internal set; }

        internal void Add(Subject subjects)
        {
            throw new NotImplementedException();
        }
    }
}
