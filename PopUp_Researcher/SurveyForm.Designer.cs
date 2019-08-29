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
            this.TextSurveyRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SubGroupNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.GroupNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.ScaleSurveyRadio = new System.Windows.Forms.RadioButton();
            this.MultiSurveyRadio = new System.Windows.Forms.RadioButton();
            this.AddQuestionButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.QuestionsListView = new System.Windows.Forms.ListView();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.DuplicateButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubGroupNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // TextSurveyRadio
            // 
            this.TextSurveyRadio.AutoSize = true;
            this.TextSurveyRadio.Location = new System.Drawing.Point(6, 20);
            this.TextSurveyRadio.Name = "TextSurveyRadio";
            this.TextSurveyRadio.Size = new System.Drawing.Size(82, 17);
            this.TextSurveyRadio.TabIndex = 14;
            this.TextSurveyRadio.TabStop = true;
            this.TextSurveyRadio.Text = "Text Survey";
            this.TextSurveyRadio.UseVisualStyleBackColor = true;
            this.TextSurveyRadio.CheckedChanged += new System.EventHandler(this.TextSurveyRadio_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SubGroupNumeric);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.GroupNumeric);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ScaleSurveyRadio);
            this.groupBox1.Controls.Add(this.MultiSurveyRadio);
            this.groupBox1.Controls.Add(this.TextSurveyRadio);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 112);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Survey type";
            // 
            // SubGroupNumeric
            // 
            this.SubGroupNumeric.Location = new System.Drawing.Point(164, 86);
            this.SubGroupNumeric.Name = "SubGroupNumeric";
            this.SubGroupNumeric.Size = new System.Drawing.Size(51, 20);
            this.SubGroupNumeric.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Sub Group";
            // 
            // GroupNumeric
            // 
            this.GroupNumeric.Location = new System.Drawing.Point(44, 86);
            this.GroupNumeric.Name = "GroupNumeric";
            this.GroupNumeric.Size = new System.Drawing.Size(51, 20);
            this.GroupNumeric.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Group";
            // 
            // ScaleSurveyRadio
            // 
            this.ScaleSurveyRadio.AutoSize = true;
            this.ScaleSurveyRadio.Location = new System.Drawing.Point(6, 65);
            this.ScaleSurveyRadio.Name = "ScaleSurveyRadio";
            this.ScaleSurveyRadio.Size = new System.Drawing.Size(88, 17);
            this.ScaleSurveyRadio.TabIndex = 16;
            this.ScaleSurveyRadio.TabStop = true;
            this.ScaleSurveyRadio.Text = "Scale Survey";
            this.ScaleSurveyRadio.UseVisualStyleBackColor = true;
            this.ScaleSurveyRadio.CheckedChanged += new System.EventHandler(this.ScaleSurveyRadio_CheckedChanged);
            // 
            // MultiSurveyRadio
            // 
            this.MultiSurveyRadio.AutoSize = true;
            this.MultiSurveyRadio.Location = new System.Drawing.Point(6, 43);
            this.MultiSurveyRadio.Name = "MultiSurveyRadio";
            this.MultiSurveyRadio.Size = new System.Drawing.Size(119, 17);
            this.MultiSurveyRadio.TabIndex = 15;
            this.MultiSurveyRadio.TabStop = true;
            this.MultiSurveyRadio.Text = "Multi Choice Survey";
            this.MultiSurveyRadio.UseVisualStyleBackColor = true;
            this.MultiSurveyRadio.CheckedChanged += new System.EventHandler(this.MultiSurveyRadio_CheckedChanged);
            // 
            // AddQuestionButton
            // 
            this.AddQuestionButton.Location = new System.Drawing.Point(8, 396);
            this.AddQuestionButton.Name = "AddQuestionButton";
            this.AddQuestionButton.Size = new System.Drawing.Size(75, 23);
            this.AddQuestionButton.TabIndex = 23;
            this.AddQuestionButton.Text = "Add Question";
            this.AddQuestionButton.UseVisualStyleBackColor = true;
            this.AddQuestionButton.Click += new System.EventHandler(this.AddQuestionButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(251, 396);
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
            this.QuestionsListView.Location = new System.Drawing.Point(6, 130);
            this.QuestionsListView.Name = "QuestionsListView";
            this.QuestionsListView.Size = new System.Drawing.Size(320, 231);
            this.QuestionsListView.TabIndex = 26;
            this.QuestionsListView.UseCompatibleStateImageBehavior = false;
            this.QuestionsListView.View = System.Windows.Forms.View.List;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(251, 367);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 27;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // DuplicateButton
            // 
            this.DuplicateButton.Enabled = false;
            this.DuplicateButton.Location = new System.Drawing.Point(8, 367);
            this.DuplicateButton.Name = "DuplicateButton";
            this.DuplicateButton.Size = new System.Drawing.Size(75, 23);
            this.DuplicateButton.TabIndex = 28;
            this.DuplicateButton.Text = "Duplicate";
            this.DuplicateButton.UseVisualStyleBackColor = true;
            this.DuplicateButton.Click += new System.EventHandler(this.DuplicateButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Location = new System.Drawing.Point(89, 367);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(75, 23);
            this.MinusButton.TabIndex = 29;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.Location = new System.Drawing.Point(170, 367);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(75, 23);
            this.PlusButton.TabIndex = 30;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // SurveyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 427);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.DuplicateButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.QuestionsListView);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AddQuestionButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "SurveyForm";
            this.Text = "Survey";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubGroupNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupNumeric)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.NumericUpDown SubGroupNumeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown GroupNumeric;
        private System.Windows.Forms.Label label1;
    }
}