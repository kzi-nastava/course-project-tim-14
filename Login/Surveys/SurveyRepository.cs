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
        public FileWriter fileWriter;
        public string fileName;
        public SurveyRepository(string fileName) {
            this.fileName = fileName;
            fileWriter = new FileWriter(fileName);
            LoadSurveys();
        }

        public void LoadSurveys()
        {
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                string[] data = line.Split('|');
                Survey survey = new Survey(Int32.Parse(data[0]), Int32.Parse(data[1]), Int32.Parse(data[2]), Int32.Parse(data[3]), Int32.Parse(data[4]), Int32.Parse(data[5]), data[6],data[7]);
                surveys.Add(survey);     
            }
        }

        public List<string> SurveysToString()
        {
            List<string> lines = new List<string>();
            foreach (Survey survey in surveys)
                lines.Add(survey.FormatToString());
            return lines;
        }

        public void AddSurvey(Survey survey) {
            surveys.Add(survey);
            fileWriter.AddToFile(survey.FormatToString());
        }

        public int GetNewId() {
                int lastId = surveys.Last().id;
                return lastId + 1;
        }
    }

}
