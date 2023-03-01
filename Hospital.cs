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
        private List<Appointment> appointments;

        public Hospital()
        {
            patients = new List<Patient>();
            doctors = new List<Doctor>();
            appointments = new List<Appointment>();
        }

        public void AddPatient(Patient patient)
        {
            patients.Add(patient);
        }

        public void AddDoctor(Doctor doctor)
        {
            doctors.Add(doctor);
        }

        public void ScheduleAppointment(Appointment appointment)
        {
            appointments.Add(appointment);
        }

        public List<Appointment> GetAppointmentsForDoctor(string doctorName)
        {
            List<Appointment> doctorAppointments = new List<Appointment>();
            foreach (Appointment appointment in appointments)
            {
                if (appointment.Doctor.Name == doctorName)
                {
                    doctorAppointments.Add(appointment);
                }
            }
            return doctorAppointments;
        }

        public List<Appointment> GetAppointmentsForPatient(string patientName)
        {
            List<Appointment> patientAppointments = new List<Appointment>();
            foreach (Appointment appointment in appointments)
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
