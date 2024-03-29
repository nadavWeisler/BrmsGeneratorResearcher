﻿using System;
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
        public Brms ReturnEdit;

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
        public BrmsForm(Brms _existingTrial = null, List<string> existingTrialsNames = null)
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
                this.StimulusGroup.Enabled = false;
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

        private Brms getNewBrms()
        {
            var newBrms = new Brms
            {
                block = this.BlockNumeric.Value,
                sub_block = this.SubBlockNumeric.Value,
                StimulusDictionary = new Dictionary<string, List<string>>(),
                name = NameTextBox.Text
            };

            newBrms.tags1 = new List<string>();
            foreach (ListViewItem tag in TagsListView.SelectedItems)
            {
                newBrms.tags1.Add(tag.Text);
                newBrms.StimulusDictionary[tag.Text] = Helper.GetStimulusByOneTag(tag.Text);
            }

            foreach (ListViewItem tag in secondTagsListView.SelectedItems)
            {
                newBrms.StimulusDictionary[tag.Text] = Helper.GetStimulusByOneTag(tag.Text);
            }


            newBrms.brms_type = "mix";
            newBrms.trial_type = this.rmsRadioButton.Checked ? "RMS" :
                this.MaskedControlRadioButton.Checked ? "Masked" : "UNMASK";

            newBrms.two_side = this.doubleTagCheckBox.Checked;
            if (newBrms.two_side)
            {
                newBrms.tags2 = new List<string>();
                foreach (ListViewItem tag in secondTagsListView.SelectedItems)
                {
                    newBrms.tags2.Add(tag.Text);
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
            newBrms.post_trial_gap = this.PostTrialGapNumeric.Value * 1000;
            newBrms.rectangle_number = this.RectangleNumeric.Value;
            newBrms.timing_response = this.TimingResponseNumeric.Value;
            newBrms.mask_duration = this.numericMondrianDuration.Value;
            newBrms.mondrian_max_opacity = this.MondrianMaxOpacityNumeric.Value;
            newBrms.stimulus_after_press = this.ShowStimulusAfterNumeric.Value;

            var choicesList = new List<string>();
            foreach (var choice in this.ChoicesTextBox.Text.Split(','))
            {
                if (!string.IsNullOrEmpty(choice))
                {
                    choicesList.Add(choice);
                }
            }
            newBrms.choices = choicesList;

            return newBrms;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            var validationString = ValidateBeforeAdd();
            if (!string.IsNullOrEmpty(validationString))
            {
                MessageBox.Show(validationString);
                return;
            }

            var newBrms = getNewBrms();
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
            this.NameTextBox.Text = this.existingTrial.name;
            this.NameGroupBox.Enabled = false;
            this.AllBRMSGroupBox.Enabled = false;
            this.AddButton.Enabled = false;

            this.BlockNumeric.Value = this.existingTrial.block;
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
            this.doubleTagCheckBox.Checked = this.existingTrial.two_side;

            foreach(string choice in this.existingTrial.choices)
            {
                AddNewChoice(choice);
            }

            foreach(string tag in this.existingTrial.StimulusDictionary.Keys)
            {
                this.TagsListView.Items.Add(tag);
                this.secondTagsListView.Items.Add(tag);
            }

            if (this.existingTrial.tags1 != null)
            {
                foreach (string tag in this.existingTrial.tags1)
                {
                    this.TagsListView.FindItemWithText(tag).Selected = true;
                    //this.TagsListView.Items[tag].Selected = true;
                }
            } 

            if (this.existingTrial.tags2 != null)
            {
                foreach (string tag in this.existingTrial.tags2)
                {
                    this.secondTagsListView.FindItemWithText(tag).Selected = true;
                }
            }    
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
                secondTagsListView.Clear();
                foreach (var tag in this.Helper.GetTagList())
                {
                    TagsListView.Items.Add(tag);
                    secondTagsListView.Items.Add(tag);
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
            if(this.existingTrial == null)
            {
                ParamsGroupBox.Enabled = enabled;
            }
            EnableSecondStimulus();
        }

   

        /// <summary
        /// Validate bRMS before creation
        /// </summary>
        private string ValidateBeforeAdd()
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                return ErrMsg.NameMissingError;
            }
            if(this.TagsListView.SelectedItems.Count == 0)
            {
                return "Missing Tags";
            }
            foreach (var name in BrmsNames)
            {
                if (name.Equals(NameTextBox.Text))
                {
                    return ErrMsg.NameAlreadyExistError;
                }
            }
            if(this.existingTrial == null)
            {
                foreach (var name in this.existingNames)
                {
                    if (name.Equals(NameTextBox.Text))
                    {
                        return ErrMsg.NameAlreadyExistError;
                    }
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
            if(this.existingTrial != null)
            {
                var validationString = ValidateBeforeAdd();
                if (!string.IsNullOrEmpty(validationString))
                {
                    MessageBox.Show(validationString);
                    return;
                }
                this.ReturnEdit = getNewBrms();
            } 
            else
            {
                if (BrmsNames.Count <= 0) return;
                MainForm.AddBrms(brmsTrials);
                Close();
            }    
        }

        private void AddNewChoice(string choice)
        {
            this.ChoicesTextBox.Text += choice;
            if (!string.IsNullOrEmpty(this.ChoicesTextBox.Text))
            {
                this.ChoicesTextBox.Text += ",";
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
                this.AddNewChoice(this.AddChoiceTextBox.Text);
                this.AddChoiceTextBox.Text = string.Empty;
            }
        }

        #endregion

        private void DoubleTagCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            EnableSecondStimulus();
        }

        private void EnableSecondStimulus()
        {
            this.secondTagsGroupBox.Enabled = this.doubleTagCheckBox.Checked;
        }

        private void ChoicesResetButton_Click(object sender, EventArgs e)
        {
            this.ChoicesTextBox.Text = string.Empty;
        }
    }
}
