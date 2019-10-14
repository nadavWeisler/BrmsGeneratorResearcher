using System.Collections.Generic;
using PopUp_Researcher.Helpers;

namespace PopUp_Researcher.Models
{
    public class Brms: Trial
    {
        public Dictionary<string, List<string>> StimulusDictionary;

        public string name;
        public string stimulusFolder;
        public string stimulus;
        public string block;
        public string brms_type;
        public string orientation;
        public string file;
        public string performance_message;
        public string stop_trial_message;
        public string break_message;

        public decimal trial_length;
        public decimal fade_in_time;
        public decimal fade_out_time;
        public decimal timing_post_trial;
        public decimal fade_out_length;
        public decimal visUnit;
        public decimal within_ITI;
        public decimal repetitions;
        public decimal max_type;
        public decimal timing_response;
        public decimal mondrian_count;
        public decimal break_time;
        public decimal experiment_length;
        public decimal rectangle_number;
        public decimal stimulus_opacity;
        public decimal stimulus_max_opacity;
        public decimal mondrian_max_opacity;
        public decimal trial_limit;
        public decimal allowed_to_repeat;
        
        
        public Brms()
        {
            this.type = "bRMS";
        }
    }
}
