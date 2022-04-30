using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class Antitroll
    {
        public int updateCount;
        public int addCount;
        public int deleteCount;

        public void AddAction(string action)
        {
            if (action.Equals("update"))
                updateCount++;
            else if (action.Equals("add"))
                addCount++;
            else
                deleteCount++;

        }
    }
}
