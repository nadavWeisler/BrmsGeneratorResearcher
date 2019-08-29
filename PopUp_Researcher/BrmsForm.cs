using bRMS_Generator.Helpers;
using bRMS_Generator.src;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace bRMS_Generator
{
    public partial class BrmsForm : Form
    {
        #region Properties

        /// <summary>
        /// 
        /// </summary>
        protected BRmsHelper Helper = null;

        /// <summary>
        /// 
        /// </summary>
        protected List<string> brms_names;

        /// <summary>
        /// 
        /// </summary>
        protected Dictionary<string, bRMS> brms_trials;

        /// <summary>
        /// 
        /// </summary>
        protected int brms_count;

        #endregion

        #region Constractors

        /// <summary>
        /// 
        /// </summary>
        public BrmsForm()
        {
            InitializeComponent();
            if (this.Helper == null)
            {
                this.Helper = new BRmsHelper();
            }
            this.brms_names = new List<string>();
            this.brms_trials = new Dictionary<string, bRMS>();

            PageEnabled();
        }

        #endregion

        #region Private Methods

        #region Events

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StimulusFolderButton_Click(object sender, EventArgs e)
        {
            // Show the FolderBrowserDialog.  
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                StimulusTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HelpCsvButton_Click(object sender, EventArgs e)
        {

            // Show the FolderBrowserDialog.  
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                HelpCsvTextBox.Text = openFileDialog1.FileName;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HelpCsvTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(HelpCsvTextBox.Text))
            {
                UpdateHelperFromCsv(HelpCsvTextBox.Text);
            }
            PageEnabled();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HelpCsvTextBox_DoubleClick(object sender, EventArgs e)
        {
            HelpCsvTextBox.Text = string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StimulusTextBox_DoubleClick(object sender, EventArgs e)
        {
            StimulusTextBox.Text = string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderedRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioEnabled();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            if(TagsListView.SelectedItems.Count < 1) { return; }

            string validationString = ValidateBeforeAdd();
            if(!string.IsNullOrEmpty(validationString))
            {
                MessageBox.Show(validationString);
                return;
            }

            bRMS new_brms = new bRMS
            {
                name = "bRMS" + brms_count,
                group = this.GroupNumeric.Value,
                sub_group = this.SubGroupNumeric.Value
            };
            Dictionary<string, List<string>> tags_stimuluses = new Dictionary<string, List<string>>();
            foreach(ListViewItem tag in TagsListView.SelectedItems)
            {
                tags_stimuluses[tag.Text] = Helper.GetStimulusByOneTag(tag.Text);
            }
            if(this.MixedRadio.Checked)
            {
                new_brms.BrmsType = "mix";
            }
            else
            {
                if(this.RandomRadio.Checked)
                {
                    new_brms.BrmsType = "random";
                }
                else
                {
                    new_brms.BrmsType = "order";
                }
            }
            new_brms.Repetitions = this.CountNumeric.Value;
            new_brms.MaxType = this.MaxTypeNumeric.Value;
            new_brms.FadeInTime = this.FadeInTimeNumeric.Value;
            new_brms.FadeOutTime = this.FacdeOutTimeNumeric.Value;
            new_brms.FadeOutLength = this.FadeOutLengthNumeric.Value;
            new_brms.VisualUnit = this.VisUnitNumeric.Value;
            new_brms.MondrianCount = this.MondrianCountNumeric.Value;
            new_brms.BreakTime = this.BreakTimeNumeric.Value;
            if ((this.OriantetionComboBox.SelectedValue == null))
            {
                new_brms.Orientation = "h";
            }
            else
            {
                switch (this.OriantetionComboBox.SelectedValue.ToString().ToLower())
                {
                    case "horizontal":
                        new_brms.Orientation = "h";
                        break;
                    case "vertical":
                        new_brms.Orientation = "h";
                        break;
                }
            }
            new_brms.TimingPostTrial = this.TimingPostTrialNumeric.Value;
            new_brms.WithinIti = this.ItiNumeric.Value;
            new_brms.ExperimentLength = this.ExperimentLengthNumeric.Value;
            new_brms.RectengleNumber = this.RectangleNumeric.Value;
            new_brms.TimingResponse = this.TimingResponseNumeric.Value;
            new_brms.StimulusMaxOpacity = this.StimulusMaxOpacityNumeric.Value;
            new_brms.MondrianMaxOpacity = this.MondrianMaxOpacityNumeric.Value;
            new_brms.TrialLimit = this.TrialLimitNumeric.Value;
            this.brms_names.Add("bRMS" + brms_count);
            this.brms_trials["bRMS" + brms_count] = new_brms;
            brms_count++;
            BindListView();
        }

        #endregion

        /// <summary>
        /// Bind brms list view
        /// </summary>
        private void BindListView()
        {
            AllTrialsListView.Clear();
            foreach(var name in brms_names)
            {
                AllTrialsListView.Items.Add(name);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="csvFileName"></param>
        private void UpdateHelperFromCsv(string csvFileName)
        {
            this.Helper.UpdateStimulusFromCsv(csvFileName);
            TagsListView.Clear();
            foreach (var tag in this.Helper.GetTagList())
            {
                TagsListView.Items.Add(tag);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void PageEnabled()
        {
            var enabled = !string.IsNullOrEmpty(HelpCsvTextBox.Text);
            AllBRMSGroupBox.Enabled = enabled;
            onebRMSGroupBox.Enabled = enabled;
            RadioEnabled();
        }

        /// <summary>
        /// 
        /// </summary>
        private void RadioEnabled()
        {
            this.OrderGroup.Enabled = this.OrderdRadio.Checked;
        }

        /// <summary>
        /// Validate bRMS before createtion
        /// </summary>
        private string ValidateBeforeAdd()
        {
            if (string.IsNullOrEmpty(StimulusTextBox.Text))
            {
                //return ErrorMsg.bRMS_Form_StimulusFileMissing;
            }

            if (string.IsNullOrEmpty(HelpCsvTextBox.Text))
            {
                //return ErrorMsg.bRMS_Form_HelpCsvMissing;
            }

            return string.Empty;
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in AllTrialsListView.SelectedItems)
            {
                this.brms_names = (Utils.RemoveItemByIndex(this.brms_names, item.Index));
                this.brms_trials.Remove(item.Text);
            }
            BindListView();
        }

        /// <summary>
        /// Up Button Click On bRMS List View
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DownButton_Click(object sender, EventArgs e)
        {
            if (AllTrialsListView.SelectedItems.Count > 0 && 
                AllTrialsListView.SelectedItems[0].Index < this.brms_names.Count)
            {
                this.brms_names = Utils.UpOneItem(this.brms_names, AllTrialsListView.SelectedItems[0].Index);
                BindListView();
            }
        }

        /// <summary>
        /// Up Button Click On bRMS List View
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpButton_Click(object sender, EventArgs e)
        {
            if (AllTrialsListView.SelectedItems.Count > 0 && 
                AllTrialsListView.SelectedItems[0].Index > 0)
            {
                this.brms_names = Utils.DownOneItem(this.brms_names, AllTrialsListView.SelectedItems[0].Index);
                BindListView();
            }
        }

        /// <summary>
        /// Save bRMS Trials
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (brms_names.Count > 0)
            {
                List<bRMS> brms_list = new List<bRMS>();
                foreach(var item in brms_trials.Values)
                {
                    brms_list.Add(item);
                }
                MainForm.AddBrms(brms_list);
                Close();
            }
        }
    }
}
