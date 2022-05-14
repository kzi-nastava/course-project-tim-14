using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Login
{
    public partial class FormMedicalHistory : Form
    {
        CheckupRepository checkupRepository;
        Patient currentPatient;
        string currentPatientId;
        DataTable checkupTable = new DataTable();
        
        public FormMedicalHistory(Patient currentPatient,CheckupRepository checkupRepository)
        {
            InitializeComponent();
            this.currentPatient = currentPatient;
            this.checkupRepository = checkupRepository;
            currentPatientId = currentPatient.id.ToString();
            CreateCheckupTable();
            
        }
        void CreateCheckupTable() {
            checkupTable.Columns.Add("ID");
            checkupTable.Columns.Add("DATUM");
            checkupTable.Columns.Add("DOKTOR");
            checkupTable.Columns.Add("ANAMNEZA");
            checkupTable.Columns.Add("STRUKA");
        }

        private void FormMedicalHistory_Load(object sender, EventArgs e)
        {
            
            foreach (Checkup checkup in checkupRepository.checkups)
            {
                if(checkup.patient.Equals(currentPatientId) && checkup.dateTime<DateTime.Now)
                    checkupTable.Rows.Add(checkup.id, checkup.dateTime, checkup.doctor,checkup.medicalHistory,GetDoctorType(checkup.doctor));
            }
            dataGridViewCheckups.DataSource = checkupTable;
            dataGridViewCheckups.Columns["STRUKA"].Visible = false;
            LoadSortCB();
        }

       void LoadSortCB() {
            sort_cb.Items.Add("Datum");
            sort_cb.Items.Add("Doktor");
            sort_cb.Items.Add("Uza oblast doktora");
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            checkupTable.Rows.Clear();
            foreach (Checkup checkup in checkupRepository.checkups)
            {
                if (checkup.patient.Equals(currentPatientId) && checkup.dateTime < DateTime.Now)
                    if(checkup.medicalHistory.Contains(search_tb.Text))
                        checkupTable.Rows.Add(checkup.id, checkup.dateTime, checkup.doctor, checkup.medicalHistory,GetDoctorType(checkup.doctor));
            }
        }

        private void sort_btn_Click(object sender, EventArgs e)
        {
            if (sort_cb.SelectedIndex == 0)
                SortBy("Datum");
            if (sort_cb.SelectedIndex == 1)
                SortBy("Doktor");
            if (sort_cb.SelectedIndex == 2)
                SortBy("Struka");
        }

        void SortBy(string type) {
            checkupTable.DefaultView.Sort = type+" ASC";
        }

        string GetDoctorType(string doctor)
        {
            string[] lines = File.ReadAllLines("../../Data/doctors.txt");

            foreach (string line in lines)
            {
                string[] data = line.Split('|');
                if (data[1].Equals(doctor))
                    return data[5];
            }
            return null;
        }
    }
}
