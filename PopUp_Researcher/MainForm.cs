using System;
using System.Collections.Generic;
using System.Windows.Forms;
using bRMS_Generator.src;
using Newtonsoft.Json;

namespace bRMS_Generator
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public static Dictionary<string, Experiment> Experiments;

        /// <summary>
        /// 
        /// </summary>
        private static List<string> experiments_order;

        /// <summary>
        /// 
        /// </summary>
        private static int fullscreenCount;


        /// <summary>
        /// 
        /// </summary>
        private static int introCount;

        /// <summary>
        /// 
        /// </summary>
        private static int surveyCount;

        /// <summary>
        /// 
        /// </summary>
        private static int bRMS_count;

        /// <summary>
        /// 
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            Experiments = new Dictionary<string, Experiment>();
            experiments_order = new List<string>();
            fullscreenCount = 0;
            introCount = 0;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IntroButton_Click(object sender, EventArgs e)
        {
            var intro = new IntroductionForm();
            intro.ShowDialog();
            BindListView();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BRms_button_Click(object sender, EventArgs e)
        {
            var bRms = new BrmsForm();
            bRms.ShowDialog();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SurveyButton_Click(object sender, EventArgs e)
        {
            var sForm = new SurveyForm();
            sForm.ShowDialog();
            BindListView();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FullscreenButton_Click(object sender, EventArgs e)
        {
            var newForm = new FullscreenForm();
            newForm.ShowDialog();
            BindListView();
        }

        /// <summary>
        /// Bind ListView by experiment list
        /// </summary>
        private void BindListView()
        {
            listView1.Clear();
            foreach (var item in experiments_order)
            {
                listView1.Items.Add(item);
            }
        }

        /// <summary>
        /// Add fullscreen experiment in to experiments list
        /// </summary>
        /// <param name="obj"></param>
        public static void AddFullscreen(FullScreen obj)
        {
            Experiments.Add("Fullscreen" + fullscreenCount, obj);
            experiments_order.Add("Fullscreen" + fullscreenCount);
            fullscreenCount++;
        }

        /// <summary>
        /// Add intro experiment in to experiments list
        /// </summary>
        /// <param name="obj"></param>
        public static void AddIntro(Introduction obj)
        {
            Experiments.Add("Introduction" + introCount, obj);
            experiments_order.Add("Introduction" + introCount);
            introCount++;
        }

        /// <summary>
        /// Add survey experiment in to experiments list
        /// </summary>
        /// <param name="obj"></param>
        public static void AddSurvey(Survey obj)
        {
            Experiments.Add("Survey" + surveyCount, obj);
            experiments_order.Add("Survey" + surveyCount);
            surveyCount++;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count < 1) { return; }

            var item_index = listView1.SelectedItems[0].Index;
            var item = experiments_order[item_index];
            Experiments.Remove(item);
            experiments_order.Remove(item);
            BindListView();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            List<Experiment> valuesList = new List<Experiment>();
            foreach(var item in Experiments.Values)
            {
                valuesList.Add(item);
            }
            string json = JsonConvert.SerializeObject(valuesList.ToArray());
            // Displays a SaveFileDialog so the user can save the Image  
            // assigned to Button2.  
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Filter = "Experiment JSON|*.Experiment",
                Title = "Save an Expriment File"
            };
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                //write string to file
                System.IO.File.WriteAllText(saveFileDialog1.FileName, json);
            }   
        }
    }
}
