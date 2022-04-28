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
        readonly Patient currentPatient;
        readonly CheckupRepository checkupRepository = new CheckupRepository();
        public DeleteUpdateRequestRepository requestRepository = new DeleteUpdateRequestRepository();

        public FormPatient(string email)
        {
            
            InitializeComponent();
            PatientRepository patientRepository = new PatientRepository();
            patientRepository.LoadPatients("patients.txt");
            patientRepository.LoadAntitrolls("history.txt");
            checkupRepository.LoadCheckups("checkups.txt");
            requestRepository.LoadRequests("deleteUpdateRequests.txt");
            currentPatient = patientRepository.FindPatient(email);
            if (currentPatient.IsBlocked())
            {
                MessageBox.Show("Blokirani ste.");
                Application.Exit();
            }
        }

        private void checkupCRUD_btn_Click(object sender, EventArgs e)
        {
            if (checkup_cb.SelectedIndex != -1)
                switch (checkup_cb.SelectedIndex)
                {
                    case 0:
                        this.Hide();
                        FormReadCheckups checkupRead = new FormReadCheckups(currentPatient.id, checkupRepository);
                        checkupRead.Show();
                        break;
                    case 1:
                        this.Hide();
                        FormCreateCheckup checkupCreate = new FormCreateCheckup(currentPatient, checkupRepository);
                        checkupCreate.Show();
                        break;
                    case 2:
                        this.Hide();
                        FormDeleteCheckup checkupDelete = new FormDeleteCheckup(currentPatient, checkupRepository, requestRepository);
                        checkupDelete.Show();
                        break;
                    case 3:
                        this.Hide();
                        FormUpdateCheckup checkupUpdate = new FormUpdateCheckup(currentPatient, checkupRepository, requestRepository);
                        checkupUpdate.Show();
                        break;
                }
        }
    }
}
