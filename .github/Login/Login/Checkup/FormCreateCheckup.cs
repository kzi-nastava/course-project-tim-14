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
        readonly int patientId;

        public FormCreateCheckup(int patient, CheckupRepository ckpRepository)
        {
            InitializeComponent();
            patientId = patient;
            checkupRepository = ckpRepository;
        }

        private void FormCreateCheckup_Load(object sender, EventArgs e)
        {
            checkup_date.ValueChanged += new System.EventHandler(checkup_date_ValueChanged);
            time_cb.SelectedIndexChanged += new System.EventHandler(time_cb_SelectedIndexChanged);
        }

        private void checkup_date_ValueChanged(Object sender, EventArgs e)
        {
            if (IsDateValid())
                LoadTimeCB(checkup_date.Value);
            else
                MessageBox.Show("Neispravan datum!");

        }

        private void time_cb_SelectedIndexChanged(Object sender, EventArgs e)
        {
            if (IsDateValid())
            {
                doctor_cb.Items.Add("Doktor1");
                doctor_cb.Items.Add("Doktor2");
                doctor_cb.Items.Add("Doktor3");
                doctor_cb.Refresh();
            }             
            else
                MessageBox.Show("Doslo je do greske!");

        }

        private void create_checkup_Click(object sender, EventArgs e)
        {
            if (IsDateValid() && time_cb.SelectedIndex != -1 && doctor_cb.SelectedIndex != -1)
            {
                Checkup newCheckup = new Checkup(GetNewCheckupId(), patientId.ToString(), GetCheckupDateTime(), doctor_cb.SelectedItem.ToString());
                checkupRepository.checkups.Add(newCheckup);
                checkupRepository.AddCheckupToFile(newCheckup);
                MessageBox.Show("Pregled je zakazan.");
            }
            else
                MessageBox.Show("Doslo je do greske!");
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
