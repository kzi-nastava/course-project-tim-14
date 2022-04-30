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
    }
}
