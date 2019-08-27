using bRMS_Generator.Helpers;
using System;
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

        }

        #endregion


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
        /// 
        /// </summary>
        private string ValidateBeforeAdd()
        {
            if (string.IsNullOrEmpty(StimulusTextBox.Text))
            {
                return ErrorMsg.bRMS_Form_StimulusFileMissing;
            }

            if (string.IsNullOrEmpty(HelpCsvTextBox.Text))
            {
                return ErrorMsg.bRMS_Form_HelpCsvMissing;
            }

            return string.Empty;
        }

        #endregion
    }
}
