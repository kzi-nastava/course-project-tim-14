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
    public partial class FormDeleteCheckup : Form
    {
        readonly CheckupRepository checkupRepository;
        readonly int patientId;

        public FormDeleteCheckup(int patient, CheckupRepository ckpRepository)
        {
            InitializeComponent();
            patientId = patient;
            checkupRepository = ckpRepository;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string message = checkupRepository.DeleteCheckup(delete_cb.SelectedItem.ToString());
            MessageBox.Show(message);
        }

        private void FormDeleteCheckup_Load(object sender, EventArgs e)
        {
            foreach(Checkup checkup in checkupRepository.checkups)
            {
                if(int.Parse(checkup.patient)==patientId)
                    delete_cb.Items.Add(checkup.id);
            }
        }
    }
}
