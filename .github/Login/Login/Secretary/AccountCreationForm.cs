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
    public partial class AccountCreationForm : Form
    {
        public AccountCreationForm()
        {
            InitializeComponent();
        }

        private void AccountCreationForm_Load(object sender, EventArgs e)
        {

        }

        private void done_btn_Click(object sender, EventArgs e)
        {
            string usersFilePath = "users.txt";
            string patientsFilePath = "patients.txt";
            string patientCardsFilePath = "patientCards.txt";

            int newCardId = getNewCardId();
            int newPatientId = getNewUserId();
            string patientName = name_tb.Text;
            string patientLastName = lastName_tb.Text;
            string patientEmail = email_tb.Text;
            string patientPassword = password_tb.Text;
            string patientHeight = height_tb.Text;
            string patientWeight = weight_tb.Text;
            string alergies = alergies_tb.Text;
            string illnesses = illness_tb.Text;

            string newUserLine = newPatientId + "|" + patientEmail + "|" + patientPassword + "|" + "patient";
            string newPatientLine = newPatientId + "|" + patientName + "|" + patientLastName + "|" + patientEmail + "|" + patientPassword + "|" + "n/a";
            string newPatientCardLine = newCardId + "|" + newPatientId + "|" + patientName + "|" + patientLastName + "|" + patientHeight + "|" + patientWeight + "|" + alergies + "|" + illnesses + "|";

            TextWriter userTSW = new StreamWriter(usersFilePath, true);
            userTSW.WriteLine(newUserLine);
            userTSW.Close();

            TextWriter patientTSW = new StreamWriter(patientsFilePath, true);
            patientTSW.WriteLine(newPatientLine);
            patientTSW.Close();

            TextWriter patientCardTSW = new StreamWriter(patientCardsFilePath, true);
            patientCardTSW.WriteLine(newPatientCardLine);
            patientCardTSW.Close();


            MessageBox.Show("Kreiran nalog novog pacijenta!");
            this.Hide();
        }

        public int getNewUserId()
        {
            string[] lines = File.ReadAllLines("users.txt");
            string[] lastLine = lines[lines.Length-1].Split('|');
            return Int32.Parse(lastLine[0]) + 1;
        }

        public int getNewCardId()
        {
            string[] lines = File.ReadAllLines("patientCards.txt");
            string[] lastLine = lines[lines.Length - 1].Split('|');
            return Int32.Parse(lastLine[0]) + 1;
        }
    }
}
