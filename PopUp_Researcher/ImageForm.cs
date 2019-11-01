﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bRMS_Generator;
using PopUp_Researcher.Helpers;

namespace PopUp_Researcher
{
    public partial class ImageForm : Form
    {
        #region Properties

        /// <summary>
        /// Existing trial to edit
        /// </summary>
        private ImageKeyboard _existingTrial;

        /// <summary>
        /// Return value for edit
        /// </summary>
        public ImageKeyboard ReturnEdit;

        #endregion

        public ImageForm()
        {
            InitializeComponent();
        }

        private void ChoosePicButton_Click(object sender, EventArgs e)
        {
            // Show the FolderBrowserDialog.  
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                UrlTextBox.Text = openFileDialog1.FileName;
            }
        }

        private void UrlTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UrlTextBox.Text))
            {
                ImagePictureBox.ImageLocation = ".\\IMAGES\\qMark.png";
            }
            else
            {
                ImagePictureBox.ImageLocation = UrlTextBox.Text;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UrlTextBox.Text)) return;

            var newImageKeyboard = new ImageKeyboard(PromptTextBox.Text, UrlTextBox.Text);

            newImageKeyboard.SetGroup(this.BlockNumeric.Value);
            newImageKeyboard.SetSubGroup(this.SubBlockNumeric.Value);

            if (this._existingTrial != null)
            {
                this.ReturnEdit = newImageKeyboard;
            }
            else
            {
                MainForm.AddImageKeyboard(newImageKeyboard);
            }
            Close();
        }
    }
}