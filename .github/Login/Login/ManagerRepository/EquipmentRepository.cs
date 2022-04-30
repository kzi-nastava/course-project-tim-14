using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.ManagerRepository
{
    
    public class EquipmentRepository
    {
        public List<Equipment> allEquipment = new List<Equipment>();
        public string equipmentFileName = "equipment.txt";
        public string quantityFileName = "equipmentQuantity.txt";

        public void LoadEquipmentRepository()
        {
            if (!allEquipment.Any()) { 
                string[] lines = File.ReadAllLines(equipmentFileName);
                foreach (string line in lines)
                {
                    string[] data = line.Split('|');
                    Equipment equipment = new Equipment(Int32.Parse(data[0]), data[1], data[2], data[3], data[4], Int32.Parse(data[5]));
                    allEquipment.Add(equipment);
                }
            }
            
        }

        public List<Equipment> SearchEquipment(string searchInput)
        {
            List<Equipment> foundEquipment = new List<Equipment>();
            foreach (Equipment equipment in allEquipment)
            {
                if (equipment.id.ToString() == searchInput || equipment.description.Contains(searchInput) || equipment.type.Contains(searchInput) || equipment.roomType == searchInput)
                {
                    foundEquipment.Add(equipment);
                } else if (searchInput == "") {
                    return allEquipment;
                }
            }
            return foundEquipment;
        }

        public List<Equipment> FilterByType(string typeInput)
        {
            List<Equipment> foundEquipment = new List<Equipment>();
            foreach (Equipment equipment in allEquipment)
            {
                if (equipment.type == typeInput)
                {
                    foundEquipment.Add(equipment);
                }
            }
            return foundEquipment;
        }

        public void ReloadEquipmentRepository()
        {
            TextWriter tw = new StreamWriter(equipmentFileName);

            foreach (Equipment eq in allEquipment)
            {
                tw.WriteLine(eq.ToFile());
            }
            tw.Close();
            
        }

        public List<QuantityCounter> Count(int lowerBound, int upperBound)
        {
            List<QuantityCounter> quantityCounter = new List<QuantityCounter>();
            string[] lines = File.ReadAllLines(quantityFileName);
            foreach (string line in lines)
            {
                string[] data = line.Split('|');
                int quantity = Int32.Parse(data[3]);
                if (lowerBound <= quantity && quantity <= upperBound)
                {
                    string description = data[2];
                    QuantityCounter counter = new QuantityCounter(data[0], data[1], data[2], data[3]);
                    quantityCounter.Add(counter);
                }
            }
            return quantityCounter;
        }

        public Equipment FindById(int id)
        {
            foreach (Equipment eq in allEquipment)
            {
                if (id == eq.id)
                {
                    return eq;
                }
            }
            return null;
        }
    }
    
}

