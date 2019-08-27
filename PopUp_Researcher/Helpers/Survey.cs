using System.Collections.Generic;

namespace bRMS_Generator
{
    public abstract class Survey : Experiment
    {
        public List<Question> questions;

        /// <summary>
        /// 
        /// </summary>
        protected Survey()
        {
            this.type = "";
        }
    }

    public class TextSurvey: Survey
    {
        public TextSurvey(List<Question> _questions)
        {
            this.type = "survey-text";
            this.questions = _questions;
        }
    }

    public class MultiSurvey: Survey
    {
        public MultiSurvey(List<Question> _questions)
        {
            this.type = "survey-multi-choice";
            this.questions = _questions;
        }
    }

    public class ScaleSurvey : Survey
    {
        public ScaleSurvey(List<Question> _questions)
        {
            this.type = "survey-likert";
            this.questions = _questions;
        }
    }
}
