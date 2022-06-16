using Login.Secretary;
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

namespace Login
{
    public partial class FormSecretary : Form
    {
        readonly CheckupRepository checkupRepository = new CheckupRepository();   

        public FormSecretary()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void createPatientAccount_btn_Click(object sender, EventArgs e)
        {
            var accountCreationForm = new AccountCreationForm();
            accountCreationForm.Show();
        }

        private void editPatientAccount_btn_Click(object sender, EventArgs e)
        {
            var accountEditForm = new AccountEditForm();
            accountEditForm.Show();
        }

        private void deletePatientAccount_btn_Click(object sender, EventArgs e)
        {
            var accountDeleteForm = new AccountDeletionForm();
            accountDeleteForm.Show();
        }

        private void showPatients_btn_Click(object sender, EventArgs e)
        {
            var allPatientsForm = new AllPatientsForm();
            allPatientsForm.Show();
        }

        private void viewSingleAccount_btn_Click(object sender, EventArgs e)
        {
            var singlePatientForm = new ChooseAccountForm();
            singlePatientForm.Show();
        }

        private void showBlockedAccounts_btn_Click(object sender, EventArgs e)
        {
            var blockedAccountsForm = new BlockedAccountsForm();
            blockedAccountsForm.Show();
        }

        private void requestCheck_btn_Click(object sender, EventArgs e)
        {
            var requestCheckForm = new RequestsCheckForm();
            requestCheckForm.Show();
        }

        private void createCheckupFromRefferal_btn_Click(object sender, EventArgs e)
        {
            var createCheckupFromRefferalForm = new CreateCheckupFromRefferalForm(checkupRepository);
            createCheckupFromRefferalForm.Show();
        }

        private void dynEquipmentCheck_btn_Click(object sender, EventArgs e)
        {
            var createDynamicEquipmentCheckForm = new DynamicEquipmentCheckForm();
            createDynamicEquipmentCheckForm.Show();
        }

        private void orderRequestHandle_btn_Click(object sender, EventArgs e)
        {
            string[] fileContent = File.ReadAllLines("../../Data/dynamicEquipmentRequests.txt");

            foreach (string element in fileContent)
            {
                string[] splitRequest = element.Split('|');
                if (splitRequest[5] == "0")
                {
                    DateTime requestTime = Convert.ToDateTime(splitRequest[4]);
                    if (DateTime.Now > requestTime.AddDays(1))
                    {
                        string newRequestLine = splitRequest[0] + "|" + splitRequest[1] + "|" + splitRequest[2] + "|" + splitRequest[3] + "|" + splitRequest[4] + "|" + "1";
                        completeRequest(splitRequest[1], splitRequest[3], newRequestLine);
                    }
                }             
            }

            MessageBox.Show("Zahtevi za narudzbinu obradjeni.");
        }

        private void completeRequest(string equipmentId, string quantity, string newRequestLine)
        {
            changeLineInFile(newRequestLine, "../../Data/dynamicEquipmentRequests.txt", Int32.Parse(newRequestLine.Split('|')[0]));
            addQuantityToEquipment(equipmentId, quantity);
        }

        private void addQuantityToEquipment(string equipmentId, string quantity)
        {
            string[] fileContent = File.ReadAllLines("../../Data/dynamicEquipment.txt");

            foreach (string element in fileContent)
            {
                string[] splitEquipment = element.Split('|');
                if (splitEquipment[0] == equipmentId)
                {
                    string newLine = splitEquipment[0] + "|" + splitEquipment[1] + "|" + (Int32.Parse(splitEquipment[2]) + Int32.Parse(quantity)).ToString();
                    changeLineInFile(newLine, "../../Data/dynamicEquipment.txt", Int32.Parse(splitEquipment[0]));
                }
            }
        }

        public void changeLineInFile(string newText, string fileName, int lineToEdit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[lineToEdit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }

        private void freeDayRequest_btn_Click(object sender, EventArgs e)
        {
            var createFreeDayRequestForm = new FreeDayRequestForm();
            createFreeDayRequestForm.Show();
        }
    }
}
