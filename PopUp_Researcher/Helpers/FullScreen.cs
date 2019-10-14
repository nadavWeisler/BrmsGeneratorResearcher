using bRMS_Generator;

namespace PopUp_Researcher.Helpers
{
    public class FullScreen: Trial
    {
        #region Properties

        /// <summary>
        /// Fullscreen Mode
        /// </summary>
        public bool FullscreenMode;

        /// <summary>
        /// Fullscreen Display Message
        /// </summary>
        public string Message;

        #endregion

        #region Constractors

        /// <summary>
        /// Basic Constructors
        /// </summary>
        /// <param name="_message"></param>
        public FullScreen(string _message)
        {
            this.type = "fullscreen";
            this.Message = _message;
            this.FullscreenMode = true;
        }

        #endregion
    }
}
