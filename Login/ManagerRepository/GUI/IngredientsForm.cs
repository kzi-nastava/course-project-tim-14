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
    public partial class IngredientsForm : Form
    {
        readonly IngredientRepository ingredientRepository;
        public IngredientsForm(IngredientRepository ingredientRepository)
        {
            InitializeComponent();
            this.ingredientRepository = ingredientRepository;

        }

        private void IngredientsForm_Load(object sender, EventArgs e)
        {
            DataTable ingredientTable = new DataTable();
            ingredientTable.Columns.Add("ID");
            ingredientTable.Columns.Add("INGREDIENT NAME");
            foreach (Ingredient ingredient in ingredientRepository.ingredients)
            {
                ingredientTable.Rows.Add(ingredient.id, ingredient.name);
            }
            ingredientsGridView.DataSource = ingredientTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewIngredientForm newIngredientForm = new NewIngredientForm(ingredientRepository);
            newIngredientForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditIngredient editIngredient = new EditIngredient(ingredientRepository);
            editIngredient.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteIngredientForm deleteIngredient = new DeleteIngredientForm(ingredientRepository);
            deleteIngredient.Show();
        }
    }
}
