using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management
{
    public class Appointments
    {
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime AppointedDateTime { get; set; }

        public Appointments(Patient patient,Doctor doctor, DateTime appointedDateTime) 
        {
        }
    }
}
