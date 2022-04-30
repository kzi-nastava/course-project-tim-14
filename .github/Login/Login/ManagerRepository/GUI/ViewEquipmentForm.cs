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
    public partial class ViewEquipmentForm : Form
    {
        readonly EquipmentRepository equipmentRepository;
        public ViewEquipmentForm(EquipmentRepository equipmentRepository)
        {
            InitializeComponent();
            this.equipmentRepository = equipmentRepository;
        }

        private void ViewEquipmentForm_Load(object sender, EventArgs e)
        {
            DataTable equipmentTable = new DataTable();
            equipmentTable.Columns.Add("ID");
            equipmentTable.Columns.Add("TYPE");
            equipmentTable.Columns.Add("DESCRIPTION");
            foreach (Equipment equipment in equipmentRepository.allEquipment)
            {
                equipmentTable.Rows.Add(equipment.id, equipment.type, equipment.description);
            }
            dataGridViewEquipment.DataSource = equipmentTable;
        }

        private void btnFilterByType_Click(object sender, EventArgs e)
        {
            DataTable equipmentTable = new DataTable();
            equipmentTable.Columns.Add("ID");
            equipmentTable.Columns.Add("TYPE");
            equipmentTable.Columns.Add("DESCRIPTION");
            equipmentTable.Columns.Add("NAME");
            foreach (Equipment equipment in equipmentRepository.FilterByType(equipmentTypeOptions.SelectedItem.ToString()))
            {
                equipmentTable.Rows.Add(equipment.id, equipment.type, equipment.description, equipment.name);
            }
            dataGridViewEquipment.DataSource = equipmentTable;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable equipmentTable = new DataTable();
            equipmentTable.Columns.Add("ID");
            equipmentTable.Columns.Add("TYPE");
            equipmentTable.Columns.Add("DESCRIPTION");
            equipmentTable.Columns.Add("NAME");
            foreach (Equipment equipment in equipmentRepository.SearchEquipment(textBoxSearch.Text))
            {
                equipmentTable.Rows.Add(equipment.id, equipment.type, equipment.description, equipment.name);
            }
            dataGridViewEquipment.DataSource = equipmentTable;

        }

        private void btnFilterByQuantity_Click(object sender, EventArgs e)
        {
            List<QuantityCounter> foundEquipment = new List<QuantityCounter>();
            string selectedQuantity = quantityOptions.SelectedItem.ToString();
            if (selectedQuantity == "nema na stanju") {
                foundEquipment = equipmentRepository.Count(0, 0);
            }
            else if (selectedQuantity == "0-10"){
                foundEquipment = equipmentRepository.Count(1, 10);
            }
            else if (selectedQuantity == "10+"){
                foundEquipment = equipmentRepository.Count(11, 100);
            }

            DataTable quantityTable = new DataTable();
            quantityTable.Columns.Add("ID");
            quantityTable.Columns.Add("TYPE");
            quantityTable.Columns.Add("DESCRIPTION");
            quantityTable.Columns.Add("QUANTITY");
            foreach (QuantityCounter counter in foundEquipment)
            {
                quantityTable.Rows.Add(counter.id, counter.type, counter.description, counter.quantity);
            }
            dataGridViewEquipment.DataSource = quantityTable;
        }


        private void FilterByRoom_Click(object sender, EventArgs e)
        {
            DataTable equipmentTable = new DataTable();
            equipmentTable.Columns.Add("ID");
            equipmentTable.Columns.Add("TYPE");
            equipmentTable.Columns.Add("DESCRIPTION");
            equipmentTable.Columns.Add("NAME");
            foreach (Equipment equipment in equipmentRepository.SearchEquipment(roomTypeOptions.SelectedItem.ToString()))
            {
                equipmentTable.Rows.Add(equipment.id, equipment.type, equipment.description, equipment.name);
            }
            dataGridViewEquipment.DataSource = equipmentTable;
        }
    }
}
