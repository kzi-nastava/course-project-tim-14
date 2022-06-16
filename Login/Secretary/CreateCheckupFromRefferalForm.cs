using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Secretary
{
    public partial class CreateCheckupFromRefferalForm : Form
    {
        readonly CheckupRepository checkupRepository;

        public CreateCheckupFromRefferalForm(CheckupRepository ckpRepository)
        {
            InitializeComponent();
            checkupRepository = ckpRepository;
            checkupRepository.LoadCheckups("../../Data/checkups.txt");
        }

        private void CreateCheckupFromRefferalForm_Load(object sender, EventArgs e)
        {
            loadRefferals();
            refferedCheckup_date.ValueChanged += new System.EventHandler(refferedCheckup_date_ValueChanged);
        }

        private void loadRefferals()
        {
            string[] fileContent = File.ReadAllLines("../../Data/refferals.txt");
            foreach (string element in fileContent)
            {
                string[] splitRefferal = element.Split('|');
                refferalSelect_cb.Items.Add(splitRefferal[0]);
            }
        }

        private void refferedCheckup_date_ValueChanged(Object sender, EventArgs e)
        {
            if (IsDateValid())
                LoadTimeCB(refferedCheckup_date.Value);
            else
                MessageBox.Show("Neispravan datum!");

        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            if (IsDateValid() && refferalTime_cb.SelectedIndex != -1)
            {
                Checkup newCheckup = new Checkup(GetNewCheckupId(), GetPatientId(), GetCheckupDateTime(), GetDoctorName(),"n/a");
                checkupRepository.checkups.Add(newCheckup);
                //checkupRepository.AddCheckupToFile(newCheckup);
                MessageBox.Show("Pregled je zakazan.");
            }
            else
            {
                MessageBox.Show("Doslo je do greske!");
            }

            deleteRefferal();
            this.Hide();
        }

        private bool IsDateValid()
        {
            DateTime currentDate = DateTime.Now;
            if (refferedCheckup_date.Value.Date > currentDate)
                return true;
            return false;
        }

        private void LoadTimeCB(DateTime selectedDate)
        {
            List<string> avaliableTimes = checkupRepository.LoadAvaliableCheckupTimes(selectedDate);
            foreach (string time in avaliableTimes)
            {
                refferalTime_cb.Items.Add(time);
            }
            refferalTime_cb.Refresh();
        }

        private int GetNewCheckupId()
        {
            int lastId = checkupRepository.checkups.Last().id;
            return lastId + 1;
        }

        private DateTime GetCheckupDateTime()
        {
            string[] hoursMinutes = refferalTime_cb.SelectedItem.ToString().Split(':');
            TimeSpan time = new TimeSpan(int.Parse(hoursMinutes[0]), int.Parse(hoursMinutes[1]), 0);
            DateTime checkupDateTime = refferedCheckup_date.Value.Date;
            DateTime combined = checkupDateTime.Add(time);
            return combined;
        }

        private string GetPatientId()
        {
            string patientId = "";
            string refferalId = refferalSelect_cb.SelectedItem.ToString();

            string[] refferalsFileContent = File.ReadAllLines("../../Data/refferals.txt");
            foreach (string element in refferalsFileContent)
            {
                string[] splitRefferal = element.Split('|');
                if (splitRefferal[0] == refferalId)
                {
                    patientId = splitRefferal[1];
                    break;
                }
            }

            return patientId;
        }

        private string GetDoctorName()
        {
            string doctorName = "";
            string doctorId = "";
            string refferalId = refferalSelect_cb.SelectedItem.ToString();

            string[] refferalsFileContent = File.ReadAllLines("../../Data/refferals.txt");
            foreach (string element in refferalsFileContent)
            {
                string[] splitRefferal = element.Split('|');
                if (splitRefferal[0] == refferalId)
                {
                    doctorId = splitRefferal[2];
                    break;
                }
            }

            string[] doctorsFileContent = File.ReadAllLines("../../Data/doctors.txt");
            foreach (string element in doctorsFileContent)
            {
                string[] splitDoctor = element.Split('|');
                if (splitDoctor[0] == doctorId)
                {
                    doctorName = splitDoctor[1];
                    break;
                }
            }

            return doctorName;
        }

        private void deleteRefferal()
        {
            string refferalsFilePath = "../../Data/refferals.txt";

            string deletedRefferalID = refferalSelect_cb.SelectedItem.ToString();

            deleteFromFile(refferalsFilePath, 0, deletedRefferalID);
        }

        public void deleteFromFile(string filePath, int idPosition, string deletedUserID)
        {
            var tempFile = Path.GetTempFileName();
            var linesToKeep = File.ReadLines(filePath).Where(l => l.Split('|')[idPosition] != deletedUserID);

            File.WriteAllLines(tempFile, linesToKeep);

            File.Delete(filePath);
            File.Move(tempFile, filePath);
        }
    }
}
