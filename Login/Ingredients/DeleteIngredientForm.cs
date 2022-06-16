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
    public partial class DeleteIngredientForm : Form
    {
        readonly IngredientRepository ingredientRepository;
        public DeleteIngredientForm(IngredientRepository ingredientRepository)
        {
            InitializeComponent();
            this.ingredientRepository = ingredientRepository;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(idTextBox.Text);
            Ingredient ingredient = ingredientRepository.FindIngredient(id);
            if (ingredient != null)
            {
                ingredientRepository.ingredients.Remove(ingredient);
                ingredientRepository.ReloadRepository();
            }

        }
    }
}
