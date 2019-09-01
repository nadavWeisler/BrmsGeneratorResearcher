using System.Collections.Generic;

namespace bRMS_Generator
{
    public abstract class Survey : Trial
    {
        #region Properties

        /// <summary>
        /// Questions List
        /// </summary>
        public List<Question> questions;

        #endregion
    }

    public class TextSurvey: Survey
    {
        #region Constractor

        /// <summary>
        /// Constractor
        /// </summary>
        /// <param name="_questions"></param>
        public TextSurvey(List<Question> _questions)
        {
            this.type = "survey-text";
            this.questions = _questions;
        }

        #endregion
    }

    public class MultiSurvey: Survey
    {
        #region Constractor

        /// <summary>
        /// Constractor
        /// </summary>
        /// <param name="_questions"></param>
        public MultiSurvey(List<Question> _questions)
        {
            this.type = "survey-multi-choice";
            this.questions = _questions;
        }

        #endregion
    }

    public class ScaleSurvey : Survey
    {
        #region Constractors

        /// <summary>
        /// Constractor
        /// </summary>
        /// <param name="_questions"></param>
        public ScaleSurvey(List<Question> _questions)
        {
            this.type = "survey-likert";
            this.questions = _questions;
        }

        #endregion
    }
}
