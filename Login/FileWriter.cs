using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Login
{
    public class FileWriter:IFileWriter
    {
        public string fileName;
        public FileWriter(string fileName) {
            this.fileName = fileName;
        }
        public void AddToFile(string line)
        {
            using (StreamWriter tw = File.AppendText(fileName))
            {
                tw.WriteLine(line);
                tw.Close();
            }
        }
    }
}
