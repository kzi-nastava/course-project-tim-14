using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Login
{
    public class Patient
    {
        public int id;
        public string ime;
        public string prezime;
        public string email;
        public string password;
        public string blocked;
        public Antitroll antitroll;

        public Patient(int id, string ime, string prezime, string email, string password, string blocked)
        {
            this.id = id;
            this.ime = ime;
            this.prezime = prezime;
            this.email = email;
            this.password = password;
            this.blocked = blocked;
            this.antitroll = new Antitroll();
        }

        public bool IsBlockedBySystem()
        {
            if (antitroll.addCount >= 8 || antitroll.updateCount >= 5 || antitroll.deleteCount >= 5)
            {
                blocked = "blocked";
                return true;
            }
            return false;
        }

        public void AddToHistory(DateTime actionDate, string action)
        {
            using (StreamWriter tw = File.AppendText("history.txt"))
            {
                string line = this.id.ToString() + "|" + actionDate.ToString() + "|" + action + "|" + blocked;
                tw.WriteLine(line);
                tw.Close();
            }
        }

    }
}