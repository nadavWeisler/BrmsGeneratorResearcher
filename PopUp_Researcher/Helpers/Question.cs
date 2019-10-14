using System.Collections.Generic;

namespace PopUp_Researcher.Helpers
{
    public abstract class Question
    {
        #region Properties

        /// <summary>
        /// Question Prompt
        /// </summary>
        public string Prompt = "";

        /// <summary>
        /// If question is required
        /// </summary>
        public bool Required = true;

        #endregion

        #region Public Methods

        /// <summary>
        /// Get Prompt
        /// </summary>
        /// <returns></returns>
        public string GetPrompt()
        {
            return this.Prompt;
        }

        #endregion
    }

    public class TextQuestion: Question
    {
        #region Properties

        /// <summary>
        /// Rows
        /// </summary>
        public decimal Rows;

        /// <summary>
        /// Cols
        /// </summary>
        public decimal Columns;

        /// <summary>
        /// Default value
        /// </summary>
        public string Value;

        #endregion

        #region Constractors

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="_prompt"></param>
        /// <param name="_rows"></param>
        /// <param name="_cols"></param>
        /// <param name="_value"></param>
        /// <param name="_required"></param>
        public TextQuestion(string _prompt, decimal _rows, decimal _cols, string _value, bool _required)
        {
            this.Prompt = _prompt;
            this.Rows = _rows;
            this.Columns = _cols;
            this.Value = _value;
            this.Required = _required;
        }

        #endregion
    }

    public class MultiScaleQuestion: Question
    {
        #region Properties

        /// <summary>
        /// Options
        /// </summary>
        public List<string> Options;

        #endregion

        #region Contractors

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="_prompt"></param>
        /// <param name="_required"></param>
        /// <param name="_options"></param>
        public MultiScaleQuestion(string _prompt, bool _required, List<string> _options)
        {
            this.Prompt = _prompt;
            this.Required = _required;
            this.Options = _options;
        }

        #endregion
    }
}
