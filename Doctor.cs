﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management
{
    internal class Doctor : Personnel
    {
        public string DoctorId { get; private set; }
        
        public Doctor (string name, string employeeID, string contact, DateTime birthDate,DateTime timeIn,DateTime timeOut, string doctorId) : base(name, employeeID, contact, birthDate, timeIn, timeOut) 
        {
            this.DoctorId = doctorId;
        }
    }
}