using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace bRMS_Generator.src
{
    public class bRMS: Experiment
    {
        public string name;

        [BsonElement("stimulusFolder")]
        public string StimulusFolder;
        [BsonElement("visualUnit")]
        public decimal VisualUnit;
        [BsonElement("stimulus")]
        public string Stimulus;
        [BsonElement("block")]
        public string Block;
        [BsonElement("file")]
        public string File;
        [BsonElement("trial_length")]
        public decimal TrialLength;
        [BsonElement("fade_in_time")]
        public decimal FadeInTime;
        [BsonElement("fade_out_time")]
        public decimal FadeOutTime;
        [BsonElement("timing_post_trial")]
        public decimal TimingPostTrial;
        [BsonElement("fade_out_length")]
        public decimal FadeOutLength;
        [BsonElement("train_alpha")]
        public decimal TrainAlpha;
        [BsonElement("visUnit")]
        public decimal VisUnit;
        [BsonElement("within_ITI")]
        public decimal WithinIti;
        [BsonElement("orientation")]
        public string Orientation;
        [BsonElement("repetitions")]
        public decimal Repetitions;
        [BsonElement("max_type ")]
        public decimal MaxType;
        [BsonElement("timing_response")]
        public decimal TimingResponse;
        [BsonElement("mondrian_count")]
        public decimal MondrianCount;
        [BsonElement("break_time")]
        public decimal BreakTime;
        [BsonElement("experiment_length")]
        public decimal ExperimentLength;
        [BsonElement("rectengle_number")]
        public decimal RectengleNumber;
        [BsonElement("stimulus_max_opacity")]
        public decimal StimulusMaxOpacity;
        [BsonElement("mondrian_max_opacity")]
        public decimal MondrianMaxOpacity;
        [BsonElement("trial_limit")]
        public decimal TrialLimit;
        [BsonElement("brms_type")]
        public string BrmsType;
    }
}
