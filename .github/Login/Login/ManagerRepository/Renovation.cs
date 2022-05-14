using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.ManagerRepository
{
    public class Renovation
    {
        public int roomId;
        public DateTime start;
        public DateTime end;


        public Renovation(int v, DateTime renovationStart, DateTime renovationEnd)
        {
            this.roomId = v;
            this.start = renovationStart;
            this.end = renovationEnd;
        }

        public string ToFile()
        {
            return roomId.ToString() + "|" + start.ToString("dd/MM/yyyy") + "|" + end.ToString("dd/MM/yyyy");
        }
    }
}
