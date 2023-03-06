using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management
{
    public class Doctor : Personnel
    {
        public string DoctorId { get; private set; }
        public string Specialization {get; private set; }
        
        public Doctor (string name, string employeeID, string contact, DateTime birthDate,DateTime timeIn,DateTime timeOut, string doctorId, string specialization) : base(name, employeeID, contact, birthDate, timeIn, timeOut) 
        {
            this.DoctorId = doctorId;
            this.Specialization = specialization;
        }
    }
}
