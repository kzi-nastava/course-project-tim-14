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
    public partial class RejectedMedicineForm : Form
    {
        readonly MedicineRepository medicineRepository;
        readonly IngredientRepository ingredientRepository;

        public RejectedMedicineForm(MedicineRepository medicineRepository, IngredientRepository ingredientRepository)
        {
            InitializeComponent();
            this.medicineRepository = medicineRepository;
            this.ingredientRepository = ingredientRepository;
        }

        private void RejectedMedicineForm_Load(object sender, EventArgs e)
        {
            DataTable medicineTable = new DataTable();
            medicineTable.Columns.Add("ID");
            medicineTable.Columns.Add("MEDICINE NAME");
            medicineTable.Columns.Add("NUM TABLETS");
            medicineTable.Columns.Add("INGREDIENTS");
            foreach (Medicine medicine in medicineRepository.FindRejected())
            {
                medicineTable.Rows.Add(medicine.id, medicine.name, medicine.numTablets, medicine.ingredientsList);
            }
            medicineGridView.DataSource = medicineTable;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            EditMedicineForm editMedicineForm = new EditMedicineForm(medicineRepository, ingredientRepository);
            editMedicineForm.Show();
        }
    }
}
