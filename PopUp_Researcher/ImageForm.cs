using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using PopUp_Researcher.Helpers;

namespace PopUp_Researcher
{
    public partial class ImageForm : Form
    {
        #region Properties

        /// <summary>
        /// Existing trial to edit
        /// </summary>
        private readonly ImageKeyboard _existingTrial;

        /// <summary>
        /// Return value for edit
        /// </summary>
        public ImageButton ReturnEdit;

        #endregion

        public ImageForm(ImageKeyboard existing = null)
        {
            InitializeComponent();

            if(existing == null) { return;}

            this._existingTrial = existing;
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
            this.NameTextBox.Text = this._existingTrial.name;
            this.SubBlockNumeric.Value = this._existingTrial.sub_block;
            this.BlockNumeric.Value = this._existingTrial.block;
            this.NameTextBox.Text = this._existingTrial.name;
            ImagePictureBox.Image = ByteArrayToImage(Convert.FromBase64String(this._existingTrial.ImageBlob));
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
            var newImageButton = new ImageButton(file)
            {
                name = NameTextBox.Text
            };
            newImageButton.SetGroup(this.BlockNumeric.Value);
            newImageButton.SetSubGroup(this.SubBlockNumeric.Value);

            if (this._existingTrial != null)
            {
                this.ReturnEdit = newImageButton;
            }
            else
            {
                MainForm.AddImageKeyboard(newImageButton);
            }
            Close();
        }

        private void ImageForm_Load(object sender, EventArgs e)
        {

        }
    }
}
