using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management
{
    public class Patient
    {
        public string Name { get; set; }
        public DateTime AdmissionDuration { get; set; }
        public Patient(string name, DateTime admissionDuration) 
        {
            this.Name = name;
            this.AdmissionDuration = admissionDuration; 
        }
    }
}
