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
    public partial class FormUpdateCheckup : Form
    {
        readonly CheckupRepository checkupRepository;
        readonly int patientId;

        public FormUpdateCheckup(int patient, CheckupRepository ckpRepository)
        {
            InitializeComponent();
            patientId = patient;
            checkupRepository = ckpRepository;
        }


        private void update_btn_Click(object sender, EventArgs e)
        {
            string message = checkupRepository.UpdateCheckup(update_cb.Text, time_cb.SelectedItem.ToString());
            MessageBox.Show(message);
        }

        private void FormUpdateCheckup_Load(object sender, EventArgs e)
        {
            foreach (Checkup checkup in checkupRepository.checkups)
            {
                if (int.Parse(checkup.patient) == patientId)
                    update_cb.Items.Add(checkup.id);
            }
            update_cb.SelectedIndexChanged += new System.EventHandler(update_cb_SelectedIndexChanged);
        }

        private void update_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Checkup selectedCheckup = checkupRepository.FindCheckup(int.Parse(update_cb.SelectedItem.ToString()));
            LoadTimeCb(selectedCheckup);
        }

        public void LoadTimeCb(Checkup checkup)
        {
            List<string> avaliableTimes=checkupRepository.LoadAvaliableCheckupTimes(checkup.dateTime,checkup.doctor);
            foreach(string time in avaliableTimes)
            {
                time_cb.Items.Add(time);
            }
        }
    }
}
