using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PopUp_Researcher.Helpers;
using PopUp_Researcher.Resources;

namespace PopUp_Researcher
{
    public partial class SurveyForm : Form
    {
        #region Properties

        /// <summary>
        /// Questions ListView
        /// </summary>
        protected List<Question> Questions;

        /// <summary>
        /// If Page Loaded
        /// </summary>
        protected bool Loaded;

        /// <summary>
        /// Existing Trial
        /// </summary>
        protected Survey ExistingTrial;

        /// <summary>
        /// Return edited survey
        /// </summary>
        public Survey ReturnEdit;

        #endregion

        #region Constractors

        /// <summary>
        /// Constructors
        /// </summary>
        public SurveyForm(Survey existing = null)
        {
            this.Loaded = false;

            InitializeComponent();
            this.Questions = new List<Question>();
            
            if(existing != null)
            {
                this.ExistingTrial = existing;
                UpdateExistingTrial();
                BindListView();
            }
            this.Loaded = true;
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Update Questions list view by existing survey
        /// </summary>
        private void UpdateExistingTrial()
        {
            this.SubBlockNumeric.Value = this.ExistingTrial.sub_block;
            this.BlockNumeric.Value = this.ExistingTrial.block;
            this.NameTextBox.Text = this.ExistingTrial.name;

            switch (this.ExistingTrial.type)
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

            foreach(var question in this.ExistingTrial.questions)
            {
                this.Questions.Add(question);
            }
        }

        /// <summary>
        /// Bind Questions ListView with Questions list
        /// </summary>
        private void BindListView()
        {
            QuestionsListView.Items.Clear();
            foreach (var item in this.Questions)
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
                qForm = new QuestionForm(EnumSurveyTypes.Text);
            }
            else if (MultiSurveyRadio.Checked)
            {
                qForm = new QuestionForm(EnumSurveyTypes.MultiChoice);
            }
            else if (ScaleSurveyRadio.Checked)
            {
                qForm = new QuestionForm(EnumSurveyTypes.Scale);
            } 
            else if (ScaleCustomRadio.Checked)
            {
                qForm = new QuestionForm(EnumSurveyTypes.CustomScale);
            }



            if (qForm == null) return;
            qForm.ShowDialog();
            if (qForm.question == null) return;
            this.Questions.Add(qForm.question);
            BindListView();
        }

        /// <summary>
        /// Save Survey button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (this.Questions.Count <= 0) return;

            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                MessageBox.Show(ErrMsg.NameMissingError);
                return;
            }

            Survey newSurvey;
            if (this.TextSurveyRadio.Checked)
            {
                newSurvey = new TextSurvey(this.Questions);
            }
            else if(this.ScaleSurveyRadio.Checked)
            {
                newSurvey = new ScaleSurvey(this.Questions);
            }
            else if(this.MultiSurveyRadio.Checked)
            {
                newSurvey = new MultiSurvey(this.Questions);
            } 
            else if (this.ScaleCustomRadio.Checked)
            {
                newSurvey = new ScaleSurvey(this.Questions);
            }
            else
            {
                return;
            }
            

            newSurvey.name = NameTextBox.Text;
            newSurvey.SetGroup(BlockNumeric.Value);
            newSurvey.SetSubGroup(SubBlockNumeric.Value);
            if(this.ExistingTrial == null)
            {
                MainForm.AddSurvey(newSurvey);
            }
            else
            {
                ReturnEdit = newSurvey;
            }
            Close();
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
                this.Questions = Utils.RemoveItemByIndex(this.Questions, item.Index);
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
            if (QuestionsListView.SelectedItems.Count <= 0 ||
                QuestionsListView.SelectedItems[0].Index >= this.Questions.Count - 1) return;

            this.Questions = Utils.UpOneItem(this.Questions, QuestionsListView.SelectedItems[0].Index);
            BindListView();
        }

        /// <summary>
        /// Plus button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlusButton_Click(object sender, EventArgs e)
        {
            if (QuestionsListView.SelectedItems.Count <= 0 || 
                QuestionsListView.SelectedItems[0].Index <= 0) return;
            
            this.Questions = Utils.DownOneItem(this.Questions, QuestionsListView.SelectedItems[0].Index);
            BindListView();
        }

        /// <summary>
        /// Duplicate question button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DuplicateButton_Click(object sender, EventArgs e)
        {
            if(this.QuestionsListView.SelectedItems.Count > 0)
            {
                this.Questions.Add(this.Questions[this.QuestionsListView.SelectedItems[0].Index]);
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
            if (!Loaded || QuestionsListView.Items.Count <= 0) return;

            var dialogResult = MessageBox.Show(BasicResources.AreYouSureQ,
                BasicResources.ChangeSurveyTypeQ,
                MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes) return;
            QuestionsListView.Clear();
            BindListView();
        }

        #endregion
    }
}
