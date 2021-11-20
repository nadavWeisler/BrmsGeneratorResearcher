using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BrmsGeneratorResearcher.Helpers;
using BrmsGeneratorResearcher.Models;
using BrmsGeneratorResearcher.Resources;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BrmsGeneratorResearcher
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

        protected static int CptCount;

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
            BRmsCount = 0;
            CptCount = 0;
            ImageButtonCount = 0;
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
        /// Get names of exiting bRMS trials
        /// </summary>
        /// <returns></returns>
        private static List<string> GetExistingBrmsNames()
        {
            var result = new List<string>();
            foreach (var trial in Experiments.Keys)
            {
                if (Experiments[trial].type == ExperimentTypes.bRMS)
                {
                    result.Add(Experiments[trial].name);
                }
            }

            return result;
        }

        /// <summary>
        /// Open Create bRMS Dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BRms_button_Click(object sender, EventArgs e)
        {
            var bRms = new BrmsForm(null, GetExistingBrmsNames());
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
            var result = openFileDialog1.ShowDialog();
            if (result != DialogResult.OK) return;
            ExperimentsOrder.Clear();
            Experiments.Clear();
            var newExperiment = Utils.LoadExperimentJson(openFileDialog1.FileName);
            NameTextBox.Text = newExperiment.name;
            NameTextBox.Enabled = false;
            LoadExperiment(newExperiment.trialList, newExperiment);
            BindListView();
        }

        /// <summary>
        /// Load experiment
        /// </summary>
        /// <param name="trialLst"></param>
        private static void LoadExperiment(IEnumerable<Trial> trialLst, Experiment ex)
        {
            int count = 0;
            foreach (var item in trialLst)
            {
                switch (item.type)
                {
                    case ExperimentTypes.Instructions:
                        AddIntro((Instructions)item);
                        break;
                    case ExperimentTypes.bRMS:
                        List<string> tags = new List<string>();
                        if(ex.timeline[count].ContainsKey("StimulusDictionary"))
                        {
                            Dictionary<string, object> stimulusDictionaryValues =
                            JObject.FromObject(ex.timeline[count]["StimulusDictionary"]).ToObject<Dictionary<string, object>>();
                            Dictionary<string, List<string>> stimulusDictionary = new Dictionary<string, List<string>>();
                            foreach (var key in stimulusDictionaryValues.Keys)
                            {
                                tags.Add(key);
                                stimulusDictionary.Add(key, ((JArray)stimulusDictionaryValues[key]).ToObject<List<string>>());
                            }
                            ((Brms)item).StimulusDictionary = stimulusDictionary;
                            //((Brms)item).tags1 = tags;
                            //((Brms)item).tags2 = tags;
                        }
                        if (ex.timeline[count].ContainsKey("tags1"))
                        {
                            ((Brms)item).tags1 = ((JArray)ex.timeline[count]["tags1"]).ToObject<List<string>>();
                        }
                        if (ex.timeline[count].ContainsKey("tags2"))
                        {
                            ((Brms)item).tags2 = ((JArray)ex.timeline[count]["tags2"]).ToObject<List<string>>();
                        }
                        if (ex.timeline[count].ContainsKey("two_side"))
                        {
                            ((Brms)item).two_side = bool.Parse(ex.timeline[count]["two_side"].ToString());
                        }
                        ((Brms)item).choices = ((JArray)ex.timeline[count]["choices"]).ToObject<List<string>>();
                        AddSingleBrms((Brms)item);
                        break;
                    case ExperimentTypes.Survey:
                    case ExperimentTypes.MultiChoiceSurvey:
                    case ExperimentTypes.ScaleSurvey:
                    case ExperimentTypes.TextSurvey:
                        AddSurvey((Survey) item);
                        break;
                    case ExperimentTypes.Fullscreen:
                        AddFullscreen((FullScreen) item);
                        break;
                }
                count++;
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

        
        /// <summary>
        /// Validation Before Save
        /// </summary>
        /// <returns></returns>
        private string ValidateBeforeSave()
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                return ErrMsg.NameMissingError;
            }
            else if (TrialsListView.Items.Count == 0)
            {
                return ErrMsg.NoTrialAddedError;
            }
            else if(!Utils.ValidateRgb(BackgoundRgbTextBox.Text))
            {
                return ErrMsg.InvalidRGBcode;
            }
            else
            {
                return string.Empty;
            }
        }

        private static List<Trial> GetFinalTimeline()
        {
            var resultList = new List<Trial>();
            foreach (var trialString in ExperimentsOrder)
            {
                resultList.Add(Experiments[trialString]);
            }
            return resultList;
        }

        private static Dictionary<string, object> ToDictionary(object obj)
        {
            var json = JsonConvert.SerializeObject(obj);
            var dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
            return dictionary;
        }

        private static Experiment ExperimentListToDic(Experiment experiment)
        {
            experiment.timeline = new List<Dictionary<string, object>>();
            foreach (var trial in experiment.trialList)
            {
                experiment.timeline.Add(ToDictionary(trial));
            }

            experiment.trialList = null;
            return experiment;
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

            var newExperiment = new Experiment(NameTextBox.Text,
                BackgoundRgbTextBox.Text, 
                CompletionCodeText.Text,
                GetFinalTimeline());
            newExperiment = ExperimentListToDic(newExperiment);

            var json = JsonConvert.SerializeObject(newExperiment, Formatting.Indented);


            // Displays a SaveFileDialog so the user can save the Image  
            var saveFileDialog1 = new SaveFileDialog
            {
                FileName = NameTextBox.Text,
                Filter = BasicResources.ExperimentFilter,
                Title = BasicResources.ExperimentDialogTitle
            };
            saveFileDialog1.ShowDialog();

            if (!string.IsNullOrEmpty(saveFileDialog1.FileName))
            {
                //write string to file
                File.WriteAllText(saveFileDialog1.FileName, json);
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
            EditExperiment(TrialsListView.SelectedItems[0].Index);
        }

        /// <summary>
        /// Edit Trial
        /// </summary>
        /// <param name="trialIndex"></param>
        private void EditExperiment(int trialIndex)
        {
            var trial = Experiments[ExperimentsOrder[trialIndex]];
            switch (trial.type)
            {
                case ExperimentTypes.ScaleSurvey:
                case ExperimentTypes.TextSurvey:
                case ExperimentTypes.MultiChoiceSurvey:
                {
                    var surveyF = new SurveyForm((Survey)trial);
                    surveyF.ShowDialog();
                    if (surveyF.ReturnEdit != null)
                    {
                        Experiments[ExperimentsOrder[trialIndex]] = surveyF.ReturnEdit;
                    }
                    break;
                }
                case ExperimentTypes.Fullscreen:
                {
                    var fullscreenF = new FullscreenForm((FullScreen)trial);
                    fullscreenF.ShowDialog();
                    if (fullscreenF.ReturnEdit != null)
                    {
                        Experiments[ExperimentsOrder[trialIndex]] = fullscreenF.ReturnEdit;
                    }
                    break;
                }
                case ExperimentTypes.Instructions:
                {
                    var instructionsF = new InstructionsForm((Instructions)trial);
                    instructionsF.ShowDialog();
                    if (instructionsF.ReturnEdit != null)
                    {
                        Experiments[ExperimentsOrder[trialIndex]] = instructionsF.ReturnEdit;
                    }
                    break;
                }
                case ExperimentTypes.bRMS:
                    var rmsForm = new BrmsForm((Brms)trial, GetExistingBrmsNames());
                    rmsForm.ShowDialog();
                    if (rmsForm.ReturnEdit != null)
                    {
                        Experiments[ExperimentsOrder[trialIndex]] = rmsForm.ReturnEdit;
                    }
                    break;
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
                string[] splitedName = obj.name.Split('_');
                string newName;
                if (splitedName.Length > 2)
                {
                    newName = string.Join("_", splitedName.ToList().GetRange(0, splitedName.Length - 1)); 
                } 
                else
                {
                    newName = splitedName[0];
                }
                while (ExperimentsOrder.Contains(newName + "_" + i))
                {
                    i++;
                }

                obj.name = newName + "_" + i;
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

        public static void AddCpt(Cpt obj)
        {
            AddTrial(obj);
            CptCount++;
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

        public static void AddSingleBrms(Brms item)
        {
            AddTrial(item);
            BRmsCount++;
        }

        /// <summary>
        /// Add bRMS trials to Experiment list view
        /// </summary>
        /// <param name="_brmsList"></param>
        public static void AddBrms(Dictionary<string, Brms> _brmsList)
        {
            foreach (var item in _brmsList.Values)
            {
                AddSingleBrms(item);
            }
        }

        private void ImageButton_Click(object sender, EventArgs e)
        {
            var newForm = new ImageForm();
            newForm.ShowDialog();
            BindListView();
        }

        #endregion

        private void cptButton_Click(object sender, EventArgs e)
        {
            var newForm = new CptForm();
            newForm.ShowDialog();
            BindListView();
        }

        private void DuplicateButton_Click(object sender, EventArgs e)
        {
            if (TrialsListView.SelectedItems.Count == 0) { return; }
            var trial = Experiments[ExperimentsOrder[TrialsListView.SelectedItems[0].Index]];
            switch(trial.type)
            {
                case ExperimentTypes.bRMS:
                    AddSingleBrms((Brms) trial);
                    break;
                case ExperimentTypes.Instructions:
                    AddIntro((Instructions)trial);
                    break;
                case ExperimentTypes.ImageKeyboard:
                    AddImageKeyboard((ImageButton)trial);
                    break;
                case ExperimentTypes.ConjunctiveCPT:
                    AddCpt((Cpt)trial);
                    break;
                case ExperimentTypes.MultiChoiceSurvey:
                    AddSurvey((MultiSurvey)trial);
                    break;
                case ExperimentTypes.ScaleSurvey:
                    AddSurvey((ScaleSurvey)trial);
                    break;
                case ExperimentTypes.TextSurvey:
                    AddSurvey((TextSurvey)trial);
                    break;
            }
            BindListView();
        }
    }
}
