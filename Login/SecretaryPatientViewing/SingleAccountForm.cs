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
    public partial class SingleAccountForm : Form
    {
        string patientId;
        public SingleAccountForm(string patientId)
        {
            InitializeComponent();
            this.patientId = patientId;
        }

        private void block_btn_Click(object sender, EventArgs e)
        {
            int lineCounter = 0;
            string newLine = "";

            string[] patientLines = File.ReadAllLines("../../Data/patients.txt");
            foreach (string element in patientLines)
            {
                lineCounter += 1;
                string[] splitPatientData = element.Split('|');
                if (splitPatientData[0] == patientId)
                {
                    newLine = patientId + "|" + splitPatientData[1] + "|" + splitPatientData[2] + "|" + splitPatientData[3] + "|" + splitPatientData[4] + "|" + "blocked";
                    break;
                }
            }

            changeLineInFile(newLine, "../../Data/patients.txt", lineCounter);

            MessageBox.Show("Nalog pacijenta blokiran.");
            this.Hide();
        }

        public void changeLineInFile(string newText, string fileName, int lineToEdit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[lineToEdit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }

        private void SingleAccountForm_Load(object sender, EventArgs e)
        {
            string[] patientLines = File.ReadAllLines("../../Data/patients.txt");
            foreach (string element in patientLines)
            {
                string[] splitPatientData = element.Split('|');
                if (splitPatientData[0] == patientId)
                {
                    patientId_tb.Text = patientId;
                    patientName_tb.Text = splitPatientData[1];
                    patientLastName_tb.Text = splitPatientData[2];
                    patientEmail_tb.Text = splitPatientData[3];
                    patientPassword_tb.Text = splitPatientData[4];
                    blockedStatus_tb.Text = splitPatientData[5];
                    break;
                }
            }
        }
    }
}
