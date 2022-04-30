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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label_Click(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string userType = findUser(email_tb.Text, password_tb.Text);
            if (!(userType is null))
            {
                openUserForm(userType);

            }
        }

        public string findUser(string email, string password)
        {
            string userFileName = "users.txt";
            string[] lines = File.ReadAllLines(userFileName);
            foreach (string line in lines)
            {
                string[] data = line.Split('|');
                if (email == data[1] && password == data[2]) { return data[3]; }
            }
            return null;
        }

        public void openUserForm(string userType)
        {
            switch (userType)
            {
                case "admin":
                    var adminForm = new FormAdmin();
                    adminForm.Show();
                    break;
                case "secretary":
                    var secretaryForm = new FormSecretary();
                    secretaryForm.Show();
                    break;
                case "patient":
                    var patientForm = new FormPatient();
                    patientForm.Show();
                    break;
                case "doctor":
                    var doctorForm = new FormDoctor();
                    doctorForm.Show();
                    break;
                default:
                    break;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    
}
