using System.Collections.Generic;

namespace PopUp_Researcher.Helpers
{
    public abstract class Question
    {
        #region Properties

        /// <summary>
        /// Question prompt
        /// </summary>
        public string prompt = "";

        /// <summary>
        /// If question is required
        /// </summary>
        public bool required = true;

        #endregion

        #region Public Methods

        /// <summary>
        /// Get prompt
        /// </summary>
        /// <returns></returns>
        public string GetPrompt()
        {
            return this.prompt;
        }

        #endregion
    }

    public class TextQuestion: Question
    {
        #region Properties

        /// <summary>
        /// rows
        /// </summary>
        public decimal rows;

        /// <summary>
        /// Cols
        /// </summary>
        public decimal columns;

        /// <summary>
        /// Default value
        /// </summary>
        public string value;

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
            this.prompt = _prompt;
            this.rows = _rows;
            this.columns = _cols;
            this.value = _value;
            this.required = _required;
        }

        #endregion
    }

    public class ScaleQuestion : Question
    {
        #region Properties

        /// <summary>
        /// Labels
        /// </summary>
        public List<string> labels;

        /// <summary>
        /// Scale Question Basic Constructor
        /// </summary>
        /// <param name="_prompt"></param>
        /// <param name="_required"></param>
        /// <param name="_labels"></param>
        public ScaleQuestion(string _prompt, bool _required, List<string> _labels)
        {
            this.prompt = _prompt;
            this.required = _required;
            this.labels = _labels;
        }
        #endregion
    }

    public class MultiSelectQuestion: Question
    {
        #region Properties

        /// <summary>
        /// options
        /// </summary>
        public List<string> options;

        #endregion

        #region Contractors

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="_prompt"></param>
        /// <param name="_required"></param>
        /// <param name="_options"></param>
        public MultiSelectQuestion(string _prompt, bool _required, List<string> _options)
        {
            this.prompt = _prompt;
            this.required = _required;
            this.options = _options;
        }

        #endregion
    }
}
