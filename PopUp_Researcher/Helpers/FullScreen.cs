namespace bRMS_Generator
{
    public class FullScreen: Trial
    {
        #region Properties

        /// <summary>
        /// Fullscreen Mode
        /// </summary>
        public bool fullscreen_mode = true;

        /// <summary>
        /// Fullscreen Display Message
        /// </summary>
        public string message;

        #endregion

        #region Constractors

        /// <summary>
        /// Basic Constractors
        /// </summary>
        /// <param name="_message"></param>
        public FullScreen(string _message)
        {
            this.type = "fullscreen";
            this.message = _message;
        }

        #endregion
    }
}
