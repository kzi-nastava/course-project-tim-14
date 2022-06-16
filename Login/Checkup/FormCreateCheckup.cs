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
        readonly CheckupRepository checkupRepository = new CheckupRepository("../../Data/checkups.txt");
        readonly Patient currentPatient;
        readonly DoctorRepository doctorRepository = new DoctorRepository("../../Data/doctors.txt");
        readonly string doctor;
        public FormCreateCheckup(Patient patient,string doctor)
        {
            InitializeComponent();
            currentPatient = patient;
            this.doctor = doctor;
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
            if (IsAllSelected())
            {
                Checkup newCheckup = new Checkup(checkupRepository.GetNewCheckupId(), currentPatient.id.ToString(), GetCheckupDateTime(), doctor_cb.SelectedItem.ToString(),"n/a");
                checkupRepository.AddCheckup(newCheckup,currentPatient);
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

        private bool IsAllSelected()
        {
            return IsDateValid() && time_cb.SelectedIndex != -1 && doctor_cb.SelectedIndex != -1;
        }

        private bool IsDateValid()
        {
            return checkup_date.Value.Date > DateTime.Now;
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
