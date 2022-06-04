using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.ManagerRepository
{
    public class MedicineRepository
    {

        public List<Medicine> allMedicine = new List<Medicine>();
        public string fileName = "../../Data/medicine.txt";
        public int lastId;

        internal void LoadRepository()
        {
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                string[] data = line.Split('|');
                this.lastId = Int32.Parse(data[0]);
                Medicine medicine = new Medicine(Int32.Parse(data[0]), data[1], Int32.Parse(data[2]), data[3], Int32.Parse(data[4]));
                allMedicine.Add(medicine);
            }
        }
        public void AddNewMedicine(Medicine newMedicine)
        {
            allMedicine.Add(newMedicine);
            using (StreamWriter tw = File.AppendText(fileName))
            {
                tw.WriteLine(newMedicine.ToFile());
                tw.Close();
            }
        }

        public Medicine FindMedicine(int id)
        {
            foreach (Medicine medicine in allMedicine)
            {
                if (medicine.id == id)
                {
                    return medicine;
                }
            }
            return null;
        }

        public List<Medicine> FindRejected()
        {
            List<Medicine> rejected = new List<Medicine>();

            foreach (Medicine medicine in allMedicine)
            {
                if (medicine.approved == -1)
                {
                    rejected.Add(medicine);
                }
            }
            return rejected;
        }
        public int FindIndex(int id)
        {
            int i = 0;
            foreach (Medicine medicine in allMedicine)
            {
                if (medicine.id == id)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }

        public void ReloadRepository()
        {
            TextWriter tw = new StreamWriter(fileName);

            foreach (Medicine medicine in allMedicine)
            {
                tw.WriteLine(medicine.ToFile());
            }
            tw.Close();
        }
    }

}
