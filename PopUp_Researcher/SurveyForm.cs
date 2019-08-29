using System;
using System.Collections.Generic;
using System.Windows.Forms;
using bRMS_Generator.src;

namespace bRMS_Generator
{
    public partial class SurveyForm : Form
    {
        /// <summary>
        /// Questions ListView
        /// </summary>
        protected List<Question> questions;

        /// <summary>
        /// Constractors
        /// </summary>
        public SurveyForm()
        {
            InitializeComponent();
            this.questions = new List<Question>();
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
        /// Add Question
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
        /// Save Survey
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
                    newSurvey.SetGroup(GroupNumeric.Value);
                    newSurvey.SetSubGroup(SubGroupNumeric.Value);
                    MainForm.AddSurvey(newSurvey);
                    Close();
                }
            }
        }


        /// <summary>
        /// 
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
        /// 
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
        /// 
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DuplicateButton_Click(object sender, EventArgs e)
        {
            if(this.QuestionsListView.SelectedItems.Count > 0)
            {

            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextSurveyRadio_CheckedChanged(object sender, EventArgs e)
        {
            QuestionsListView.Clear();
        }

        private void MultiSurveyRadio_CheckedChanged(object sender, EventArgs e)
        {
            QuestionsListView.Clear();
        }

        private void ScaleSurveyRadio_CheckedChanged(object sender, EventArgs e)
        {
            QuestionsListView.Clear();
        }
    }
}
