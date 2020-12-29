using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BrmsGeneratorResearcher.Helpers;
using BrmsGeneratorResearcher.Models;
using BrmsGeneratorResearcher.Resources;

namespace BrmsGeneratorResearcher
{
    public partial class BrmsForm : Form
    {
        #region Properties

        /// <summary>
        /// bRMS Helper Object
        /// </summary>
        protected BRmsHelper Helper;

        /// <summary>
        /// bRMS Trials Names List
        /// </summary>
        protected List<string> BrmsNames;

        /// <summary>
        /// bRMS Dictionary of bRMS name and Object Key value Pair
        /// </summary>
        protected Dictionary<string, Brms> brmsTrials;

        /// <summary>
        /// Existing bRMS(edit)
        /// </summary>
        protected Brms existingTrial;

        /// <summary>
        /// bRMS Trials Count
        /// </summary>
        protected int brms_count;

        /// <summary>
        /// Return fullscreen for edit
        /// </summary>
        public FullScreen ReturnEdit;

        /// <summary>
        /// Already exist bRMS names
        /// </summary>
        protected List<string> existingNames;

        public Regex AddChoiceRegex { get; } = new Regex("^[a-zA-Z0-9 ]*$");

        #endregion

        #region Constractors

        /// <summary>
        /// Basic Constructors
        /// </summary>
        public BrmsForm(Brms _existingTrial=null, List<string> existingTrialsNames = null)
        {
            InitializeComponent();
            if (this.Helper == null)
            {
                this.Helper = new BRmsHelper();
            }

            if (existingTrialsNames != null)
            {
                this.existingNames = existingTrialsNames;
            }

            this.BrmsNames = new List<string>();
            this.brmsTrials = new Dictionary<string, Brms>();

            if(_existingTrial != null)
            {
                this.existingTrial = _existingTrial;
                UpdateExistingTrial();
            }

            PageEnabled();
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Update CSV click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HelpCsvButton_Click(object sender, EventArgs e)
        {
            // Show the FolderBrowserDialog.  
            var result = openFileDialog1.ShowDialog();
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
            if (string.IsNullOrEmpty(HelpCsvTextBox.Text)) return;

            if (UpdateHelperFromCsv(HelpCsvTextBox.Text))
            {
                PageEnabled();
            }
            else
            {
                this.HelpCsvTextBox.Text = string.Empty;
            }

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
        private void AddButton_Click(object sender, EventArgs e)
        {
            if(TagsListView.SelectedItems.Count < 1) { return; }

            var validationString = ValidateBeforeAdd();
            if(!string.IsNullOrEmpty(validationString))
            {
                MessageBox.Show(validationString);
                return;
            }

            var newBrms = new Brms
            {
                block = this.BlockNumeric.Value,
                sub_block = this.SubBlockNumeric.Value,
                StimulusDictionary = new Dictionary<string, List<string>>(),
                name = NameTextBox.Text
            };

            foreach(ListViewItem tag in TagsListView.SelectedItems)
            {
                newBrms.StimulusDictionary[tag.Text] = Helper.GetStimulusByOneTag(tag.Text);
            }

            if(this.MixedRadio.Checked)
            {
                newBrms.brms_type = "mix";
            }
            else
            {
                newBrms.brms_type = this.RandomRadio.Checked ? "random" : "order";
            }

            newBrms.trial_type = this.rmsRadioButton.Checked ? "RMS" :
                this.MaskedControlRadioButton.Checked ? "Masked" : "UNMASK";
            
            newBrms.fade_in_time = this.FadeInTimeNumeric.Value;
            newBrms.fade_out_time = this.FacdeOutTimeNumeric.Value;
            newBrms.mondrian_count = this.MondrianCountNumeric.Value;
            newBrms.stimulus_opacity = this.StimulusOpacityNumeric.Value;
            newBrms.fixation_width = this.FixationWidthNumeric.Value;
            newBrms.fixation_height = this.FixationHeightNumeric.Value;
            newBrms.frame_width = this.FrameWidthNumeric.Value;
            newBrms.frame_height = this.FrameHeightNumeric.Value;
            newBrms.stimulus_width = this.StimulusWidthNumeric.Value;
            newBrms.stimulus_height = this.StimulusHeightNumeric.Value;
            newBrms.rectangle_width = this.RectWidthNumeric.Value;
            newBrms.rectangle_height = this.RectHeightNumeric.Value;
            newBrms.stimulus_duration = this.StimulusDurationNumeric.Value;
            newBrms.post_trial_gap = this.PostTrialGapNumeric.Value * 1000;
            newBrms.rectangle_number = this.RectangleNumeric.Value;
            newBrms.timing_response = this.TimingResponseNumeric.Value;
            newBrms.mask_duration = this.numericMondrianDuration.Value;
            newBrms.mondrian_max_opacity = this.MondrianMaxOpacityNumeric.Value;

            var choicesList = new List<string>();
            foreach (var choice in this.ChoicesTextBox.Text.Split(','))
            {
                if (!string.IsNullOrEmpty(choice))
                {
                    choicesList.Add(choice);
                }
            }
            newBrms.choices = choicesList;

            this.BrmsNames.Add(newBrms.name);
            this.brmsTrials[newBrms.name] = newBrms;
            brms_count++;
            BindListView();
        }

        /// <summary>
        /// Update Existing Trial by this.existingTrial
        /// </summary>
        private void UpdateExistingTrial()
        {
            this.BlockNumeric.Value = existingTrial.block;
            this.SubBlockNumeric.Value = this.existingTrial.sub_block;
            this.FadeInTimeNumeric.Value = this.existingTrial.fade_in_time;
            this.FacdeOutTimeNumeric.Value = this.existingTrial.fade_out_time;
            this.MondrianCountNumeric.Value = this.existingTrial.mondrian_count;
            this.PostTrialGapNumeric.Value = this.existingTrial.post_trial_gap / 1000;
            this.RectangleNumeric.Value = this.existingTrial.rectangle_number;
            this.numericMondrianDuration.Value = this.existingTrial.mask_duration;
            this.TimingResponseNumeric.Value = this.existingTrial.timing_response;
            this.MondrianMaxOpacityNumeric.Value = this.existingTrial.mondrian_max_opacity;
            this.FixationWidthNumeric.Value = this.existingTrial.fixation_width;
            this.FixationHeightNumeric.Value = this.existingTrial.fixation_height;
            this.FrameWidthNumeric.Value = this.existingTrial.frame_width;
            this.FrameHeightNumeric.Value = this.existingTrial.frame_height;
            this.StimulusWidthNumeric.Value = this.existingTrial.stimulus_width;
            this.StimulusHeightNumeric.Value = this.existingTrial.stimulus_height;
            this.RectWidthNumeric.Value = this.existingTrial.rectangle_width;
            this.RectHeightNumeric.Value = this.existingTrial.rectangle_height;
            this.StimulusDurationNumeric.Value = this.existingTrial.stimulus_duration;
        }

        /// <summary>
        /// Bind bRMS list view
        /// </summary>
        private void BindListView()
        {
            AllTrialsListView.Clear();
            foreach(var name in BrmsNames)
            {
                AllTrialsListView.Items.Add(name);
            }
        }

        /// <summary>
        /// Update Tags from CSV
        /// </summary>
        /// <param name="csvFileName"></param>
        private bool UpdateHelperFromCsv(string csvFileName)
        {
            if (this.Helper.UpdateStimulusFromCsv(csvFileName))
            {
                TagsListView.Clear();
                foreach (var tag in this.Helper.GetTagList())
                {
                    TagsListView.Items.Add(tag);
                }
            }
            else
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Enabled Page
        /// </summary>
        private void PageEnabled()
        {
            var enabled = !string.IsNullOrEmpty(HelpCsvTextBox.Text);
            AllBRMSGroupBox.Enabled = enabled;
            ParamsGroupBox.Enabled = enabled;
            RadioEnabled();
        }

        /// <summary>
        /// Enabled Radio buttons
        /// </summary>
        private void RadioEnabled()
        {
            this.OrderGroup.Enabled = this.OrderdRadio.Checked;
        }

        /// <summary>
        /// Validate bRMS before creation
        /// </summary>
        private string ValidateBeforeAdd()
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                return ErrMsg.NameMissingError;
            }
            foreach (var name in BrmsNames)
            {
                if (name.Equals(NameTextBox.Text))
                {
                    return ErrMsg.NameAlreadyExistError;
                }
            }
            foreach (var name in this.existingNames)
            {
                if (name.Equals(NameTextBox.Text))
                {
                    return ErrMsg.NameAlreadyExistError;
                }
            }
            
            return string.Empty;
        }

        /// <summary>
        /// Remove button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in AllTrialsListView.SelectedItems)
            {
                this.BrmsNames = (Utils.RemoveItemByIndex(this.BrmsNames, item.Index));
                this.brmsTrials.Remove(item.Text);
            }
            BindListView();
        }

