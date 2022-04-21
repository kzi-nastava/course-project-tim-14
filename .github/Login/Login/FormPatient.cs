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
    public partial class FormPatient : Form
    {
        public FormPatient()
        {
            InitializeComponent();
        }

        private void checkupCRUD_btn_Click(object sender, EventArgs e)
        {
            if (checkup_cb.SelectedIndex != -1)
                switch (checkup_cb.SelectedIndex)
                {
                    case 0:
                        this.Hide();
                        FormReadCheckups checkups = new FormReadCheckups();
                        checkups.Show();
                        break;
                    case 1:
                        this.Hide();
                        FormCreateCheckup checkupCreate = new FormCreateCheckup();
                        checkupCreate.Show();
                        break;
                    case 2:
                        this.Hide();
                        FormDeleteCheckup checkupDelete = new FormDeleteCheckup();
                        checkupDelete.Show();
                        break;
                    case 3:
                        this.Hide();
                        FormUpdateCheckup checkupUpdate = new FormUpdateCheckup();
                        checkupUpdate.Show();
                        break;
                }
        }
    }
}
