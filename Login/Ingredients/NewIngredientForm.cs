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
    public partial class NewIngredientForm : Form
    {
        readonly IngredientRepository ingredientRepository;
        public NewIngredientForm(IngredientRepository ingredientRepository)
        {
            InitializeComponent();
            this.ingredientRepository = ingredientRepository;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            ingredientRepository.lastId++;
            int newId = ingredientRepository.lastId;
            string name = nameTextBox.Text;
            Ingredient newIngredient = new Ingredient(newId, name);
            ingredientRepository.AddNewIngredient(newIngredient);

            MessageBox.Show("New ingredient created.", "Success");
            this.Close();
        }
    }
}
