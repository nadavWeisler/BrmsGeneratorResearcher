using Newtonsoft.Json;
using PopUp_Researcher.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace bRMS_Generator
{
    public static class Utils
    {
        /// <summary>
        /// Load CSV File
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static List<List<string>> LoadCsvFile(string filePath)
        {
            var searchList = new List<List<string>>();
            using (var reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (!string.IsNullOrEmpty(line))
                    {
                        searchList.Add(line.Split(',').ToList());
                    }
                }
            }
            return searchList;
        }

        /// <summary>
        /// Get Questions list from TextQuestions/MultiScaleQuestion list
        /// </summary>
        /// <param name="textQ"></param>
        /// <param name="scaleQ"></param>
        /// <returns></returns>
        private static List<Question> GetListFromTextScale(List<TextQuestion> textQ=null,
            List<MultiScaleQuestion> scaleQ=null)
        {
            List<Question> ret = new List<Question>();
            if(textQ == null)
            {
                foreach(var item in scaleQ)
                {
                    ret.Add((Question)item);
                }
            }
            else
            {
                foreach (var item in textQ)
                {
                    ret.Add((Question)item);
                }
            }
            return ret;
        }

        /// <summary>
        /// Load survey questions from json string
        /// </summary>
        /// <param name="questionType"></param>
        /// <param name="jsonString"></param>
        /// <returns></returns>
        public static List<Question> GetQuestionsListFromJson(string questionType, string jsonString)
        {
            List<MultiScaleQuestion> scaleList = null;
            List<TextQuestion> textList = null;
            switch (questionType)
            {
                case "survey-text":
                    textList = JsonConvert.DeserializeObject<List<TextQuestion>>(jsonString);
                    break;
                case "survey-likert":
                case "survey-multi-choice":
                    scaleList = JsonConvert.DeserializeObject<List<MultiScaleQuestion>>(jsonString);
                    break;
            }
            return GetListFromTextScale(textList, scaleList);
        }

        /// <summary>
        /// Load instructions pages from json string
        /// </summary>
        /// <param name="jsonString"></param>
        /// <returns></returns>
        public static List<string> GetPagesFromJson(string jsonString)
        {
            return JsonConvert.DeserializeObject<List<string>>(jsonString);
        }

        /// <summary>
        /// Load Experiment CSV
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static Experiment LoadExperimentCsv(string filePath)
        {
            var json = File.ReadAllText(filePath);
            Experiment experimentJson = JsonConvert.DeserializeObject<Experiment>(json);
            experimentJson.UpdateTrialsByTimeline();
            return experimentJson;
        }

        #region ListView Methods

        /// <summary>
        /// Get Down One Item in List
        /// </summary>
        /// <param name="index"></param>
        public static List<T> DownOneItem<T>(List<T> lst, int index)
        {
            if (index >= 1 && index < lst.Count)
            {
                var tmp = lst[index];
                lst[index] = lst[index - 1];
                lst[index - 1] = tmp;      
            }
            return lst;
        }

        /// <summary>
        /// Get Up One Item in List
        /// </summary>
        /// <param name="index"></param>
        public static List<T> UpOneItem<T>(List<T> lst, int index)
        {
            if (index >= 0 && index < lst.Count - 1)
            {
                var tmp = lst[index];
                lst[index] = lst[index + 1];
                lst[index + 1] = tmp; 
            }
            return lst;
        }

        /// <summary>
        /// Remove item in given index from pages
        /// </summary>
        /// <param name="index"></param>
        public static List<T> RemoveItemByIndex<T>(List<T> lst, int index)
        {
            if (index >= 0 && index < lst.Count)
            {
                lst.RemoveAt(index);
            }
            return lst;
        }

        #endregion
    }
}