namespace PopUp_Researcher
{
    partial class ImageForm
    {
        /// <summary>
        /// required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChoosePicButton = new System.Windows.Forms.Button();
            this.ImagePictureBox = new System.Windows.Forms.PictureBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.PromptTextBox = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.UrlTextBox = new System.Windows.Forms.TextBox();
            this.SubBlockNumeric = new System.Windows.Forms.NumericUpDown();
            this.SubBlockLabel = new System.Windows.Forms.Label();
            this.BlockNumeric = new System.Windows.Forms.NumericUpDown();
            this.BlockLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubBlockNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UrlTextBox);
            this.groupBox1.Controls.Add(this.ChoosePicButton);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pic";
            // 
            // ChoosePicButton
            // 
            this.ChoosePicButton.Location = new System.Drawing.Point(6, 29);
            this.ChoosePicButton.Name = "ChoosePicButton";
            this.ChoosePicButton.Size = new System.Drawing.Size(125, 37);
            this.ChoosePicButton.TabIndex = 0;
            this.ChoosePicButton.Text = "Choose Image";
            this.ChoosePicButton.UseVisualStyleBackColor = true;
            this.ChoosePicButton.Click += new System.EventHandler(this.ChoosePicButton_Click);
            // 
            // ImagePictureBox
            // 
            this.ImagePictureBox.Location = new System.Drawing.Point(588, 24);
            this.ImagePictureBox.Name = "ImagePictureBox";
            this.ImagePictureBox.Size = new System.Drawing.Size(400, 300);
            this.ImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagePictureBox.TabIndex = 1;
            this.ImagePictureBox.TabStop = false;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(860, 330);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(128, 43);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PromptTextBox
            // 
            this.PromptTextBox.Location = new System.Drawing.Point(12, 96);
            this.PromptTextBox.Name = "PromptTextBox";
            this.PromptTextBox.Size = new System.Drawing.Size(570, 228);
            this.PromptTextBox.TabIndex = 3;
            this.PromptTextBox.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image files (*.jpg)|*.jpg";
            // 
            // UrlTextBox
            // 
            this.UrlTextBox.Enabled = false;
            this.UrlTextBox.Location = new System.Drawing.Point(138, 34);
            this.UrlTextBox.Name = "UrlTextBox";
            this.UrlTextBox.Size = new System.Drawing.Size(425, 26);
            this.UrlTextBox.TabIndex = 1;
            this.UrlTextBox.TextChanged += new System.EventHandler(this.UrlTextBox_TextChanged);
            // 
            // SubBlockNumeric
            // 
            this.SubBlockNumeric.Location = new System.Drawing.Point(240, 338);
            this.SubBlockNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubBlockNumeric.Name = "SubBlockNumeric";
            this.SubBlockNumeric.Size = new System.Drawing.Size(76, 26);
            this.SubBlockNumeric.TabIndex = 30;
            // 
            // SubBlockLabel
            // 
            this.SubBlockLabel.AutoSize = true;
            this.SubBlockLabel.Location = new System.Drawing.Point(147, 341);
            this.SubBlockLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SubBlockLabel.Name = "SubBlockLabel";
            this.SubBlockLabel.Size = new System.Drawing.Size(81, 20);
            this.SubBlockLabel.TabIndex = 29;
            this.SubBlockLabel.Text = "Sub Block";
            // 
            // BlockNumeric
            // 
            this.BlockNumeric.Location = new System.Drawing.Point(62, 338);
            this.BlockNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BlockNumeric.Name = "BlockNumeric";
            this.BlockNumeric.Size = new System.Drawing.Size(76, 26);
            this.BlockNumeric.TabIndex = 28;
            // 
            // BlockLabel
            // 
            this.BlockLabel.AutoSize = true;
            this.BlockLabel.Location = new System.Drawing.Point(15, 341);
            this.BlockLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BlockLabel.Name = "BlockLabel";
            this.BlockLabel.Size = new System.Drawing.Size(48, 20);
            this.BlockLabel.TabIndex = 27;
            this.BlockLabel.Text = "Block";
            // 
            // ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 378);
            this.Controls.Add(this.SubBlockNumeric);
            this.Controls.Add(this.SubBlockLabel);
            this.Controls.Add(this.BlockNumeric);
            this.Controls.Add(this.BlockLabel);
            this.Controls.Add(this.PromptTextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ImagePictureBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "ImageForm";
            this.Text = "ImageForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubBlockNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ChoosePicButton;
        private System.Windows.Forms.PictureBox ImagePictureBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.RichTextBox PromptTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox UrlTextBox;
        private System.Windows.Forms.NumericUpDown SubBlockNumeric;
        private System.Windows.Forms.Label SubBlockLabel;
        private System.Windows.Forms.NumericUpDown BlockNumeric;
        private System.Windows.Forms.Label BlockLabel;
    }
}