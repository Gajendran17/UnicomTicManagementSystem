using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_TIC_Management_System.Model
{
    public class Lecture
    {
        public int LecturerID { get; set; }
        public string Name { get; set; }
        public string NIC { get; set; }
        public string Phone { get; set; }
        public int? UserID { get; set; }
        public int? SubjectID { get; set; }
    }


}
