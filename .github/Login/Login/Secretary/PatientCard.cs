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
        public Patient patient;
        public int height;
        public int weight;
        public string alergies;
        public string previousIllnesses;
        public string doctorNotes;

        public PatientCard(int cardId, Patient patient, int height, int weight, string alergies, string previousIllnesses, string doctorNotes)
        {
            this.cardId = cardId;
            this.patient = patient;
            this.height = height;
            this.weight = weight;
            this.alergies = alergies;
            this.previousIllnesses = previousIllnesses;
            this.doctorNotes = doctorNotes;
        }
    }
}
