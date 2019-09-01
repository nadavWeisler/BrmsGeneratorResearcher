using System.Collections.Generic;
using System.Linq;
using bRMS_Generator.src;

namespace bRMS_Generator
{
    public class BRmsHelper
    {
        #region Properties

        /// <summary>
        /// bRMS Object
        /// </summary>
        protected BRMS Obj;

        /// <summary>
        /// Stimulus Dictionary
        /// </summary>
        protected Dictionary<string, List<string>> StimulusDictionary;

        #endregion

        #region Constractors

        /// <summary>
        /// Basic Constractor
        /// </summary>
        public BRmsHelper()
        {
            this.Obj = new BRMS();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Update stimulues from instructions CSV
        /// </summary>
        /// <param name="fileName"></param>
        public void UpdateStimulusFromCsv(string fileName)
        {
            var csvContent = Utils.LoadCsvFile(fileName);
            var resultDictionary = new Dictionary<string, List<string>>();
            foreach (var csvLine in csvContent)
            {
                for (var i = 1; i < csvLine.Count; i++)
                {
                    if (!resultDictionary.ContainsKey(csvLine[i]))
                    {
                        resultDictionary[csvLine[i]] = new List<string>();
                    }
                    resultDictionary[csvLine[i]].Add(csvLine[0]);
                }
            }

            this.StimulusDictionary = resultDictionary;
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
        /// Get Tag List From STimulus Dictionary
        /// </summary>
        /// <returns></returns>
        public List<string> GetTagList()
        {
            return this.StimulusDictionary.Keys.ToList();
        }

        #endregion
    }
}