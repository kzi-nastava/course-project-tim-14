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
    public partial class BlockedAccountsForm : Form
    {
        public BlockedAccountsForm()
        {
            InitializeComponent();
        }

        private void unblock_btn_Click(object sender, EventArgs e)
        {
            string unblockedId = unblockId_tb.Text;

            int lineCounter = 0;
            string newLine = "";

            string[] patientLines = File.ReadAllLines("../../Data/patients.txt");
            foreach (string element in patientLines)
            {
                lineCounter += 1;
                string[] splitPatientData = element.Split('|');
                if (splitPatientData[0] == unblockedId)
                {
                    newLine = unblockedId + "|" + splitPatientData[1] + "|" + splitPatientData[2] + "|" + splitPatientData[3] + "|" + splitPatientData[4] + "|" + "n/a";
                    break;
                }
            }

            changeLineInFile(newLine, "../../Data/patients.txt", lineCounter);

            MessageBox.Show("Uklonjena blokada sa naloga.");
            this.Hide();
        }

        private void BlockedAccountsForm_Load(object sender, EventArgs e)
        {
            string patientsFilePath = "../../Data/patients.txt";
            FillRichText(patientsFilePath);
        }

        public void FillRichText(string filePath)
        {
            string content = "";
            string[] fileContent = File.ReadAllLines(filePath);
            foreach (string element in fileContent)
            {
                string[] singlePatientData = element.Split('|');
                if (singlePatientData[5] == "blocked")
                {
                    content = content + singlePatientData[0] + "   " + singlePatientData[1] + "   " + singlePatientData[2] + "   " + singlePatientData[3] + "   " + singlePatientData[4] + "\n";
                }
            }
            richTextBox1.Text = content;
        }

        public void changeLineInFile(string newText, string fileName, int lineToEdit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[lineToEdit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }
    }
}
