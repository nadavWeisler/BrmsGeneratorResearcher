using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace bRMS_Generator
{
    public static class Utils
    {
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
        /// 
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
        /// 
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
    }
}