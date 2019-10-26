using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PopUp_Researcher.Helpers;

namespace bRMS_Generator
{
    public partial class FullscreenForm : Form
    {
        #region Public Properties

        /// <summary>
        /// Return fullscreen for edit
        /// </summary>
        public FullScreen returnEdit;

        #endregion

        #region Private Properties

        /// <summary>
        /// Existing trial for edit
        /// </summary>
        private FullScreen existingTrial;

        #endregion

        #region Constractors

        public FullscreenForm(FullScreen existing=null)
        {
            InitializeComponent();
            
            if(existing != null)
            {
                this.existingTrial = existing;
                UpdateExistingTrial();
            }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Update Existing Trial by this.existingTrial
        /// </summary>
        private void UpdateExistingTrial()
        {
            this.SubBlockNumeric.Value = this.existingTrial.sub_block;
            this.BlockNumeric.Value = this.existingTrial.block;
            MsgRich.Text = this.existingTrial.Message;
        }

        /// <summary>
        /// Save Fullscreen button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MsgRich.Text)) return;

            var newFullScreen = new FullScreen(MsgRich.Text)
            {
                block = (BlockNumeric.Value),
                sub_block = (SubBlockNumeric.Value)
            };

            if (this.existingTrial != null)
            {
                this.returnEdit = newFullScreen;
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
