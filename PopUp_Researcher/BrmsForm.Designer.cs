using System.Windows.Forms;

namespace bRMS_Generator
{
    partial class BrmsForm : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrmsForm));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.StimulusGroup = new System.Windows.Forms.GroupBox();
            this.HelpCsvButton = new System.Windows.Forms.Button();
            this.HelpCsvLabel = new System.Windows.Forms.Label();
            this.HelpCsvTextBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.AllTrialsListView = new System.Windows.Forms.ListView();
            this.AllBRMSGroupBox = new System.Windows.Forms.GroupBox();
            this.UpButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.DuplicateButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.ParamsGroupBox = new System.Windows.Forms.GroupBox();
            this.TagsGroupBox = new System.Windows.Forms.GroupBox();
            this.TagsListView = new System.Windows.Forms.ListView();
            this.OrderGroup = new System.Windows.Forms.GroupBox();
            this.PlusButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.OrderlistView = new System.Windows.Forms.ListView();
            this.FrameHeightNumeric = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.FrameWidthNumeric = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.StopMessageRichTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PerformanceMessageRchTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BreakMessageRichTextBox = new System.Windows.Forms.RichTextBox();
            this.AllowedToRepeatNumeric = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.PerformanceNumeric = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.RectHeightNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.RectWithNumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.FadeOutLengthNumeric = new System.Windows.Forms.NumericUpDown();
            this.TrialLimitNumeric = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.MondrianMaxOpacityNumeric = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StimulusMaxOpacityNumeric = new System.Windows.Forms.NumericUpDown();
            this.OriantetionComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TypeGroupBox = new System.Windows.Forms.GroupBox();
            this.SubBlockNumeric = new System.Windows.Forms.NumericUpDown();
            this.SubBlockLabel = new System.Windows.Forms.Label();
            this.BlockNumeric = new System.Windows.Forms.NumericUpDown();
            this.BlockLabel = new System.Windows.Forms.Label();
            this.RandomRadio = new System.Windows.Forms.RadioButton();
            this.OrderdRadio = new System.Windows.Forms.RadioButton();
            this.MixedRadio = new System.Windows.Forms.RadioButton();
            this.rectNumLabel = new System.Windows.Forms.Label();
            this.RectangleNumeric = new System.Windows.Forms.NumericUpDown();
            this.ExperimentLengthNumeric = new System.Windows.Forms.NumericUpDown();
            this.TimingResponseLabel = new System.Windows.Forms.Label();
            this.TimingResponseNumeric = new System.Windows.Forms.NumericUpDown();
            this.MondrianCountLabel = new System.Windows.Forms.Label();
            this.MondrianCountNumeric = new System.Windows.Forms.NumericUpDown();
            this.ITILabel = new System.Windows.Forms.Label();
            this.ItiNumeric = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TimingPostTrialNumeric = new System.Windows.Forms.NumericUpDown();
            this.MondrianMaxOpacity = new System.Windows.Forms.Label();
            this.BreakTimeNumeric = new System.Windows.Forms.NumericUpDown();
            this.VisUnitNumeric = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.FacdeOutTimeNumeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.FadeInTimeNumeric = new System.Windows.Forms.NumericUpDown();
            this.TrialLengthLabel = new System.Windows.Forms.Label();
            this.MaxTypeLabel = new System.Windows.Forms.Label();
            this.CountLabel = new System.Windows.Forms.Label();
            this.MaxTypeNumeric = new System.Windows.Forms.NumericUpDown();
            this.CountNumeric = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.StimulusOpacityNumeric = new System.Windows.Forms.NumericUpDown();
            this.StimulusGroup.SuspendLayout();
            this.AllBRMSGroupBox.SuspendLayout();
            this.ParamsGroupBox.SuspendLayout();
            this.TagsGroupBox.SuspendLayout();
            this.OrderGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FrameHeightNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrameWidthNumeric)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllowedToRepeatNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PerformanceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectHeightNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectWithNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FadeOutLengthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrialLimitNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MondrianMaxOpacityNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StimulusMaxOpacityNumeric)).BeginInit();
            this.TypeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubBlockNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectangleNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExperimentLengthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimingResponseNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MondrianCountNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItiNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimingPostTrialNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BreakTimeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisUnitNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacdeOutTimeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FadeInTimeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxTypeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StimulusOpacityNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // StimulusGroup
            // 
            this.StimulusGroup.Controls.Add(this.HelpCsvButton);
            this.StimulusGroup.Controls.Add(this.HelpCsvLabel);
            this.StimulusGroup.Controls.Add(this.HelpCsvTextBox);
            this.StimulusGroup.Location = new System.Drawing.Point(12, 12);
            this.StimulusGroup.Name = "StimulusGroup";
            this.StimulusGroup.Size = new System.Drawing.Size(757, 56);
            this.StimulusGroup.TabIndex = 1;
            this.StimulusGroup.TabStop = false;
            this.StimulusGroup.Text = "Basic";
            // 
            // HelpCsvButton
            // 
            this.HelpCsvButton.Location = new System.Drawing.Point(727, 19);
            this.HelpCsvButton.Name = "HelpCsvButton";
            this.HelpCsvButton.Size = new System.Drawing.Size(24, 20);
            this.HelpCsvButton.TabIndex = 6;
            this.HelpCsvButton.Text = "...";
            this.HelpCsvButton.UseVisualStyleBackColor = true;
            this.HelpCsvButton.Click += new System.EventHandler(this.HelpCsvButton_Click);
            // 
            // HelpCsvLabel
            // 
            this.HelpCsvLabel.AutoSize = true;
            this.HelpCsvLabel.Location = new System.Drawing.Point(13, 23);
            this.HelpCsvLabel.Name = "HelpCsvLabel";
            this.HelpCsvLabel.Size = new System.Drawing.Size(72, 13);
            this.HelpCsvLabel.TabIndex = 5;
            this.HelpCsvLabel.Text = "Help CSV File";
            // 
            // HelpCsvTextBox
            // 
            this.HelpCsvTextBox.Location = new System.Drawing.Point(91, 19);
            this.HelpCsvTextBox.Name = "HelpCsvTextBox";
            this.HelpCsvTextBox.ReadOnly = true;
            this.HelpCsvTextBox.Size = new System.Drawing.Size(630, 20);
            this.HelpCsvTextBox.TabIndex = 4;
            this.HelpCsvTextBox.TextChanged += new System.EventHandler(this.HelpCsvTextBox_TextChanged);
            this.HelpCsvTextBox.DoubleClick += new System.EventHandler(this.HelpCsvTextBox_DoubleClick);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(8, 577);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 21;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(670, 577);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 20;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(924, 657);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "CSV files (*.csv)|*.csv";
            // 
            // AllTrialsListView
            // 
            this.AllTrialsListView.HideSelection = false;
            this.AllTrialsListView.Location = new System.Drawing.Point(6, 19);
            this.AllTrialsListView.Name = "AllTrialsListView";
            this.AllTrialsListView.Size = new System.Drawing.Size(230, 579);
            this.AllTrialsListView.TabIndex = 8;
            this.AllTrialsListView.UseCompatibleStateImageBehavior = false;
            this.AllTrialsListView.View = System.Windows.Forms.View.List;
            // 
            // AllBRMSGroupBox
            // 
            this.AllBRMSGroupBox.Controls.Add(this.UpButton);
            this.AllBRMSGroupBox.Controls.Add(this.DownButton);
            this.AllBRMSGroupBox.Controls.Add(this.DuplicateButton);
            this.AllBRMSGroupBox.Controls.Add(this.RemoveButton);
            this.AllBRMSGroupBox.Controls.Add(this.AllTrialsListView);
            this.AllBRMSGroupBox.Location = new System.Drawing.Point(769, 12);
            this.AllBRMSGroupBox.Name = "AllBRMSGroupBox";
            this.AllBRMSGroupBox.Size = new System.Drawing.Size(245, 639);
            this.AllBRMSGroupBox.TabIndex = 10;
            this.AllBRMSGroupBox.TabStop = false;
            this.AllBRMSGroupBox.Text = "All Trials";
            // 
            // UpButton
            // 
            this.UpButton.Location = new System.Drawing.Point(87, 604);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(30, 23);
            this.UpButton.TabIndex = 34;
            this.UpButton.Text = "+";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // DownButton
            // 
            this.DownButton.Location = new System.Drawing.Point(125, 604);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(30, 23);
            this.DownButton.TabIndex = 33;
            this.DownButton.Text = "-";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // DuplicateButton
            // 
            this.DuplicateButton.Enabled = false;
            this.DuplicateButton.Location = new System.Drawing.Point(6, 604);
            this.DuplicateButton.Name = "DuplicateButton";
            this.DuplicateButton.Size = new System.Drawing.Size(75, 23);
            this.DuplicateButton.TabIndex = 32;
            this.DuplicateButton.Text = "Duplicate";
            this.DuplicateButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(161, 604);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 31;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // ParamsGroupBox
            // 
            this.ParamsGroupBox.Controls.Add(this.StimulusOpacityNumeric);
            this.ParamsGroupBox.Controls.Add(this.label16);
            this.ParamsGroupBox.Controls.Add(this.TagsGroupBox);
            this.ParamsGroupBox.Controls.Add(this.ClearButton);
            this.ParamsGroupBox.Controls.Add(this.AddButton);
            this.ParamsGroupBox.Controls.Add(this.OrderGroup);
            this.ParamsGroupBox.Controls.Add(this.FrameHeightNumeric);
            this.ParamsGroupBox.Controls.Add(this.label15);
            this.ParamsGroupBox.Controls.Add(this.FrameWidthNumeric);
            this.ParamsGroupBox.Controls.Add(this.label14);
            this.ParamsGroupBox.Controls.Add(this.groupBox3);
            this.ParamsGroupBox.Controls.Add(this.groupBox2);
            this.ParamsGroupBox.Controls.Add(this.groupBox1);
            this.ParamsGroupBox.Controls.Add(this.AllowedToRepeatNumeric);
            this.ParamsGroupBox.Controls.Add(this.label12);
            this.ParamsGroupBox.Controls.Add(this.PerformanceNumeric);
            this.ParamsGroupBox.Controls.Add(this.label7);
            this.ParamsGroupBox.Controls.Add(this.RectHeightNumeric);
            this.ParamsGroupBox.Controls.Add(this.label1);
            this.ParamsGroupBox.Controls.Add(this.RectWithNumeric);
            this.ParamsGroupBox.Controls.Add(this.label4);
            this.ParamsGroupBox.Controls.Add(this.label13);
            this.ParamsGroupBox.Controls.Add(this.FadeOutLengthNumeric);
            this.ParamsGroupBox.Controls.Add(this.TrialLimitNumeric);
            this.ParamsGroupBox.Controls.Add(this.label11);
            this.ParamsGroupBox.Controls.Add(this.MondrianMaxOpacityNumeric);
            this.ParamsGroupBox.Controls.Add(this.label8);
            this.ParamsGroupBox.Controls.Add(this.label3);
            this.ParamsGroupBox.Controls.Add(this.StimulusMaxOpacityNumeric);
            this.ParamsGroupBox.Controls.Add(this.OriantetionComboBox);
            this.ParamsGroupBox.Controls.Add(this.label2);
            this.ParamsGroupBox.Controls.Add(this.TypeGroupBox);
            this.ParamsGroupBox.Controls.Add(this.rectNumLabel);
            this.ParamsGroupBox.Controls.Add(this.RectangleNumeric);
            this.ParamsGroupBox.Controls.Add(this.ExperimentLengthNumeric);
            this.ParamsGroupBox.Controls.Add(this.TimingResponseLabel);
            this.ParamsGroupBox.Controls.Add(this.TimingResponseNumeric);
            this.ParamsGroupBox.Controls.Add(this.MondrianCountLabel);
            this.ParamsGroupBox.Controls.Add(this.MondrianCountNumeric);
            this.ParamsGroupBox.Controls.Add(this.ITILabel);
            this.ParamsGroupBox.Controls.Add(this.ItiNumeric);
            this.ParamsGroupBox.Controls.Add(this.label10);
            this.ParamsGroupBox.Controls.Add(this.label9);
            this.ParamsGroupBox.Controls.Add(this.TimingPostTrialNumeric);
            this.ParamsGroupBox.Controls.Add(this.MondrianMaxOpacity);
            this.ParamsGroupBox.Controls.Add(this.BreakTimeNumeric);
            this.ParamsGroupBox.Controls.Add(this.VisUnitNumeric);
            this.ParamsGroupBox.Controls.Add(this.label6);
            this.ParamsGroupBox.Controls.Add(this.FacdeOutTimeNumeric);
            this.ParamsGroupBox.Controls.Add(this.label5);
            this.ParamsGroupBox.Controls.Add(this.FadeInTimeNumeric);
            this.ParamsGroupBox.Controls.Add(this.TrialLengthLabel);
            this.ParamsGroupBox.Controls.Add(this.MaxTypeLabel);
            this.ParamsGroupBox.Controls.Add(this.CountLabel);
            this.ParamsGroupBox.Controls.Add(this.MaxTypeNumeric);
            this.ParamsGroupBox.Controls.Add(this.CountNumeric);
            this.ParamsGroupBox.Location = new System.Drawing.Point(12, 74);
            this.ParamsGroupBox.Name = "ParamsGroupBox";
            this.ParamsGroupBox.Size = new System.Drawing.Size(757, 606);
            this.ParamsGroupBox.TabIndex = 22;
            this.ParamsGroupBox.TabStop = false;
            this.ParamsGroupBox.Text = "Paramenters";
            // 
            // TagsGroupBox
            // 
            this.TagsGroupBox.Controls.Add(this.TagsListView);
            this.TagsGroupBox.Location = new System.Drawing.Point(530, 21);
            this.TagsGroupBox.Name = "TagsGroupBox";
            this.TagsGroupBox.Size = new System.Drawing.Size(221, 162);
            this.TagsGroupBox.TabIndex = 51;
            this.TagsGroupBox.TabStop = false;
            this.TagsGroupBox.Text = "Tags";
            // 
            // TagsListView
            // 
            this.TagsListView.HideSelection = false;
            this.TagsListView.Location = new System.Drawing.Point(9, 21);
            this.TagsListView.Name = "TagsListView";
            this.TagsListView.Size = new System.Drawing.Size(206, 134);
            this.TagsListView.TabIndex = 7;
            this.TagsListView.UseCompatibleStateImageBehavior = false;
            this.TagsListView.View = System.Windows.Forms.View.List;
            // 
            // OrderGroup
            // 
            this.OrderGroup.Controls.Add(this.PlusButton);
            this.OrderGroup.Controls.Add(this.MinusButton);
            this.OrderGroup.Controls.Add(this.OrderlistView);
            this.OrderGroup.Enabled = false;
            this.OrderGroup.Location = new System.Drawing.Point(530, 189);
            this.OrderGroup.Name = "OrderGroup";
            this.OrderGroup.Size = new System.Drawing.Size(221, 217);
            this.OrderGroup.TabIndex = 50;
            this.OrderGroup.TabStop = false;
            this.OrderGroup.Text = "Order";
            // 
            // PlusButton
            // 
            this.PlusButton.Location = new System.Drawing.Point(179, 188);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(36, 23);
            this.PlusButton.TabIndex = 3;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            // 
            // MinusButton
            // 
            this.MinusButton.Location = new System.Drawing.Point(9, 188);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(36, 23);
            this.MinusButton.TabIndex = 1;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            // 
            // OrderlistView
            // 
            this.OrderlistView.HideSelection = false;
            this.OrderlistView.Location = new System.Drawing.Point(6, 19);
            this.OrderlistView.Name = "OrderlistView";
            this.OrderlistView.Size = new System.Drawing.Size(209, 159);
            this.OrderlistView.TabIndex = 0;
            this.OrderlistView.UseCompatibleStateImageBehavior = false;
            // 
            // FrameHeightNumeric
            // 
            this.FrameHeightNumeric.Location = new System.Drawing.Point(452, 390);
            this.FrameHeightNumeric.Name = "FrameHeightNumeric";
            this.FrameHeightNumeric.Size = new System.Drawing.Size(71, 20);
            this.FrameHeightNumeric.TabIndex = 49;
            this.FrameHeightNumeric.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(288, 393);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 13);
            this.label15.TabIndex = 48;
            this.label15.Text = "Frame Height Percentage";
            // 
            // FrameWidthNumeric
            // 
            this.FrameWidthNumeric.Location = new System.Drawing.Point(452, 364);
            this.FrameWidthNumeric.Name = "FrameWidthNumeric";
            this.FrameWidthNumeric.Size = new System.Drawing.Size(71, 20);
            this.FrameWidthNumeric.TabIndex = 47;
            this.FrameWidthNumeric.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(288, 366);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 13);
            this.label14.TabIndex = 46;
            this.label14.Text = "Frame Width Percentage";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.StopMessageRichTextBox);
            this.groupBox3.Location = new System.Drawing.Point(508, 458);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 107);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stop Message";
            // 
            // StopMessageRichTextBox
            // 
            this.StopMessageRichTextBox.Location = new System.Drawing.Point(6, 19);
            this.StopMessageRichTextBox.Name = "StopMessageRichTextBox";
            this.StopMessageRichTextBox.Size = new System.Drawing.Size(225, 82);
            this.StopMessageRichTextBox.TabIndex = 0;
            this.StopMessageRichTextBox.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PerformanceMessageRchTextBox);
            this.groupBox2.Location = new System.Drawing.Point(259, 458);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 107);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Performance Message";
            // 
            // PerformanceMessageRchTextBox
            // 
            this.PerformanceMessageRchTextBox.Location = new System.Drawing.Point(6, 19);
            this.PerformanceMessageRchTextBox.Name = "PerformanceMessageRchTextBox";
            this.PerformanceMessageRchTextBox.Size = new System.Drawing.Size(232, 82);
            this.PerformanceMessageRchTextBox.TabIndex = 0;
            this.PerformanceMessageRchTextBox.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BreakMessageRichTextBox);
            this.groupBox1.Location = new System.Drawing.Point(8, 458);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 107);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Break Message";
            // 
            // BreakMessageRichTextBox
            // 
            this.BreakMessageRichTextBox.Location = new System.Drawing.Point(6, 19);
            this.BreakMessageRichTextBox.Name = "BreakMessageRichTextBox";
            this.BreakMessageRichTextBox.Size = new System.Drawing.Size(232, 82);
            this.BreakMessageRichTextBox.TabIndex = 0;
            this.BreakMessageRichTextBox.Text = "";
            // 
            // AllowedToRepeatNumeric
            // 
            this.AllowedToRepeatNumeric.Location = new System.Drawing.Point(452, 338);
            this.AllowedToRepeatNumeric.Name = "AllowedToRepeatNumeric";
            this.AllowedToRepeatNumeric.Size = new System.Drawing.Size(71, 20);
            this.AllowedToRepeatNumeric.TabIndex = 45;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(289, 338);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "Allowed to repeat";
            // 
            // PerformanceNumeric
            // 
            this.PerformanceNumeric.Location = new System.Drawing.Point(452, 260);
            this.PerformanceNumeric.Name = "PerformanceNumeric";
            this.PerformanceNumeric.Size = new System.Drawing.Size(71, 20);
            this.PerformanceNumeric.TabIndex = 43;
            this.PerformanceNumeric.Value = new decimal(new int[] {
            85,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Performance Percentage";
            // 
            // RectHeightNumeric
            // 
            this.RectHeightNumeric.Location = new System.Drawing.Point(453, 312);
            this.RectHeightNumeric.Name = "RectHeightNumeric";
            this.RectHeightNumeric.Size = new System.Drawing.Size(71, 20);
            this.RectHeightNumeric.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Rectangle Height";
            // 
            // RectWithNumeric
            // 
            this.RectWithNumeric.DecimalPlaces = 1;
            this.RectWithNumeric.Location = new System.Drawing.Point(453, 286);
            this.RectWithNumeric.Name = "RectWithNumeric";
            this.RectWithNumeric.Size = new System.Drawing.Size(71, 20);
            this.RectWithNumeric.TabIndex = 39;
            this.RectWithNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Rectangle Width";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 186);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "Fade Out Length";
            // 
            // FadeOutLengthNumeric
            // 
            this.FadeOutLengthNumeric.Location = new System.Drawing.Point(107, 184);
            this.FadeOutLengthNumeric.Name = "FadeOutLengthNumeric";
            this.FadeOutLengthNumeric.Size = new System.Drawing.Size(71, 20);
            this.FadeOutLengthNumeric.TabIndex = 36;
            this.FadeOutLengthNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // TrialLimitNumeric
            // 
            this.TrialLimitNumeric.Location = new System.Drawing.Point(107, 315);
            this.TrialLimitNumeric.Name = "TrialLimitNumeric";
            this.TrialLimitNumeric.Size = new System.Drawing.Size(71, 20);
            this.TrialLimitNumeric.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 315);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Trial Limit";
            // 
            // MondrianMaxOpacityNumeric
            // 
            this.MondrianMaxOpacityNumeric.DecimalPlaces = 1;
            this.MondrianMaxOpacityNumeric.Location = new System.Drawing.Point(453, 234);
            this.MondrianMaxOpacityNumeric.Name = "MondrianMaxOpacityNumeric";
            this.MondrianMaxOpacityNumeric.Size = new System.Drawing.Size(71, 20);
            this.MondrianMaxOpacityNumeric.TabIndex = 33;
            this.MondrianMaxOpacityNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Mondrian Maximum Opacity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Break time";
            // 
            // StimulusMaxOpacityNumeric
            // 
            this.StimulusMaxOpacityNumeric.DecimalPlaces = 1;
            this.StimulusMaxOpacityNumeric.Location = new System.Drawing.Point(453, 210);
            this.StimulusMaxOpacityNumeric.Name = "StimulusMaxOpacityNumeric";
            this.StimulusMaxOpacityNumeric.Size = new System.Drawing.Size(71, 20);
            this.StimulusMaxOpacityNumeric.TabIndex = 30;
            this.StimulusMaxOpacityNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // OriantetionComboBox
            // 
            this.OriantetionComboBox.FormattingEnabled = true;
            this.OriantetionComboBox.Items.AddRange(new object[] {
            "v",
            "h"});
            this.OriantetionComboBox.Location = new System.Drawing.Point(108, 288);
            this.OriantetionComboBox.Name = "OriantetionComboBox";
            this.OriantetionComboBox.Size = new System.Drawing.Size(71, 21);
            this.OriantetionComboBox.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Oriantetion";
            // 
            // TypeGroupBox
            // 
            this.TypeGroupBox.Controls.Add(this.SubBlockNumeric);
            this.TypeGroupBox.Controls.Add(this.SubBlockLabel);
            this.TypeGroupBox.Controls.Add(this.BlockNumeric);
            this.TypeGroupBox.Controls.Add(this.BlockLabel);
            this.TypeGroupBox.Controls.Add(this.RandomRadio);
            this.TypeGroupBox.Controls.Add(this.OrderdRadio);
            this.TypeGroupBox.Controls.Add(this.MixedRadio);
            this.TypeGroupBox.Location = new System.Drawing.Point(9, 21);
            this.TypeGroupBox.Name = "TypeGroupBox";
            this.TypeGroupBox.Size = new System.Drawing.Size(515, 51);
            this.TypeGroupBox.TabIndex = 4;
            this.TypeGroupBox.TabStop = false;
            this.TypeGroupBox.Text = "bRMS type";
            // 
            // SubBlockNumeric
            // 
            this.SubBlockNumeric.Location = new System.Drawing.Point(458, 19);
            this.SubBlockNumeric.Name = "SubBlockNumeric";
            this.SubBlockNumeric.Size = new System.Drawing.Size(51, 20);
            this.SubBlockNumeric.TabIndex = 26;
            // 
            // SubBlockLabel
            // 
            this.SubBlockLabel.AutoSize = true;
            this.SubBlockLabel.Location = new System.Drawing.Point(396, 21);
            this.SubBlockLabel.Name = "SubBlockLabel";
            this.SubBlockLabel.Size = new System.Drawing.Size(56, 13);
            this.SubBlockLabel.TabIndex = 25;
            this.SubBlockLabel.Text = "Sub Block";
            // 
            // BlockNumeric
            // 
            this.BlockNumeric.Location = new System.Drawing.Point(339, 19);
            this.BlockNumeric.Name = "BlockNumeric";
            this.BlockNumeric.Size = new System.Drawing.Size(51, 20);
            this.BlockNumeric.TabIndex = 24;
            // 
            // BlockLabel
            // 
            this.BlockLabel.AutoSize = true;
            this.BlockLabel.Location = new System.Drawing.Point(298, 21);
            this.BlockLabel.Name = "BlockLabel";
            this.BlockLabel.Size = new System.Drawing.Size(34, 13);
            this.BlockLabel.TabIndex = 23;
            this.BlockLabel.Text = "Block";
            // 
            // RandomRadio
            // 
            this.RandomRadio.AutoSize = true;
            this.RandomRadio.Location = new System.Drawing.Point(65, 23);
            this.RandomRadio.Name = "RandomRadio";
            this.RandomRadio.Size = new System.Drawing.Size(93, 17);
            this.RandomRadio.TabIndex = 2;
            this.RandomRadio.TabStop = true;
            this.RandomRadio.Text = "Fixed-Random";
            this.RandomRadio.UseVisualStyleBackColor = true;
            // 
            // OrderdRadio
            // 
            this.OrderdRadio.AutoSize = true;
            this.OrderdRadio.Enabled = false;
            this.OrderdRadio.Location = new System.Drawing.Point(164, 23);
            this.OrderdRadio.Name = "OrderdRadio";
            this.OrderdRadio.Size = new System.Drawing.Size(78, 17);
            this.OrderdRadio.TabIndex = 1;
            this.OrderdRadio.TabStop = true;
            this.OrderdRadio.Text = "Fixed-Fixed";
            this.OrderdRadio.UseVisualStyleBackColor = true;
            // 
            // MixedRadio
            // 
            this.MixedRadio.AutoSize = true;
            this.MixedRadio.Checked = true;
            this.MixedRadio.Location = new System.Drawing.Point(6, 22);
            this.MixedRadio.Name = "MixedRadio";
            this.MixedRadio.Size = new System.Drawing.Size(53, 17);
            this.MixedRadio.TabIndex = 0;
            this.MixedRadio.TabStop = true;
            this.MixedRadio.Text = "Mixed";
            this.MixedRadio.UseVisualStyleBackColor = true;
            // 
            // rectNumLabel
            // 
            this.rectNumLabel.AutoSize = true;
            this.rectNumLabel.Location = new System.Drawing.Point(288, 158);
            this.rectNumLabel.Name = "rectNumLabel";
            this.rectNumLabel.Size = new System.Drawing.Size(155, 13);
            this.rectNumLabel.TabIndex = 27;
            this.rectNumLabel.Text = "Rectangle Number In Mondrian";
            // 
            // RectangleNumeric
            // 
            this.RectangleNumeric.Location = new System.Drawing.Point(452, 156);
            this.RectangleNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.RectangleNumeric.Name = "RectangleNumeric";
            this.RectangleNumeric.Size = new System.Drawing.Size(71, 20);
            this.RectangleNumeric.TabIndex = 26;
            this.RectangleNumeric.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // ExperimentLengthNumeric
            // 
            this.ExperimentLengthNumeric.Location = new System.Drawing.Point(452, 130);
            this.ExperimentLengthNumeric.Name = "ExperimentLengthNumeric";
            this.ExperimentLengthNumeric.Size = new System.Drawing.Size(71, 20);
            this.ExperimentLengthNumeric.TabIndex = 24;
            // 
            // TimingResponseLabel
            // 
            this.TimingResponseLabel.AutoSize = true;
            this.TimingResponseLabel.Location = new System.Drawing.Point(288, 183);
            this.TimingResponseLabel.Name = "TimingResponseLabel";
            this.TimingResponseLabel.Size = new System.Drawing.Size(89, 13);
            this.TimingResponseLabel.TabIndex = 23;
            this.TimingResponseLabel.Text = "Timing Response";
            // 
            // TimingResponseNumeric
            // 
            this.TimingResponseNumeric.Location = new System.Drawing.Point(453, 183);
            this.TimingResponseNumeric.Name = "TimingResponseNumeric";
            this.TimingResponseNumeric.Size = new System.Drawing.Size(71, 20);
            this.TimingResponseNumeric.TabIndex = 22;
            this.TimingResponseNumeric.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // MondrianCountLabel
            // 
            this.MondrianCountLabel.AutoSize = true;
            this.MondrianCountLabel.Location = new System.Drawing.Point(6, 238);
            this.MondrianCountLabel.Name = "MondrianCountLabel";
            this.MondrianCountLabel.Size = new System.Drawing.Size(82, 13);
            this.MondrianCountLabel.TabIndex = 21;
            this.MondrianCountLabel.Text = "Mondrian Count";
            // 
            // MondrianCountNumeric
            // 
            this.MondrianCountNumeric.Location = new System.Drawing.Point(108, 236);
            this.MondrianCountNumeric.Name = "MondrianCountNumeric";
            this.MondrianCountNumeric.Size = new System.Drawing.Size(71, 20);
            this.MondrianCountNumeric.TabIndex = 20;
            this.MondrianCountNumeric.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // ITILabel
            // 
            this.ITILabel.AutoSize = true;
            this.ITILabel.Location = new System.Drawing.Point(288, 108);
            this.ITILabel.Name = "ITILabel";
            this.ITILabel.Size = new System.Drawing.Size(112, 13);
            this.ITILabel.TabIndex = 19;
            this.ITILabel.Text = "ITI Reserved Duration";
            // 
            // ItiNumeric
            // 
            this.ItiNumeric.Location = new System.Drawing.Point(452, 104);
            this.ItiNumeric.Name = "ItiNumeric";
            this.ItiNumeric.Size = new System.Drawing.Size(71, 20);
            this.ItiNumeric.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Base Visual Unit ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(288, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Timing Post Experiment ";
            // 
            // TimingPostTrialNumeric
            // 
            this.TimingPostTrialNumeric.Location = new System.Drawing.Point(452, 78);
            this.TimingPostTrialNumeric.Name = "TimingPostTrialNumeric";
            this.TimingPostTrialNumeric.Size = new System.Drawing.Size(71, 20);
            this.TimingPostTrialNumeric.TabIndex = 14;
            // 
            // MondrianMaxOpacity
            // 
            this.MondrianMaxOpacity.AutoSize = true;
            this.MondrianMaxOpacity.Location = new System.Drawing.Point(288, 212);
            this.MondrianMaxOpacity.Name = "MondrianMaxOpacity";
            this.MondrianMaxOpacity.Size = new System.Drawing.Size(132, 13);
            this.MondrianMaxOpacity.TabIndex = 13;
            this.MondrianMaxOpacity.Text = "Stimulus Maximum Opacity";
            // 
            // BreakTimeNumeric
            // 
            this.BreakTimeNumeric.Location = new System.Drawing.Point(108, 262);
            this.BreakTimeNumeric.Name = "BreakTimeNumeric";
            this.BreakTimeNumeric.Size = new System.Drawing.Size(71, 20);
            this.BreakTimeNumeric.TabIndex = 12;
            this.BreakTimeNumeric.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // VisUnitNumeric
            // 
            this.VisUnitNumeric.Location = new System.Drawing.Point(108, 209);
            this.VisUnitNumeric.Name = "VisUnitNumeric";
            this.VisUnitNumeric.Size = new System.Drawing.Size(71, 20);
            this.VisUnitNumeric.TabIndex = 10;
            this.VisUnitNumeric.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fade Out Time";
            // 
            // FacdeOutTimeNumeric
            // 
            this.FacdeOutTimeNumeric.Location = new System.Drawing.Point(108, 158);
            this.FacdeOutTimeNumeric.Name = "FacdeOutTimeNumeric";
            this.FacdeOutTimeNumeric.Size = new System.Drawing.Size(71, 20);
            this.FacdeOutTimeNumeric.TabIndex = 8;
            this.FacdeOutTimeNumeric.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fade In Time";
            // 
            // FadeInTimeNumeric
            // 
            this.FadeInTimeNumeric.Location = new System.Drawing.Point(108, 132);
            this.FadeInTimeNumeric.Name = "FadeInTimeNumeric";
            this.FadeInTimeNumeric.Size = new System.Drawing.Size(71, 20);
            this.FadeInTimeNumeric.TabIndex = 6;
            this.FadeInTimeNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TrialLengthLabel
            // 
            this.TrialLengthLabel.AutoSize = true;
            this.TrialLengthLabel.Location = new System.Drawing.Point(288, 134);
            this.TrialLengthLabel.Name = "TrialLengthLabel";
            this.TrialLengthLabel.Size = new System.Drawing.Size(95, 13);
            this.TrialLengthLabel.TabIndex = 5;
            this.TrialLengthLabel.Text = "Experiment Length";
            // 
            // MaxTypeLabel
            // 
            this.MaxTypeLabel.AutoSize = true;
            this.MaxTypeLabel.Location = new System.Drawing.Point(6, 106);
            this.MaxTypeLabel.Name = "MaxTypeLabel";
            this.MaxTypeLabel.Size = new System.Drawing.Size(50, 13);
            this.MaxTypeLabel.TabIndex = 3;
            this.MaxTypeLabel.Text = "Max type";
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(6, 80);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(63, 13);
            this.CountLabel.TabIndex = 2;
            this.CountLabel.Text = "Repetitions ";
            // 
            // MaxTypeNumeric
            // 
            this.MaxTypeNumeric.Location = new System.Drawing.Point(108, 104);
            this.MaxTypeNumeric.Name = "MaxTypeNumeric";
            this.MaxTypeNumeric.Size = new System.Drawing.Size(71, 20);
            this.MaxTypeNumeric.TabIndex = 1;
            // 
            // CountNumeric
            // 
            this.CountNumeric.Location = new System.Drawing.Point(108, 78);
            this.CountNumeric.Name = "CountNumeric";
            this.CountNumeric.Size = new System.Drawing.Size(71, 20);
            this.CountNumeric.TabIndex = 0;
            this.CountNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 345);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 13);
            this.label16.TabIndex = 52;
            this.label16.Text = "Stimulus Opacity";
            // 
            // StimulusOpacityNumeric
            // 
            this.StimulusOpacityNumeric.Location = new System.Drawing.Point(107, 343);
            this.StimulusOpacityNumeric.Name = "StimulusOpacityNumeric";
            this.StimulusOpacityNumeric.Size = new System.Drawing.Size(71, 20);
            this.StimulusOpacityNumeric.TabIndex = 53;
            // 
            // BrmsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 692);
            this.Controls.Add(this.ParamsGroupBox);
            this.Controls.Add(this.AllBRMSGroupBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.StimulusGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BrmsForm";
            this.Text = "bRMS";
            this.StimulusGroup.ResumeLayout(false);
            this.StimulusGroup.PerformLayout();
            this.AllBRMSGroupBox.ResumeLayout(false);
            this.ParamsGroupBox.ResumeLayout(false);
            this.ParamsGroupBox.PerformLayout();
            this.TagsGroupBox.ResumeLayout(false);
            this.OrderGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FrameHeightNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrameWidthNumeric)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AllowedToRepeatNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PerformanceNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectHeightNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectWithNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FadeOutLengthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrialLimitNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MondrianMaxOpacityNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StimulusMaxOpacityNumeric)).EndInit();
            this.TypeGroupBox.ResumeLayout(false);
            this.TypeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubBlockNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectangleNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExperimentLengthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimingResponseNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MondrianCountNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItiNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimingPostTrialNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BreakTimeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisUnitNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacdeOutTimeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FadeInTimeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxTypeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StimulusOpacityNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox StimulusGroup;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button HelpCsvButton;
        private System.Windows.Forms.Label HelpCsvLabel;
        private System.Windows.Forms.TextBox HelpCsvTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListView AllTrialsListView;
        private System.Windows.Forms.GroupBox AllBRMSGroupBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button AddButton;
        private Button UpButton;
        private Button DownButton;
        private Button DuplicateButton;
        private Button RemoveButton;
        private GroupBox ParamsGroupBox;
        private GroupBox TagsGroupBox;
        private ListView TagsListView;
        private GroupBox OrderGroup;
        private Button PlusButton;
        private Button MinusButton;
        private ListView OrderlistView;
        private NumericUpDown FrameHeightNumeric;
        private Label label15;
        private NumericUpDown FrameWidthNumeric;
        private Label label14;
        private GroupBox groupBox3;
        private RichTextBox StopMessageRichTextBox;
        private GroupBox groupBox2;
        private RichTextBox PerformanceMessageRchTextBox;
        private GroupBox groupBox1;
        private RichTextBox BreakMessageRichTextBox;
        private NumericUpDown AllowedToRepeatNumeric;
        private Label label12;
        private NumericUpDown PerformanceNumeric;
        private Label label7;
        private NumericUpDown RectHeightNumeric;
        private Label label1;
        private NumericUpDown RectWithNumeric;
        private Label label4;
        private Label label13;
        private NumericUpDown FadeOutLengthNumeric;
        private NumericUpDown TrialLimitNumeric;
        private Label label11;
        private NumericUpDown MondrianMaxOpacityNumeric;
        private Label label8;
        private Label label3;
        private NumericUpDown StimulusMaxOpacityNumeric;
        private ComboBox OriantetionComboBox;
        private Label label2;
        private GroupBox TypeGroupBox;
        private NumericUpDown SubBlockNumeric;
        private Label SubBlockLabel;
        private NumericUpDown BlockNumeric;
        private Label BlockLabel;
        private RadioButton RandomRadio;
        private RadioButton OrderdRadio;
        private RadioButton MixedRadio;
        private Label rectNumLabel;
        private NumericUpDown RectangleNumeric;
        private NumericUpDown ExperimentLengthNumeric;
        private Label TimingResponseLabel;
        private NumericUpDown TimingResponseNumeric;
        private Label MondrianCountLabel;
        private NumericUpDown MondrianCountNumeric;
        private Label ITILabel;
        private NumericUpDown ItiNumeric;
        private Label label10;
        private Label label9;
        private NumericUpDown TimingPostTrialNumeric;
        private Label MondrianMaxOpacity;
        private NumericUpDown BreakTimeNumeric;
        private NumericUpDown VisUnitNumeric;
        private Label label6;
        private NumericUpDown FacdeOutTimeNumeric;
        private Label label5;
        private NumericUpDown FadeInTimeNumeric;
        private Label TrialLengthLabel;
        private Label MaxTypeLabel;
        private Label CountLabel;
        private NumericUpDown MaxTypeNumeric;
        private NumericUpDown CountNumeric;
        private NumericUpDown StimulusOpacityNumeric;
        private Label label16;
    }
}