using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Login
{
    public class CheckupRepository
    {
        public List<Checkup> checkups = new List<Checkup>();

        public void LoadCheckups(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] data = line.Split('|');
                Checkup checkup = new Checkup(Int32.Parse(data[0]),data[1], Convert.ToDateTime(data[2]), data[3]);
                checkups.Add(checkup);
            }
        }

        public List<string> LoadAvaliableCheckupTimes(DateTime date)
        {
            List<string> avaliableTimes = new List<string>() { "08:00","08:15", "08:30", "08:45","09:00","09:15","09:30","09:45","10:00","10:15", "10:30", "10:45","11:00","11:15", "11:30", "11:45", "12:00", "12:15", "12:30", "12:45", "13:00", "13:15", "13:30", "13:45", "14:00", "14:15", "14:30", "14:45", "15:00", "15:15", "15:30", "15:45" };

            /*foreach (Checkup checkup in this.checkups)
            {
                if (checkup.dateTime.Date.Equals(date.Date))
                    
                    avaliableTimes.Remove(checkup.dateTime.ToString("HH:mm"));
            }*/
            return avaliableTimes;
        }

        public List<string> LoadAvaliableCheckupTimes(DateTime date, string doctor)
        {
            List<string> avaliableTimes = new List<string>() { "08:00", "08:15", "08:30", "08:45", "09:00", "09:15", "09:30", "09:45", "10:00", "10:15", "10:30", "10:45", "11:00", "11:15", "11:30", "11:45", "12:00", "12:15", "12:30", "12:45", "13:00", "13:15", "13:30", "13:45", "14:00", "14:15", "14:30", "14:45", "15:00", "15:15", "15:30", "15:45" };
            
            foreach (Checkup checkup in this.checkups)
            {
                if (checkup.dateTime.Date.Equals(date.Date) && checkup.doctor.Equals(doctor))
                    avaliableTimes.Remove(checkup.dateTime.ToString("HH:mm"));
            }

            return avaliableTimes;
        }

        public Checkup FindCheckup(int id)
        {
            foreach (Checkup checkup in checkups)
            {
                if (checkup.id==id)
                {
                    return checkup;
                }
            }
            return null;
        }

        public Checkup ChangeTime(Checkup checkup,string time)
        {
            string[] hoursMinutes = time.Split(':');
            TimeSpan newTime = new TimeSpan(int.Parse(hoursMinutes[0]), int.Parse(hoursMinutes[1]), 0);
            DateTime checkupDateTime = checkup.dateTime.Date;
            DateTime newDateTime = checkupDateTime.Add(newTime);
            Checkup newCheckup = new Checkup(checkup.id, checkup.patient, newDateTime, checkup.doctor);
            return newCheckup;
        }

        public string DeleteCheckup(string id, Patient patient,DeleteUpdateRequestRepository requestRepository)
        {
            int chosenId = int.Parse(id);
            Checkup checkup = FindCheckup(chosenId);
            if (checkup.dateTime.Date > DateTime.Today.AddDays(2))
            {
                checkups.Remove(checkup);
                RemoveCheckupFromFile(checkup);
                return "Otkazali ste pregled.";
            }

            else
            {
                DeleteUpdateRequest request = new DeleteUpdateRequest(requestRepository.GetNewId(),patient.email,checkup.id, "0","delete","false");
                requestRepository.requests.Add(request);
                requestRepository.AddRequestToFile(request);
                return "Poslat je zahtev za brisanje.";
            }
                
        }

        public string UpdateCheckup(string id,string time, Patient patient, DeleteUpdateRequestRepository requestRepository)
        {
            int chosenId = int.Parse(id);
            Checkup checkup = FindCheckup(chosenId);
            if (checkup.dateTime.Date > DateTime.Today.AddDays(2))
            {
                int listId = -1;
                foreach(Checkup element in checkups)
                {
                    listId++;
                    if (element.id == chosenId)
                    {
                        checkups[listId] = ChangeTime(checkup, time);
                        break;
                    }
                }
                ReloadCheckupFile(checkup);
                return "Izmenili ste pregled.";
            }
            else
            {
                DeleteUpdateRequest request = new DeleteUpdateRequest(requestRepository.GetNewId(), patient.email, checkup.id, time, "update", "false");
                requestRepository.requests.Add(request);
                requestRepository.AddRequestToFile(request);
                return "Poslat je zahtev za izmenu.";
            }
        }

        public void AddCheckupToFile(Checkup checkup)
        {
            using (StreamWriter tw = File.AppendText("../../Data/checkups.txt"))
            {
                string line = checkup.id.ToString() + "|" + checkup.patient + "|" + checkup.dateTime.ToString() + "|" + checkup.doctor;
                tw.WriteLine(line);
                tw.Close();
            }
        }

        public void RemoveCheckupFromFile(Checkup delCheckup)
        {
            TextWriter tw = new StreamWriter("checkups.txt");
           
            foreach (Checkup checkup in checkups)
            {
                if (checkup.id != delCheckup.id)
                {
                    string line = checkup.id.ToString() + "|" + checkup.patient + "|" + checkup.dateTime.ToString() + "|" + checkup.doctor;
                    tw.WriteLine(line);
                }
            }
                

            tw.Close();
        }

        public void ReloadCheckupFile(Checkup delCheckup)
        {
            TextWriter tw = new StreamWriter("checkups.txt");

            foreach (Checkup checkup in checkups)
            {
                string line = checkup.id.ToString() + "|" + checkup.patient + "|" + checkup.dateTime.ToString() + "|" + checkup.doctor;
                tw.WriteLine(line);
                
            }


            tw.Close();
        }
    }
}

