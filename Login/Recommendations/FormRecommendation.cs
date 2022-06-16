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
    public partial class FormRecommendation : Form
    {
        CheckupRepository checkupRepository = new CheckupRepository("../../Data/checkups.txt");
        Patient currentPatient;
        string choosenDoctor; 
        public FormRecommendation(Patient patient)
        {
            InitializeComponent();
            currentPatient = patient;
            
        }

        private void recommend_btn_Click(object sender, EventArgs e)
        {
            if (to_date_dtp.Value > DateTime.Now)
            {
                Checkup recommendedCheckup = GetRecommended();
                if (!(recommendedCheckup is null))
                    ApproveCheckup(recommendedCheckup);
                else {
                    List<Checkup> closestCheckups = FindClosestThree(from_time_cb.SelectedItem.ToString(), to_time_cb.SelectedItem.ToString(),choosenDoctor);
                    ClosestRecommendations closestRecsForm = new ClosestRecommendations(closestCheckups, currentPatient);
                    closestRecsForm.Show();
                }
            }
            else {
                MessageBox.Show("Doslo je do greske!");
            }
        }

        Checkup GetRecommended() {
            if (doctor_rb.Checked)
                return RecommendByDoctor();
            else
                return RecommendByTime();
        }
        void ApproveCheckup(Checkup recommendedCheckup) {
            string question = "Da li zelite da zakazete pregled dana " + recommendedCheckup.dateTime.ToString("MM/dd/yyyy")+ " u " + recommendedCheckup.dateTime.TimeOfDay+" kod doktora "+recommendedCheckup.doctor;
            DialogResult approveCheckup = MessageBox.Show(question,"Provera", MessageBoxButtons.YesNo);
            if (approveCheckup == DialogResult.Yes)
            {
                checkupRepository.AddCheckup(recommendedCheckup,currentPatient);
                MessageBox.Show("Pregled je zakazan.");
                if (currentPatient.IsBlockedBySystem())
                {
                    MessageBox.Show("Blokirani ste.");
                    Application.Exit();
                }
            }
        }

        private void FormRecommendation_Load(object sender, EventArgs e)
        {
            LoadDoctors();
            LoadStartTime();
            from_time_cb.SelectedIndexChanged += new System.EventHandler(from_time_cb_SelectedIndexChanged);
        }

        private void from_time_cb_SelectedIndexChanged(Object sender, EventArgs e)
        {
            choosenDoctor = doctor_cb.SelectedItem.ToString();
            LoadEndTime();
        }

        void LoadStartTime() {
            List<string> avaliableTimes=checkupRepository.LoadAvaliableCheckupTimes(to_date_dtp.Value);
            foreach(string time in avaliableTimes) {
                from_time_cb.Items.Add(time);
            }
        }

        void LoadEndTime() {
            List<string> avaliableTimes = checkupRepository.LoadAvaliableCheckupTimes(to_date_dtp.Value);
            string startTime = from_time_cb.SelectedItem.ToString();
            foreach (string time in avaliableTimes)
            {
                if(time.CompareTo(startTime)>0)
                    to_time_cb.Items.Add(time);
            }
        }

        void LoadDoctors() {
            doctor_cb.Items.Add("Doktor1");
            doctor_cb.Items.Add("Doktor2");
            doctor_cb.Items.Add("Doktor3");
        }

        Checkup NewCheckup(string avaliableTime, DateTime date, string doctor)
        {
            DateTime newDate = GetCheckupDateTime(avaliableTime, date);
            string patientId = currentPatient.id.ToString();
            Checkup checkup = new Checkup(GetNewCheckupId(), patientId, newDate, doctor, "n\a");
            return checkup;
        }

        DateTime GetCheckupDateTime(string avaliableTime, DateTime date)
        {
            string[] hoursMinutes = avaliableTime.Split(':');
            TimeSpan newTime = new TimeSpan(int.Parse(hoursMinutes[0]), int.Parse(hoursMinutes[1]), 0);
            DateTime checkupDateTime = date.Date;
            DateTime newDateTime = checkupDateTime.Add(newTime);
            return newDateTime;
        }
        Checkup RecommendByDoctor()
        {
            DateTime choosenDate = to_date_dtp.Value;
            while (choosenDate > DateTime.Now)
            {
                string avaliableTime = GetAvaliableTime(choosenDoctor, choosenDate);
                if (!(avaliableTime is null))
                    return NewCheckup(avaliableTime, choosenDate, choosenDoctor);
                choosenDate.AddDays(1);
            }
            return null;
        }

        Checkup RecommendByTime()
        {
            string starTime = from_time_cb.SelectedItem.ToString();
            string endTime = to_time_cb.SelectedItem.ToString();
            List<string> times = GetTimePeriod(starTime, endTime);
            DateTime choosenDate = to_date_dtp.Value;
            while (choosenDate > DateTime.Now)
            {
                foreach (string time in times)
                {
                    string avaliableDoctor = GetAvaliableDoctor(time, choosenDate);
                    if (!(avaliableDoctor is null))
                        return NewCheckup(time, choosenDate,avaliableDoctor);
                }
                choosenDate=choosenDate.AddDays(-1);
            }
            
            return null;
        }

        List<Checkup> FindClosestThree(string startTime,string endTime,string doctor) {
            List<Checkup> closestCheckups = new List<Checkup>();
            DateTime choosenDate = to_date_dtp.Value;
            string[] doctors = { "", "", "" };
            while (choosenDate > DateTime.Now)
            {
                List<string> avaliableTimes = checkupRepository.LoadAvaliableCheckupTimes(choosenDate);
                int closest = FindFirstAfter(choosenDate,endTime);
                if (avaliableTimes.Count() - 3 > closest)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        doctors[i] = GetAvaliableDoctor(avaliableTimes[closest], choosenDate);
                        
                        closestCheckups.Add(NewCheckup(avaliableTimes[closest], choosenDate, doctors[i]));
                        closest++;
                        if (closestCheckups.Count == 3)
                            return closestCheckups;
                    }
                }
                choosenDate.AddDays(1);
            }
            return closestCheckups;
        }

        int FindFirstAfter(DateTime choosenDate,string endTime) {
            List<string> avaliableTimes = checkupRepository.LoadAvaliableCheckupTimes(choosenDate);
            int position = 0;
            foreach (string time in avaliableTimes)
            {
                if (avaliableTimes[position].CompareTo(endTime) > 0)
                    return position;
                position++;
            }
            return -1;
        }

        List<string> GetTimePeriod(string startTime,string endTime) {
            List<string> avaliableTimes = new List<string>() { "08:00", "08:15", "08:30", "08:45", "09:00", "09:15", "09:30", "09:45", "10:00", "10:15", "10:30", "10:45", "11:00", "11:15", "11:30", "11:45", "12:00", "12:15", "12:30", "12:45", "13:00", "13:15", "13:30", "13:45", "14:00", "14:15", "14:30", "14:45", "15:00", "15:15", "15:30", "15:45" };
            int length = avaliableTimes.Count()-1;
            while (length >= 0)
            {
                if (avaliableTimes[length].CompareTo(startTime) < 0 || avaliableTimes[length].CompareTo(endTime) > 0)
                    avaliableTimes.Remove(avaliableTimes[length]);
                length--;
            }
            return avaliableTimes;
            
        }

        string GetAvaliableTime(string doctor, DateTime date)
        {
            List<string> allTimes = new List<string>() { "08:00", "08:15", "08:30", "08:45", "09:00", "09:15", "09:30", "09:45", "10:00", "10:15", "10:30", "10:45", "11:00", "11:15", "11:30", "11:45", "12:00", "12:15", "12:30", "12:45", "13:00", "13:15", "13:30", "13:45", "14:00", "14:15", "14:30", "14:45", "15:00", "15:15", "15:30", "15:45" };

            foreach (Checkup checkup in checkupRepository.checkups)
                if (checkup.dateTime.Date.Equals(date.Date) && doctor.Equals(checkup.doctor))
                    allTimes.Remove(checkup.dateTime.ToString("HH:mm"));

            if (allTimes.Count == 0)
                return null;
            return allTimes[0];
        }

        string GetAvaliableDoctor(string time, DateTime date)
        {
            List<string> allDoctors = new List<string>() { "Doktor1", "Doktor2", "Doktor3"};

            foreach (Checkup checkup in checkupRepository.checkups)
            {
                string checkupTime = checkup.dateTime.ToString("HH:mm");
                if (checkup.dateTime.Date.Equals(date.Date) && checkupTime.Equals(time))
                    allDoctors.Remove(checkup.doctor);
            }
            if (allDoctors.Count == 0)
                return null;
            return allDoctors[0];
        }

        private int GetNewCheckupId()
        {
            int lastId = checkupRepository.checkups.Last().id;
            return lastId + 1;
        }
    }
}
