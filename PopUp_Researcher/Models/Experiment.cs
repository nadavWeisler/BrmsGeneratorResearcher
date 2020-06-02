using System.Collections.Generic;
using System.IO;
using PopUp_Researcher.Helpers;

namespace PopUp_Researcher.Models
{
    public class Experiment
    {
        #region Properties

        public string name { get; set; }

        public int count = 0;

        public string background_color;

        public List<Dictionary<string, object>> timeline { get; set; }

        public List<Trial> trialList;

        #endregion

        #region Constructors

        public Experiment(string _name, string _background, List<Trial> trialList)
        {
            this.name = _name;
            this.background_color = _background;
            this.trialList = trialList;
        }

        #endregion

        #region Public Methods

        public void UpdateTrialsByTimeline()
        {
            this.trialList = new List<Trial>();
            foreach (var item in this.timeline)
            {
                Survey newSurvey = null;
                string questionsJson;
                List<Question> qList;
                switch (item["type"])
                {
                    case "bRMS":
                        var newBrms = new Brms()
                        {
                            name = item["name"].ToString(),
                            block = decimal.Parse(item["block"].ToString()),
                            sub_block = decimal.Parse(item["sub_block"].ToString())
                        };
                        this.trialList.Add(newBrms);
                        break;
                    case "survey-text":
                        qList = Utils.GetQuestionsListFromJson(
                            "survey-text",
                            item["questions"].ToString());
                        newSurvey = new TextSurvey(qList)
                        {
                            name = item["name"].ToString(),
                            block = decimal.Parse(item["block"].ToString()),
                            sub_block = decimal.Parse(item["sub_block"].ToString())
                        };
                        break;
                    case "survey-likert":
                        qList = Utils.GetQuestionsListFromJson(
                            "survey-likert",
                            item["questions"].ToString());
                        newSurvey = new ScaleSurvey(qList)
                        {
                            name = item["name"].ToString(),
                            block = decimal.Parse(item["block"].ToString()),
                            sub_block = decimal.Parse(item["sub_block"].ToString())
                        };
                        break;
                    case "survey-multi-choice":
                        qList = Utils.GetQuestionsListFromJson(
                            "survey-multi-choice",
                            item["questions"].ToString());
                        newSurvey = new MultiSurvey(qList)
                        {
                            name = item["name"].ToString(),
                            block = decimal.Parse(item["block"].ToString()),
                            sub_block = decimal.Parse(item["sub_block"].ToString())
                        };
                        break;
                    case "fullscreen":
                        var newFullscreen = new FullScreen((string)item["message"])
                        {
                            name = item["name"].ToString(),
                            block = decimal.Parse(item["block"].ToString()),
                            sub_block = decimal.Parse(item["sub_block"].ToString())
                        };
                        this.trialList.Add(newFullscreen);
                        break;
                    case "instructions":
                        var newIntro = new Instructions
                        {
                            name = item["name"].ToString(),
                            pages = Utils.GetPagesFromJson(item["pages"].ToString()),
                            block = decimal.Parse(item["block"].ToString()),
                            sub_block = decimal.Parse(item["sub_block"].ToString())
                        };
                        this.trialList.Add(newIntro);
                        break;
                }
                if(newSurvey != null)
                {
                    this.trialList.Add(newSurvey);
                }
            }
        }

        #endregion
    }
}
