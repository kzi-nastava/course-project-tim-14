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
        readonly Patient currentPatient;
        readonly DeleteUpdateRequestRepository requestRepository;

        public FormDeleteCheckup(Patient patient, CheckupRepository ckpRepository, DeleteUpdateRequestRepository rqstRepository)
        {
            InitializeComponent();
            currentPatient = patient;
            checkupRepository = ckpRepository;
            requestRepository = rqstRepository;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string message = checkupRepository.DeleteCheckup(delete_cb.SelectedItem.ToString(),currentPatient,requestRepository);
            MessageBox.Show(message);
            if(message.Equals("Otkazali ste pregled."))
                currentPatient.AddToHistory(DateTime.Today, "delete");
            if (currentPatient.IsBlocked())
            {
                MessageBox.Show("Blokirani ste.");
                Application.Exit();
            }
        }

        private void FormDeleteCheckup_Load(object sender, EventArgs e)
        {
            foreach(Checkup checkup in checkupRepository.checkups)
            {
                if(int.Parse(checkup.patient)==currentPatient.id)
                    delete_cb.Items.Add(checkup.id);
            }
        }
    }
}
