using System.Collections.Generic;

namespace bRMS_Generator
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Question
    {
        /// <summary>
        /// 
        /// </summary>
        public string prompt = "";

        /// <summary>
        /// 
        /// </summary>
        public bool required = true;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetPrompt()
        {
            return this.prompt;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class TextQuestion: Question
    {
        public decimal rows;
        public decimal cols;
        public string value;

        public TextQuestion(string _prompt, decimal _rows, decimal _cols, string _value, bool _required)
        {
            this.prompt = _prompt;
            this.rows = _rows;
            this.cols = _cols;
            this.value = _value;
            this.required = _required;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class MultiScaleQuestion: Question
    {
        public List<string> options;

        public MultiScaleQuestion(string _prompt, bool _required, List<string> _options)
        {
            this.prompt = _prompt;
            this.required = _required;
            this.options = _options;
        }
    }
}
