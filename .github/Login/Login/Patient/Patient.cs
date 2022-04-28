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
        public Antitroll antitroll;

        public Patient(int id, string ime, string prezime, string email, string password)
        {
            this.id = id;
            this.ime = ime;
            this.prezime = prezime;
            this.email = email;
            this.password = password;
            this.antitroll = new Antitroll();
        }

        public bool IsBlocked()
        {
            if (antitroll.addCount >= 8 || antitroll.updateCount >= 5 || antitroll.deleteCount >= 5)
                return true;
            return false;
        }

        public void AddToHistory(DateTime actionDate, string action)
        {
            using (StreamWriter tw = File.AppendText("history.txt"))
            {
                string line = this.id.ToString() + "|" + actionDate.ToString() + "|" + action;
                tw.WriteLine(line);
                tw.Close();
            }
        }

    }
}
