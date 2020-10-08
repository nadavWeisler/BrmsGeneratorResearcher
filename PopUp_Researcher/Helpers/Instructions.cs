using System.Collections.Generic;

namespace BrmsGeneratorResearcher.Helpers
{
    public class Instructions : Trial
    {
        #region Properties

        /// <summary>
        /// pages Property
        /// </summary>
        public List<string> pages;

        /// <summary>
        /// Show click-able navigation 
        /// </summary>
        public bool show_clickable_nav;

        #endregion

        #region Contractors

        /// <summary>
        /// Constructors
        /// </summary>
        public Instructions()
        {
            this.type = ExperimentTypes.Instructions;
            this.pages = new List<string>();
            this.show_clickable_nav = true;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Get pages
        /// </summary>
        /// <returns></returns>
        public List<string> GetPages()
        {
            return this.pages;
        }

        #endregion
    }

}
