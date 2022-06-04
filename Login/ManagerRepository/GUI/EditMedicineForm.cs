using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.ManagerRepository.GUI
{
    public partial class EditMedicineForm : Form
    {

        readonly MedicineRepository medicineRepository;
        readonly IngredientRepository ingredientRepository;
        public EditMedicineForm(MedicineRepository medicineRepository, IngredientRepository ingredientRepository)
        {
            InitializeComponent();
            this.medicineRepository = medicineRepository;
            this.ingredientRepository = ingredientRepository;
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(idTextBox.Text);
            Medicine medicine = medicineRepository.FindMedicine(id);
            nameTextBox.Text = medicine.name;
            numTextBox.Text = medicine.numTablets.ToString();
            foreach (Ingredient ingredient in ingredientRepository.ingredients)
            {
                if (medicine.ingredientsList.Contains(ingredient.name))
                {
                    ingredientsListBox.Items.Add(ingredient.name, CheckState.Checked);

                } else { 
                    ingredientsListBox.Items.Add(ingredient.name, CheckState.Unchecked);
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(idTextBox.Text);
            int num = Int32.Parse(numTextBox.Text);
            string name = nameTextBox.Text;
            string ingredients = "";
            foreach (String s in ingredientsListBox.CheckedItems)
            {
                if (ingredients.Equals(""))
                {
                    ingredients += s;
                }
                else
                {
                    ingredients += ", ";
                    ingredients += s;
                }
            }

            int index = medicineRepository.FindIndex(id);
            if (index != -1)
            {
                medicineRepository.allMedicine[index].name = name;
                medicineRepository.allMedicine[index].numTablets = num;
                medicineRepository.allMedicine[index].ingredientsList = ingredients;
                medicineRepository.allMedicine[index].approved = 0;
                medicineRepository.ReloadRepository();
            }

            MessageBox.Show("Medicine waiting doctor approval.", "Success");
            this.Close();
        }
    }
}
