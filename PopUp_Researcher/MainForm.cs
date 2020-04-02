using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using bRMS_Generator;
using Newtonsoft.Json;
using PopUp_Researcher.Helpers;
using PopUp_Researcher.Models;
using Formatting = Newtonsoft.Json.Formatting;

namespace PopUp_Researcher
{
    public partial class MainForm : Form
    {
        #region Properties 

        /// <summary>
        /// Experiment's Trials
        /// </summary>
        protected static Dictionary<string, Trial> Experiments;

        /// <summary>
        /// Experiment's Trials Name List
        /// </summary>
        protected static List<string> ExperimentsOrder;

        /// <summary>
        /// Fullscreen Trial Count
        /// </summary>
        protected static int FullscreenCount;

        /// <summary>
        /// Introduction Trial Count
        /// </summary>
        protected static int IntroCount;

        /// <summary>
        /// Introduction Trial Count
        /// </summary>
        protected static int ImageButtonCount;

        /// <summary>
        /// Survey Trials Count
        /// </summary>
        protected static int SurveyCount;

        /// <summary>
        /// bRMS Trials Count
        /// </summary>
        protected static int BRmsCount;

        #endregion

        #region Constractors

        /// <summary>
        /// MainForm Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            Experiments = new Dictionary<string, Trial>();
            ExperimentsOrder = new List<string>();
            FullscreenCount = 0;
            IntroCount = 0;
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
            TrialsListView.Clear();
            foreach (var item in ExperimentsOrder)
            {
                TrialsListView.Items.Add(item);
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
            var result = openFileDialog1.ShowDialog();
            if (result != DialogResult.OK) return;
            var newExperiment = Utils.LoadExperimentCsv(openFileDialog1.FileName);
            NameTextBox.Text = newExperiment.Name;
            NameTextBox.Enabled = false;
            this.TrialsListView.Clear();
            LoadExperiment(newExperiment.Trials);
            BindListView();
        }

        /// <summary>
        /// Load experiment
        /// </summary>
        /// <param name="trialLst"></param>
        private static void LoadExperiment(IEnumerable<Trial> trialLst)
        {
            foreach (var item in trialLst)
            {
                switch (item.type)
                {
                    case "bRMS":
                    {
                        var helpDic = new Dictionary<string, Brms>
                        {
                            {"bRMS", (Brms) item}
                        };
                        AddBrms(helpDic);
                        break;
                    }
                    case "survey-text":
                    case "survey-likert":
                    case "survey-multi-choice":
                        AddSurvey((Survey) item);
                        break;
                    case "fullscreen":
                        AddFullscreen((FullScreen) item);
                        break;
                    case "instructions":
                        AddIntro((Instructions) item);
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
            if (TrialsListView.SelectedItems.Count < 1) { return; }

            var itemIndex = TrialsListView.SelectedItems[0].Index;
            var item = ExperimentsOrder[itemIndex];
            Experiments.Remove(item);
            ExperimentsOrder.Remove(item);
            BindListView();
        }

        private static bool ValidRgb(string str)
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
        /// Validation Before Save
        /// </summary>
        /// <returns></returns>
        private string ValidateBeforeSave()
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                return "Experiment Name Is Missing";
            }
            else if (TrialsListView.Items.Count == 0)
            {
                return "No Trials Selected";
            }
            else if(!ValidRgb(BackgoundRgbTextBox.Text))
            {
                return "Invalid RGB code";
            }
            else
            {
                return string.Empty;
            }
        }

        private List<Trial> GetFinalTimeline()
        {
            var resultList = new List<Trial>();
            foreach (var trialString in ExperimentsOrder)
            {
                resultList.Add(Experiments[trialString]);
            }
            return resultList;
        }
        /// <summary>
        /// Save all experiment button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (TrialsListView.Items.Count == 0){ return; }
            var validationString = ValidateBeforeSave();
            if (!string.IsNullOrWhiteSpace(validationString))
            {
                MessageBox.Show(validationString);
                return;
            }

            var toJsonDic = new Dictionary<string, object>
            {
                {"timeline", this.GetFinalTimeline()},
                {"name", NameTextBox.Text},
                {"count", 0},
                {"background_color", BackgoundRgbTextBox.Text}
            };


            var json = JsonConvert.SerializeObject(toJsonDic, Formatting.Indented);


            // Displays a SaveFileDialog so the user can save the Image  
            var saveFileDialog1 = new SaveFileDialog
            {
                FileName = NameTextBox.Text,
                Filter = "Experiment JSON|*.json",
                Title = "Save an Experiment File"
            };
            saveFileDialog1.ShowDialog();

            if (!string.IsNullOrEmpty(saveFileDialog1.FileName))
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
            if (TrialsListView.SelectedItems.Count == 0) {return;}
            var selectedIndex = TrialsListView.SelectedItems[0].Index;
            if (Experiments[ExperimentsOrder[selectedIndex]].type == ExperimentTypes.bRMS)
            {
                MessageBox.Show("Edit bRMS experiment is not supported at this moment");
                return;
            }
            EditExperiment(selectedIndex);
        }

