using System.Collections.Generic;
using bRMS_Generator;

namespace PopUp_Researcher.Helpers
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
            this.type = "instructions";
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

        /// <summary>
        /// Set pages
        /// </summary>
        /// <param name="lst"></param>
        public void SetPages(List<string> lst)
        {
            this.pages = lst;
        }

        /// <summary>
        /// Add new page to instructions pages
        /// </summary>
        /// <param name="page"></param>
        public void AddPage(string page)
        {
            this.pages.Add(page);
        }

        #endregion
    }

}
