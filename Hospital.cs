using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management
{
    public class Hospital 
    {
        private List<Patient> patients;
        private List<Doctor> doctors;
        private List<Appointments> appointments;
        public int MaxCapacity { get; private set; }
        public int CurrentPassengerCount { get; private set; }

        public Hospital(int maxCapacity, int currentPassengerCount)
        {
            patients = new List<Patient>();
            doctors = new List<Doctor>();
            appointments = new List<Appointments>();
            this.MaxCapacity = maxCapacity;
            this.CurrentPassengerCount = currentPassengerCount;
        }

        public void AddPatient(Patient patient)
        {
            if (CurrentPassengerCount == 0 || CurrentPassengerCount < MaxCapacity)
            {
                patients.Add(patient);
            }
            
        }

        public void AddDoctor(Doctor doctor)
        {
            this.doctors.Add(doctor);
        }

        public void ScheduleAppointment(Appointments appointment)
        {
            appointments.Add(appointment);
        }

        public List<Appointments> GetAppointmentsForDoctor(string doctorName)
        {
            List<Appointments> doctorAppointments = new List<Appointments>();
            foreach (Appointments appointment in appointments)
            {
                if (appointment.Doctor.Name == doctorName)
                {
                    doctorAppointments.Add(appointment);
                }
            }
            return doctorAppointments;
        }

        public List<Appointments> GetAppointmentsForPatient(string patientName)
        {
            List<Appointments> patientAppointments = new List<Appointments>();
            foreach (Appointments appointment in appointments)
            {
                if (appointment.Patient.Name == patientName)
                {
                    patientAppointments.Add(appointment);
                }
            }
            return patientAppointments;
        }
    }
}
