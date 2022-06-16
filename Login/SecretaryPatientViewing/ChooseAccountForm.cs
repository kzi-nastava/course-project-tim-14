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
    public partial class ChooseAccountForm : Form
    {
        public ChooseAccountForm()
        {
            InitializeComponent();
        }

        private void continue_btn_Click(object sender, EventArgs e)
        {
            string patientId = patientId_tb.Text;
            var singleAccountForm = new SingleAccountForm(patientId);
            singleAccountForm.Show();

            this.Hide();
        }
    }
}
