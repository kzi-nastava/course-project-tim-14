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
    public partial class FormCreateCheckup : Form
    {
        readonly CheckupRepository checkupRepository;
        readonly Patient currentPatient;
        readonly DoctorRepository doctorRepository = new DoctorRepository();
        readonly string doctor;
        public FormCreateCheckup(Patient patient, CheckupRepository ckpRepository,string doctor)
        {
            InitializeComponent();
            currentPatient = patient;
            checkupRepository = ckpRepository;
            this.doctor = doctor;
            doctorRepository.LoadDoctors("../../Data/doctors.txt");
        }

        private void FormCreateCheckup_Load(object sender, EventArgs e)
        {
           
            LoadDoctorCB();
            SetDoctor();
            checkup_date.ValueChanged += new System.EventHandler(checkup_date_ValueChanged);
            
        }

        void SetDoctor() {
            if (!doctor.Equals(""))
            {
                doctor_cb.SelectedItem = doctor;
                doctor_cb.SelectedText = doctor;
                doctor_cb.SelectedIndex = doctor_cb.FindString(doctor);
            }
        }

        private void checkup_date_ValueChanged(Object sender, EventArgs e)
        {
            if (IsDateValid())
                LoadTimeCB(checkup_date.Value);
            else
                MessageBox.Show("Neispravan datum!");

        }

 

        void LoadDoctorCB() {
            foreach (Doctor doctor in doctorRepository.doctors)
                doctor_cb.Items.Add(doctor.name);
        }

        private void create_checkup_Click(object sender, EventArgs e)
        {
            if (IsDateValid() && time_cb.SelectedIndex != -1 && doctor_cb.SelectedIndex != -1)
            {
                Checkup newCheckup = new Checkup(GetNewCheckupId(), currentPatient.id.ToString(), GetCheckupDateTime(), doctor_cb.SelectedItem.ToString(),"n/a");
                checkupRepository.checkups.Add(newCheckup);
                checkupRepository.AddCheckupToFile(newCheckup);
                currentPatient.antitroll.AddAction("add");
                currentPatient.AddToHistory(DateTime.Today, "add");
                MessageBox.Show("Pregled je zakazan.");
            }
            else
                MessageBox.Show("Doslo je do greske!");
            if (currentPatient.IsBlockedBySystem())
            {
                MessageBox.Show("Blokirani ste.");
                Application.Exit();
            }
        }

        private bool IsDateValid()
        {
            DateTime currentDate = DateTime.Now;
            if (checkup_date.Value.Date > currentDate)
                return true;
            return false;
        }

        private void LoadTimeCB(DateTime selectedDate)
        {
            List<string> avaliableTimes = checkupRepository.LoadAvaliableCheckupTimes(selectedDate);
            foreach(string time in avaliableTimes)
            {
                time_cb.Items.Add(time);
            }
            time_cb.Refresh();
        }
        
        private int GetNewCheckupId()
        {
            int lastId=checkupRepository.checkups.Last().id;
            return lastId + 1;
        }

        private DateTime GetCheckupDateTime()
        {
            string[] hoursMinutes = time_cb.SelectedItem.ToString().Split(':');
            TimeSpan time = new TimeSpan(int.Parse(hoursMinutes[0]), int.Parse(hoursMinutes[1]),0);
            DateTime checkupDateTime = checkup_date.Value.Date;
            DateTime combined = checkupDateTime.Add(time);
            return combined;
        }
    }
}
