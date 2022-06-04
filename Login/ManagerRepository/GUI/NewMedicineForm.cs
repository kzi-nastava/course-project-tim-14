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
    public partial class NewMedicineForm : Form
    {
        readonly MedicineRepository medicineRepository;
        readonly IngredientRepository ingredientRepository;

        public NewMedicineForm(MedicineRepository medicineRepository, IngredientRepository ingredientRepository)
        {
            InitializeComponent();
            this.medicineRepository = medicineRepository;
            this.ingredientRepository = ingredientRepository;
        }

        private void NewMedicineForm_Load(object sender, EventArgs e)
        {
            foreach (Ingredient ingredient in ingredientRepository.ingredients)
            {
                ingredientsListBox.Items.Add(ingredient.name, CheckState.Unchecked);
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            int newId = medicineRepository.lastId;
            int num = Int32.Parse(numTextBox.Text);
            string name = nameTextBox.Text;
            medicineRepository.lastId++;
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
            Medicine createdMedicine = new Medicine(newId + 1, name, num, ingredients, 0);
            medicineRepository.AddNewMedicine(createdMedicine);

            MessageBox.Show("Medicine added.", "Success");
            this.Close();
        }

        private void ingredientsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
