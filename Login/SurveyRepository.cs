using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Login
{
    public class SurveyRepository
    {
        public List<Survey> surveys = new List<Survey>();

        public SurveyRepository(string fileName) {
            LoadSurveys(fileName);
        }
        public void LoadSurveys(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] data = line.Split('|');
                Survey survey = new Survey(Int32.Parse(data[0]), Int32.Parse(data[1]), Int32.Parse(data[2]), Int32.Parse(data[3]), Int32.Parse(data[4]), Int32.Parse(data[5]), data[6],data[7]);
                surveys.Add(survey);
            }
        }

        public void AddSurveyToFile(Survey survey)
        {
            using (StreamWriter tw = File.AppendText("../../Data/surveys.txt"))
            {
                survey.AddComment();
                string line = survey.id + "|" + survey.patientId + "|" + survey.quality + "|" + survey.hygiene + "|" + survey.rating + "|" + survey.recommend + "|" + survey.comment+"|"+survey.type;
                tw.WriteLine(line);
                tw.Close();
            }
        }

        public void AddSurvey(Survey survey) {
            surveys.Add(survey);
            AddSurveyToFile(survey);
        }

        public int GetNewId() {
                int lastId = surveys.Last().id;
                return lastId + 1;
        }
    }

}
