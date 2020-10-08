namespace BrmsGeneratorResearcher.Helpers
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

        /// <summary>
        /// Image blob
        /// </summary>
        public string ImageBlob;

        #endregion

        #region Constructors

        /// <summary>
        /// Class Constructor
        /// </summary>
        /// <param name="_prompt"></param>
        /// <param name="_stimulus"></param>
        public ImageKeyboard(string _prompt, string _stimulus)
        {
            this.type = ExperimentTypes.ImageButton;
            this.choices = new[] {32};
            this.prompt = _prompt;
            this.stimulus = _stimulus;
        }

        #endregion
    }
}
