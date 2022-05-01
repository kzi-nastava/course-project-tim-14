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
        public string patient; //TREBA DA BUDE TIPA PATIENT
        public DateTime dateTime;
        public string doctor;  //TREBA DA BUDE TIPA DOCTOR
        
        public Checkup(int id,string patient,DateTime dateTime,string doctor)
        {
            this.id = id;
            this.patient = patient;
            this.dateTime = dateTime;
            this.doctor = doctor;
        }
    }
}
