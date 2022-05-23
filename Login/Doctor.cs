using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class Doctor
    {
        public int id;
        public string name;
        public string lastName;
        public string email;
        public string password;
        public string type;
        public float rating;

        public Doctor(int id, string name, string lastName, string email, string password, string type, float rating) {
            this.id = id;
            this.name = name;
            this.lastName = lastName;
            this.email = email;
            this.password = password;
            this.type = type;
            this.rating = rating;
        }
    }
}
