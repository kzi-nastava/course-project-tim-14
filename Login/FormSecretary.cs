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

namespace Login
{
    public partial class FormSecretary : Form
    {
        readonly CheckupRepository checkupRepository = new CheckupRepository();   

        public FormSecretary()
        {
            InitializeComponent();
            PatientCardRepository cardRepository = new PatientCardRepository();
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
            var createCheckupFromRefferalFrom = new CreateCheckupFromRefferalForm(checkupRepository);
            createCheckupFromRefferalFrom.Show();
        }
    }
}
