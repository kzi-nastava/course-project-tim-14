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
        CheckupRepository checkupRepository = new CheckupRepository("../../Data/checkups.txt");
        Patient currentPatient;
        List<Checkup> checkups;
        public ClosestRecommendations(List<Checkup> chkps,Patient patient)
        {
            InitializeComponent();
            currentPatient = patient;
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
                checkupRepository.AddCheckup(checkups[0],currentPatient);
            if(checkup2_rb.Checked)
                checkupRepository.AddCheckup(checkups[1], currentPatient);
            if (checkup3_rb.Checked)
                checkupRepository.AddCheckup(checkups[2], currentPatient);
        }

    }
}
