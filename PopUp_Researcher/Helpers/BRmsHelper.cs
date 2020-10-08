using System.Collections.Generic;
using System.Linq;
using BrmsGeneratorResearcher.Models;

namespace BrmsGeneratorResearcher.Helpers
{
    public class BRmsHelper
    {
        #region Properties

        /// <summary>
        /// bRMS Object
        /// </summary>
        protected Brms Obj;

        /// <summary>
        /// Stimulus Dictionary
        /// </summary>
        protected Dictionary<string, List<string>> StimulusDictionary;

        #endregion

        #region Constractors

        /// <summary>
        /// Basic Constructor
        /// </summary>
        public BRmsHelper()
        {
            this.Obj = new Brms();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Update stimulus from instructions CSV
        /// </summary>
        /// <param name="fileName"></param>
        public bool UpdateStimulusFromCsv(string fileName)
        {
            var csvContent = Utils.LoadCsvFile(fileName);
            if (csvContent.Count == 0) return false;

            var resultDictionary = new Dictionary<string, List<string>>();
            foreach (var csvLine in csvContent)
            {
                for (var i = 1; i < csvLine.Count; i++)
                {
                    if (csvLine[i] == string.Empty)
                    {
                        continue;
                    }

                    if (!resultDictionary.ContainsKey(csvLine[i]))
                    {
                        resultDictionary[csvLine[i]] = new List<string>();
                    }
                    
                    resultDictionary[csvLine[i]].Add(csvLine[0]);
                }
            }

            this.StimulusDictionary = resultDictionary;
            return true;
        }

        /// <summary>
        /// Get Stimulus List by tag list
        /// </summary>
        /// <param name="tagsList"></param>
        /// <returns></returns>
        public List<string> GetStimulusByTags(List<string> tagsList)
        {
            var resultList = new List<string>();
            foreach (var tag in tagsList)
            {
                if (this.StimulusDictionary != null && this.StimulusDictionary.ContainsKey(tag))
                {
                    resultList.AddRange(this.StimulusDictionary[tag]);
                }
            }

            return resultList;
        }

        /// <summary>
        /// Get Stimulus list by one Tag
        /// </summary>
        /// <param name="tag"></param>
        /// <returns></returns>
        public List<string> GetStimulusByOneTag(string tag)
        {
            var resultList = new List<string>();
            if (this.StimulusDictionary != null && this.StimulusDictionary.ContainsKey(tag))
            {
                resultList.AddRange(this.StimulusDictionary[tag]);
            }
            return resultList;
        }

        /// <summary>
        /// Get Tag List From Stimulus Dictionary
        /// </summary>
        /// <returns></returns>
        public List<string> GetTagList()
        {
            return this.StimulusDictionary.Keys.ToList();
        }

        #endregion
    }
}