using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Secretary
{
    class PatientCard
    {
        public int CardId;
        public Patient Patient;
        public int Height;
        public int Weight;
        public string[] PreviouseIllnesses;
        public string[] DoctorNotes;
    }

    public PatientCard(int cardId, PatientCard patient, int height, int weight, string[] previousIllnesses, string[] doctorNotes)
    {
        CardId = cardId;
        Patient = patient;
        Height = height;
        Weight = weight;
        PreviouseIllnesses = previousIllnesses;
        DoctorNotes = doctorNotes;
    }
}
