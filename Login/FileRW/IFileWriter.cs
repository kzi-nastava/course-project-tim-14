using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public interface IFileWriter
    {
        void AddToFile(string line);
        void ReloadFile(List<string> lines);
    }
}
