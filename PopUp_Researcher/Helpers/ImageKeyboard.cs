using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopUp_Researcher.Helpers
{
    public class ImageKeyboard: Trial
    {
        #region Properties

        /// <summary>
        /// stimulus (image) src
        /// </summary>
        public string stimulus;

        /// <summary>
        /// Trial prompt
        /// </summary>
        public string prompt;

        /// <summary>
        /// Keyboard choice
        /// </summary>
        public int[] choices;

        #endregion

        #region Constructors

        /// <summary>
        /// Class Constructor
        /// </summary>
        /// <param name="_prompt"></param>
        /// <param name="_stimulus"></param>
        public ImageKeyboard(string _prompt, string _stimulus)
        {
            this.type = "image-keyboard-response";
            this.choices = new int[] {32};
            this.prompt = _prompt;
            this.stimulus = _stimulus;
        }

        #endregion
    }
}
