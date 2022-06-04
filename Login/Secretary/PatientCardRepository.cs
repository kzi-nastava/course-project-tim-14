using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Login.Secretary
{
    class PatientCardRepository
    {
        public List<PatientCard> patientCards = new List<PatientCard>();

        public void LoadPatientCards(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] data = line.Split('|');
                PatientCard patientCard = new PatientCard(Int32.Parse(data[0]), Int32.Parse(data[1]), data[2], data[3], Int32.Parse(data[4]), Int32.Parse(data[5]), data[6], data[7], data[8]);
                patientCards.Add(patientCard);
            }
        }

        public PatientCard FindPatientCard(int id)
        {
            foreach (PatientCard patientCard in patientCards)
            {
                if (patientCard.cardId == id)
                {
                    return patientCard;
                }
            }
            return null;
        }
    }
}
