namespace bRMS_Generator
{
    /// <summary>
    /// 
    /// </summary>
    public class FullScreen: Experiment
    {
        /// <summary>
        /// 
        /// </summary>
        public bool fullscreen_mode = true;

        /// <summary>
        /// 
        /// </summary>
        public string message;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_message"></param>
        public FullScreen(string _message)
        {
            this.type = "fullscreen";
            this.message = _message;
        }
    }
}
