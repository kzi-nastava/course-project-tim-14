using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Prescription
{
    public class Prescription
    {
        public string id;
        public string patient;
        public string medicine;
        public string time;
        public int num;
        public string description;
        public DateTime fromDate;
        public DateTime toDate;

        public Prescription(string id,string patient, string medicine, string time, int num, string description,DateTime fromDate,DateTime toDate) {
            this.id = id;
            this.patient = patient;
            this.medicine = medicine;
            this.time = time;
            this.num = num;
            this.description = description;
            this.fromDate = fromDate;
            this.toDate = toDate;
        }

        public bool IsActive(string patient)
        {
            return this.patient.Equals(patient) && fromDate < DateTime.Now && toDate > DateTime.Now;
        }

        public string GetMessage()
        {
            return "Popij " + medicine + " u " + time + " " + description + ".";
        }
    }
}
