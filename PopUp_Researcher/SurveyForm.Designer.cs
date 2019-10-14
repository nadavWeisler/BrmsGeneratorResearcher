namespace bRMS_Generator
{
    partial class SurveyForm
    {
        /// <summary>
        /// Required designer variable.
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
        /// Required method for Designer support - do not modify
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubBlockNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // TextSurveyRadio
            // 
            this.TextSurveyRadio.AutoSize = true;
            this.TextSurveyRadio.Location = new System.Drawing.Point(6, 20);
            this.TextSurveyRadio.Name = "TextSurveyRadio";
            this.TextSurveyRadio.Size = new System.Drawing.Size(46, 17);
            this.TextSurveyRadio.TabIndex = 14;
            this.TextSurveyRadio.TabStop = true;
            this.TextSurveyRadio.Text = "Text";
            this.TextSurveyRadio.UseVisualStyleBackColor = true;
            this.TextSurveyRadio.CheckedChanged += new System.EventHandler(this.TextSurveyRadio_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ScaleSurveyRadio);
            this.groupBox1.Controls.Add(this.MultiSurveyRadio);
            this.groupBox1.Controls.Add(this.TextSurveyRadio);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 48);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Survey type";
            // 
            // ScaleSurveyRadio
            // 
            this.ScaleSurveyRadio.AutoSize = true;
            this.ScaleSurveyRadio.Location = new System.Drawing.Point(219, 19);
            this.ScaleSurveyRadio.Name = "ScaleSurveyRadio";
            this.ScaleSurveyRadio.Size = new System.Drawing.Size(52, 17);
            this.ScaleSurveyRadio.TabIndex = 16;
            this.ScaleSurveyRadio.TabStop = true;
            this.ScaleSurveyRadio.Text = "Scale";
            this.ScaleSurveyRadio.UseVisualStyleBackColor = true;
            this.ScaleSurveyRadio.CheckedChanged += new System.EventHandler(this.ScaleSurveyRadio_CheckedChanged);
            // 
            // MultiSurveyRadio
            // 
            this.MultiSurveyRadio.AutoSize = true;
            this.MultiSurveyRadio.Location = new System.Drawing.Point(94, 20);
            this.MultiSurveyRadio.Name = "MultiSurveyRadio";
            this.MultiSurveyRadio.Size = new System.Drawing.Size(83, 17);
            this.MultiSurveyRadio.TabIndex = 15;
            this.MultiSurveyRadio.TabStop = true;
            this.MultiSurveyRadio.Text = "Multi Choice";
            this.MultiSurveyRadio.UseVisualStyleBackColor = true;
            this.MultiSurveyRadio.CheckedChanged += new System.EventHandler(this.MultiSurveyRadio_CheckedChanged);
            // 
            // AddQuestionButton
            // 
            this.AddQuestionButton.Location = new System.Drawing.Point(231, 63);
            this.AddQuestionButton.Name = "AddQuestionButton";
            this.AddQuestionButton.Size = new System.Drawing.Size(82, 23);
            this.AddQuestionButton.TabIndex = 23;
            this.AddQuestionButton.Text = "Add Question";
            this.AddQuestionButton.UseVisualStyleBackColor = true;
            this.AddQuestionButton.Click += new System.EventHandler(this.AddQuestionButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(238, 367);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 25;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // QuestionsListView
            // 
            this.QuestionsListView.HideSelection = false;
            this.QuestionsListView.Location = new System.Drawing.Point(6, 92);
            this.QuestionsListView.Name = "QuestionsListView";
            this.QuestionsListView.Size = new System.Drawing.Size(307, 269);
            this.QuestionsListView.TabIndex = 26;
            this.QuestionsListView.UseCompatibleStateImageBehavior = false;
            this.QuestionsListView.View = System.Windows.Forms.View.List;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(159, 367);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 27;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // DuplicateButton
            // 
            this.DuplicateButton.Location = new System.Drawing.Point(6, 367);
            this.DuplicateButton.Name = "DuplicateButton";
            this.DuplicateButton.Size = new System.Drawing.Size(75, 23);
            this.DuplicateButton.TabIndex = 28;
            this.DuplicateButton.Text = "Duplicate";
            this.DuplicateButton.UseVisualStyleBackColor = true;
            this.DuplicateButton.Click += new System.EventHandler(this.DuplicateButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Location = new System.Drawing.Point(123, 367);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(30, 23);
            this.MinusButton.TabIndex = 29;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.Location = new System.Drawing.Point(87, 367);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(30, 23);
            this.PlusButton.TabIndex = 30;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // SubBlockNumeric
            // 
            this.SubBlockNumeric.Location = new System.Drawing.Point(169, 66);
            this.SubBlockNumeric.Name = "SubBlockNumeric";
            this.SubBlockNumeric.Size = new System.Drawing.Size(51, 20);
            this.SubBlockNumeric.TabIndex = 34;
            // 
            // SubBlockLabel
            // 
            this.SubBlockLabel.AutoSize = true;
            this.SubBlockLabel.Location = new System.Drawing.Point(105, 68);
            this.SubBlockLabel.Name = "SubBlockLabel";
            this.SubBlockLabel.Size = new System.Drawing.Size(56, 13);
            this.SubBlockLabel.TabIndex = 33;
            this.SubBlockLabel.Text = "Sub Block";
            // 
            // BlockNumeric
            // 
            this.BlockNumeric.Location = new System.Drawing.Point(49, 66);
            this.BlockNumeric.Name = "BlockNumeric";
            this.BlockNumeric.Size = new System.Drawing.Size(51, 20);
            this.BlockNumeric.TabIndex = 32;
            // 
            // BlockLabel
            // 
            this.BlockLabel.AutoSize = true;
            this.BlockLabel.Location = new System.Drawing.Point(7, 68);
            this.BlockLabel.Name = "BlockLabel";
            this.BlockLabel.Size = new System.Drawing.Size(34, 13);
            this.BlockLabel.TabIndex = 31;
            this.BlockLabel.Text = "Block";
            // 
            // SurveyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 394);
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
            this.Name = "SurveyForm";
            this.Text = "Survey";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubBlockNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockNumeric)).EndInit();
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
    }
}