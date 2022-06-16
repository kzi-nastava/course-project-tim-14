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
    public partial class HospitalSurveyResultsForm : Form
    {
        private readonly SurveyRepository surveyRepository;
        private ScoreCalculator scoreCalculator;

        public HospitalSurveyResultsForm(SurveyRepository surveyRepository)
        {
            this.InitializeComponent();
            this.surveyRepository = surveyRepository;
        }

        private void HospitalSurveyResultsForm_Load(object sender, EventArgs e)
        {
            scoreCalculator = new ScoreCalculator(surveyRepository.surveys);
            FillTextBoxes();
            FillComments();
        }

        private void moreInfoQuality_Click(object sender, EventArgs e)
        {
            scoreCalculator.SpecifiScoresForQuality();
        }

        private void moreInfoHygiene_Click(object sender, EventArgs e)
        {
            scoreCalculator.SpecifiScoresForHygiene();
        }

        private void moreInfoSatisfaction_Click(object sender, EventArgs e)
        {
            scoreCalculator.SpecifiScoresForRating();
        }

        private void moreInfoRecommend_Click(object sender, EventArgs e)
        {
            scoreCalculator.SpecifiScoresForRecommend();
        }

        private void FillTextBoxes()
        {
            qualityAvg.Text = scoreCalculator.quality.ToString();
            qualityAvg.ReadOnly = true;
            hygieneAvg.Text = scoreCalculator.hygiene.ToString();
            hygieneAvg.ReadOnly = true;
            recommendAvg.Text = scoreCalculator.recommend.ToString();
            recommendAvg.ReadOnly = true;
            satisfactionAvg.Text = scoreCalculator.rating.ToString();
            satisfactionAvg.ReadOnly = true;
        }

        private void FillComments()
        {
            foreach (Survey survey in surveyRepository.surveys)
            {
                commentsListBox.Items.Add(survey.comment);
            }
        }

        
    }
}
