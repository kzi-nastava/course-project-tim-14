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
    public partial class EditIngredient : Form
    {
        readonly IngredientRepository ingredientRepository;

        public EditIngredient(IngredientRepository ingredientRepository)
        {
            InitializeComponent();
            this.ingredientRepository = ingredientRepository;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(idTextBox.Text);
            string name = nameTextBox.Text;
            Ingredient found = ingredientRepository.FindIngredient(id);
            found.name = name;
            ingredientRepository.ReloadRepository();
        }
    }
}
