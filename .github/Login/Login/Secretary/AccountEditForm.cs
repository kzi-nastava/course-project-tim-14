using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Secretary
{
    public partial class AccountEditForm : Form
    {
        public AccountEditForm()
        {
            InitializeComponent();
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            string editedPatientID = patientEditID_tb.Text;

            var accountDateEditForm = new AccountDataEditForm(editedPatientID);
            accountDateEditForm.Show();

            this.Hide();
        }
    }
}
