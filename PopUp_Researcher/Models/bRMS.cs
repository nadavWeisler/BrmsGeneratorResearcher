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
        public string stimulus_block;
        public string brms_type;
        public string orientation;
        public string file;
        public string performance_message;
        public string stop_trial_message;
        public string break_message;

        public decimal fade_in_time;
        public decimal fade_out_time;
        public decimal post_trial_gap;
        public decimal stimulus_delay;
        public decimal repetitions;
        public decimal max_type;
        public decimal timing_response;
        public decimal mondrian_count;
        public decimal break_time;
        public decimal rectangle_number;
        public decimal stimulus_opacity;
        public decimal mondrian_max_opacity;
        public decimal allowed_to_repeat;
        public decimal fixation_width;
        public decimal fixation_height;
        public decimal frame_width;
        public decimal frame_height;
        public decimal stimulus_width;
        public decimal stimulus_height;
        public decimal rectangle_width;
        public decimal rectangle_height;



        public Brms()
        {
            this.type = "bRMS";
        }
    }
}
