using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hospital_Management
{
    public abstract class Personnel
    {
        public string Name { get; private set; }
        public string EmployeeID { get; private set; }
        public string Contact { get; private set; }
        public DateTime BirthDate { get; private set; } 
        public DateTime TimeIn { get; private set; }
        public DateTime TimeOut { get; private set; }
        public Personnel(string name, string employeeID, string contact , DateTime birthDate, DateTime timeIn, DateTime timeOut) 
        {
            this.Name = name;
            this.EmployeeID = employeeID;
            this.Contact = contact;
            this.BirthDate = birthDate;
            this.TimeIn = timeIn;
            this.TimeOut = timeOut; 
        }
    }
}
