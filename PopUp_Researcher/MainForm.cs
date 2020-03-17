using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Firebase.Storage;
using Newtonsoft.Json;
using PopUp_Researcher;
using PopUp_Researcher.Helpers;
using PopUp_Researcher.Models;
using Formatting = Newtonsoft.Json.Formatting;

namespace bRMS_Generator
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
        protected static int ImageKeyboardCount;

        /// <summary>
        /// Survry Trials Count
        /// </summary>
        protected static int SurveyCount;

        /// <summary>
        /// bRMS Trials Count
        /// </summary>
        protected static int BRmsCount;

        #endregion

        #region Constractors

        /// <summary>
        /// MainForm Constractor
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
            listView1.Clear();
            foreach (var item in ExperimentsOrder)
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
            var result = openFileDialog1.ShowDialog();
            if (result != DialogResult.OK) return;
            var newExperiment = Utils.LoadExperimentCsv(openFileDialog1.FileName);
            NameTextBox.Text = newExperiment.Name;
            NameTextBox.Enabled = false;
            this.listView1.Clear();
            this.LoadExperiment(newExperiment.Trials);
            BindListView();
        }

        /// <summary>
        /// Load experiment
        /// </summary>
        /// <param name="trialLst"></param>
        private void LoadExperiment(IEnumerable<Trial> trialLst)
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
            if (listView1.SelectedItems.Count < 1) { return; }

            var itemIndex = listView1.SelectedItems[0].Index;
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
                return "Experiment Name Is Missing";
            }

            if (listView1.Items.Count == 0)
            {
                return "No Trials Selected";
            }

            return string.Empty;
        }

        private async System.Threading.Tasks.Task AddImageToStorageAsync(string filePath, string folderName)
        {
            // Get any Stream - it can be FileStream, MemoryStream or any other type of Stream
            var stream = File.Open(filePath, FileMode.Open);
            Console.WriteLine(Path.GetFileName(filePath));
            // Construct FirebaseStorage, path to where you want to upload the file and Put it there
            var task = new FirebaseStorage("popup-965c9.appspot.com")
                .Child(folderName)
                .Child(Path.GetFileName(filePath))
                .PutAsync(stream);

            // Track progress of the upload
            task.Progress.ProgressChanged += (s, e) => Console.WriteLine($"Progress: {e.Percentage} %");

            // await the task to wait until upload completes and get the download url
            var downloadUrl = await task;
            Console.WriteLine("down" + downloadUrl);
        }

        /// <summary>
        /// Save all experiment button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0){ return; }
            var validationString = ValidateBeforeSave();
            if (!string.IsNullOrWhiteSpace(validationString))
            {
                MessageBox.Show(validationString);
                return;
            }

            var valuesList = new List<Trial>();
            var allImages = new HashSet<string>();
            foreach (var item in Experiments.Values)
            {
                if (item.type == "bRMS")
                {
                    var brmsTrial = (Brms) item;
                    foreach (var image in brmsTrial.all_images)
                    {
                        allImages.Add(image);
                    } 

                    foreach (var image in allImages)
                    {
                        try
                        {
                            _ = AddImageToStorageAsync(image, NameTextBox.Text);
                        }
                        catch (Exception)
                        {
                            _ = AddImageToStorageAsync(image, NameTextBox.Text);
                        }
                    }
                }
                valuesList.Add(item);
            }

            string background_color;
            if (BackgroundColorComboBox.SelectedText == null)
            {
                background_color = "white";
            }
            else
            {
                background_color = BackgroundColorComboBox.SelectedText;
            }

            var toJsonDic = new Dictionary<string, object>
            {
                {"timeline", valuesList},
                {"name", NameTextBox.Text},
                {"count", 0 },
                {"background_color", background_color }
            };


            var json = JsonConvert.SerializeObject(toJsonDic, Formatting.Indented);


            // Displays a SaveFileDialog so the user can save the Image  
            var saveFileDialog1 = new SaveFileDialog
            {
                FileName = NameTextBox.Text,
                Filter = "Experiment JSON|*.json",
                Title = "Save an Expriment File"
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
            if (listView1.SelectedItems.Count == 0) {return;}

            var selectedIndex = listView1.SelectedItems[0].Index;
            EditExperiment(selectedIndex);
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
                case "bRMS":
                    MessageBox.Show("There is no options to edit bRMS trial, sorry");
                    if (false)
                    {
                        var bRms = new BrmsForm((Brms)trial);
                        bRms.ShowDialog();
                    }
                    break;
                case "survey-text":
                case "survey-multi-choice":
                case "survey-likert":
                {
                    var surveyF = new SurveyForm((Survey)trial);
                    surveyF.ShowDialog();
                    if (surveyF.ReturnEdit != null)
                    {
                        Experiments[ExperimentsOrder[trialIndex]] = surveyF.ReturnEdit;
                    }

                    break;
                }
                case "fullscreen":
                {
                    var fullscreenF = new FullscreenForm((FullScreen)trial);
                    fullscreenF.ShowDialog();
                    if (fullscreenF.returnEdit != null)
                    {
                        Experiments[ExperimentsOrder[trialIndex]] = fullscreenF.returnEdit;
                    }

                    break;
                }
                case "instructions":
                {
                    var instructionsF = new InstructionsForm((Instructions)trial);
                    instructionsF.ShowDialog();
                    if (instructionsF.ReturnEdit != null)
                    {
                        Experiments[ExperimentsOrder[trialIndex]] = instructionsF.ReturnEdit;
                    }

                    break;
                }
                default:
                    return;
            }
            BindListView();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlusButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count <= 0 || listView1.SelectedItems[0].Index <= 0) return;

            var tmp = listView1.SelectedItems[0].Text;
            var tmpIndex = listView1.SelectedItems[0].Index;
            listView1.Items[tmpIndex].Text = listView1.Items[tmpIndex - 1].Text;
            listView1.Items[tmpIndex - 1].Text = tmp;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinusButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count <= 0 ||
                listView1.SelectedItems[0].Index >= listView1.Items.Count - 1) return;

            var tmp = listView1.SelectedItems[0].Text;
            var tmpIndex = listView1.SelectedItems[0].Index;
            listView1.Items[tmpIndex].Text = listView1.Items[tmpIndex + 1].Text;
            listView1.Items[tmpIndex + 1].Text = tmp;
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
        public static void AddImageKeyboard(ImageKeyboard obj)
        {
            AddTrial(obj);
            ImageKeyboardCount++;
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


        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ImageButton_Click(object sender, EventArgs e)
        {
            var newForm = new ImageForm();
            newForm.ShowDialog();
            BindListView();
        }
    }
}
