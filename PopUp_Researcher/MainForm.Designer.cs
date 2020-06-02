namespace PopUp_Researcher
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.bRMS_button = new System.Windows.Forms.Button();
            this.introButton = new System.Windows.Forms.Button();
            this.surveyButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.TrialsButtonGroup = new System.Windows.Forms.GroupBox();
            this.ImageButton = new System.Windows.Forms.Button();
            this.FullscreenButton = new System.Windows.Forms.Button();
            this.SaveButtonGroup = new System.Windows.Forms.GroupBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.TrialsListView = new System.Windows.Forms.ListView();
            this.LoadButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MinusButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BackgoundRgbTextBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.TrialsButtonGroup.SuspendLayout();
            this.SaveButtonGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Location = new System.Drawing.Point(18, 14);
            this.HeaderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(51, 20);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "Name";
            // 
            // bRMS_button
            // 
            this.bRMS_button.Location = new System.Drawing.Point(15, 74);
            this.bRMS_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bRMS_button.Name = "bRMS_button";
            this.bRMS_button.Size = new System.Drawing.Size(112, 35);
            this.bRMS_button.TabIndex = 2;
            this.bRMS_button.Text = "bRMS";
            this.bRMS_button.UseVisualStyleBackColor = true;
            this.bRMS_button.Click += new System.EventHandler(this.BRms_button_Click);
            // 
            // introButton
            // 
            this.introButton.Location = new System.Drawing.Point(135, 74);
            this.introButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.introButton.Name = "introButton";
            this.introButton.Size = new System.Drawing.Size(112, 35);
            this.introButton.TabIndex = 3;
            this.introButton.Text = "Instructions";
            this.introButton.UseVisualStyleBackColor = true;
            this.introButton.Click += new System.EventHandler(this.IntroButton_Click);
            // 
            // surveyButton
            // 
            this.surveyButton.Location = new System.Drawing.Point(15, 29);
            this.surveyButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.surveyButton.Name = "surveyButton";
            this.surveyButton.Size = new System.Drawing.Size(112, 35);
            this.surveyButton.TabIndex = 4;
            this.surveyButton.Text = "Survey";
            this.surveyButton.UseVisualStyleBackColor = true;
            this.surveyButton.Click += new System.EventHandler(this.SurveyButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(15, 79);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(112, 35);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(15, 34);
            this.removeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(112, 35);
            this.removeButton.TabIndex = 6;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // TrialsButtonGroup
            // 
            this.TrialsButtonGroup.Controls.Add(this.ImageButton);
            this.TrialsButtonGroup.Controls.Add(this.FullscreenButton);
            this.TrialsButtonGroup.Controls.Add(this.bRMS_button);
            this.TrialsButtonGroup.Controls.Add(this.introButton);
            this.TrialsButtonGroup.Controls.Add(this.surveyButton);
            this.TrialsButtonGroup.Location = new System.Drawing.Point(538, 49);
            this.TrialsButtonGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TrialsButtonGroup.Name = "TrialsButtonGroup";
            this.TrialsButtonGroup.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TrialsButtonGroup.Size = new System.Drawing.Size(257, 165);
            this.TrialsButtonGroup.TabIndex = 8;
            this.TrialsButtonGroup.TabStop = false;
            this.TrialsButtonGroup.Text = "Experiments";
            // 
            // ImageButton
            // 
            this.ImageButton.Location = new System.Drawing.Point(15, 119);
            this.ImageButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ImageButton.Name = "ImageButton";
            this.ImageButton.Size = new System.Drawing.Size(112, 35);
            this.ImageButton.TabIndex = 6;
            this.ImageButton.Text = "Image";
            this.ImageButton.UseVisualStyleBackColor = true;
            this.ImageButton.Click += new System.EventHandler(this.ImageButton_Click);
            // 
            // FullscreenButton
            // 
            this.FullscreenButton.Location = new System.Drawing.Point(135, 29);
            this.FullscreenButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FullscreenButton.Name = "FullscreenButton";
            this.FullscreenButton.Size = new System.Drawing.Size(112, 35);
            this.FullscreenButton.TabIndex = 5;
            this.FullscreenButton.Text = "Fullscreen";
            this.FullscreenButton.UseVisualStyleBackColor = true;
            this.FullscreenButton.Click += new System.EventHandler(this.FullscreenButton_Click);
            // 
            // SaveButtonGroup
            // 
            this.SaveButtonGroup.Controls.Add(this.EditButton);
            this.SaveButtonGroup.Controls.Add(this.saveButton);
            this.SaveButtonGroup.Controls.Add(this.removeButton);
            this.SaveButtonGroup.Location = new System.Drawing.Point(535, 314);
            this.SaveButtonGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveButtonGroup.Name = "SaveButtonGroup";
            this.SaveButtonGroup.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveButtonGroup.Size = new System.Drawing.Size(260, 126);
            this.SaveButtonGroup.TabIndex = 9;
            this.SaveButtonGroup.TabStop = false;
            this.SaveButtonGroup.Text = "Save";
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(135, 34);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(112, 35);
            this.EditButton.TabIndex = 7;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(80, 9);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameTextBox.MaxLength = 20;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(448, 26);
            this.NameTextBox.TabIndex = 10;
            // 
            // TrialsListView
            // 
            this.TrialsListView.HideSelection = false;
            this.TrialsListView.Location = new System.Drawing.Point(22, 49);
            this.TrialsListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TrialsListView.Name = "TrialsListView";
            this.TrialsListView.Size = new System.Drawing.Size(505, 391);
            this.TrialsListView.TabIndex = 11;
            this.TrialsListView.UseCompatibleStateImageBehavior = false;
            this.TrialsListView.View = System.Windows.Forms.View.List;
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(554, 6);
            this.LoadButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(112, 35);
            this.LoadButton.TabIndex = 6;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JSON files (*.json)|*.json";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MinusButton);
            this.groupBox1.Controls.Add(this.PlusButton);
            this.groupBox1.Location = new System.Drawing.Point(538, 224);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(257, 80);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navigation";
            // 
            // MinusButton
            // 
            this.MinusButton.Location = new System.Drawing.Point(135, 29);
            this.MinusButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(112, 35);
            this.MinusButton.TabIndex = 7;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.Location = new System.Drawing.Point(15, 29);
            this.PlusButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(112, 35);
            this.PlusButton.TabIndex = 6;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BackgoundRgbTextBox);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Location = new System.Drawing.Point(22, 448);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(763, 65);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parameters";
            // 
            // BackgoundRgbTextBox
            // 
            this.BackgoundRgbTextBox.Location = new System.Drawing.Point(269, 28);
            this.BackgoundRgbTextBox.MaxLength = 7;
            this.BackgoundRgbTextBox.Name = "BackgoundRgbTextBox";
            this.BackgoundRgbTextBox.Size = new System.Drawing.Size(100, 26);
            this.BackgoundRgbTextBox.TabIndex = 71;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 31);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(255, 20);
            this.label19.TabIndex = 70;
            this.label19.Text = "Background Color (RGB Include #)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 525);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.TrialsListView);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.SaveButtonGroup);
            this.Controls.Add(this.TrialsButtonGroup);
            this.Controls.Add(this.HeaderLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Main";
            this.TrialsButtonGroup.ResumeLayout(false);
            this.SaveButtonGroup.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Button bRMS_button;
        private System.Windows.Forms.Button introButton;
        private System.Windows.Forms.Button surveyButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.GroupBox TrialsButtonGroup;
        private System.Windows.Forms.GroupBox SaveButtonGroup;
        private System.Windows.Forms.Button FullscreenButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ListView TrialsListView;
        private System.Windows.Forms.Button LoadButton
            ;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button ImageButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox BackgoundRgbTextBox;
    }
}

