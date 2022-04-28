using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class DeleteUpdateRequest
    {
        public int id;
        public string patient;
        public int checkup;
        public string time;
        public string type;
        public string approved; 

        public DeleteUpdateRequest(int id, string patient,int checkup, string time,string type,string approved)
        {
            this.id = id;
            this.patient = patient;
            this.checkup = checkup;
            this.time = time;
            this.type = type;
            this.approved = approved;

        }
        
    }
}