        /// <summary>
        /// Edit Trial
        /// </summary>
        /// <param name="trialIndex"></param>
        private void EditExperiment(int trialIndex)
        {
            var trial = Experiments[ExperimentsOrder[trialIndex]];
            if (trial.type == ExperimentTypes.ScaleSurvey ||
                     trial.type == ExperimentTypes.TextSurvey ||
                     trial.type == ExperimentTypes.MultiChoiceSurvey)
            {
                var surveyF = new SurveyForm((Survey)trial);
                surveyF.ShowDialog();
                if (surveyF.ReturnEdit != null)
                {
                    Experiments[ExperimentsOrder[trialIndex]] = surveyF.ReturnEdit;
                }
            }
            else if (trial.type == ExperimentTypes.Fullscreen)
            {
                var fullscreenF = new FullscreenForm((FullScreen)trial);
                fullscreenF.ShowDialog();
                if (fullscreenF.ReturnEdit != null)
                {
                    Experiments[ExperimentsOrder[trialIndex]] = fullscreenF.ReturnEdit;
                }
            }
            else if (trial.type == ExperimentTypes.Instructions)
            {
                var instructionsF = new InstructionsForm((Instructions)trial);
                instructionsF.ShowDialog();
                if (instructionsF.ReturnEdit != null)
                {
                    Experiments[ExperimentsOrder[trialIndex]] = instructionsF.ReturnEdit;
                }
            }
            BindListView();
        }

        /// <summary>
        /// Plus button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlusButton_Click(object sender, EventArgs e)
        {
            if (TrialsListView.SelectedItems.Count <= 0 || TrialsListView.SelectedItems[0].Index <= 0) return;

            var tmp = TrialsListView.SelectedItems[0].Text;
            var tmpIndex = TrialsListView.SelectedItems[0].Index;
            TrialsListView.Items[tmpIndex].Text = TrialsListView.Items[tmpIndex - 1].Text;
            TrialsListView.Items[tmpIndex - 1].Text = tmp;

            ExperimentsOrder[tmpIndex] = ExperimentsOrder[tmpIndex - 1];
            ExperimentsOrder[tmpIndex - 1] = tmp;

            TrialsListView.Items[tmpIndex].Selected = false;
            TrialsListView.Items[tmpIndex - 1].Selected = true;
        }

        /// <summary>
        /// Minus button click 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinusButton_Click(object sender, EventArgs e)
        {
            if (TrialsListView.SelectedItems.Count <= 0 ||
                TrialsListView.SelectedItems[0].Index >= TrialsListView.Items.Count - 1) return;

            var tmp = TrialsListView.SelectedItems[0].Text;
            var tmpIndex = TrialsListView.SelectedItems[0].Index;
            TrialsListView.Items[tmpIndex].Text = TrialsListView.Items[tmpIndex + 1].Text;
            TrialsListView.Items[tmpIndex + 1].Text = tmp;

            ExperimentsOrder[tmpIndex] = ExperimentsOrder[tmpIndex + 1];
            ExperimentsOrder[tmpIndex + 1] = tmp;

            TrialsListView.Items[tmpIndex].Selected = false;
            TrialsListView.Items[tmpIndex + 1].Selected = true;
        }

        private static void AddTrial(Trial obj)
        {
            if (ExperimentsOrder.Contains(obj.name))
            {
                var i = 2;
                while (ExperimentsOrder.Contains(obj.name + 1))
                {
                    i++;
                }

                obj.name += i;
            }
            Experiments.Add(obj.name, obj);
            ExperimentsOrder.Add(obj.name);
        }
        #endregion

        #region Public Methods

        /// <summary>
        /// Add fullscreen experiment in to experiments list
        /// </summary>
        /// <param name="obj"></param>
        public static void AddFullscreen(FullScreen obj)
        {
            AddTrial(obj);
            FullscreenCount++;
        }

        /// <summary>
        /// Add intro experiment in to experiments list
        /// </summary>
        /// <param name="obj"></param>
        public static void AddIntro(Instructions obj)
        {
            AddTrial(obj);
            IntroCount++;
        }

        /// <summary>
        /// Add ImageKeyboard experiment in to experiments list
        /// </summary>
        /// <param name="obj"></param>
        public static void AddImageKeyboard(ImageButton obj)
        {
            AddTrial(obj);
            ImageButtonCount++;
        }

        /// <summary>
        /// Add survey experiment in to experiments list
        /// </summary>
        /// <param name="obj"></param>
        public static void AddSurvey(Survey obj)
        {
            AddTrial(obj);
            SurveyCount++;
        }

        /// <summary>
        /// Add bRMS trials to Experiment list view
        /// </summary>
        /// <param name="_brmsList"></param>
        public static void AddBrms(Dictionary<string, Brms> _brmsList)
        {
            foreach (var item in _brmsList.Values)
            {
                if (ExperimentsOrder.Contains(item.name))
                {
                    var i = 2;
                    while (ExperimentsOrder.Contains(item.name + 1))
                    {
                        i++;
                    }

                    item.name += i;
                }
                Experiments.Add(item.name, item);
                ExperimentsOrder.Add(item.name);
                BRmsCount++;
            }
        }

        private void ImageButton_Click(object sender, EventArgs e)
        {
            var newForm = new ImageForm();
            newForm.ShowDialog();
            BindListView();
        }

        #endregion


    }
}
