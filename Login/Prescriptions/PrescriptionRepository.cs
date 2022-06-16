using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Login.Prescription
{
    public class PrescriptionRepository
    {
        public List<Prescription> prescriptions = new List<Prescription>();
        

        public void LoadPrescriptions(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] data = line.Split('|');
                Prescription prescription = new Prescription(data[0], data[1], data[2], data[3], Int32.Parse(data[4]), data[5], Convert.ToDateTime(data[6]), Convert.ToDateTime(data[7]));
                prescriptions.Add(prescription);
            }
        }

    }
}
