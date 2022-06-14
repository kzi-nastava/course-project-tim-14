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
    public partial class FormSurvey : Form
    {
        int currentPatientId;
        string type;
        SurveyRepository surveyRepository = new SurveyRepository("../../Data/surveys.txt");
        public FormSurvey(int currentPatient,string type)
        {
            InitializeComponent();
            currentPatientId = currentPatient;
            this.type = type;
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            if (ISValid())
            {
                int surveyId = surveyRepository.GetNewId();
                Survey newSurvey = new Survey(surveyId, currentPatientId, GetRating(quality_cb), GetRating(hygiene_cb), GetRating(rating_cb), GetRating(recommend_cb), comment_tb.Text,type);
                surveyRepository.AddSurvey(newSurvey);
                MessageBox.Show("Hvala na odgovoru.");
            }
            else {
                MessageBox.Show("Doslo je do greske.");
            }
        }

        private void FormSurvey_Load(object sender, EventArgs e)
        {
            if (!type.Equals("bolnica"))
            {
                hygiene_cb.Hide();
                hygiene_lbl.Hide();
            }
            LoadCB(quality_cb);
            LoadCB(hygiene_cb);
            LoadCB(rating_cb);
            LoadCB(recommend_cb);
        }

        public int GetRating(ComboBox comboBox) {
            if (comboBox.SelectedIndex != -1)
                return Int32.Parse(comboBox.SelectedItem.ToString());
            else
                return -1;
        }
        public bool ISValid() {
            return !(GetRating(quality_cb) == -1 || GetRating(rating_cb) == -1 || GetRating(recommend_cb) == -1);
        }
        void LoadCB(ComboBox comboBox) {
            for (int i = 1; i < 6; i++)
                comboBox.Items.Add(i.ToString());
        }

    }
}
