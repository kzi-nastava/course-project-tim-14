using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Login
{
    public class DoctorRepository
    {
        public List<Doctor> doctors = new List<Doctor>();

        public void LoadDoctors(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] data = line.Split('|');
                Doctor doctor = new Doctor(Int32.Parse(data[0]), data[1], data[2], data[3], data[4], data[5], float.Parse(data[6]));
                doctors.Add(doctor);
            }
        }

        public DoctorRepository(string fileName) {
            LoadDoctors(fileName);
        }

        public DoctorRepository()
        {
        }

        public List<Doctor> GetSearchedDoctors(int fieldNum, string text) {
            List<Doctor> searchedDoctors = new List<Doctor>();
            foreach (Doctor doctor in doctors)
                if (doctor.GetChoosenField(fieldNum).Contains(text))
                    searchedDoctors.Add(doctor);
            return searchedDoctors;
            
        }

        public string FindDoctorType(string name) {
            foreach (Doctor doctor in doctors)
                if (doctor.name == name)
                    return doctor.type;
            return null;
        }
        
    }
}
