using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Surveys
{
    public partial class DoctorSurveyResultsForm : Form
    {
        public readonly SurveyRepository surveyRepository;
        public List<Doctor> doctors;
        public ScoreCalculator scoreCalculator;
        public DoctorSurveyResultsForm(SurveyRepository surveyRepository, List<Doctor> doctors)
        {
            InitializeComponent();
            this.surveyRepository = surveyRepository;
            this.doctors = doctors;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            List<Survey> surveysForDoctor = new List<Survey>();
            string doctorName = doctorComboBox.SelectedItem.ToString();
            foreach (Survey survey in surveyRepository.surveys)
            {
                if (survey.type == doctorName)
                {
                    surveysForDoctor.Add(survey);
                }
            }
            scoreCalculator = new ScoreCalculator(surveysForDoctor);
            FillTextBoxes();
            FillComments(surveysForDoctor);
        }

        private void DoctorSurveyResultsForm_Load(object sender, EventArgs e)
        {
            foreach(Doctor doctor in doctors)
            {
                doctorComboBox.Items.Add(doctor.name);
            }
        }

        private void FillTextBoxes()
        {
            qualityAvg.Text = scoreCalculator.quality.ToString();
            qualityAvg.ReadOnly = true;
            recommendAvg.Text = scoreCalculator.recommend.ToString();
            recommendAvg.ReadOnly = true;
            satisfactionAvg.Text = scoreCalculator.rating.ToString();
            satisfactionAvg.ReadOnly = true;
        }

        private void FillComments(List<Survey> surveysForDoctor)
        {
            foreach (Survey survey in surveysForDoctor)
            {
                commentsListBox.Items.Add(survey.comment);
            }
        }

        private void bestDoctorsBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, double> doctorAvgScore = CalculateAvgScores();

            var kvpGroups = doctorAvgScore.OrderByDescending(x => x.Value).GroupBy(x => x.Value).Take(3);
            string threeBestDoctors = "";
            foreach (var kvpGroup in kvpGroups)
            {
                foreach (var kvp in kvpGroup)
                {
                    threeBestDoctors += kvp.Key + " " + kvp.Value.ToString() + "\n";
                }
            }
            MessageBox.Show(threeBestDoctors, "Highest Rated Doctors");

        }

        private void worstDoctorsBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, double> doctorAvgScore = CalculateAvgScores();

            var kvpGroups = doctorAvgScore.OrderBy(x => x.Value).GroupBy(x => x.Value).Take(3);
            string threeWorstDoctors = "";
            foreach (var kvpGroup in kvpGroups)
            {
                foreach (var kvp in kvpGroup)
                {
                    threeWorstDoctors += kvp.Key + " " + kvp.Value.ToString() + "\n";
                }
            }
            MessageBox.Show(threeWorstDoctors, "Lowest Rated Doctors");
        }

        private Dictionary<string, double> CalculateAvgScores()
        {
            Dictionary<string, double> doctorAvgScore = new Dictionary<string, double>();
            foreach (Doctor doctor in doctors)
            {
                List<Survey> surveysForDoctor = new List<Survey>();
                string doctorName = doctor.name;
                foreach (Survey survey in surveyRepository.surveys)
                {
                    if (survey.type == doctorName)
                    {
                        surveysForDoctor.Add(survey);
                    }
                }
                scoreCalculator = new ScoreCalculator(surveysForDoctor);
                double totalScore = scoreCalculator.CalculateTotal();
                doctorAvgScore.Add(doctorName, totalScore);
            }
            return doctorAvgScore;
        }

    }
}
