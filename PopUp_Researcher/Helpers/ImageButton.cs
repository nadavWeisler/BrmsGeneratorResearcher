using BrmsGeneratorResearcher.Resources;

namespace BrmsGeneratorResearcher.Helpers
{
    public class ImageButton: Trial
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
        public string[] choices;

        #endregion

        #region Constructors

        /// <summary>
        /// Class Constructor
        /// </summary>
        /// <param name="_stimulus"></param>
        public ImageButton(string _stimulus)
        {
            this.type = ExperimentTypes.ImageButton;
            this.choices = new[] {BasicResources.ImageButtonText};
            this.stimulus = _stimulus;
        }

        #endregion
    }
}
