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
        public int hoursBefore;

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

        public List<Prescription> GetActivePrescriptions(string patient)
        {
            List<Prescription> activePrescriptions = new List<Prescription>();
            foreach (Prescription prescription in prescriptions)
                if (prescription.IsActive(patient))
                    activePrescriptions.Add(prescription);
            return activePrescriptions;
        }

        public List<Prescription> GetTodaysPrescriptions(string patient)
        {
            List<Prescription> selectedPrescriptions = new List<Prescription>();
            foreach (Prescription prescription in GetActivePrescriptions(patient))
            {
                DateTime prescriptionTime = DateTime.ParseExact(prescription.time, "HH:mm", null);
                for (int i = 0; i < prescription.num; i++)
                {
                    prescriptionTime = prescriptionTime.AddHours(24 / prescription.num);
                    if (IsTime(prescriptionTime))
                    {
                        prescription.time = prescriptionTime.ToString();
                        selectedPrescriptions.Add(prescription);
                    }
                }
            }
            return selectedPrescriptions;
        }

        public bool IsTime(DateTime prescriptionTime)
        {
            return prescriptionTime.AddHours(hoursBefore).TimeOfDay < DateTime.Now.TimeOfDay;
        }

    }
}
