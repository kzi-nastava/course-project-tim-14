using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.ManagerRepository
{
    public class Ingredient
    {
        public string name;
        public int id;

        public Ingredient(int id, string name)
        {
            this.name = name;
            this.id = id;
        }

        public string ToFile()
        {
            return id.ToString() + "|" + name;
        }
    }

    
}
