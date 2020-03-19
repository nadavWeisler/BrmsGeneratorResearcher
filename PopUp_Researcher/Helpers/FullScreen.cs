using bRMS_Generator;

namespace PopUp_Researcher.Helpers
{
    public class FullScreen: Trial
    {
        #region Properties

        /// <summary>
        /// Fullscreen Mode
        /// </summary>
        public bool fullscreenMode;

        /// <summary>
        /// Fullscreen Display Message
        /// </summary>
        public string message;

        #endregion

        #region Constractors

        /// <summary>
        /// Basic Constructors
        /// </summary>
        /// <param name="_message"></param>
        public FullScreen(string _message)
        {
            this.type = ExperimentTypes.Fullscreen;
            this.message = _message;
            this.fullscreenMode = true;
        }

        #endregion
    }
}
