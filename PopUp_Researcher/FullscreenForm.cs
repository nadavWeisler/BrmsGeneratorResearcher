using System;
using System.Windows.Forms;
using PopUp_Researcher.Helpers;
using PopUp_Researcher.Resources;

namespace PopUp_Researcher
{
    public partial class FullscreenForm
    {
        #region Public Properties

        /// <summary>
        /// Return fullscreen for edit
        /// </summary>
        public FullScreen ReturnEdit;

        #endregion

        #region Private Properties

        /// <summary>
        /// Existing trial for edit
        /// </summary>
        private readonly FullScreen _existingTrial;

        #endregion

        #region Constractors

        public FullscreenForm(FullScreen existing=null)
        {
            InitializeComponent();

            if (existing == null) return;
            this._existingTrial = existing;
            UpdateExistingTrial();
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Update Existing Trial by this.existingTrial
        /// </summary>
        private void UpdateExistingTrial()
        {
            this.SubBlockNumeric.Value = this._existingTrial.sub_block;
            this.BlockNumeric.Value = this._existingTrial.block;
            this.NameTextBox.Text = this._existingTrial.name;
            MsgRich.Text = this._existingTrial.message;
        }

        /// <summary>
        /// Save Fullscreen button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MsgRich.Text)) return;

            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                MessageBox.Show(ErrMsg.NameMissingError);
                return;
            }

            var newFullScreen = new FullScreen(MsgRich.Text)
            {
                block = (BlockNumeric.Value), sub_block = (SubBlockNumeric.Value), name = NameTextBox.Text
            };


            if (this._existingTrial != null)
            {
                this.ReturnEdit = newFullScreen;
            }
            else
            {
                MainForm.AddFullscreen(newFullScreen);
            }            
            this.Close();
        }

        #endregion
    }
}
