using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace bRMS_Generator.src
{
    public class bRMS: Experiment
    {
        [BsonElement("stimulusFolder")]
        protected string StimulusFolder;
        [BsonElement("visualUnit")]
        protected int VisualUnit;
        [BsonElement("stimulus")]
        protected string Stimulus;
        [BsonElement("block")]
        protected string Block;
        [BsonElement("file")]
        protected string File;
        [BsonElement("trial_length")]
        protected int TrialLength;
        [BsonElement("fade_in_time")]
        protected int FadeInTime;
        [BsonElement("fade_out_time")]
        protected int FadeOutTime;
        [BsonElement("timing_post_trial")]
        protected int TimingPostTrial;
        [BsonElement("fade_out_length")]
        protected int FadeOutLength;
        [BsonElement("train_alpha")]
        protected int TrainAlpha;
        [BsonElement("visUnit")]
        protected int VisUnit;
        [BsonElement("within_ITI")]
        protected int WithinIti;
        [BsonElement("orientation")]
        protected char Orientation;
    }
}
