using System.Collections.Generic;

namespace bRMS_Generator
{
    public abstract class Question
    {
        #region Properties

        /// <summary>
        /// Question Prompt
        /// </summary>
        public string prompt = "";

        /// <summary>
        /// If question is required
        /// </summary>
        public bool required = true;

        #endregion

        #region Public Methods

        /// <summary>
        /// Get Prompt
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
        /// Rows
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
        /// Constractor
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

    public class MultiScaleQuestion: Question
    {
        #region Properties

        /// <summary>
        /// Options
        /// </summary>
        public List<string> options;

        #endregion

        #region Contractors

        /// <summary>
        /// Constractor
        /// </summary>
        /// <param name="_prompt"></param>
        /// <param name="_required"></param>
        /// <param name="_options"></param>
        public MultiScaleQuestion(string _prompt, bool _required, List<string> _options)
        {
            this.prompt = _prompt;
            this.required = _required;
            this.options = _options;
        }

        #endregion
    }
}
