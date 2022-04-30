using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.ManagerRepository
{
    public class QuantityCounter
    {
        public string id;
        public string type;
        public string description;
        public string quantity;

        public QuantityCounter(string v1, string v2, string v3, string v4)
        {
            this.id = v1;
            this.type = v2;
            this.description = v3;
            this.quantity = v4;
        }
    }
}
