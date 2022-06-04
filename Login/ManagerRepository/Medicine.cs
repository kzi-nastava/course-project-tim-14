using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.ManagerRepository
{
    public class Medicine
    {
        public int id;
        public string name;
        public int numTablets;
        public string ingredientsList;
        public int approved;

        public Medicine(int id, string name, int numTablets, string ingredientsList, int approved)
        {
            this.id = id;
            this.name = name;
            this.numTablets = numTablets;
            this.ingredientsList = ingredientsList;
            this.approved = approved;
        }

        public string ToFile()
        {
            return id.ToString() + "|" + name + "|" + numTablets.ToString() + "|" + ingredientsList + "|" + approved;
        }
    }
}
