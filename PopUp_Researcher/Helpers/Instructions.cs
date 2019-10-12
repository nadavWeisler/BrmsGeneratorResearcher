using System;
using System.Collections.Generic;

namespace bRMS_Generator
{
    public class Instructions : Trial
    {
        #region Properties

        /// <summary>
        /// Pages Property
        /// </summary>
        public List<string> pages;

        /// <summary>
        /// Show clickable navigation 
        /// </summary>
        public bool show_clickable_nav = true;

        #endregion

        #region Contractors

        /// <summary>
        /// Constractors
        /// </summary>
        public Instructions()
        {
            this.type = "instructions";
            this.pages = new List<string>();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Get Pages
        /// </summary>
        /// <returns></returns>
        public List<string> GetPages()
        {
            return this.pages;
        }

        /// <summary>
        /// Set Pages
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
