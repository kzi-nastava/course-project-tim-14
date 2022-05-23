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
        readonly CheckupRepository checkupRepository = new CheckupRepository();
        public DeleteUpdateRequestRepository requestRepository = new DeleteUpdateRequestRepository();
        public PrescriptionRepository prescriptionRepository = new PrescriptionRepository();

        public FormPatient(string email)
        {
            
            InitializeComponent();
            PatientRepository patientRepository = new PatientRepository();
            patientRepository.LoadPatients("../../Data/patients.txt");
            patientRepository.LoadAntitrolls("../../Data/history.txt");
            patientRepository.LoadAntitrolls("../../Data/history.txt");
            checkupRepository.LoadCheckups("../../Data/checkups.txt");
            requestRepository.LoadRequests("../../Data/deleteUpdateRequests.txt");
            prescriptionRepository.LoadPrescriptions("../../Data/prescriptions.txt");
            prescriptionRepository.hoursBefore = 5;
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
                        FormReadCheckups checkupRead = new FormReadCheckups(currentPatient.id, checkupRepository);
                        checkupRead.Show();
                        break;
                    case 1:
                        this.Hide();
                        FormCreateCheckup checkupCreate = new FormCreateCheckup(currentPatient, checkupRepository,"");
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

        private void recommend_btn_Click(object sender, EventArgs e)
        {
            FormRecommendation formRecommendation = new FormRecommendation(currentPatient,checkupRepository);
            formRecommendation.Show();
        }


        private void medical_history_btn_Click_1(object sender, EventArgs e)
        {
            FormMedicalHistory formMedicalHistory = new FormMedicalHistory(currentPatient, checkupRepository);
            formMedicalHistory.Show();
        }

        private void doctor_search_btn_Click(object sender, EventArgs e)
        {
            FormDoctorSearch formDoctorSearch = new FormDoctorSearch(currentPatient, checkupRepository);
            formDoctorSearch.Show();
        }

        private void notification_btn_Click(object sender, EventArgs e)
        {
            List<Prescription.Prescription> prescriptions=prescriptionRepository.GetPrescriptions(currentPatient.id.ToString());
            foreach (Prescription.Prescription prescription in prescriptions) {
                DateTime prescriptionTime = DateTime.ParseExact(prescription.time, "HH:mm", null);
                for (int i = 0; i < prescription.num; i++)
                {
                    prescriptionTime=prescriptionTime.AddHours(24 / prescription.num);
                    
                    if (IsTime(prescriptionTime))
                    {
                        MessageBox.Show(GetMessage(prescription,prescriptionTime));
                    }
                }
            }
        }

        public string GetMessage(Prescription.Prescription prescription,DateTime time) {
            return "Popij " + prescription.medicine + " u " + time.ToString("HH:mm") + " " + prescription.description+".";
        }

        public bool IsTime(DateTime prescriptionTime) {
            return prescriptionTime.TimeOfDay < DateTime.Now.AddHours(prescriptionRepository.hoursBefore).TimeOfDay;

            //return prescriptionTime.AddHours(prescriptionRepository.hoursBefore).TimeOfDay > DateTime.Now.TimeOfDay;
        }

        private void choose_hours_btn_Click(object sender, EventArgs e)
        {
            int.TryParse(hours_tb.Text, out prescriptionRepository.hoursBefore);
            
        }
    }
}
