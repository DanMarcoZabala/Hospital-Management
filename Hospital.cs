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

        public Hospital()
        {
            patients = new List<Patient>();
            doctors = new List<Doctor>();
            appointments = new List<Appointments>();
        }

        public void AddPatient(Patient patient)
        {
            patients.Add(patient);
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
