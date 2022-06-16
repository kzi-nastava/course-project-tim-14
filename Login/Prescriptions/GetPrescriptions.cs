using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class GetPrescriptions:IGetPrescriptions
    {
        public int hoursBefore;
        public CheckTime checkTime = new CheckTime();
        public List<Prescription.Prescription> GetActivePrescriptions(string patient, List<Prescription.Prescription> prescriptions) {
            List<Prescription.Prescription> activePrescriptions = new List<Prescription.Prescription>();
            foreach (Prescription.Prescription prescription in prescriptions)
                if (prescription.IsActive(patient))
                    activePrescriptions.Add(prescription);
            return activePrescriptions;
        }

        public List<Prescription.Prescription> GetTodaysPrescriptions(string patient, List<Prescription.Prescription> prescriptions) {
            List<Prescription.Prescription> selectedPrescriptions = new List<Prescription.Prescription>();
            foreach (Prescription.Prescription prescription in GetActivePrescriptions(patient,prescriptions))
            {
                DateTime prescriptionTime = DateTime.ParseExact(prescription.time, "HH:mm", null);
                for (int i = 0; i < prescription.num; i++)
                {
                    prescriptionTime = prescriptionTime.AddHours(24 / prescription.num);
                    if (checkTime.IsTime(prescriptionTime,hoursBefore))
                    {
                        prescription.time = prescriptionTime.ToString();
                        selectedPrescriptions.Add(prescription);
                    }
                }
            }
            return selectedPrescriptions;
        }
    }
}
