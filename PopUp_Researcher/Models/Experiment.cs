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

        #region Methods

        private Brms getBrmsFromDic(Dictionary<string, object> dic)
        {
            return new Brms()
            {
                name = dic["name"].ToString(),
                brms_type = dic["brms_type"].ToString(),

                block = decimal.Parse(dic["block"].ToString()),
                sub_block = decimal.Parse(dic["sub_block"].ToString()),
                rectangle_height = decimal.Parse(dic["rectangle_height"].ToString()),
                rectangle_width = decimal.Parse(dic["rectangle_width"].ToString()),
                stimulus_duration = decimal.Parse(dic["stimulus_duration"].ToString()),
                stimulus_height = decimal.Parse(dic["stimulus_height"].ToString()),
                stimulus_width = decimal.Parse(dic["stimulus_width"].ToString()),
                frame_height = decimal.Parse(dic["frame_height"].ToString()),
                frame_width = decimal.Parse(dic["frame_width"].ToString()),
                fixation_height = decimal.Parse(dic["fixation_height"].ToString()),
                fixation_width = decimal.Parse(dic["fixation_width"].ToString()),
                gap_duration = decimal.Parse(dic["gap_duration"].ToString()),
                mask_duration = decimal.Parse(dic["mask_duration"].ToString()),
                mondrian_max_opacity = decimal.Parse(dic["mondrian_max_opacity"].ToString()),
                stimulus_opacity = decimal.Parse(dic["stimulus_opacity"].ToString()),
                rectangle_number = decimal.Parse(dic["rectangle_number"].ToString()),
                mondrian_count = decimal.Parse(dic["mondrian_count"].ToString()),
                timing_response = decimal.Parse(dic["timing_response"].ToString()),
                post_trial_gap = decimal.Parse(dic["post_trial_gap"].ToString()),
                fade_out_time = decimal.Parse(dic["fade_out_time"].ToString()),
                fade_in_time = decimal.Parse(dic["fade_in_time"].ToString()),

            };
        }
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
                            sub_block = decimal.Parse(item["sub_block"].ToString()),
                            
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
