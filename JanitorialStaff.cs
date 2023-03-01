using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management
{
    internal class JanitorialStaff : Personnel
    {
        public int RoomCount { get; set; }

        public JanitorialStaff(string name, string employeeID, string contact, DateTime birthDate, DateTime timeIn, DateTime timeOut) : base(name, employeeID, contact, birthDate,timeIn,timeOut)
        {
            RoomCount = 0;  
        }
    }
}
