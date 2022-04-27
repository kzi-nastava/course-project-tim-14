using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Login
{
    public class PatientRepository
    {
        public List<Patient> patients = new List<Patient>();

        public void LoadPatients(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] data = line.Split('|');
                Patient patient = new Patient(Int32.Parse(data[0]), data[1], data[2], data[3], data[4]);
                patients.Add(patient);
            }
        }
        public Patient FindPatient(string email)
        {
            foreach (Patient patient in patients)
            {
                if (patient.email.Equals(email))
                {
                    return patient;
                }
            }
            return null;
        }
    }
}

