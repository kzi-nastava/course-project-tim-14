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
    public partial class FreeDayRequestForm : Form
    {
        public FreeDayRequestForm()
        {
            InitializeComponent();

        }

        private void FreeDayRequestForm_Load(object sender, EventArgs e)
        {
            LoadRequests();
        }

        private void approveRequest_btn_Click(object sender, EventArgs e)
        {
            string request = requests_cb.SelectedItem.ToString();
            int lineCounter = 0;
            string newLine = "";

            string[] fileContent = File.ReadAllLines("../../Data/freeDayRequests.txt");
            foreach (string element in fileContent)
            {
                lineCounter += 1;
                string[] splitRequest = element.Split('|');
                if (splitRequest[0] == request.Split('|')[0])
                {
                    newLine = splitRequest[0] + "|" + splitRequest[1] + "|" + splitRequest[2] + "|"  + "1";
                    break;
                }
            }

            changeLineInFile(newLine, "../../Data/freeDayRequests.txt", lineCounter);

            MessageBox.Show("Zahtev odobren.");
            this.Hide();
        }

        private void rejectRequest_btn_Click(object sender, EventArgs e)
        {
            string request = requests_cb.SelectedItem.ToString();

            var createDeclineRequestForm = new DeclineRequestForm(request);
            createDeclineRequestForm.Show();

            this.Hide();
        }

        public void LoadRequests()
        {
            string[] fileContent = File.ReadAllLines("../../Data/freeDayRequests.txt");
            foreach (string element in fileContent)
            {
                string[] splitRequest = element.Split('|');
                if (splitRequest[3] == "0")
                {
                    requests_cb.Items.Add(element);
                }
            }
        }

        public void changeLineInFile(string newText, string fileName, int lineToEdit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[lineToEdit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }
    }
}
