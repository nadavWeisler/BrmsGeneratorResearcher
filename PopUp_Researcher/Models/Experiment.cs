using bRMS_Generator;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PopUp_Researcher.Helpers;

namespace PopUp_Researcher.Models
{
    public class Experiment
    {
        #region Properties

        public string Name { get; set; }

        public List<Dictionary<string, object>> Timeline { get; set; }

        public List<Trial> Trials;

        #endregion

        #region Public Methods

        public void UpdateTrialsByTimeline()
        {
            this.Trials = new List<Trial>();
            string questionsJson = null;
            List<Question> qList = null;
            Survey newSurvey;
            foreach (var item in this.Timeline)
            {
                newSurvey = null;
                switch(item["type"])
                {
                    case "bRMS":
                        Brms newBRMS = new Brms()
                        {
                            group = decimal.Parse(item["group"].ToString()),
                            sub_group = decimal.Parse(item["sub_group"].ToString())
                        };
                        break;
                    case "survey-text":
                        questionsJson = item["questions"].ToString();
                        qList = Utils.GetQuestionsListFromJson("survey-text", questionsJson);
                        newSurvey = new TextSurvey(qList)
                        {
                            group = decimal.Parse(item["group"].ToString()),
                            sub_group = decimal.Parse(item["sub_group"].ToString())
                        };
                        break;
                    case "survey-likert":
                        questionsJson = File.ReadAllText((string)item["questions"]);
                        qList = Utils.GetQuestionsListFromJson("survey-likert", questionsJson);
                        newSurvey = new ScaleSurvey(qList)
                        {
                            group = decimal.Parse(item["group"].ToString()),
                            sub_group = decimal.Parse(item["sub_group"].ToString())
                        };
                        break;
                    case "survey-multi-choice":
                        questionsJson = File.ReadAllText((string)item["questions"]);
                        qList = Utils.GetQuestionsListFromJson("survey-multi-choice", questionsJson);
                        newSurvey = new MultiSurvey(qList)
                        {
                            group = decimal.Parse(item["group"].ToString()),
                            sub_group = decimal.Parse(item["sub_group"].ToString())
                        };
                        break;
                    case "fullscreen":
                        var newFullscreen = new FullScreen((string)item["Message"])
                        {
                            group = decimal.Parse(item["group"].ToString()),
                            sub_group = decimal.Parse(item["sub_group"].ToString())
                        };
                        this.Trials.Add(newFullscreen);
                        break;
                    case "instructions":
                        var newIntro = new Instructions
                        {
                            pages = Utils.GetPagesFromJson(item["pages"].ToString()),
                            group = decimal.Parse(item["group"].ToString()),
                            sub_group = decimal.Parse(item["sub_group"].ToString())
                        };
                        this.Trials.Add(newIntro);
                        break;
                }
                if(newSurvey != null)
                {
                    this.Trials.Add(newSurvey);
                }
            }
        }

        #endregion
    }
}
