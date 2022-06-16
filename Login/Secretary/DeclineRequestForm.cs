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
    public partial class DeclineRequestForm : Form
    {
        string request;
        public DeclineRequestForm(string request)
        {
            InitializeComponent();
            this.request = request;
        }

        private void cancelRejection_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public int getNewId(string path)
        {
            string[] lines = File.ReadAllLines(path);
            string[] lastLine = lines[lines.Length - 1].Split('|');
            return Int32.Parse(lastLine[0]) + 1;
        }

        public void writeToFile(string path, string newLine)
        {
            TextWriter userTSW = new StreamWriter(path, true);
            userTSW.WriteLine(newLine);
            userTSW.Close();
        }

        private void confirmRejection_btn_Click(object sender, EventArgs e)
        {
            string newId = getNewId("../../Data/freeDayReply.txt").ToString();
            string newLine = newId + "|" + request.Substring(0, request.Length - 2) + "|" + explanation_tb.Text;

            writeToFile("../../Data/freeDayReply.txt", newLine);
            markRequest();

            MessageBox.Show("Zahtev odbijen.");
            this.Hide();
        }

        public void markRequest()
        {
            int lineCounter = 0;
            string newLine = "";

            string[] fileContent = File.ReadAllLines("../../Data/freeDayRequests.txt");
            foreach (string element in fileContent)
            {
                lineCounter += 1;
                string[] splitRequest = element.Split('|');
                if (splitRequest[0] == request.Split('|')[0])
                {
                    newLine = splitRequest[0] + "|" + splitRequest[1] + "|" + splitRequest[2] + "|" + "1";
                    break;
                }
            }

            changeLineInFile(newLine, "../../Data/freeDayRequests.txt", lineCounter);
        }
        public void changeLineInFile(string newText, string fileName, int lineToEdit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[lineToEdit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }
    }
}
