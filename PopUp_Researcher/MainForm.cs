using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using bRMS_Generator.src;
using Newtonsoft.Json;

namespace bRMS_Generator
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Experiment's Trials
        /// </summary>
        public static Dictionary<string, Experiment> Experiments;

        /// <summary>
        /// Experiment's Trials Name List
        /// </summary>
        private static List<string> experiments_order;

        /// <summary>
        /// Fullscreen Trial Count
        /// </summary>
        private static int fullscreenCount;

        /// <summary>
        /// Introduction Trial Count
        /// </summary>
        private static int introCount;

        /// <summary>
        /// Survry Trials Count
        /// </summary>
        private static int surveyCount;

        /// <summary>
        /// bRMS Trials Count
        /// </summary>
        private static int bRMS_count;

        /// <summary>
        /// MainForm Constractor
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
        /// Open Create Introduction Dialog
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
        /// Open Create bRMS Dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BRms_button_Click(object sender, EventArgs e)
        {
            var bRms = new BrmsForm();
            bRms.ShowDialog();
            BindListView();
        }

        /// <summary>
        /// Open Create Survey Dialog
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
        /// Open Create Fullscreen Dialog
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
        public static void AddIntro(Instructions obj)
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
        /// Add bRMS trials to Experiment list view
        /// </summary>
        /// <param name="brms_list"></param>
        public static void AddBrms(List<BRMS> brms_list)
        {
            foreach(var item in brms_list)
            {
                Experiments.Add("bRMS" + bRMS_count, item);
                experiments_order.Add("bRMS" + bRMS_count);
                bRMS_count++;
            }
        }

        /// <summary>
        /// Load new Experiment (for edit)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Remove Trial from experiment list view
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
        /// Save all experiment button click
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

            Dictionary<string, List<Experiment>> to_json_dic = new Dictionary<string, List<Experiment>>
            {
                { "timeline", valuesList }
            };

            string json = JsonConvert.SerializeObject(to_json_dic, Formatting.Indented);

            
            // Displays a SaveFileDialog so the user can save the Image  
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Filter = "Experiment JSON|*.json",
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
