using System;
using System.Drawing;
using System.IO;
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
        private ImageKeyboard existingTrial;

        /// <summary>
        /// Return value for edit
        /// </summary>
        public ImageKeyboard ReturnEdit;

        #endregion

        public ImageForm(ImageKeyboard existing = null)
        {
            InitializeComponent();

            if(existing == null) { return;}

            this.existingTrial = existing;
            UpdateExistingTrial();
        }

        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            var ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        /// <summary>
        /// Update Existing Trial by this.existingTrial
        /// </summary>
        private void UpdateExistingTrial()
        {
            this.NameTextBox.Text = this.existingTrial.name;
            this.SubBlockNumeric.Value = this.existingTrial.sub_block;
            this.BlockNumeric.Value = this.existingTrial.block;
            this.NameTextBox.Text = this.existingTrial.name;
            PromptTextBox.Text = this.existingTrial.prompt;
            ImagePictureBox.Image = ByteArrayToImage(Convert.FromBase64String(this.existingTrial.ImageBlob));
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

            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                MessageBox.Show("Enter Name");
                return;
            }

            var bytes = File.ReadAllBytes(UrlTextBox.Text);
            var file = Convert.ToBase64String(bytes);
            var newImageKeyboard = new ImageKeyboard(PromptTextBox.Text, file)
            {
                name = NameTextBox.Text
            };
            newImageKeyboard.SetGroup(this.BlockNumeric.Value);
            newImageKeyboard.SetSubGroup(this.SubBlockNumeric.Value);

            if (this.existingTrial != null)
            {
                this.ReturnEdit = newImageKeyboard;
            }
            else
            {
                MainForm.AddImageKeyboard(newImageKeyboard);
            }
            Close();
        }

        private void ImageForm_Load(object sender, EventArgs e)
        {

        }
    }
}
