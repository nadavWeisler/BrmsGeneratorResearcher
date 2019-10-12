namespace bRMS_Generator
{
    partial class QuestionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionForm));
            this.PromptGroup = new System.Windows.Forms.GroupBox();
            this.PromptRichTextBox = new System.Windows.Forms.RichTextBox();
            this.TextGroupBox = new System.Windows.Forms.GroupBox();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.ColsLabel = new System.Windows.Forms.Label();
            this.RowsLabel = new System.Windows.Forms.Label();
            this.ColsNumeric = new System.Windows.Forms.NumericUpDown();
            this.RowsNumeric = new System.Windows.Forms.NumericUpDown();
            this.RequiredCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ScaleGroupBox = new System.Windows.Forms.GroupBox();
            this.EndLabel = new System.Windows.Forms.Label();
            this.EndLabelText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MiddleLabelText = new System.Windows.Forms.TextBox();
            this.ScaleCountLabel = new System.Windows.Forms.Label();
            this.StartLabel = new System.Windows.Forms.Label();
            this.ScaleNumeric = new System.Windows.Forms.NumericUpDown();
            this.StartLabelText = new System.Windows.Forms.TextBox();
            this.OptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.MinusButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.DuplicateButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.AddOptionButton = new System.Windows.Forms.Button();
            this.OptionsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PromptGroup.SuspendLayout();
            this.TextGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowsNumeric)).BeginInit();
            this.ScaleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleNumeric)).BeginInit();
            this.OptionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PromptGroup
            // 
            this.PromptGroup.Controls.Add(this.PromptRichTextBox);
            this.PromptGroup.Location = new System.Drawing.Point(12, 15);
            this.PromptGroup.Name = "PromptGroup";
            this.PromptGroup.Size = new System.Drawing.Size(393, 218);
            this.PromptGroup.TabIndex = 27;
            this.PromptGroup.TabStop = false;
            this.PromptGroup.Text = "Prompt";
            // 
            // PromptRichTextBox
            // 
            this.PromptRichTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.PromptRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PromptRichTextBox.Location = new System.Drawing.Point(3, 16);
            this.PromptRichTextBox.Name = "PromptRichTextBox";
            this.PromptRichTextBox.ShowSelectionMargin = true;
            this.PromptRichTextBox.Size = new System.Drawing.Size(387, 199);
            this.PromptRichTextBox.TabIndex = 0;
            this.PromptRichTextBox.Text = "";
            // 
            // TextGroupBox
            // 
            this.TextGroupBox.Controls.Add(this.ValueTextBox);
            this.TextGroupBox.Controls.Add(this.ValueLabel);
            this.TextGroupBox.Controls.Add(this.ColsLabel);
            this.TextGroupBox.Controls.Add(this.RowsLabel);
            this.TextGroupBox.Controls.Add(this.ColsNumeric);
            this.TextGroupBox.Controls.Add(this.RowsNumeric);
            this.TextGroupBox.Location = new System.Drawing.Point(210, 239);
            this.TextGroupBox.Name = "TextGroupBox";
            this.TextGroupBox.Size = new System.Drawing.Size(195, 153);
            this.TextGroupBox.TabIndex = 28;
            this.TextGroupBox.TabStop = false;
            this.TextGroupBox.Text = "Text";
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Location = new System.Drawing.Point(73, 70);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.ValueTextBox.TabIndex = 33;
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(6, 70);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(34, 13);
            this.ValueLabel.TabIndex = 32;
            this.ValueLabel.Text = "Value";
            // 
            // ColsLabel
            // 
            this.ColsLabel.AutoSize = true;
            this.ColsLabel.Location = new System.Drawing.Point(6, 46);
            this.ColsLabel.Name = "ColsLabel";
            this.ColsLabel.Size = new System.Drawing.Size(47, 13);
            this.ColsLabel.TabIndex = 31;
            this.ColsLabel.Text = "Columns";
            // 
            // RowsLabel
            // 
            this.RowsLabel.AutoSize = true;
            this.RowsLabel.Location = new System.Drawing.Point(6, 20);
            this.RowsLabel.Name = "RowsLabel";
            this.RowsLabel.Size = new System.Drawing.Size(34, 13);
            this.RowsLabel.TabIndex = 30;
            this.RowsLabel.Text = "Rows";
            // 
            // ColsNumeric
            // 
            this.ColsNumeric.Location = new System.Drawing.Point(73, 44);
            this.ColsNumeric.Name = "ColsNumeric";
            this.ColsNumeric.Size = new System.Drawing.Size(100, 20);
            this.ColsNumeric.TabIndex = 24;
            this.ColsNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // RowsNumeric
            // 
            this.RowsNumeric.Location = new System.Drawing.Point(72, 18);
            this.RowsNumeric.Name = "RowsNumeric";
            this.RowsNumeric.Size = new System.Drawing.Size(101, 20);
            this.RowsNumeric.TabIndex = 25;
            this.RowsNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // RequiredCheckBox
            // 
            this.RequiredCheckBox.AutoSize = true;
            this.RequiredCheckBox.Checked = true;
            this.RequiredCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RequiredCheckBox.Location = new System.Drawing.Point(521, 402);
            this.RequiredCheckBox.Name = "RequiredCheckBox";
            this.RequiredCheckBox.Size = new System.Drawing.Size(69, 17);
            this.RequiredCheckBox.TabIndex = 29;
            this.RequiredCheckBox.Text = "Required";
            this.RequiredCheckBox.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(596, 398);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 30;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ScaleGroupBox
            // 
            this.ScaleGroupBox.Controls.Add(this.EndLabel);
            this.ScaleGroupBox.Controls.Add(this.EndLabelText);
            this.ScaleGroupBox.Controls.Add(this.label5);
            this.ScaleGroupBox.Controls.Add(this.MiddleLabelText);
            this.ScaleGroupBox.Controls.Add(this.ScaleCountLabel);
            this.ScaleGroupBox.Controls.Add(this.StartLabel);
            this.ScaleGroupBox.Controls.Add(this.ScaleNumeric);
            this.ScaleGroupBox.Controls.Add(this.StartLabelText);
            this.ScaleGroupBox.Location = new System.Drawing.Point(12, 239);
            this.ScaleGroupBox.Name = "ScaleGroupBox";
            this.ScaleGroupBox.Size = new System.Drawing.Size(192, 153);
            this.ScaleGroupBox.TabIndex = 31;
            this.ScaleGroupBox.TabStop = false;
            this.ScaleGroupBox.Text = "Scale";
            // 
            // EndLabel
            // 
            this.EndLabel.AutoSize = true;
            this.EndLabel.Location = new System.Drawing.Point(6, 99);
            this.EndLabel.Name = "EndLabel";
            this.EndLabel.Size = new System.Drawing.Size(55, 13);
            this.EndLabel.TabIndex = 40;
            this.EndLabel.Text = "End Label";
            // 
            // EndLabelText
            // 
            this.EndLabelText.Location = new System.Drawing.Point(79, 96);
            this.EndLabelText.Name = "EndLabelText";
            this.EndLabelText.Size = new System.Drawing.Size(100, 20);
            this.EndLabelText.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Middle Label";
            // 
            // MiddleLabelText
            // 
            this.MiddleLabelText.Location = new System.Drawing.Point(79, 69);
            this.MiddleLabelText.Name = "MiddleLabelText";
            this.MiddleLabelText.Size = new System.Drawing.Size(100, 20);
            this.MiddleLabelText.TabIndex = 37;
            // 
            // ScaleCountLabel
            // 
            this.ScaleCountLabel.AutoSize = true;
            this.ScaleCountLabel.Location = new System.Drawing.Point(6, 19);
            this.ScaleCountLabel.Name = "ScaleCountLabel";
            this.ScaleCountLabel.Size = new System.Drawing.Size(65, 13);
            this.ScaleCountLabel.TabIndex = 36;
            this.ScaleCountLabel.Text = "Scale Count";
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Location = new System.Drawing.Point(6, 47);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(58, 13);
            this.StartLabel.TabIndex = 33;
            this.StartLabel.Text = "Start Label";
            // 
            // ScaleNumeric
            // 
            this.ScaleNumeric.Location = new System.Drawing.Point(79, 17);
            this.ScaleNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ScaleNumeric.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.ScaleNumeric.Name = "ScaleNumeric";
            this.ScaleNumeric.Size = new System.Drawing.Size(100, 20);
            this.ScaleNumeric.TabIndex = 32;
            this.ScaleNumeric.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // StartLabelText
            // 
            this.StartLabelText.Location = new System.Drawing.Point(79, 43);
            this.StartLabelText.Name = "StartLabelText";
            this.StartLabelText.Size = new System.Drawing.Size(100, 20);
            this.StartLabelText.TabIndex = 31;
            // 
            // OptionsGroupBox
            // 
            this.OptionsGroupBox.Controls.Add(this.MinusButton);
            this.OptionsGroupBox.Controls.Add(this.PlusButton);
            this.OptionsGroupBox.Controls.Add(this.RemoveButton);
            this.OptionsGroupBox.Controls.Add(this.DuplicateButton);
            this.OptionsGroupBox.Controls.Add(this.listView1);
            this.OptionsGroupBox.Controls.Add(this.AddOptionButton);
            this.OptionsGroupBox.Controls.Add(this.OptionsTextBox);
            this.OptionsGroupBox.Controls.Add(this.label1);
            this.OptionsGroupBox.Location = new System.Drawing.Point(411, 12);
            this.OptionsGroupBox.Name = "OptionsGroupBox";
            this.OptionsGroupBox.Size = new System.Drawing.Size(271, 380);
            this.OptionsGroupBox.TabIndex = 33;
            this.OptionsGroupBox.TabStop = false;
            this.OptionsGroupBox.Text = "Options";
            // 
            // MinusButton
            // 
            this.MinusButton.Location = new System.Drawing.Point(86, 351);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(45, 23);
            this.MinusButton.TabIndex = 41;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.Location = new System.Drawing.Point(137, 351);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(45, 23);
            this.PlusButton.TabIndex = 40;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(185, 351);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 39;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // DuplicateButton
            // 
            this.DuplicateButton.Location = new System.Drawing.Point(5, 351);
            this.DuplicateButton.Name = "DuplicateButton";
            this.DuplicateButton.Size = new System.Drawing.Size(75, 23);
            this.DuplicateButton.TabIndex = 38;
            this.DuplicateButton.Text = "Duplicate";
            this.DuplicateButton.UseVisualStyleBackColor = true;
            this.DuplicateButton.Click += new System.EventHandler(this.DuplicateButton_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(7, 82);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(258, 263);
            this.listView1.TabIndex = 37;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // AddOptionButton
            // 
            this.AddOptionButton.Location = new System.Drawing.Point(185, 47);
            this.AddOptionButton.Name = "AddOptionButton";
            this.AddOptionButton.Size = new System.Drawing.Size(75, 23);
            this.AddOptionButton.TabIndex = 36;
            this.AddOptionButton.Text = "Add";
            this.AddOptionButton.UseVisualStyleBackColor = true;
            this.AddOptionButton.Click += new System.EventHandler(this.AddOptionButton_Click);
            // 
            // OptionsTextBox
            // 
            this.OptionsTextBox.Location = new System.Drawing.Point(51, 17);
            this.OptionsTextBox.Name = "OptionsTextBox";
            this.OptionsTextBox.Size = new System.Drawing.Size(209, 20);
            this.OptionsTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Option";
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 436);
            this.Controls.Add(this.OptionsGroupBox);
            this.Controls.Add(this.ScaleGroupBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.TextGroupBox);
            this.Controls.Add(this.PromptGroup);
            this.Controls.Add(this.RequiredCheckBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuestionForm";
            this.Text = "Questions";
            this.PromptGroup.ResumeLayout(false);
            this.TextGroupBox.ResumeLayout(false);
            this.TextGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowsNumeric)).EndInit();
            this.ScaleGroupBox.ResumeLayout(false);
            this.ScaleGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleNumeric)).EndInit();
            this.OptionsGroupBox.ResumeLayout(false);
            this.OptionsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox PromptGroup;
        private System.Windows.Forms.RichTextBox PromptRichTextBox;
        private System.Windows.Forms.GroupBox TextGroupBox;
        private System.Windows.Forms.TextBox ValueTextBox;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Label ColsLabel;
        private System.Windows.Forms.Label RowsLabel;
        private System.Windows.Forms.NumericUpDown ColsNumeric;
        private System.Windows.Forms.NumericUpDown RowsNumeric;
        private System.Windows.Forms.CheckBox RequiredCheckBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.GroupBox ScaleGroupBox;
        private System.Windows.Forms.Label EndLabel;
        private System.Windows.Forms.TextBox EndLabelText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MiddleLabelText;
        private System.Windows.Forms.Label ScaleCountLabel;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.NumericUpDown ScaleNumeric;
        private System.Windows.Forms.TextBox StartLabelText;
        private System.Windows.Forms.GroupBox OptionsGroupBox;
        private System.Windows.Forms.Button AddOptionButton;
        private System.Windows.Forms.TextBox OptionsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button DuplicateButton;
    }
}