using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class Checkup
    {
        public int id;
        public string patient;
        public DateTime dateTime;
        public string doctor;
        public string medicalHistory;
        
        public Checkup(int id,string patient,DateTime dateTime,string doctor,string medicalHistory)
        {
            this.id = id;
            this.patient = patient;
            this.dateTime = dateTime;
            this.doctor = doctor;
            this.medicalHistory = medicalHistory;
        }

        public bool CheckupOf(int patient) {
            return Int32.Parse(this.patient) == patient;
        }

        public bool IsDone(int patient) {
            return CheckupOf(patient) && dateTime < DateTime.Now;
        }

        public bool Contains(string patient, string text) {
            return this.patient.Equals(patient) && dateTime < DateTime.Now && medicalHistory.Contains(text);
        }

        public bool AlreadyExists(string doctor,DateTime dateTime) {
            return this.dateTime.Date.Equals(dateTime) && this.doctor.Equals(doctor);
        }

        public void SetTime(string avaliableTime)
        {
            string[] hoursMinutes = avaliableTime.Split(':');
            TimeSpan newTime = new TimeSpan(int.Parse(hoursMinutes[0]), int.Parse(hoursMinutes[1]), 0);
            DateTime checkupDateTime = dateTime.Date;
            DateTime newDateTime = checkupDateTime.Add(newTime);
        }

        public string FormatToString() {
            return id.ToString() + "|" + patient + "|" + dateTime.ToString() + "|" + doctor + "|" + medicalHistory;
        }
    }
}
