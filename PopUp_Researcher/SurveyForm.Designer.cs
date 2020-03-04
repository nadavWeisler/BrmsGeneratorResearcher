namespace bRMS_Generator
{
    partial class SurveyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SurveyForm));
            this.TextSurveyRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ScaleSurveyRadio = new System.Windows.Forms.RadioButton();
            this.MultiSurveyRadio = new System.Windows.Forms.RadioButton();
            this.AddQuestionButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.QuestionsListView = new System.Windows.Forms.ListView();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.DuplicateButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.SubBlockNumeric = new System.Windows.Forms.NumericUpDown();
            this.SubBlockLabel = new System.Windows.Forms.Label();
            this.BlockNumeric = new System.Windows.Forms.NumericUpDown();
            this.BlockLabel = new System.Windows.Forms.Label();
            this.NameGroupBox = new System.Windows.Forms.GroupBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ScaleCustomRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubBlockNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockNumeric)).BeginInit();
            this.NameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextSurveyRadio
            // 
            this.TextSurveyRadio.AutoSize = true;
            this.TextSurveyRadio.Location = new System.Drawing.Point(9, 31);
            this.TextSurveyRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextSurveyRadio.Name = "TextSurveyRadio";
            this.TextSurveyRadio.Size = new System.Drawing.Size(64, 24);
            this.TextSurveyRadio.TabIndex = 14;
            this.TextSurveyRadio.TabStop = true;
            this.TextSurveyRadio.Text = "Text";
            this.TextSurveyRadio.UseVisualStyleBackColor = true;
            this.TextSurveyRadio.CheckedChanged += new System.EventHandler(this.TextSurveyRadio_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ScaleCustomRadio);
            this.groupBox1.Controls.Add(this.ScaleSurveyRadio);
            this.groupBox1.Controls.Add(this.MultiSurveyRadio);
            this.groupBox1.Controls.Add(this.TextSurveyRadio);
            this.groupBox1.Location = new System.Drawing.Point(13, 98);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(460, 74);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Survey type";
            // 
            // ScaleSurveyRadio
            // 
            this.ScaleSurveyRadio.AutoSize = true;
            this.ScaleSurveyRadio.Location = new System.Drawing.Point(209, 31);
            this.ScaleSurveyRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScaleSurveyRadio.Name = "ScaleSurveyRadio";
            this.ScaleSurveyRadio.Size = new System.Drawing.Size(74, 24);
            this.ScaleSurveyRadio.TabIndex = 16;
            this.ScaleSurveyRadio.TabStop = true;
            this.ScaleSurveyRadio.Text = "Scale";
            this.ScaleSurveyRadio.UseVisualStyleBackColor = true;
            this.ScaleSurveyRadio.CheckedChanged += new System.EventHandler(this.ScaleSurveyRadio_CheckedChanged);
            // 
            // MultiSurveyRadio
            // 
            this.MultiSurveyRadio.AutoSize = true;
            this.MultiSurveyRadio.Location = new System.Drawing.Point(81, 31);
            this.MultiSurveyRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MultiSurveyRadio.Name = "MultiSurveyRadio";
            this.MultiSurveyRadio.Size = new System.Drawing.Size(120, 24);
            this.MultiSurveyRadio.TabIndex = 15;
            this.MultiSurveyRadio.TabStop = true;
            this.MultiSurveyRadio.Text = "Multi Choice";
            this.MultiSurveyRadio.UseVisualStyleBackColor = true;
            this.MultiSurveyRadio.CheckedChanged += new System.EventHandler(this.MultiSurveyRadio_CheckedChanged);
            // 
            // AddQuestionButton
            // 
            this.AddQuestionButton.Location = new System.Drawing.Point(350, 177);
            this.AddQuestionButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddQuestionButton.Name = "AddQuestionButton";
            this.AddQuestionButton.Size = new System.Drawing.Size(123, 35);
            this.AddQuestionButton.TabIndex = 23;
            this.AddQuestionButton.Text = "Add Question";
            this.AddQuestionButton.UseVisualStyleBackColor = true;
            this.AddQuestionButton.Click += new System.EventHandler(this.AddQuestionButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(361, 645);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(112, 35);
            this.SaveButton.TabIndex = 25;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // QuestionsListView
            // 
            this.QuestionsListView.HideSelection = false;
            this.QuestionsListView.Location = new System.Drawing.Point(13, 222);
            this.QuestionsListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.QuestionsListView.Name = "QuestionsListView";
            this.QuestionsListView.Size = new System.Drawing.Size(458, 412);
            this.QuestionsListView.TabIndex = 26;
            this.QuestionsListView.UseCompatibleStateImageBehavior = false;
            this.QuestionsListView.View = System.Windows.Forms.View.List;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(242, 645);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(112, 35);
            this.RemoveButton.TabIndex = 27;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // DuplicateButton
            // 
            this.DuplicateButton.Location = new System.Drawing.Point(13, 645);
            this.DuplicateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DuplicateButton.Name = "DuplicateButton";
            this.DuplicateButton.Size = new System.Drawing.Size(112, 35);
            this.DuplicateButton.TabIndex = 28;
            this.DuplicateButton.Text = "Duplicate";
            this.DuplicateButton.UseVisualStyleBackColor = true;
            this.DuplicateButton.Click += new System.EventHandler(this.DuplicateButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Location = new System.Drawing.Point(188, 645);
            this.MinusButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(45, 35);
            this.MinusButton.TabIndex = 29;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.Location = new System.Drawing.Point(134, 645);
            this.PlusButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(45, 35);
            this.PlusButton.TabIndex = 30;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // SubBlockNumeric
            // 
            this.SubBlockNumeric.Location = new System.Drawing.Point(258, 182);
            this.SubBlockNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubBlockNumeric.Name = "SubBlockNumeric";
            this.SubBlockNumeric.Size = new System.Drawing.Size(76, 26);
            this.SubBlockNumeric.TabIndex = 34;
            // 
            // SubBlockLabel
            // 
            this.SubBlockLabel.AutoSize = true;
            this.SubBlockLabel.Location = new System.Drawing.Point(162, 185);
            this.SubBlockLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SubBlockLabel.Name = "SubBlockLabel";
            this.SubBlockLabel.Size = new System.Drawing.Size(81, 20);
            this.SubBlockLabel.TabIndex = 33;
            this.SubBlockLabel.Text = "Sub Block";
            // 
            // BlockNumeric
            // 
            this.BlockNumeric.Location = new System.Drawing.Point(78, 182);
            this.BlockNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BlockNumeric.Name = "BlockNumeric";
            this.BlockNumeric.Size = new System.Drawing.Size(76, 26);
            this.BlockNumeric.TabIndex = 32;
            // 
            // BlockLabel
            // 
            this.BlockLabel.AutoSize = true;
            this.BlockLabel.Location = new System.Drawing.Point(14, 185);
            this.BlockLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BlockLabel.Name = "BlockLabel";
            this.BlockLabel.Size = new System.Drawing.Size(48, 20);
            this.BlockLabel.TabIndex = 31;
            this.BlockLabel.Text = "Block";
            // 
            // NameGroupBox
            // 
            this.NameGroupBox.Controls.Add(this.NameTextBox);
            this.NameGroupBox.Location = new System.Drawing.Point(13, 18);
            this.NameGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameGroupBox.Name = "NameGroupBox";
            this.NameGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameGroupBox.Size = new System.Drawing.Size(460, 70);
            this.NameGroupBox.TabIndex = 35;
            this.NameGroupBox.TabStop = false;
            this.NameGroupBox.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(9, 27);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(439, 26);
            this.NameTextBox.TabIndex = 0;
            // 
            // ScaleCustomRadio
            // 
            this.ScaleCustomRadio.AutoSize = true;
            this.ScaleCustomRadio.Location = new System.Drawing.Point(291, 31);
            this.ScaleCustomRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScaleCustomRadio.Name = "ScaleCustomRadio";
            this.ScaleCustomRadio.Size = new System.Drawing.Size(133, 24);
            this.ScaleCustomRadio.TabIndex = 17;
            this.ScaleCustomRadio.TabStop = true;
            this.ScaleCustomRadio.Text = "Scale Custom";
            this.ScaleCustomRadio.UseVisualStyleBackColor = true;
            // 
            // SurveyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 685);
            this.Controls.Add(this.NameGroupBox);
            this.Controls.Add(this.SubBlockNumeric);
            this.Controls.Add(this.SubBlockLabel);
            this.Controls.Add(this.BlockNumeric);
            this.Controls.Add(this.BlockLabel);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.DuplicateButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.QuestionsListView);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AddQuestionButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SurveyForm";
            this.Text = "Survey";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubBlockNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockNumeric)).EndInit();
            this.NameGroupBox.ResumeLayout(false);
            this.NameGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton TextSurveyRadio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ScaleSurveyRadio;
        private System.Windows.Forms.RadioButton MultiSurveyRadio;
        private System.Windows.Forms.Button AddQuestionButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ListView QuestionsListView;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button DuplicateButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.NumericUpDown SubBlockNumeric;
        private System.Windows.Forms.Label SubBlockLabel;
        private System.Windows.Forms.NumericUpDown BlockNumeric;
        private System.Windows.Forms.Label BlockLabel;
        private System.Windows.Forms.GroupBox NameGroupBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.RadioButton ScaleCustomRadio;
    }
}