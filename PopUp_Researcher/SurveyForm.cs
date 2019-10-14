using System;
using System.Collections.Generic;
using System.Windows.Forms;
using bRMS_Generator.src;

namespace bRMS_Generator
{
    public partial class SurveyForm : Form
    {
        #region Properties

        /// <summary>
        /// Questions ListView
        /// </summary>
        protected List<Question> questions;

        /// <summary>
        /// If Page Loaded
        /// </summary>
        protected bool loaded = false;

        /// <summary>
        /// Existing Trial
        /// </summary>
        protected Survey existingTrial;

        /// <summary>
        /// Return edited survey
        /// </summary>
        public Survey returnEdit;

        #endregion

        #region Constractors

        /// <summary>
        /// Constractors
        /// </summary>
        public SurveyForm(Survey existing = null)
        {
            this.loaded = false;

            InitializeComponent();
            this.questions = new List<Question>();
            
            if(existing != null)
            {
                this.existingTrial = existing;
                UpdateExistingTrial();
                BindListView();
            }
            this.loaded = true;
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Update Qustions listview by existing survey
        /// </summary>
        private void UpdateExistingTrial()
        {
            this.SubBlockNumeric.Value = this.existingTrial.sub_group;
            this.BlockNumeric.Value = this.existingTrial.group;

            switch (this.existingTrial.type)
            {
                case "survey-text":
                    TextSurveyRadio.Checked = true;
                    break;
                case "survey-likert":
                    ScaleSurveyRadio.Checked = true;
                    break;
                case "survey-multi-choice":
                    MultiSurveyRadio.Checked = true;
                    break;
            }

            foreach(var question in this.existingTrial.questions)
            {
                this.questions.Add(question);
            }
        }

        /// <summary>
        /// Bind Questions ListView with Questions list
        /// </summary>
        private void BindListView()
        {
            QuestionsListView.Items.Clear();
            foreach (var item in this.questions)
            {
                QuestionsListView.Items.Add(item.GetPrompt());
            }
        }

        /// <summary>
        /// Add Question button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddQuestionButton_Click(object sender, EventArgs e)
        {
            QuestionForm qForm = null;
            if (TextSurveyRadio.Checked)
            {
                qForm = new QuestionForm(SurveyTypes.Text);
            }
            else
            {
                if (MultiSurveyRadio.Checked)
                {
                    qForm = new QuestionForm(SurveyTypes.MultiChoice);
                }
                else
                {
                    if (ScaleSurveyRadio.Checked)
                    {
                        qForm = new QuestionForm(SurveyTypes.Scale);
                    }
                }
            }

            if (qForm != null)
            {
                qForm?.ShowDialog();
                if (qForm.question != null)
                {
                    this.questions.Add(qForm.question);
                    BindListView();
                }
            }
        }

        /// <summary>
        /// Save Survey button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(this.questions.Count > 0)
            {
                Survey newSurvey = null;
                if(this.TextSurveyRadio.Checked)
                {
                    newSurvey = new TextSurvey(this.questions);
                }
                else
                {
                    if(this.ScaleSurveyRadio.Checked)
                    {
                        newSurvey = new ScaleSurvey(this.questions);
                    }
                    else
                    {
                        newSurvey = new MultiSurvey(this.questions);
                    }
                }

                if(newSurvey != null)
                {
                    newSurvey.SetGroup(BlockNumeric.Value);
                    newSurvey.SetSubGroup(SubBlockNumeric.Value);
                    if(this.existingTrial == null)
                    {
                        MainForm.AddSurvey(newSurvey);
                    }
                    else
                    {
                        returnEdit = newSurvey;
                    }
                    Close();
                }
            }
        }

        /// <summary>
        /// Remove question button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in QuestionsListView.SelectedItems)
            {
                this.questions = Utils.RemoveItemByIndex(this.questions, item.Index);
            }
            BindListView();
        }

        /// <summary>
        /// Minus button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinusButton_Click(object sender, EventArgs e)
        {
            if (QuestionsListView.SelectedItems.Count > 0 && QuestionsListView.SelectedItems[0].Index < this.questions.Count - 1)
            {
                this.questions = Utils.UpOneItem(this.questions, QuestionsListView.SelectedItems[0].Index);
                BindListView();
            }
        }

        /// <summary>
        /// Plus button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlusButton_Click(object sender, EventArgs e)
        {
            if (QuestionsListView.SelectedItems.Count > 0 && QuestionsListView.SelectedItems[0].Index > 0)
            {
                this.questions = Utils.DownOneItem(this.questions, QuestionsListView.SelectedItems[0].Index);
                BindListView();
            }
        }

        /// <summary>
        /// Dublicate qustion button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DuplicateButton_Click(object sender, EventArgs e)
        {
            if(this.QuestionsListView.SelectedItems.Count > 0)
            {
                this.questions.Add(this.questions[this.QuestionsListView.SelectedItems[0].Index]);
            }
            BindListView();
        }

        /// <summary>
        /// Checked changes from TextSurvey radio button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextSurveyRadio_CheckedChanged(object sender, EventArgs e)
        {
            ChangeRadioButton();
        }

        /// <summary>
        /// Checked changes from MultiSurvey radio button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MultiSurveyRadio_CheckedChanged(object sender, EventArgs e)
        {
            ChangeRadioButton();
        }

        /// <summary>
        /// Checked changes from ScaleSurvey radio button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScaleSurveyRadio_CheckedChanged(object sender, EventArgs e)
        {
            ChangeRadioButton();
        }

        /// <summary>
        /// Change Survey Type Radio Button
        /// </summary>
        private void ChangeRadioButton()
        {
            if (loaded && QuestionsListView.Items.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are You Sure?", "Change Survey Type",
                    MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    QuestionsListView.Clear();
                }
            }
        }

        #endregion
    }
}
