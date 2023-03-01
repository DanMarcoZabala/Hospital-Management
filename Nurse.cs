using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management
{
    public class Nurse : Personnel
    {
        public int PatientCount { get; private set; }
        public Nurse(string name, string employeeID, string contact, DateTime birthDate, DateTime timeIn, DateTime timeOut) : base(name, employeeID, contact, birthDate,timeIn,timeOut)
        {
            this.PatientCount = 0;
        }
    }
}
