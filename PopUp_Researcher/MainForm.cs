using System;
using System.Collections.Generic;
using System.Windows.Forms;
using bRMS_Generator.src;
using Newtonsoft.Json;
using PopUp_Researcher.Models;

namespace bRMS_Generator
{
    public partial class MainForm : Form
    {
        #region Properties 

        /// <summary>
        /// Experiment's Trials
        /// </summary>
        private static Dictionary<string, Trial> Experiments;

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

        #endregion

        #region Constractors

        /// <summary>
        /// MainForm Constractor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            Experiments = new Dictionary<string, Trial>();
            experiments_order = new List<string>();
            fullscreenCount = 0;
            introCount = 0;
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Open Create Introduction Dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IntroButton_Click(object sender, EventArgs e)
        {
            var intro = new InstructionsForm();
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
        /// Load existing Experiment (for edit)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadButton_Click(object sender, EventArgs e)
        {
            // Show the FolderBrowserDialog.  
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Experiment newExpereiment = Utils.LoadExperimentCsv(openFileDialog1.FileName);
                NameTextBox.Text = newExpereiment.Name;
                NameTextBox.Enabled = false;
                this.listView1.Clear();
                this.LoadExperiment(newExpereiment.Trials);
                BindListView();
            }
        }

        /// <summary>
        /// Load experiment
        /// </summary>
        /// <param name="trialLst"></param>
        private void LoadExperiment(List<Trial> trialLst)
        {
            foreach (var item in trialLst)
            {
                switch (item.type)
                {
                    case "bRMS":
                        List<BRMS> helpLst = new List<BRMS>();
                        helpLst.Add((BRMS)item);
                        AddBrms(helpLst);
                        break;
                    case "survey-text":
                    case "survey-likert":
                    case "survey-multi-choice":
                        AddSurvey((Survey)item);
                        break;
                    case "fullscreen":
                        AddFullscreen((FullScreen)item);
                        break;
                    case "instructions":
                        AddIntro((Instructions)item);
                        break;
                }
            }
        }

        /// <summary>
        /// Remove Trial from experiment list view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count < 1) { return; }

            var item_index = listView1.SelectedItems[0].Index;
            var item = experiments_order[item_index];
            Experiments.Remove(item);
            experiments_order.Remove(item);
            BindListView();
        }

        /// <summary>
        /// Validation Before Save
        /// </summary>
        /// <returns></returns>
        private string ValidateBeforeSave()
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                return "Experiment Name Is Missing";
            }

            if (listView1.Items.Count == 0)
            {
                return "No Trials Selected";
            }

            return string.Empty;
        }

        /// <summary>
        /// Save all experiment button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            string validationString = ValidateBeforeSave();
            if (!string.IsNullOrWhiteSpace(validationString))
            {
                MessageBox.Show(validationString);
                return;
            }

            List<Trial> valuesList = new List<Trial>();
            foreach (var item in Experiments.Values)
            {
                valuesList.Add(item);
            }

            Dictionary<string, object> to_json_dic = new Dictionary<string, object>
            {
                {
                    "timeline", valuesList
                }
            };

            to_json_dic.Add("name", NameTextBox.Text);

            string json = JsonConvert.SerializeObject(to_json_dic, Formatting.Indented);


            // Displays a SaveFileDialog so the user can save the Image  
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                FileName = NameTextBox.Text,
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

        /// <summary>
        /// Edit Trial Button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems == null || listView1.SelectedItems.Count == 0)
            {
                return;
            }

            int selectedIndex = listView1.SelectedItems[0].Index;
            EditExpeiment(selectedIndex);
        }

        /// <summary>
        /// Edit Trial
        /// </summary>
        /// <param name="trialIndex"></param>
        private void EditExpeiment(int trialIndex)
        {
            Trial trial = Experiments[experiments_order[trialIndex]];
            if (trial.type == "bRMS")
            {
                if (true)
                {
                    MessageBox.Show("There is no options to edit bRMS trial, sorry");
                }
                else
                {
                    BrmsForm bRms = new BrmsForm((BRMS)trial);
                    bRms.ShowDialog();
                }
            }
            else
            {
                if (trial.type == "survey-text" || trial.type == "survey-multi-choice" ||
                    trial.type == "survey-likert")
                {
                    var surveyF = new SurveyForm((Survey)trial);
                    surveyF.ShowDialog();
                    if (surveyF.returnEdit != null)
                    {
                        Experiments[experiments_order[trialIndex]] = surveyF.returnEdit;
                    }
                }
                else
                {
                    if (trial.type == "fullscreen")
                    {
                        var fullscreenF = new FullscreenForm((FullScreen)trial);
                        fullscreenF.ShowDialog();
                        if (fullscreenF.returnEdit != null)
                        {
                            Experiments[experiments_order[trialIndex]] = fullscreenF.returnEdit;
                        }
                    }
                    else
                    {
                        if (trial.type == "instructions")
                        {
                            var instructionsF = new InstructionsForm((Instructions)trial);
                            instructionsF.ShowDialog();
                            if (instructionsF.returnEdit != null)
                            {
                                Experiments[experiments_order[trialIndex]] = instructionsF.returnEdit;
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }
            BindListView();
        }

        #endregion

        #region Public Methods

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
            foreach (var item in brms_list)
            {
                Experiments.Add("bRMS" + bRMS_count, item);
                experiments_order.Add("bRMS" + bRMS_count);
                bRMS_count++;
            }
        }

        #endregion
    }
}
