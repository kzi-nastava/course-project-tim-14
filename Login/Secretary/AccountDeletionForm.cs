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
    public partial class AccountDeletionForm : Form
    {
        public AccountDeletionForm()
        {
            InitializeComponent();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string usersFilePath = "../../Data/users.txt";
            string patientsFilePath = "../../Data/patients.txt";
            string patientCardsFilePath = "../../Data/patientCards.txt";

            string deletedUserID = deletedUserID_tb.Text;

            deleteFromFile(usersFilePath, 0, deletedUserID);
            deleteFromFile(patientsFilePath, 0, deletedUserID);
            deleteFromFile(patientCardsFilePath, 1, deletedUserID);

            MessageBox.Show("Nalog pacijenta uspesno obrisan.");
            this.Hide();
        }

        public void deleteFromFile(string filePath, int idPosition, string deletedUserID)
        {
            var tempFile = Path.GetTempFileName();
            var linesToKeep = File.ReadLines(filePath).Where(l => l.Split('|')[idPosition] != deletedUserID);

            File.WriteAllLines(tempFile, linesToKeep);

            File.Delete(filePath);
            File.Move(tempFile, filePath);
        }
    }
}
