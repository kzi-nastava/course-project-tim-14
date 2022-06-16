using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.Prescription;


namespace Login
{
    public partial class FormPatient : Form
    {
        readonly Patient currentPatient;
        readonly CheckupRepository checkupRepository = new CheckupRepository("../../Data/checkups.txt");
        public DeleteUpdateRequestRepository requestRepository = new DeleteUpdateRequestRepository("../../Data/deleteUpdateRequests.txt");
        public PrescriptionRepository prescriptionRepository = new PrescriptionRepository();

        public FormPatient(string email)
        {
            
            InitializeComponent();
            PatientRepository patientRepository = new PatientRepository();
            patientRepository.LoadPatients("../../Data/patients.txt");
            patientRepository.LoadAntitrolls("../../Data/history.txt");
            prescriptionRepository.LoadPrescriptions("../../Data/prescriptions.txt");
            prescriptionRepository.hoursBefore = 7;
            currentPatient = patientRepository.FindPatient(email);
            if (currentPatient.IsBlockedBySystem() || currentPatient.blocked.Equals("blocked"))
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
                        FormReadCheckups checkupRead = new FormReadCheckups(currentPatient.id);
                        checkupRead.Show();
                        break;
                    case 1:
                        this.Hide();
                        FormCreateCheckup checkupCreate = new FormCreateCheckup(currentPatient,"");
                        checkupCreate.Show();
                        break;
                    case 2:
                        this.Hide();
                        FormDeleteCheckup checkupDelete = new FormDeleteCheckup(currentPatient);
                        checkupDelete.Show();
                        break;
                    case 3:
                        this.Hide();
                        FormUpdateCheckup checkupUpdate = new FormUpdateCheckup(currentPatient);
                        checkupUpdate.Show();
                        break;
                }
        }

        private void recommend_btn_Click(object sender, EventArgs e)
        {
            FormRecommendation formRecommendation = new FormRecommendation(currentPatient);
            formRecommendation.Show();
        }


        private void medical_history_btn_Click_1(object sender, EventArgs e)
        {
            FormMedicalHistory formMedicalHistory = new FormMedicalHistory(currentPatient);
            formMedicalHistory.Show();
        }

        private void doctor_search_btn_Click(object sender, EventArgs e)
        {
            FormDoctorSearch formDoctorSearch = new FormDoctorSearch(currentPatient);
            formDoctorSearch.Show();
        }

        private void notification_btn_Click(object sender, EventArgs e)
        {
            List<Prescription.Prescription> prescriptions = prescriptionRepository.GetTodaysPrescriptions(currentPatient.id.ToString());
            foreach (Prescription.Prescription prescription in prescriptions)
            {
                MessageBox.Show(prescription.GetMessage());
            }
        }  

        private void choose_hours_btn_Click(object sender, EventArgs e)
        {
            int.TryParse(hours_tb.Text, out prescriptionRepository.hoursBefore);
            
        }

        private void survey_btn_Click(object sender, EventArgs e)
        {
            FormSurvey formSurvey = new FormSurvey(currentPatient.id,"bolnica");
            formSurvey.Show();
        }


    }
}
