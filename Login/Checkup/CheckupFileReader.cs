using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Login
{
    public class CheckupFileReader:IFileReader
    {
        public string fileName;
        public CheckupFileReader(string fileName)
        {
            this.fileName = fileName;
        }

        public List<Checkup> LoadFromFile()
        {
            List<Checkup> checkups = new List<Checkup>();
            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] data = line.Split('|');
                Checkup checkup = new Checkup(Int32.Parse(data[0]), data[1], Convert.ToDateTime(data[2]), data[3], data[4]);
                checkups.Add(checkup);
            }
            return checkups;
        }
    }
}
