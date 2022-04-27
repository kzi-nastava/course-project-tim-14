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

        public Patient(int id, string ime, string prezime, string email, string password)
        {
            this.id = id;
            this.ime = ime;
            this.prezime = prezime;
            this.email = email;
            this.password = password;
        }
        
       
    }
}
