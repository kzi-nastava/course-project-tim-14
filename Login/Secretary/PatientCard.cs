using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Secretary
{
    class PatientCard
    {
        public int cardId;
        public int patientId;
        public string patientName;
        public string patientLName;
        public int height;
        public int weight;
        public string alergies;
        public string previousIllnesses;
        public string doctorNotes;

        public PatientCard(int cardId, int patientId, string patientName, string patientLName, int height, int weight, string alergies, string previousIllnesses, string doctorNotes)
        {
            this.cardId = cardId;
            this.patientId = patientId;
            this.patientName = patientName;
            this.patientLName = patientLName;
            this.height = height;
            this.weight = weight;
            this.alergies = alergies;
            this.previousIllnesses = previousIllnesses;
            this.doctorNotes = doctorNotes;
        }
    }
}
