using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.SubGroupNumeric.Value = this.existingTrial.sub_group;
            this.GroupNumeric.Value = this.existingTrial.group;
            MsgRich.Text = this.existingTrial.message;
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
                group = (GroupNumeric.Value),
                sub_group = (SubGroupNumeric.Value)
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
