using bRMS_Generator.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PopUp_Researcher.Helpers;
using PopUp_Researcher.Models;

namespace bRMS_Generator
{
    public partial class BrmsForm : Form
    {
        #region Properties

        /// <summary>
        /// bRMS Helper Object
        /// </summary>
        protected BRmsHelper Helper = null;

        /// <summary>
        /// bRMS Trials Names List
        /// </summary>
        protected List<string> brms_names;

        /// <summary>
        /// bRMS Dictionary of bRMS name and Object Key Value Pair
        /// </summary>
        protected Dictionary<string, Brms> brms_trials;

        /// <summary>
        /// Existing bRMS(edit)
        /// </summary>
        protected Brms existingTrial;

        /// <summary>
        /// bRMS Trials Count
        /// </summary>
        protected int brms_count;

        #endregion

        #region Constractors

        /// <summary>
        /// Basic Constractors
        /// </summary>
        public BrmsForm(Brms _existingTrial=null)
        {
            InitializeComponent();
            if (this.Helper == null)
            {
                this.Helper = new BRmsHelper();
            }
            this.brms_names = new List<string>();
            this.brms_trials = new Dictionary<string, Brms>();

            if(_existingTrial != null)
            {
                this.existingTrial = _existingTrial;
                UpdateExistingTrial();
            }

            SetOrientationComboBox();

            PageEnabled();
        }

        #endregion

        #region Private Methods

