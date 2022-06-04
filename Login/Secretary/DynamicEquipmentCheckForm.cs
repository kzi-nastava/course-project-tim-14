using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Login.Secretary
{
    public partial class DynamicEquipmentCheckForm : Form
    {
        public DynamicEquipmentCheckForm()
        {
            InitializeComponent();
        }

        private void DynamicEquipmentCheckForm_Load(object sender, EventArgs e)
        {
            loadMissingEquipment();
        }

        private void loadMissingEquipment()
        {
            string[] fileContent = File.ReadAllLines("../../Data/dynamicEquipment.txt");
            foreach (string element in fileContent)
            {
                string[] splitEquipment = element.Split('|');
                if (splitEquipment[2] == "0")
                {
                    selectedEquipment_cb.Items.Add(splitEquipment[0] + "|" + splitEquipment[1]);
                }
            }
        }
        private void createRequest_btn_Click(object sender, EventArgs e)
        {
            string quantity = equipmentQtt_tb.Text;
            string equipmentType = selectedEquipment_cb.SelectedItem.ToString();
            int newRequestId = getNewId("../../Data/dynamicEquipmentRequests.txt");
            DateTime currentDate = DateTime.Now;

            string newLine = newRequestId.ToString() + "|" + equipmentType + "|" + quantity+ "|" + currentDate + "|" + "0";

            writeToFile("../../Data/dynamicEquipmentRequests.txt", newLine);

            MessageBox.Show("Kreiran zahtev za narudzbinu.");
            this.Hide();
        }

        public int getNewId(string path)
        {
            string[] lines = File.ReadAllLines(path);
            string[] lastLine = lines[lines.Length - 1].Split('|');
            return Int32.Parse(lastLine[0]) + 1;
        }

        public void writeToFile(string path, string newLine)
        {
            TextWriter userTSW = new StreamWriter(path, true);
            userTSW.WriteLine(newLine);
            userTSW.Close();
        }
    }
}
