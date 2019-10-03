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
        /// <summary>
        /// Return fullscreen for edit
        /// </summary>
        public FullScreen returnEdit;

        /// <summary>
        /// Existing trial for edit
        /// </summary>
        private FullScreen existingTrial;

        public FullscreenForm(FullScreen existing=null)
        {
            InitializeComponent();
            
            if(existing != null)
            {
                this.existingTrial = existing;
                UpdateExistingTrial();
            }
        }

        private void UpdateExistingTrial()
        {
            this.SubGroupNumeric.Value = this.existingTrial.sub_group;
            this.GroupNumeric.Value = this.existingTrial.group;
            MsgRich.Text = this.existingTrial.message;
        }

        #region Events

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MsgRich.Text)) return;

            var newFullScreen = new FullScreen(MsgRich.Text);
            newFullScreen.group = (GroupNumeric.Value);
            newFullScreen.sub_group = (SubGroupNumeric.Value);

            if(this.existingTrial != null)
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
