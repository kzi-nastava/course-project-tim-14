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

    public partial class ClosestRecommendations : Form
    {
        CheckupRepository checkupRepository;
        Patient currentPatient;
        List<Checkup> checkups;
        public ClosestRecommendations(List<Checkup> chkps,Patient patient, CheckupRepository ckpRepository)
        {
            InitializeComponent();
            currentPatient = patient;
            checkupRepository = ckpRepository;
            checkups = chkps;
        }

        private void ClosestRecommendations_Load(object sender, EventArgs e)
        {
            checkup1_rb.Text = checkups[0].dateTime.ToString("MM/dd/yyyy") + " " + checkups[0].dateTime.ToString("HH:mm") + " " + checkups[0].doctor;
            checkup2_rb.Text = checkups[1].dateTime.ToString("MM/dd/yyyy") + " " + checkups[1].dateTime.ToString("HH:mm") + " " + checkups[1].doctor;
            checkup3_rb.Text = checkups[2].dateTime.ToString("MM/dd/yyyy") + " " + checkups[2].dateTime.ToString("HH:mm") + " " + checkups[2].doctor;
        }

        private void approve_btn_Click(object sender, EventArgs e)
        {
            if (checkup1_rb.Checked)
                AddCheckup(checkups[0]);
            if(checkup2_rb.Checked)
                AddCheckup(checkups[1]);
            if (checkup3_rb.Checked)
                AddCheckup(checkups[2]);
        }

        void AddCheckup(Checkup recommendedCheckup)
        {
            checkupRepository.checkups.Add(recommendedCheckup);
            checkupRepository.AddCheckupToFile(recommendedCheckup);
            currentPatient.antitroll.AddAction("add");
            currentPatient.AddToHistory(DateTime.Today, "add");
            MessageBox.Show("Pregled je zakazan.");
            if (currentPatient.IsBlockedBySystem())
            {
                MessageBox.Show("Blokirani ste.");
                Application.Exit();
            }
        }
    }
}
