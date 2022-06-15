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
    public partial class FormDoctorSearch : Form
    {
        CheckupRepository checkupRepository = new CheckupRepository("../../Data/checkups.txt");
        DoctorRepository doctorRepository = new DoctorRepository("../../Data/doctors.txt");
        Patient currentPatient;
        string currentPatientId;
        DataTable doctorTable = new DataTable();
        public FormDoctorSearch(Patient currentPatient)
        {
            InitializeComponent();
            this.currentPatient = currentPatient;
            currentPatientId = currentPatient.id.ToString();
            CreateDoctorTable();
        }

        void CreateDoctorTable()
        {
            doctorTable.Columns.Add("ID");
            doctorTable.Columns.Add("IME");
            doctorTable.Columns.Add("PREZIME");
            doctorTable.Columns.Add("STRUKA");
            doctorTable.Columns.Add("OCENA");
        }
        private void FormDoctorSearch_Load(object sender, EventArgs e)
        {
            foreach (Doctor doctor in doctorRepository.doctors)
            {
                doctorTable.Rows.Add(doctor.id, doctor.name, doctor.lastName, doctor.type, doctor.rating);
            }
            dataGridViewDoctors.DataSource = doctorTable;
            LoadSearchCB();
            LoadSortCB();
        }

        void LoadSortCB()
        {
            sort_cb.Items.Add("Ime");
            sort_cb.Items.Add("Prezime");
            sort_cb.Items.Add("Uza oblast doktora");
            sort_cb.Items.Add("Ocena");
        }
        void LoadSearchCB()
        {
            search_cb.Items.Add("Ime");
            search_cb.Items.Add("Prezime");
            search_cb.Items.Add("Uza oblast doktora");
        }

        private void sort_btn_Click_1(object sender, EventArgs e)
        {
            if (sort_cb.SelectedIndex == 0)
                doctorTable.DefaultView.Sort = "IME ASC";
            if (sort_cb.SelectedIndex == 1)
                doctorTable.DefaultView.Sort = "PREZIME ASC";
            if (sort_cb.SelectedIndex == 2)
                doctorTable.DefaultView.Sort = "STRUKA ASC";
            if (sort_cb.SelectedIndex == 3)
                doctorTable.DefaultView.Sort = "OCENA ASC";
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            doctorTable.Rows.Clear();
            List<Doctor> doctors=doctorRepository.GetSearchedDoctors(search_cb.SelectedIndex, search_tb.Text);
            foreach (Doctor doctor in doctors)
                    doctorTable.Rows.Add(doctor.id, doctor.name, doctor.lastName, doctor.type, doctor.rating);

        }

        

        private void checkup_btn_Click(object sender, EventArgs e)
        {
            if (dataGridViewDoctors.SelectedRows.Count > 0)
            {
                FormCreateCheckup createCheckup = new FormCreateCheckup(currentPatient,GetSelectedDoctor());
                createCheckup.Show();
            }
        }

        string GetSelectedDoctor() {
            return dataGridViewDoctors.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
