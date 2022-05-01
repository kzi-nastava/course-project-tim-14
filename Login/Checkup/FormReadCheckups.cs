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
    public partial class FormReadCheckups : Form
    {
        readonly CheckupRepository checkupRepository;
        readonly int patientId;

        public FormReadCheckups(int patient,CheckupRepository ckpRepository)
        {
            InitializeComponent();
            patientId = patient;
            checkupRepository = ckpRepository;
        }

        private void FormReadCheckups_Load(object sender, EventArgs e)
        {
            MakeCheckupTable();

        }
        void MakeCheckupTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Vreme");
            table.Columns.Add("Doktor");
            foreach (Checkup checkup in checkupRepository.checkups)
            {
                if (Int32.Parse(checkup.patient) == patientId)
                {
                    table.Rows.Add(checkup.id, checkup.dateTime, checkup.doctor);
                }
            }

            CheckupTable.DataSource = table;
        }
    }
}
