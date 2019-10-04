using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bRMS_Generator.src;

namespace bRMS_Generator
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

        public QuestionForm(string _type)
        {
            InitializeComponent();
            this.type = _type;
            this.question = null;
            if (this.type == SurveyTypes.Text)
            {
                ScaleGroupBox.Enabled = false;
                TextGroupBox.Enabled = true;
                OptionsGroupBox.Enabled = false;
            }
            else
            {
                if (this.type == SurveyTypes.Scale)
                {
                    ScaleGroupBox.Enabled = true;
                    TextGroupBox.Enabled = false;
                    OptionsGroupBox.Enabled = false;
                }
                else
                {
                    ScaleGroupBox.Enabled = false;
                    TextGroupBox.Enabled = false;
                    OptionsGroupBox.Enabled = true;
                }
            }
        }

        #endregion

        #region Private Methods 

        /// <summary>
        /// Get Sacle from input
        /// </summary>
        /// <returns>List<string></returns>
        private List<string> GetScale()
        {
            var numberList = Enumerable.Range(1, decimal.ToInt32(ScaleNumeric.Value)).ToList();
            List<string> result = new List<string>();
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
            if (!string.IsNullOrWhiteSpace(PromptRichTextBox.Text))
            {
                if (this.type == SurveyTypes.Text)
                {
                    this.question = new TextQuestion(this.PromptRichTextBox.Text, this.RowsNumeric.Value,
                        this.ColsNumeric.Value, this.ValueTextBox.Text, this.RequiredCheckBox.Checked);
                    Close();
                }
                else
                {
                    if (this.type == SurveyTypes.Scale)
                    {
                        List<string> values = new List<string>();
                        if(string.IsNullOrWhiteSpace(StartLabelText.Text))
                        {
                            values.Add("1");
                        }
                        else
                        {
                            values.Add(StartLabelText.Text);
                        }
                        for(int i = 2; i < this.ScaleNumeric.Value; i++)
                        {
                            values.Add(i.ToString());
                        }
                        if (!string.IsNullOrWhiteSpace(MiddleLabelText.Text))
                        {
                            values[(int)ScaleNumeric.Value / 2] = MiddleLabelText.Text;
                        }
                        if (string.IsNullOrWhiteSpace(EndLabelText.Text))
                        {
                            values.Add(this.ScaleNumeric.Value.ToString());
                        }
                        else
                        {
                            values.Add(EndLabelText.Text);
                        }
                        this.question = new MultiScaleQuestion(this.PromptRichTextBox.Text,
                            this.RequiredCheckBox.Checked, values);
                        Close();

                    }
                    else
                    {
                        List<string> values = new List<string>();
                        foreach(ListViewItem item in listView1.Items)
                        {
                            values.Add(item.Text);
                        }
                        if(values.Count > 0)
                        {
                            this.question = this.question = new MultiScaleQuestion(this.PromptRichTextBox.Text,
                                this.RequiredCheckBox.Checked, values);
                            Close();
                        }
                    } 
                }
            }
        }

        #endregion
    }
}
