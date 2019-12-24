using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
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
        protected BRmsHelper Helper;

        /// <summary>
        /// bRMS Trials Names List
        /// </summary>
        protected List<string> BrmsNames;

        /// <summary>
        /// bRMS Dictionary of bRMS name and Object Key value Pair
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
            this.BrmsNames = new List<string>();
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

            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                MessageBox.Show("Enter Name");
                return;
            }

            var newBrms = new Brms
            {
                block = this.BlockNumeric.Value,
                sub_block = this.SubBlockNumeric.Value,
                StimulusDictionary = new Dictionary<string, List<string>>()
            };

            if (this.AllTrialsListView.Items.ContainsKey(NameTextBox.Text))
            {
                var i = 1;
                while (this.AllTrialsListView.Items.ContainsKey(NameTextBox.Text+i))
                {
                    i++;
                }

                newBrms.name = NameTextBox.Text + i;
            }
            else
            {
                newBrms.name = NameTextBox.Text;
            }

            var imageBlobs = new Dictionary<string, string>();
            foreach (var item in ImagesComboBox.Items)
            {
                var fileName = ImagesComboBox.GetItemText(item);
                var bytes = File.ReadAllBytes(fileName);
                var file = Convert.ToBase64String(bytes);
                imageBlobs.Add(Path.GetFileNameWithoutExtension(Path.GetFileName(fileName)), file);
            }

            newBrms.ImagesBlobs = imageBlobs;
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
            newBrms.post_trial_gap = this.PostTrialGapNumeric.Value * 1000;
            newBrms.stimulus_delay = this.StimulusDelayNumeric.Value;
            newBrms.rectangle_number = this.RectangleNumeric.Value;
            newBrms.timing_response = this.TimingResponseNumeric.Value;
            newBrms.mondrian_max_opacity = this.MondrianMaxOpacityNumeric.Value;
            var newBRmsName = "bRMS" + brms_count + "_" + newBrms.brms_type + "_" + tagString;
            this.BrmsNames.Add(newBRmsName);
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
            this.BlockNumeric.Value = existingTrial.block;
            this.SubBlockNumeric.Value = this.existingTrial.sub_block;
            this.FadeInTimeNumeric.Value = this.existingTrial.fade_in_time;
            this.FacdeOutTimeNumeric.Value = this.existingTrial.fade_out_time;
            this.MondrianCountNumeric.Value = this.existingTrial.mondrian_count;
            this.OriantetionComboBox.SelectedValue = this.existingTrial.orientation;
            this.PostTrialGapNumeric.Value = this.existingTrial.post_trial_gap / 1000;
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
            this.StimulusDurationNumeric.Value = this.existingTrial.stimulus_duration;
        }

        /// <summary>
        /// Bind brms list view
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
                this.BrmsNames = (Utils.RemoveItemByIndex(this.BrmsNames, item.Index));
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

        private void UploadImgButton_Click(object sender, EventArgs e)
        {
            // Show the FolderBrowserDialog.  
            var result = openFileDialogImages.ShowDialog();
            if (result == DialogResult.OK)
            {
                ImagesComboBox.Items.AddRange(openFileDialogImages.FileNames);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
