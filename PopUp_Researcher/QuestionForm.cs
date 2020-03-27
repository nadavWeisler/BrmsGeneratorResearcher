using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using PopUp_Researcher.Helpers;

namespace PopUp_Researcher
{
    public partial class QuestionForm : Form
    {
        #region Private Properties 

        private string type;

        #endregion

        #region Public proeprties

        public Question question;

        #endregion

        #region Constractors

        public QuestionForm(EnumSurveyTypes _type)
        {
            InitializeComponent();
            switch (_type)
            {
                case EnumSurveyTypes.CustomScale:
                    this.type = ExperimentTypes.ScaleSurvey;
                    ScaleGroupBox.Enabled = false;
                    TextGroupBox.Enabled = false;
                    OptionsGroupBox.Enabled = true;
                    break;
                case EnumSurveyTypes.Scale:
                    this.type = ExperimentTypes.ScaleSurvey;
                    ScaleGroupBox.Enabled = true;
                    TextGroupBox.Enabled = false;
                    OptionsGroupBox.Enabled = false;
                    break;
                case EnumSurveyTypes.MultiChoice:
                    this.type = ExperimentTypes.MultiChoiceSurvey;
                    ScaleGroupBox.Enabled = false;
                    TextGroupBox.Enabled = false;
                    OptionsGroupBox.Enabled = true;
                    break;
                case EnumSurveyTypes.Text:
                    this.type = ExperimentTypes.TextSurvey;
                    ScaleGroupBox.Enabled = false;
                    TextGroupBox.Enabled = true;
                    OptionsGroupBox.Enabled = false;
                    break;
            }
            this.question = null;
        }

        #endregion

        #region Private Methods 

        /// <summary>
        /// Get Scale from input
        /// </summary>
        /// <returns>string list</returns>
        private List<string> GetScale()
        {
            var numberList = Enumerable.Range(1, decimal.ToInt32(ScaleNumeric.Value)).ToList();
            var result = new List<string>();
            for (var i = 0; i < numberList.Count; i++)
            {
                if (i == 0)
                {
                    result.Add(StartLabelText.Text);
                }
                else
                {
                    if (i == numberList.Count / 2)
                    {
                        result.Add(MiddleLabelText.Text);
                    }
                    else
                    {
                        if (i == numberList.Count - 1)
                        {
                            result.Add(EndLabelText.Text);
                        }
                        else
                        {
                            result.Add(numberList[i].ToString());
                        }
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Add new option button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddOptionButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(OptionsTextBox.Text))
            {
                listView1.Items.Add(OptionsTextBox.Text);
            }
        }

        /// <summary>
        /// Remove option button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].Remove();
            }
        }

        /// <summary>
        /// Plus button click (options)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlusButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0 && listView1.SelectedItems[0].Index > 0)
            {
                var tmp = listView1.SelectedItems[0].Text;
                var tmpIndex = listView1.SelectedItems[0].Index;
                listView1.Items[tmpIndex].Text = listView1.Items[tmpIndex - 1].Text;
                listView1.Items[tmpIndex - 1].Text = tmp;
            }
        }

        /// <summary>
        /// Minus button click (options)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinusButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0 && listView1.SelectedItems[0].Index < listView1.Items.Count - 1)
            {
                var tmp = listView1.SelectedItems[0].Text;
                var tmpIndex = listView1.SelectedItems[0].Index;
                listView1.Items[tmpIndex].Text = listView1.Items[tmpIndex + 1].Text;
                listView1.Items[tmpIndex + 1].Text = tmp;
            }
        }

        /// <summary>
        /// Duplicate option button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DuplicateButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Add(listView1.SelectedItems[0].Text);
            }
        }

        /// <summary>
        /// Save question button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PromptRichTextBox.Text)) return;
            List<string> values;
            switch (this.type)
            {
                case ExperimentTypes.TextSurvey:
                    this.question = new TextQuestion(this.PromptRichTextBox.Text, this.RowsNumeric.Value,
                        this.ColsNumeric.Value, this.ValueTextBox.Text, this.RequiredCheckBox.Checked);
                    Close();
                    break;
                case ExperimentTypes.ScaleSurvey:
                    values = new List<string>();
                    if (ScaleGroupBox.Enabled)
                    {
                        if (string.IsNullOrWhiteSpace(StartLabelText.Text))
                        {
                            values.Add("1");
                        }
                        else
                        {
                            values.Add(StartLabelText.Text);
                        }

                        for (var i = 2; i < this.ScaleNumeric.Value; i++)
                        {
                            values.Add(i.ToString());
                        }

                        if (!string.IsNullOrWhiteSpace(MiddleLabelText.Text))
                        {
                            values[(int) ScaleNumeric.Value / 2] = MiddleLabelText.Text;
                        }

                        if (string.IsNullOrWhiteSpace(EndLabelText.Text))
                        {
                            values.Add(this.ScaleNumeric.Value.ToString(CultureInfo.InvariantCulture));
                        }
                        else
                        {
                            values.Add(EndLabelText.Text);
                        }
                    }
                    else
                    {
                        foreach (ListViewItem item in listView1.Items)
                        {
                            values.Add(item.Text);
                        }

                        if (values.Count <= 0) return;
                    }
                    this.question = new ScaleQuestion(this.PromptRichTextBox.Text,
                        this.RequiredCheckBox.Checked, values);
                    Close();
                    break;
                default:
                    values = new List<string>();
                    foreach(ListViewItem item in listView1.Items)
                    {
                        values.Add(item.Text);
                    }

                    if (values.Count <= 0) return;

                    this.question = this.question = new MultiSelectQuestion(this.PromptRichTextBox.Text,
                        this.RequiredCheckBox.Checked, values);

                    Close();
                    break;
            }
        }

        #endregion
    }
}
