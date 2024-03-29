﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BrmsGeneratorResearcher.Models;
using Newtonsoft.Json;

namespace BrmsGeneratorResearcher.Helpers
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
            try
            {
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
            }
            catch
            {
                MessageBox.Show("Close file");
            }
            
            return searchList;
        }

        /// <summary>
        /// Get Questions list from TextQuestions/MultiSelectQuestion list
        /// </summary>
        /// <param name="textQ"></param>
        /// <param name="scaleQ"></param>
        /// <returns></returns>
        private static List<Question> GetListFromTextScale(IReadOnlyCollection<TextQuestion> textQ=null,
            IEnumerable<MultiSelectQuestion> scaleQ=null)
        {
            var ret = new List<Question>();
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
            List<MultiSelectQuestion> scaleList = null;
            List<TextQuestion> textList = null;
            switch (questionType)
            {
                case "survey-text":
                    textList = JsonConvert.DeserializeObject<List<TextQuestion>>(jsonString);
                    break;
                case "survey-likert":
                case "survey-multi-choice":
                    scaleList = JsonConvert.DeserializeObject<List<MultiSelectQuestion>>(jsonString);
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
        /// Validate RGB string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool ValidateRgb(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return false;
            }
            else if (!str.StartsWith("#"))
            {
                return false;
            }
            else if (str.Length < 7)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        /// <summary>
        /// Load Experiment CSV
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static Experiment LoadExperimentJson(string filePath)
        {
            var json = File.ReadAllText(filePath);
            var experimentJson = JsonConvert.DeserializeObject<Experiment>(json);
            experimentJson.UpdateTrialsByTimeline();
            return experimentJson;
        }
        
        /// <summary>
        /// Change \n to <br> tag
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string AddHtmlBreakLines(string text)
        {
            return text.Replace("\n", "<br>");
        }


        #region ListView Methods

        public static List<string> GetItemsListFromListView(ListView listView, bool _onlySelected=false)
        {
            var ret = new List<string>();
            if (_onlySelected)
            {
                foreach (ListViewItem item in listView.SelectedItems)
                {
                    ret.Add(item.Text);
                }
            }
            else
            {
                foreach (ListViewItem item in listView.Items)
                {
                    ret.Add(item.Text);
                }
            }

            return ret;
        }


        /// <summary>
        /// Get Down One Item in List
        /// </summary>
        /// <param name="lst"></param>
        /// <param name="index"></param>
        public static List<T> DownOneItem<T>(List<T> lst, int index)
        {
            if (index < 1 || index >= lst.Count) return lst;
            var tmp = lst[index];
            lst[index] = lst[index - 1];
            lst[index - 1] = tmp;
            return lst;
        }

        /// <summary>
        /// Get Up One Item in List
        /// </summary>
        /// <param name="lst"></param>
        /// <param name="index"></param>
        public static List<T> UpOneItem<T>(List<T> lst, int index)
        {
            if (index < 0 || index >= lst.Count - 1) return lst;
            var tmp = lst[index];
            lst[index] = lst[index + 1];
            lst[index + 1] = tmp;
            return lst;
        }

        /// <summary>
        /// Remove item in given index from pages
        /// </summary>
        /// <param name="lst"></param>
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

    public class ExperimentTypes
    {
        public const string bRMS = "bRMS";
        public const  string Survey = "survey";
        public const  string Instructions = "instructions";
        public const string ImageKeyboard = "image-keyboard-response";
        public const string ImageButton = "image-button-response";
        public const string Fullscreen = "fullscreen";
        public const string TextSurvey = "survey-text";
        public const string ScaleSurvey = "survey-likert";
        public const string MultiChoiceSurvey = "survey-multi-choice";
        public const string ConjunctiveCPT = "conjunctive-cpt";
    }

    public class Shapes
    {
        public const string Squere = "squere";
        public const string Circle = "circle";
        public const string UpTriangle = "triangle";
        public const string DownTriangle = "down_Triangle";
    }

}