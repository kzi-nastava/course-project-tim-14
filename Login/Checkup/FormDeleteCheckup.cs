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
        readonly CheckupRepository checkupRepository=new CheckupRepository("../../Data/checkups.txt");
        readonly Patient currentPatient;
        readonly DeleteUpdateRequestRepository requestRepository = new DeleteUpdateRequestRepository("../../Data/deleteUpdateRequests.txt");

        public FormDeleteCheckup(Patient patient)
        {
            InitializeComponent();
            currentPatient = patient;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            Checkup selectedCheckup = checkupRepository.FindCheckup(Int32.Parse(delete_cb.Text));
            string message = checkupRepository.DeleteCheckup(selectedCheckup,requestRepository);
            MessageBox.Show(message);
            if(message.Equals("Otkazali ste pregled."))
                currentPatient.AddToHistory(DateTime.Today, "delete");
            if (currentPatient.IsBlockedBySystem())
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
