using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.ManagerRepository
{
    public class IngredientRepository
    {
        public List<Ingredient> ingredients = new List<Ingredient>();
        public string fileName = "../../Data/ingredients.txt";
        public int lastId;

        public void LoadRepository()
        {
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                string[] data = line.Split('|');
                Ingredient ingredient = new Ingredient(Int32.Parse(data[0]), data[1]);
                ingredients.Add(ingredient);
                this.lastId = Int32.Parse(data[0]);
            }
        }
        public void AddNewIngredient(Ingredient newIngredient)
        {
            ingredients.Add(newIngredient);
            using (StreamWriter tw = File.AppendText(fileName))
            {
                tw.WriteLine(newIngredient.ToFile());
                tw.Close();
            }
        }

        public Ingredient FindIngredient(int id)
        {
            foreach (Ingredient ingredient in ingredients)
            {
                if (ingredient.id == id)
                {
                    return ingredient;
                }
            }
            return null;
        }

        public void ReloadRepository()
        {
            TextWriter tw = new StreamWriter(fileName);

            foreach (Ingredient ingredient in ingredients)
            {
                tw.WriteLine(ingredient.ToFile());
            }
            tw.Close();
        }
    }
}
