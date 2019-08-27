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
        public FullscreenForm()
        {
            InitializeComponent();
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
            newFullScreen.SetGroup(GroupNumeric.Value);
            newFullScreen.SetSubGroup(SubGroupNumeric.Value);
            MainForm.AddFullscreen(newFullScreen);
            this.Close();
        }

        #endregion
    }
}
