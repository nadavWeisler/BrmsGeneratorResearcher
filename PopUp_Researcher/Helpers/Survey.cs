using System.Collections.Generic;

namespace PopUp_Researcher.Helpers
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
        /// Constructor
        /// </summary>
        /// <param name="_questions"></param>
        public TextSurvey(List<Question> _questions)
        {
            this.type = ExperimentTypes.TextSurvey;
            this.questions = _questions;
        }

        #endregion
    }

    public class MultiSurvey: Survey
    {
        #region Constractor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="_questions"></param>
        public MultiSurvey(List<Question> _questions)
        {
            this.type = ExperimentTypes.MultiChoiceSurvey;
            this.questions = _questions;
        }

        #endregion
    }

    public class ScaleSurvey : Survey
    {
        #region Constractors

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="_questions"></param>
        public ScaleSurvey(List<Question> _questions)
        {
            this.type = ExperimentTypes.ScaleSurvey;
            this.questions = _questions;
        }

        #endregion
    }
}