        /// <summary>
        /// Down Button Click On bRMS List View
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DownButton_Click(object sender, EventArgs e)
        {
            if (AllTrialsListView.SelectedItems.Count <= 0 ||
                AllTrialsListView.SelectedItems[0].Index >= this.BrmsNames.Count) return;

            this.BrmsNames = Utils.UpOneItem(this.BrmsNames, AllTrialsListView.SelectedItems[0].Index);
            BindListView();
        }

        /// <summary>
        /// Up Button Click On bRMS List View
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpButton_Click(object sender, EventArgs e)
        {
            if (AllTrialsListView.SelectedItems.Count <= 0 || AllTrialsListView.SelectedItems[0].Index <= 0) return;
            
            this.BrmsNames = Utils.DownOneItem(this.BrmsNames, AllTrialsListView.SelectedItems[0].Index);
            BindListView();
        }

        /// <summary>
        /// Save bRMS Trials
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (BrmsNames.Count <= 0) return;
            MainForm.AddBrms(brmsTrials);
            Close();
        }

        /// <summary>
        /// Ordered radio checked changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderedRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (this.OrderdRadio.Checked)
            {
                this.OrderGroup.Enabled = true;
                UpdateOrderedListView();
            }
            else
            {
                this.OrderlistView.Clear();
                this.OrderGroup.Enabled = false;
            }
            RadioEnabled();
        }

        /// <summary>
        /// Update fixed-fixed list view by stimulus by tags
        /// </summary>
        private void UpdateOrderedListView()
        {
            this.OrderlistView.Clear();
            var stimulusList = this.Helper.GetStimulusByTags(
                Utils.GetItemsListFromListView(TagsListView, true));
            stimulusList = stimulusList.Distinct().ToList();
            foreach (var item in stimulusList)
            {
                this.OrderlistView.Items.Add(item);
            }
        }

        /// <summary>
        /// Get Up selected item on fixed-fixed list view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlusButton_Click(object sender, EventArgs e)
        {
            if (OrderlistView.SelectedItems.Count <= 0) return;
            var orderView = Utils.GetItemsListFromListView(OrderlistView);
            orderView = Utils.DownOneItem(orderView, OrderlistView.SelectedItems[0].Index);
            OrderlistView.Items.Clear();
            foreach (var item in orderView)
            {
                OrderlistView.Items.Add(item);
            }
        }

        /// <summary>
        /// Get down selected item on fixed-fixed list view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinusButton_Click(object sender, EventArgs e)
        {
            if (OrderlistView.SelectedItems.Count <= 0) return;
            var orderView = Utils.GetItemsListFromListView(OrderlistView);
            orderView = Utils.UpOneItem(orderView, OrderlistView.SelectedItems[0].Index);
            OrderlistView.Items.Clear();
            foreach (var item in orderView)
            {
                OrderlistView.Items.Add(item);
            }
        }

        /// <summary>
        /// Remove item on fixed-fixed list view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveOrderButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in OrderlistView.SelectedItems)
            {
                OrderlistView.Items.RemoveAt(item.Index);
            }
        }

        /// <summary>
        /// Change TagListView selected index
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TagsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrderdRadio.Checked)
            {
                UpdateOrderedListView();
            }
        }

        /// <summary>
        /// Duplicate item on fixed-fixed list view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DuplicateOrderButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in OrderlistView.SelectedItems)
            {
                OrderlistView.Items.Add(item.Text);
            }
        }

        /// <summary>
        /// Choice button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChoicesButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddChoiceTextBox.Text))
            {
                AddChoiceTextBox.Text = string.Empty;
            }
            else if (!AddChoiceRegex.IsMatch(AddChoiceTextBox.Text))
            {
                MessageBox.Show(ErrMsg.InvalidChoiceError);
                this.AddChoiceTextBox.Text = string.Empty;
            }
            else if (this.ChoicesTextBox.Text.Contains(this.AddChoiceTextBox.Text))
            {
                MessageBox.Show(ErrMsg.ChoiceAlreadyExistError);
                this.AddChoiceTextBox.Text = string.Empty;
            }
            else
            {
                this.ChoicesTextBox.Text += this.AddChoiceTextBox.Text;
                if (!string.IsNullOrEmpty(this.ChoicesTextBox.Text))
                {
                    this.ChoicesTextBox.Text += ",";
                }
                this.AddChoiceTextBox.Text = string.Empty;
            }
        }

        #endregion
    }
}
