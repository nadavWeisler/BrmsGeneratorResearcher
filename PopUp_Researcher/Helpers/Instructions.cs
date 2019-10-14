using System.Collections.Generic;
using bRMS_Generator;

namespace PopUp_Researcher.Helpers
{
    public class Instructions : Trial
    {
        #region Properties

        /// <summary>
        /// Pages Property
        /// </summary>
        public List<string> Pages;

        /// <summary>
        /// Show click-able navigation 
        /// </summary>
        public bool ShowClickAbleNav;

        #endregion

        #region Contractors

        /// <summary>
        /// Constructors
        /// </summary>
        public Instructions()
        {
            this.type = "instructions";
            this.Pages = new List<string>();
            this.ShowClickAbleNav = true;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Get Pages
        /// </summary>
        /// <returns></returns>
        public List<string> GetPages()
        {
            return this.Pages;
        }

        /// <summary>
        /// Set Pages
        /// </summary>
        /// <param name="lst"></param>
        public void SetPages(List<string> lst)
        {
            this.Pages = lst;
        }

        /// <summary>
        /// Add new page to instructions pages
        /// </summary>
        /// <param name="page"></param>
        public void AddPage(string page)
        {
            this.Pages.Add(page);
        }

        #endregion
    }

}