        private void SetOrientationComboBox()
        {
            OriantetionComboBox.Items.Clear();
            var valuesList = new List<string> {"horizontal", "vertical"};
            OriantetionComboBox.DataSource = valuesList;
            OriantetionComboBox.SelectedIndex = 0;
        }

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
                name = "bRMS" + brms_count,
                group = this.BlockNumeric.Value,
                sub_group = this.SubBlockNumeric.Value,
                StimulusDictionary = new Dictionary<string, List<string>>()
            };
            var tagString = string.Empty;
            foreach(ListViewItem tag in TagsListView.SelectedItems)
            {
                newBrms.StimulusDictionary[tag.Text] = Helper.GetStimulusByOneTag(tag.Text);
                tagString += "_" + tag.Text;
            }
            if(this.MixedRadio.Checked)
            {
                newBrms.brms_type = "mix";
            }
            else
            {
                if(this.RandomRadio.Checked)
                {
                    newBrms.brms_type = "random";
                }
                else
                {
                    newBrms.brms_type = "order";
                }
            }
            newBrms.repetitions = this.CountNumeric.Value;
            newBrms.max_type = this.MaxTypeNumeric.Value;
            newBrms.fade_in_time = this.FadeInTimeNumeric.Value;
            newBrms.fade_out_time = this.FacdeOutTimeNumeric.Value;
            newBrms.mondrian_count = this.MondrianCountNumeric.Value;
            newBrms.break_time = this.BreakTimeNumeric.Value;
            newBrms.allowed_to_repeat = this.AllowedToRepeatNumeric.Value;
            newBrms.break_message = this.BreakMessageRichTextBox.Text;
            newBrms.performance_message = this.PerformanceMessageRchTextBox.Text;
            newBrms.stop_trial_message = this.StopMessageRichTextBox.Text;
            newBrms.stimulus_opacity = this.StimulusOpacityNumeric.Value;
            newBrms.fixation_width = this.FixationWidthNumeric.Value;
            newBrms.fixation_height = this.FixationHeightNumeric.Value;
            newBrms.frame_width = this.FrameWidthNumeric.Value;
            newBrms.frame_height = this.FrameHeightNumeric.Value;
            newBrms.stimulus_width = this.StimulusWidthNumeric.Value;
            newBrms.stimulus_height = this.StimulusHeightNumeric.Value;
            newBrms.rectangle_width = this.RectWidthNumeric.Value;
            newBrms.rectangle_height = this.RectHeightNumeric.Value;
            if ((this.OriantetionComboBox.SelectedValue == null))
            {
                newBrms.orientation = "h";
            }
            else
            {
                switch (this.OriantetionComboBox.SelectedValue.ToString().ToLower())
                {
                    case "horizontal":
                        newBrms.orientation = "h";
                        break;
                    case "vertical":
                        newBrms.orientation = "v";
                        break;
                }
            }
            newBrms.post_trial_gap = this.PostTrialGapNumeric.Value;
            newBrms.stimulus_delay = this.StimulusDelayNumeric.Value;
            newBrms.rectangle_number = this.RectangleNumeric.Value;
            newBrms.timing_response = this.TimingResponseNumeric.Value;
            newBrms.mondrian_max_opacity = this.MondrianMaxOpacityNumeric.Value;
            var newBRmsName = "bRMS" + brms_count + "_" + newBrms.brms_type + "_" + tagString;
            this.brms_names.Add(newBRmsName);
            this.brms_trials[newBRmsName] = newBrms;
            brms_count++;
            BindListView();
        }

        /// <summary>
        /// Update Existing Trial by this.existingTrial
        /// </summary>
        private void UpdateExistingTrial()
        {
            //new_brms.stimulus_dictionary = new Dictionary<string, List<string>>();
            //foreach (ListViewItem tag in TagsListView.SelectedItems)
            //{
            //    new_brms.stimulus_dictionary[tag.Text] = Helper.GetStimulusByOneTag(tag.Text);
            //}
            //if (this.MixedRadio.Checked)
            //{
            //    new_brms.brms_type = "mix";
            //}
            //else
            //{
            //    if (this.RandomRadio.Checked)
            //    {
            //        new_brms.brms_type = "random";
            //    }
            //    else
            //    {
            //        new_brms.brms_type = "order";
            //    }
            //}
            this.BlockNumeric.Value = this.existingTrial.group;
            this.SubBlockNumeric.Value = this.existingTrial.sub_group;
            this.CountNumeric.Value = this.existingTrial.repetitions;
            this.MaxTypeNumeric.Value = this.existingTrial.max_type;
            this.FadeInTimeNumeric.Value = this.existingTrial.fade_in_time;
            this.FacdeOutTimeNumeric.Value = this.existingTrial.fade_out_time;
            this.MondrianCountNumeric.Value = this.existingTrial.mondrian_count;
            this.BreakTimeNumeric.Value = this.existingTrial.break_time;
            this.OriantetionComboBox.SelectedValue = this.existingTrial.orientation;
            this.PostTrialGapNumeric.Value = this.existingTrial.post_trial_gap * 1000;
            this.StimulusDelayNumeric.Value = this.existingTrial.stimulus_delay;
            this.RectangleNumeric.Value = this.existingTrial.rectangle_number;
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
        }

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
        /// Validate bRMS before createtion
        /// </summary>
        private string ValidateBeforeAdd()
        {
            if (string.IsNullOrEmpty(HelpCsvTextBox.Text))
            {
                //return ErrorMsg.bRMS_Form_HelpCsvMissing;
            }

            return string.Empty;
        }

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
        /// Down Button Click On bRMS List View
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DownButton_Click(object sender, EventArgs e)
        {
            if (AllTrialsListView.SelectedItems.Count <= 0 ||
                AllTrialsListView.SelectedItems[0].Index >= this.brms_names.Count) return;

            this.brms_names = Utils.UpOneItem(this.brms_names, AllTrialsListView.SelectedItems[0].Index);
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
            
            this.brms_names = Utils.DownOneItem(this.brms_names, AllTrialsListView.SelectedItems[0].Index);
            BindListView();
        }

        /// <summary>
        /// Save bRMS Trials
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (brms_names.Count <= 0) return;
            MainForm.AddBrms(brms_trials);
            Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderdRadio_CheckedChanged(object sender, EventArgs e)
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


        #endregion

        private void ParamsGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
