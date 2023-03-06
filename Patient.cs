using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management
{
    public class Patient
    {
        public string Name { get; private set; }
        public DateTime AdmissionDuration { get; private set; }
        public string ContactInformation { get; private set; }
        public string Sex { get; private set; } 
        public Patient(string name, DateTime admissionDuration, string contactInformation, string sex) 
        {
            this.Name = name;
            this.AdmissionDuration = admissionDuration; 
            this.ContactInformation = contactInformation;
            this.Sex = sex;
        }

        
    }
}
