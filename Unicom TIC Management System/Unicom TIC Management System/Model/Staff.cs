using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_TIC_Management_System.Model
{
    internal class Staff
    {
        public int StaffId { get; set; }
        public object StaffID { get; internal set; }
        public string StaffNIC { get; set; }
        public string StaffName { get; set; }
        public string StaffPhNum { get; set; }
        public string Password { get; set; }
        public string UserRole { get; set; }
        public int UserID { get; set; }
        public string Name { get; internal set; }
    }
}
