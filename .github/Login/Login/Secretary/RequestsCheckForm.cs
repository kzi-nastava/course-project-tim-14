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
    public partial class RequestsCheckForm : Form
    {
        public RequestsCheckForm()
        {
            InitializeComponent();
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            string requestId = requests_cb.SelectedItem.ToString();
            int lineCounter = 0;
            string newLine = "";

            string[] fileContent = File.ReadAllLines("deleteUpdateRequests.txt");
            foreach (string element in fileContent)
            {
                lineCounter += 1;
                string[] splitRequest = element.Split('|');
                if (splitRequest[0] == requestId)
                {
                    newLine = requestId + "|" + splitRequest[1] + "|" + splitRequest[2] + "|" + splitRequest[3] + "|" + splitRequest[4] + "|" + "true";
                    break;
                }
            }

            lineChanger(newLine, "deleteUpdateRequests.txt", lineCounter);
        }

        private void RequestsCheckForm_Load(object sender, EventArgs e)
        {
            LoadRequests();
        }

        public void LoadRequests()
        {
            string[] fileContent = File.ReadAllLines("deleteUpdateRequests.txt");
            foreach (string element in fileContent)
            {
                string[] splitRequest = element.Split('|');
                if (splitRequest[5] == "false")
                {
                    requests_cb.Items.Add(splitRequest[0]);
                }
            }
        }
        public void lineChanger(string newText, string fileName, int lineToEdit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[lineToEdit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }
    }
}
