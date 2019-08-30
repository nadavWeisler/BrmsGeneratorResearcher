using System;
using System.Collections.Generic;

namespace bRMS_Generator
{
    public class Instructions : Experiment
    {
        /// <summary>
        /// Pages Property
        /// </summary>
        public List<string> pages;

        /// <summary>
        /// Constractors
        /// </summary>
        public Instructions()
        {
            this.type = "instructions";
            this.pages = new List<string>();
        }

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
        /// 
        /// </summary>
        /// <param name="page"></param>
        public void AddPage(string page)
        {
            this.pages.Add(page);
        }
    }

}
