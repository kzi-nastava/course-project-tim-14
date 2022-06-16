using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Surveys
{
    public class ScoreCalculator
    {
        public List<Survey> surveys;
        public double quality;
        public double hygiene;
        public double rating;
        public double recommend;
        public int scoreOne;
        public int scoreTwo;
        public int scoreThree;
        public int scoreFour;
        public int scoreFive;

        public ScoreCalculator(List<Survey> surveys)
        {
            this.surveys = surveys;
            this.SumScores();
            this.CalculateAverage();
        }

        public void CalculateAverage()
        {
            int totalSurveys = surveys.Count();
            quality /= totalSurveys;
            hygiene /= totalSurveys;
            rating /= totalSurveys;
            recommend /= totalSurveys;
        }
        
        public void SumScores()
        {
            foreach (Survey survey in surveys)
            {
                quality += survey.quality;
                hygiene += survey.hygiene;
                rating += survey.rating;
                recommend += survey.recommend;
            }
        }

        private void ResetScores()
        {
            scoreOne = 0;
            scoreTwo = 0;
            scoreThree = 0;
            scoreFour = 0;
            scoreFive = 0;
        }

        public void SpecifiScoresForQuality()
        {
            ResetScores();
            foreach (Survey survey in surveys)
            {
                CountQuestionScores(survey.quality);
            }
            ShowScores();

        }

        public void SpecifiScoresForHygiene()
        {
            ResetScores();
            foreach (Survey survey in surveys)
            {
                CountQuestionScores(survey.hygiene);

            }
            ShowScores();
        }

        public void SpecifiScoresForRecommend()
        {
            ResetScores();
            foreach (Survey survey in surveys)
            {
                CountQuestionScores(survey.recommend);

            }
            ShowScores();
        }

        public void SpecifiScoresForRating()
        {
            ResetScores();
            foreach (Survey survey in surveys)
            {
                CountQuestionScores(survey.rating);
            }
            ShowScores();
        }

        public void CountQuestionScores(int parametar)
        {
            switch (parametar)
            {
                case 1:
                    scoreOne++;
                    break;
                case 2:
                    scoreTwo++;
                    break;
                case 3:
                    scoreThree++;
                    break;
                case 4:
                    scoreFour++;
                    break;
                case 5:
                    scoreFive++;
                    break;
                default:
                    break;
            }
        }

        public void ShowScores()
        {
            MessageBox.Show("SCORE 1: " + scoreOne + "\n" +
                            "SCORE 2: " + scoreTwo + "\n" +
                            "SCORE 3: " + scoreThree + "\n" +
                            "SCORE 4: " + scoreFour + "\n" +
                            "SCORE 5: " + scoreFive, "MoreInfo");
        }

        public double CalculateTotal()
        {
            return (quality + hygiene + recommend + rating) / 4;
        }
    }
}
