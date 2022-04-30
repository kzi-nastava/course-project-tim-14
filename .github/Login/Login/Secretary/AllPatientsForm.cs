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

namespace Login.Secretary
{
    public partial class AllPatientsForm : Form
    {
        public AllPatientsForm()
        {
            InitializeComponent();
        }
        public void FillRichText(string filePath)
        {
            string content = "";
            string[] fileContent = File.ReadAllLines(filePath);
            foreach (string element in fileContent)
            {
                string[] singlePatientData = element.Split('|');
                if (singlePatientData[5] != "blocked")
                {
                    content = content + singlePatientData[0] + "   " + singlePatientData[1] + "   " + singlePatientData[2] + "   " + singlePatientData[3] + "   " + singlePatientData[4] + "\n";
                }
            }
            richTextBox1.Text = content;
        }

        private void AllPatientsForm_Load(object sender, EventArgs e)
        {
            string patientsFilePath = "patients.txt";
            FillRichText(patientsFilePath);
        }
    }
}
