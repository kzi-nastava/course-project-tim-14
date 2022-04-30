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
    public partial class AccountDataEditForm : Form
    {
        string editedPatientID;
        public AccountDataEditForm(string editedPatientID)
        {
            InitializeComponent();
            this.editedPatientID = editedPatientID;
        }

        private void AccountDataEditForm_Load(object sender, EventArgs e)
        {

        }

        private void done_btn_Click(object sender, EventArgs e)
        {
            int patientsLineCounter = 0;
            int patientCardLineCounter = 0;
            int usersLineCounter = 0;

            string newName = "";
            string newLastName = "";
            string newEmail = "";
            string newPassword = "";
            string newHeight = "";
            string newWeight = "";

            string patientsNewLine = "";
            string patientCardsNewLine = "";
            string usersNewLine = "";

            string[] patientLines = File.ReadAllLines("patients.txt");
            foreach (string element in patientLines)
            {
                patientsLineCounter += 1;
                string[] splitPatientData = element.Split('|');
                if (splitPatientData[0] == editedPatientID)
                {
                    if (newName_tb.Text == "")
                    {
                        newName = splitPatientData[1];
                    }
                    else { newName = newName_tb.Text;}

                    if (newLastName_tb.Text == "")
                    {
                        newLastName = splitPatientData[2];
                    }
                    else { newLastName = newLastName_tb.Text; }

                    if (newEmail_tb.Text == "")
                    {
                        newEmail = splitPatientData[3];
                    }
                    else { newEmail = newEmail_tb.Text; }

                    if (newPassword_tb.Text == "")
                    {
                        newPassword = splitPatientData[4];
                    }
                    else { newPassword = newPassword_tb.Text; }

                    patientsNewLine = editedPatientID + "|" + newName + "|" + newLastName + "|" + newEmail + "|" + newPassword + "|" + splitPatientData[5].Trim();
                    break;
                }
            }

            string[] patientCardLines = File.ReadAllLines("patientCards.txt");
            foreach (string element in patientCardLines)
            {
                patientCardLineCounter += 1;
                string[] splitPatientCardData = element.Split('|');
                if (splitPatientCardData[1] == editedPatientID)
                {
                    if (newHeight_tb.Text == "")
                    {
                        newHeight = splitPatientCardData[4];
                    }
                    else { newHeight = newHeight_tb.Text; }

                    if (newWeight_tb.Text == "")
                    {
                        newWeight = splitPatientCardData[5];
                    }
                    else { newWeight = newWeight_tb.Text; }

                    patientCardsNewLine = splitPatientCardData[0] + "|" + editedPatientID + "|" + newName + "|" + newLastName + "|" + newHeight + "|" + newWeight + "|" + splitPatientCardData[6] + "|" + splitPatientCardData[7] + "|" + splitPatientCardData[8].Trim();
                    break;
                }
            }

            string[] usersLines = File.ReadAllLines("users.txt");
            foreach (string element in usersLines)
            {
                usersLineCounter += 1;
                string[] splitUsersData = element.Split('|');
                if (splitUsersData[0] == editedPatientID)
                {
                    usersNewLine = editedPatientID + "|" + newEmail + "|" + newPassword + "|" + "patient";
                    break;
                }

            }

            lineChanger(patientsNewLine, "patients.txt", patientsLineCounter);
            lineChanger(patientCardsNewLine, "patientCards.txt", patientCardLineCounter);
            lineChanger(usersNewLine, "users.txt", usersLineCounter);

            MessageBox.Show("Podaci o nalogu uspesno izmenjeni!");
            this.Hide();
        }

        public void lineChanger(string newText, string fileName, int lineToEdit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[lineToEdit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }
    }
}
