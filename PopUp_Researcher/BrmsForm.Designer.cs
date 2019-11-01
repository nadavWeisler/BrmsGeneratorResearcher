using System.Windows.Forms;

namespace bRMS_Generator
{
    partial class BrmsForm : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrmsForm));
            this.RemoveButton = new System.Windows.Forms.Button();
            this.DuplicateButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.UpButton = new System.Windows.Forms.Button();
            this.AllBRMSGroupBox = new System.Windows.Forms.GroupBox();
            this.AllTrialsListView = new System.Windows.Forms.ListView();
            this.CountNumeric = new System.Windows.Forms.NumericUpDown();
            this.MaxTypeNumeric = new System.Windows.Forms.NumericUpDown();
            this.CountLabel = new System.Windows.Forms.Label();
            this.MaxTypeLabel = new System.Windows.Forms.Label();
            this.FadeInTimeNumeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.FacdeOutTimeNumeric = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.BreakTimeNumeric = new System.Windows.Forms.NumericUpDown();
            this.PostTrialGapNumeric = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.StimulusDelayNumeric = new System.Windows.Forms.NumericUpDown();
            this.StimulusDelayLabel = new System.Windows.Forms.Label();
            this.MondrianCountNumeric = new System.Windows.Forms.NumericUpDown();
            this.MondrianCountLabel = new System.Windows.Forms.Label();
            this.TimingResponseNumeric = new System.Windows.Forms.NumericUpDown();
            this.TimingResponseLabel = new System.Windows.Forms.Label();
            this.ParamsGroupBox = new System.Windows.Forms.GroupBox();
            this.FixationHeightNumeric = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.FixationWidthNumeric = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.StimulusHeightNumeric = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.StimulusWidthNumeric = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.StimulusOpacityNumeric = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.TagsGroupBox = new System.Windows.Forms.GroupBox();
            this.TagsListView = new System.Windows.Forms.ListView();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.OrderGroup = new System.Windows.Forms.GroupBox();
            this.DuplicateOrderButton = new System.Windows.Forms.Button();
            this.RemoveOrderButton = new System.Windows.Forms.Button();
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
            this.RectWidthNumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.MondrianMaxOpacityNumeric = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.HelpCsvTextBox = new System.Windows.Forms.TextBox();
            this.StimulusGroup = new System.Windows.Forms.GroupBox();
            this.HelpCsvButton = new System.Windows.Forms.Button();
            this.HelpCsvLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.AllBRMSGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxTypeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FadeInTimeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacdeOutTimeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BreakTimeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostTrialGapNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StimulusDelayNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MondrianCountNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimingResponseNumeric)).BeginInit();
            this.ParamsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FixationHeightNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FixationWidthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StimulusHeightNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StimulusWidthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StimulusOpacityNumeric)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.RectWidthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MondrianMaxOpacityNumeric)).BeginInit();
            this.TypeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubBlockNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectangleNumeric)).BeginInit();
            this.StimulusGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(242, 875);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(112, 35);
            this.RemoveButton.TabIndex = 31;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // DuplicateButton
            // 
            this.DuplicateButton.Enabled = false;
            this.DuplicateButton.Location = new System.Drawing.Point(9, 875);
            this.DuplicateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DuplicateButton.Name = "DuplicateButton";
            this.DuplicateButton.Size = new System.Drawing.Size(112, 35);
            this.DuplicateButton.TabIndex = 32;
            this.DuplicateButton.Text = "Duplicate";
            this.DuplicateButton.UseVisualStyleBackColor = true;
            // 
            // DownButton
            // 
            this.DownButton.Location = new System.Drawing.Point(188, 875);
            this.DownButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(45, 35);
            this.DownButton.TabIndex = 33;
            this.DownButton.Text = "-";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // UpButton
            // 
            this.UpButton.Location = new System.Drawing.Point(130, 875);
            this.UpButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(45, 35);
            this.UpButton.TabIndex = 34;
            this.UpButton.Text = "+";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // AllBRMSGroupBox
            // 
            this.AllBRMSGroupBox.Controls.Add(this.UpButton);
            this.AllBRMSGroupBox.Controls.Add(this.DownButton);
            this.AllBRMSGroupBox.Controls.Add(this.DuplicateButton);
            this.AllBRMSGroupBox.Controls.Add(this.RemoveButton);
            this.AllBRMSGroupBox.Controls.Add(this.AllTrialsListView);
            this.AllBRMSGroupBox.Location = new System.Drawing.Point(1154, 18);
            this.AllBRMSGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AllBRMSGroupBox.Name = "AllBRMSGroupBox";
            this.AllBRMSGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AllBRMSGroupBox.Size = new System.Drawing.Size(368, 920);
            this.AllBRMSGroupBox.TabIndex = 10;
            this.AllBRMSGroupBox.TabStop = false;
            this.AllBRMSGroupBox.Text = "All Trials";
            // 
            // AllTrialsListView
            // 
            this.AllTrialsListView.HideSelection = false;
            this.AllTrialsListView.Location = new System.Drawing.Point(9, 29);
            this.AllTrialsListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AllTrialsListView.Name = "AllTrialsListView";
            this.AllTrialsListView.Size = new System.Drawing.Size(343, 835);
            this.AllTrialsListView.TabIndex = 8;
            this.AllTrialsListView.UseCompatibleStateImageBehavior = false;
            this.AllTrialsListView.View = System.Windows.Forms.View.List;
            // 
            // CountNumeric
            // 
            this.CountNumeric.Location = new System.Drawing.Point(261, 122);
            this.CountNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CountNumeric.Name = "CountNumeric";
            this.CountNumeric.Size = new System.Drawing.Size(106, 26);
            this.CountNumeric.TabIndex = 0;
            this.CountNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MaxTypeNumeric
            // 
            this.MaxTypeNumeric.Location = new System.Drawing.Point(261, 162);
            this.MaxTypeNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaxTypeNumeric.Name = "MaxTypeNumeric";
            this.MaxTypeNumeric.Size = new System.Drawing.Size(106, 26);
            this.MaxTypeNumeric.TabIndex = 1;
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(9, 123);
            this.CountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(144, 20);
            this.CountLabel.TabIndex = 2;
            this.CountLabel.Text = "Repetitions (count)";
            // 
            // MaxTypeLabel
            // 
            this.MaxTypeLabel.AutoSize = true;
            this.MaxTypeLabel.Location = new System.Drawing.Point(9, 163);
            this.MaxTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaxTypeLabel.Name = "MaxTypeLabel";
            this.MaxTypeLabel.Size = new System.Drawing.Size(126, 20);
            this.MaxTypeLabel.TabIndex = 3;
            this.MaxTypeLabel.Text = "Max type (count)";
            // 
            // FadeInTimeNumeric
            // 
            this.FadeInTimeNumeric.Location = new System.Drawing.Point(261, 205);
            this.FadeInTimeNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FadeInTimeNumeric.Name = "FadeInTimeNumeric";
            this.FadeInTimeNumeric.Size = new System.Drawing.Size(106, 26);
            this.FadeInTimeNumeric.TabIndex = 6;
            this.FadeInTimeNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 206);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fade In Time (sec)";
            // 
            // FacdeOutTimeNumeric
            // 
            this.FacdeOutTimeNumeric.Location = new System.Drawing.Point(261, 245);
            this.FacdeOutTimeNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FacdeOutTimeNumeric.Name = "FacdeOutTimeNumeric";
            this.FacdeOutTimeNumeric.Size = new System.Drawing.Size(106, 26);
            this.FacdeOutTimeNumeric.TabIndex = 8;
            this.FacdeOutTimeNumeric.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 246);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fade Out Time (sec)";
            // 
            // BreakTimeNumeric
            // 
            this.BreakTimeNumeric.Location = new System.Drawing.Point(261, 323);
            this.BreakTimeNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BreakTimeNumeric.Name = "BreakTimeNumeric";
            this.BreakTimeNumeric.Size = new System.Drawing.Size(106, 26);
            this.BreakTimeNumeric.TabIndex = 12;
            this.BreakTimeNumeric.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // PostTrialGapNumeric
            // 
            this.PostTrialGapNumeric.DecimalPlaces = 1;
            this.PostTrialGapNumeric.Location = new System.Drawing.Point(658, 125);
            this.PostTrialGapNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PostTrialGapNumeric.Name = "PostTrialGapNumeric";
            this.PostTrialGapNumeric.Size = new System.Drawing.Size(106, 26);
            this.PostTrialGapNumeric.TabIndex = 14;
            this.PostTrialGapNumeric.Value = new decimal(new int[] {
            4,
            0,
            0,
            65536});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(432, 131);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Post Trial Gap (sec)";
            // 
            // StimulusDelayNumeric
            // 
            this.StimulusDelayNumeric.Location = new System.Drawing.Point(658, 240);
            this.StimulusDelayNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StimulusDelayNumeric.Name = "StimulusDelayNumeric";
            this.StimulusDelayNumeric.Size = new System.Drawing.Size(106, 26);
            this.StimulusDelayNumeric.TabIndex = 18;
            // 
            // StimulusDelayLabel
            // 
            this.StimulusDelayLabel.AutoSize = true;
            this.StimulusDelayLabel.Location = new System.Drawing.Point(434, 248);
            this.StimulusDelayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StimulusDelayLabel.Name = "StimulusDelayLabel";
            this.StimulusDelayLabel.Size = new System.Drawing.Size(218, 20);
            this.StimulusDelayLabel.TabIndex = 19;
            this.StimulusDelayLabel.Text = "Stimulus Delay Duration (sec)";
            // 
            // MondrianCountNumeric
            // 
            this.MondrianCountNumeric.Location = new System.Drawing.Point(261, 283);
            this.MondrianCountNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MondrianCountNumeric.Name = "MondrianCountNumeric";
            this.MondrianCountNumeric.Size = new System.Drawing.Size(106, 26);
            this.MondrianCountNumeric.TabIndex = 20;
            this.MondrianCountNumeric.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // MondrianCountLabel
            // 
            this.MondrianCountLabel.AutoSize = true;
            this.MondrianCountLabel.Location = new System.Drawing.Point(9, 285);
            this.MondrianCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MondrianCountLabel.Name = "MondrianCountLabel";
            this.MondrianCountLabel.Size = new System.Drawing.Size(176, 20);
            this.MondrianCountLabel.TabIndex = 21;
            this.MondrianCountLabel.Text = "Mondrian Count (count)";
            // 
            // TimingResponseNumeric
            // 
            this.TimingResponseNumeric.Location = new System.Drawing.Point(260, 363);
            this.TimingResponseNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TimingResponseNumeric.Name = "TimingResponseNumeric";
            this.TimingResponseNumeric.Size = new System.Drawing.Size(106, 26);
            this.TimingResponseNumeric.TabIndex = 22;
            this.TimingResponseNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // TimingResponseLabel
            // 
            this.TimingResponseLabel.AutoSize = true;
            this.TimingResponseLabel.Location = new System.Drawing.Point(9, 366);
            this.TimingResponseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimingResponseLabel.Name = "TimingResponseLabel";
            this.TimingResponseLabel.Size = new System.Drawing.Size(131, 20);
            this.TimingResponseLabel.TabIndex = 23;
            this.TimingResponseLabel.Text = "Trial Length (sec)";
            // 
            // ParamsGroupBox
            // 
            this.ParamsGroupBox.Controls.Add(this.FixationHeightNumeric);
            this.ParamsGroupBox.Controls.Add(this.label10);
            this.ParamsGroupBox.Controls.Add(this.FixationWidthNumeric);
            this.ParamsGroupBox.Controls.Add(this.label17);
            this.ParamsGroupBox.Controls.Add(this.StimulusHeightNumeric);
            this.ParamsGroupBox.Controls.Add(this.label11);
            this.ParamsGroupBox.Controls.Add(this.StimulusWidthNumeric);
            this.ParamsGroupBox.Controls.Add(this.label13);
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
            this.ParamsGroupBox.Controls.Add(this.RectWidthNumeric);
            this.ParamsGroupBox.Controls.Add(this.label4);
            this.ParamsGroupBox.Controls.Add(this.MondrianMaxOpacityNumeric);
            this.ParamsGroupBox.Controls.Add(this.label8);
            this.ParamsGroupBox.Controls.Add(this.label3);
            this.ParamsGroupBox.Controls.Add(this.OriantetionComboBox);
            this.ParamsGroupBox.Controls.Add(this.label2);
            this.ParamsGroupBox.Controls.Add(this.TypeGroupBox);
            this.ParamsGroupBox.Controls.Add(this.rectNumLabel);
            this.ParamsGroupBox.Controls.Add(this.RectangleNumeric);
            this.ParamsGroupBox.Controls.Add(this.TimingResponseLabel);
            this.ParamsGroupBox.Controls.Add(this.TimingResponseNumeric);
            this.ParamsGroupBox.Controls.Add(this.MondrianCountLabel);
            this.ParamsGroupBox.Controls.Add(this.MondrianCountNumeric);
            this.ParamsGroupBox.Controls.Add(this.StimulusDelayLabel);
            this.ParamsGroupBox.Controls.Add(this.StimulusDelayNumeric);
            this.ParamsGroupBox.Controls.Add(this.label9);
            this.ParamsGroupBox.Controls.Add(this.PostTrialGapNumeric);
            this.ParamsGroupBox.Controls.Add(this.BreakTimeNumeric);
            this.ParamsGroupBox.Controls.Add(this.label6);
            this.ParamsGroupBox.Controls.Add(this.FacdeOutTimeNumeric);
            this.ParamsGroupBox.Controls.Add(this.label5);
            this.ParamsGroupBox.Controls.Add(this.FadeInTimeNumeric);
            this.ParamsGroupBox.Controls.Add(this.MaxTypeLabel);
            this.ParamsGroupBox.Controls.Add(this.CountLabel);
            this.ParamsGroupBox.Controls.Add(this.MaxTypeNumeric);
            this.ParamsGroupBox.Controls.Add(this.CountNumeric);
            this.ParamsGroupBox.Location = new System.Drawing.Point(18, 114);
            this.ParamsGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ParamsGroupBox.Name = "ParamsGroupBox";
            this.ParamsGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ParamsGroupBox.Size = new System.Drawing.Size(1136, 874);
            this.ParamsGroupBox.TabIndex = 22;
            this.ParamsGroupBox.TabStop = false;
            this.ParamsGroupBox.Text = "Paramenters";
            // 
            // FixationHeightNumeric
            // 
            this.FixationHeightNumeric.DecimalPlaces = 1;
            this.FixationHeightNumeric.Location = new System.Drawing.Point(658, 574);
            this.FixationHeightNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FixationHeightNumeric.Name = "FixationHeightNumeric";
            this.FixationHeightNumeric.Size = new System.Drawing.Size(106, 26);
            this.FixationHeightNumeric.TabIndex = 61;
            this.FixationHeightNumeric.Value = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(434, 582);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 20);
            this.label10.TabIndex = 60;
            this.label10.Text = "Fixation Height (mm)";
            // 
            // FixationWidthNumeric
            // 
            this.FixationWidthNumeric.DecimalPlaces = 1;
            this.FixationWidthNumeric.Location = new System.Drawing.Point(658, 534);
            this.FixationWidthNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FixationWidthNumeric.Name = "FixationWidthNumeric";
            this.FixationWidthNumeric.Size = new System.Drawing.Size(106, 26);
            this.FixationWidthNumeric.TabIndex = 59;
            this.FixationWidthNumeric.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(434, 540);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(149, 20);
            this.label17.TabIndex = 58;
            this.label17.Text = "Fixation Width (mm)";
            // 
            // StimulusHeightNumeric
            // 
            this.StimulusHeightNumeric.Location = new System.Drawing.Point(658, 488);
            this.StimulusHeightNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StimulusHeightNumeric.Name = "StimulusHeightNumeric";
            this.StimulusHeightNumeric.Size = new System.Drawing.Size(106, 26);
            this.StimulusHeightNumeric.TabIndex = 57;
            this.StimulusHeightNumeric.Value = new decimal(new int[] {
            65,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(434, 495);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 20);
            this.label11.TabIndex = 56;
            this.label11.Text = "Stimulus Height (mm)";
            // 
            // StimulusWidthNumeric
            // 
            this.StimulusWidthNumeric.DecimalPlaces = 1;
            this.StimulusWidthNumeric.Location = new System.Drawing.Point(658, 448);
            this.StimulusWidthNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StimulusWidthNumeric.Name = "StimulusWidthNumeric";
            this.StimulusWidthNumeric.Size = new System.Drawing.Size(106, 26);
            this.StimulusWidthNumeric.TabIndex = 55;
            this.StimulusWidthNumeric.Value = new decimal(new int[] {
            65,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(434, 454);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(155, 20);
            this.label13.TabIndex = 54;
            this.label13.Text = "Stimulus Width (mm)";
            // 
            // StimulusOpacityNumeric
            // 
            this.StimulusOpacityNumeric.DecimalPlaces = 2;
            this.StimulusOpacityNumeric.Location = new System.Drawing.Point(260, 402);
            this.StimulusOpacityNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StimulusOpacityNumeric.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StimulusOpacityNumeric.Name = "StimulusOpacityNumeric";
            this.StimulusOpacityNumeric.Size = new System.Drawing.Size(106, 26);
            this.StimulusOpacityNumeric.TabIndex = 53;
            this.StimulusOpacityNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 405);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(164, 20);
            this.label16.TabIndex = 52;
            this.label16.Text = "Stimulus Opacity (0-1)";
            // 
            // TagsGroupBox
            // 
            this.TagsGroupBox.Controls.Add(this.TagsListView);
            this.TagsGroupBox.Location = new System.Drawing.Point(795, 32);
            this.TagsGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TagsGroupBox.Name = "TagsGroupBox";
            this.TagsGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TagsGroupBox.Size = new System.Drawing.Size(332, 249);
            this.TagsGroupBox.TabIndex = 51;
            this.TagsGroupBox.TabStop = false;
            this.TagsGroupBox.Text = "Tags";
            // 
            // TagsListView
            // 
            this.TagsListView.HideSelection = false;
            this.TagsListView.Location = new System.Drawing.Point(14, 32);
            this.TagsListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TagsListView.Name = "TagsListView";
            this.TagsListView.Size = new System.Drawing.Size(307, 204);
            this.TagsListView.TabIndex = 7;
            this.TagsListView.UseCompatibleStateImageBehavior = false;
            this.TagsListView.View = System.Windows.Forms.View.List;
            this.TagsListView.SelectedIndexChanged += new System.EventHandler(this.TagsListView_SelectedIndexChanged);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(12, 834);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(112, 35);
            this.ClearButton.TabIndex = 21;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(1005, 834);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(112, 35);
            this.AddButton.TabIndex = 20;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // OrderGroup
            // 
            this.OrderGroup.Controls.Add(this.DuplicateOrderButton);
            this.OrderGroup.Controls.Add(this.RemoveOrderButton);
            this.OrderGroup.Controls.Add(this.PlusButton);
            this.OrderGroup.Controls.Add(this.MinusButton);
            this.OrderGroup.Controls.Add(this.OrderlistView);
            this.OrderGroup.Enabled = false;
            this.OrderGroup.Location = new System.Drawing.Point(795, 291);
            this.OrderGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OrderGroup.Name = "OrderGroup";
            this.OrderGroup.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OrderGroup.Size = new System.Drawing.Size(332, 334);
            this.OrderGroup.TabIndex = 50;
            this.OrderGroup.TabStop = false;
            this.OrderGroup.Text = "Order";
            // 
            // DuplicateOrderButton
            // 
            this.DuplicateOrderButton.Location = new System.Drawing.Point(8, 283);
            this.DuplicateOrderButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DuplicateOrderButton.Name = "DuplicateOrderButton";
            this.DuplicateOrderButton.Size = new System.Drawing.Size(90, 35);
            this.DuplicateOrderButton.TabIndex = 5;
            this.DuplicateOrderButton.Text = "DuplicateOrderButton";
            this.DuplicateOrderButton.UseVisualStyleBackColor = true;
            this.DuplicateOrderButton.Click += new System.EventHandler(this.DuplicateOrderButton_Click);
            // 
            // RemoveOrderButton
            // 
            this.RemoveOrderButton.Location = new System.Drawing.Point(232, 283);
            this.RemoveOrderButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemoveOrderButton.Name = "RemoveOrderButton";
            this.RemoveOrderButton.Size = new System.Drawing.Size(90, 35);
            this.RemoveOrderButton.TabIndex = 4;
            this.RemoveOrderButton.Text = "Remove";
            this.RemoveOrderButton.UseVisualStyleBackColor = true;
            this.RemoveOrderButton.Click += new System.EventHandler(this.RemoveOrderButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.Location = new System.Drawing.Point(106, 283);
            this.PlusButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(54, 35);
            this.PlusButton.TabIndex = 3;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Location = new System.Drawing.Point(170, 283);
            this.MinusButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(54, 35);
            this.MinusButton.TabIndex = 1;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // OrderlistView
            // 
            this.OrderlistView.HideSelection = false;
            this.OrderlistView.Location = new System.Drawing.Point(9, 29);
            this.OrderlistView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OrderlistView.MultiSelect = false;
            this.OrderlistView.Name = "OrderlistView";
            this.OrderlistView.Size = new System.Drawing.Size(312, 242);
            this.OrderlistView.TabIndex = 0;
            this.OrderlistView.UseCompatibleStateImageBehavior = false;
            this.OrderlistView.View = System.Windows.Forms.View.List;
            // 
            // FrameHeightNumeric
            // 
            this.FrameHeightNumeric.DecimalPlaces = 1;
            this.FrameHeightNumeric.Location = new System.Drawing.Point(658, 405);
            this.FrameHeightNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FrameHeightNumeric.Name = "FrameHeightNumeric";
            this.FrameHeightNumeric.Size = new System.Drawing.Size(106, 26);
            this.FrameHeightNumeric.TabIndex = 49;
            this.FrameHeightNumeric.Value = new decimal(new int[] {
            67,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(434, 412);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 20);
            this.label15.TabIndex = 48;
            this.label15.Text = "Frame Height (mm)";
            // 
            // FrameWidthNumeric
            // 
            this.FrameWidthNumeric.DecimalPlaces = 1;
            this.FrameWidthNumeric.Location = new System.Drawing.Point(658, 365);
            this.FrameWidthNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FrameWidthNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.FrameWidthNumeric.Name = "FrameWidthNumeric";
            this.FrameWidthNumeric.Size = new System.Drawing.Size(106, 26);
            this.FrameWidthNumeric.TabIndex = 47;
            this.FrameWidthNumeric.Value = new decimal(new int[] {
            160,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(434, 371);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 20);
            this.label14.TabIndex = 46;
            this.label14.Text = "Frame Width (mm)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.StopMessageRichTextBox);
            this.groupBox3.Location = new System.Drawing.Point(766, 640);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(356, 175);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stop Message";
            // 
            // StopMessageRichTextBox
            // 
            this.StopMessageRichTextBox.Location = new System.Drawing.Point(9, 29);
            this.StopMessageRichTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StopMessageRichTextBox.Name = "StopMessageRichTextBox";
            this.StopMessageRichTextBox.Size = new System.Drawing.Size(336, 135);
            this.StopMessageRichTextBox.TabIndex = 0;
            this.StopMessageRichTextBox.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PerformanceMessageRchTextBox);
            this.groupBox2.Location = new System.Drawing.Point(393, 640);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(366, 175);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Performance Message";
            // 
            // PerformanceMessageRchTextBox
            // 
            this.PerformanceMessageRchTextBox.Location = new System.Drawing.Point(9, 29);
            this.PerformanceMessageRchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PerformanceMessageRchTextBox.Name = "PerformanceMessageRchTextBox";
            this.PerformanceMessageRchTextBox.Size = new System.Drawing.Size(346, 135);
            this.PerformanceMessageRchTextBox.TabIndex = 0;
            this.PerformanceMessageRchTextBox.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BreakMessageRichTextBox);
            this.groupBox1.Location = new System.Drawing.Point(16, 640);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(368, 175);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Break Message";
            // 
            // BreakMessageRichTextBox
            // 
            this.BreakMessageRichTextBox.Location = new System.Drawing.Point(9, 29);
            this.BreakMessageRichTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BreakMessageRichTextBox.Name = "BreakMessageRichTextBox";
            this.BreakMessageRichTextBox.Size = new System.Drawing.Size(346, 135);
            this.BreakMessageRichTextBox.TabIndex = 0;
            this.BreakMessageRichTextBox.Text = "";
            // 
            // AllowedToRepeatNumeric
            // 
            this.AllowedToRepeatNumeric.Location = new System.Drawing.Point(658, 162);
            this.AllowedToRepeatNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AllowedToRepeatNumeric.Name = "AllowedToRepeatNumeric";
            this.AllowedToRepeatNumeric.Size = new System.Drawing.Size(106, 26);
            this.AllowedToRepeatNumeric.TabIndex = 45;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(434, 169);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(186, 20);
            this.label12.TabIndex = 44;
            this.label12.Text = "Allowed to repeat (count)";
            // 
            // PerformanceNumeric
            // 
            this.PerformanceNumeric.DecimalPlaces = 2;
            this.PerformanceNumeric.Location = new System.Drawing.Point(260, 443);
            this.PerformanceNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PerformanceNumeric.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PerformanceNumeric.Name = "PerformanceNumeric";
            this.PerformanceNumeric.Size = new System.Drawing.Size(106, 26);
            this.PerformanceNumeric.TabIndex = 43;
            this.PerformanceNumeric.Value = new decimal(new int[] {
            85,
            0,
            0,
            131072});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 446);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = "Performance Percentage (0-1)";
            // 
            // RectHeightNumeric
            // 
            this.RectHeightNumeric.DecimalPlaces = 1;
            this.RectHeightNumeric.Location = new System.Drawing.Point(658, 322);
            this.RectHeightNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RectHeightNumeric.Name = "RectHeightNumeric";
            this.RectHeightNumeric.Size = new System.Drawing.Size(106, 26);
            this.RectHeightNumeric.TabIndex = 41;
            this.RectHeightNumeric.Value = new decimal(new int[] {
            65,
            0,
            0,
            65536});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 325);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Rectangle Height (mm)";
            // 
            // RectWidthNumeric
            // 
            this.RectWidthNumeric.DecimalPlaces = 1;
            this.RectWidthNumeric.Location = new System.Drawing.Point(658, 282);
            this.RectWidthNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RectWidthNumeric.Name = "RectWidthNumeric";
            this.RectWidthNumeric.Size = new System.Drawing.Size(106, 26);
            this.RectWidthNumeric.TabIndex = 39;
            this.RectWidthNumeric.Value = new decimal(new int[] {
            65,
            0,
            0,
            65536});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 285);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Rectangle Width (mm)";
            // 
            // MondrianMaxOpacityNumeric
            // 
            this.MondrianMaxOpacityNumeric.DecimalPlaces = 2;
            this.MondrianMaxOpacityNumeric.Location = new System.Drawing.Point(658, 200);
            this.MondrianMaxOpacityNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MondrianMaxOpacityNumeric.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MondrianMaxOpacityNumeric.Name = "MondrianMaxOpacityNumeric";
            this.MondrianMaxOpacityNumeric.Size = new System.Drawing.Size(106, 26);
            this.MondrianMaxOpacityNumeric.TabIndex = 33;
            this.MondrianMaxOpacityNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(434, 206);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Mondrian Max Opacity (0-1)\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 325);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Break time";
            // 
            // OriantetionComboBox
            // 
            this.OriantetionComboBox.FormattingEnabled = true;
            this.OriantetionComboBox.Location = new System.Drawing.Point(261, 525);
            this.OriantetionComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OriantetionComboBox.Name = "OriantetionComboBox";
            this.OriantetionComboBox.Size = new System.Drawing.Size(106, 28);
            this.OriantetionComboBox.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 526);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
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
            this.TypeGroupBox.Location = new System.Drawing.Point(14, 32);
            this.TypeGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TypeGroupBox.Name = "TypeGroupBox";
            this.TypeGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TypeGroupBox.Size = new System.Drawing.Size(772, 78);
            this.TypeGroupBox.TabIndex = 4;
            this.TypeGroupBox.TabStop = false;
            this.TypeGroupBox.Text = "bRMS type";
            // 
            // SubBlockNumeric
            // 
            this.SubBlockNumeric.Location = new System.Drawing.Point(687, 29);
            this.SubBlockNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubBlockNumeric.Name = "SubBlockNumeric";
            this.SubBlockNumeric.Size = new System.Drawing.Size(76, 26);
            this.SubBlockNumeric.TabIndex = 26;
            // 
            // SubBlockLabel
            // 
            this.SubBlockLabel.AutoSize = true;
            this.SubBlockLabel.Location = new System.Drawing.Point(594, 32);
            this.SubBlockLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SubBlockLabel.Name = "SubBlockLabel";
            this.SubBlockLabel.Size = new System.Drawing.Size(81, 20);
            this.SubBlockLabel.TabIndex = 25;
            this.SubBlockLabel.Text = "Sub Block";
            // 
            // BlockNumeric
            // 
            this.BlockNumeric.Location = new System.Drawing.Point(508, 29);
            this.BlockNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BlockNumeric.Name = "BlockNumeric";
            this.BlockNumeric.Size = new System.Drawing.Size(76, 26);
            this.BlockNumeric.TabIndex = 24;
            // 
            // BlockLabel
            // 
            this.BlockLabel.AutoSize = true;
            this.BlockLabel.Location = new System.Drawing.Point(447, 32);
            this.BlockLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BlockLabel.Name = "BlockLabel";
            this.BlockLabel.Size = new System.Drawing.Size(48, 20);
            this.BlockLabel.TabIndex = 23;
            this.BlockLabel.Text = "Block";
            // 
            // RandomRadio
            // 
            this.RandomRadio.AutoSize = true;
            this.RandomRadio.Location = new System.Drawing.Point(98, 35);
            this.RandomRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RandomRadio.Name = "RandomRadio";
            this.RandomRadio.Size = new System.Drawing.Size(138, 24);
            this.RandomRadio.TabIndex = 2;
            this.RandomRadio.TabStop = true;
            this.RandomRadio.Text = "Fixed-Random";
            this.RandomRadio.UseVisualStyleBackColor = true;
            // 
            // OrderdRadio
            // 
            this.OrderdRadio.AutoSize = true;
            this.OrderdRadio.Location = new System.Drawing.Point(246, 35);
            this.OrderdRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OrderdRadio.Name = "OrderdRadio";
            this.OrderdRadio.Size = new System.Drawing.Size(115, 24);
            this.OrderdRadio.TabIndex = 1;
            this.OrderdRadio.TabStop = true;
            this.OrderdRadio.Text = "Fixed-Fixed";
            this.OrderdRadio.UseVisualStyleBackColor = true;
            this.OrderdRadio.CheckedChanged += new System.EventHandler(this.OrderdRadio_CheckedChanged);
            // 
            // MixedRadio
            // 
            this.MixedRadio.AutoSize = true;
            this.MixedRadio.Checked = true;
            this.MixedRadio.Location = new System.Drawing.Point(9, 34);
            this.MixedRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MixedRadio.Name = "MixedRadio";
            this.MixedRadio.Size = new System.Drawing.Size(75, 24);
            this.MixedRadio.TabIndex = 0;
            this.MixedRadio.TabStop = true;
            this.MixedRadio.Text = "Mixed";
            this.MixedRadio.UseVisualStyleBackColor = true;
            // 
            // rectNumLabel
            // 
            this.rectNumLabel.AutoSize = true;
            this.rectNumLabel.Location = new System.Drawing.Point(9, 488);
            this.rectNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rectNumLabel.Name = "rectNumLabel";
            this.rectNumLabel.Size = new System.Drawing.Size(224, 20);
            this.rectNumLabel.TabIndex = 27;
            this.rectNumLabel.Text = "Rectangle In Mondrian (count)";
            // 
            // RectangleNumeric
            // 
            this.RectangleNumeric.Location = new System.Drawing.Point(260, 483);
            this.RectangleNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RectangleNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.RectangleNumeric.Name = "RectangleNumeric";
            this.RectangleNumeric.Size = new System.Drawing.Size(106, 26);
            this.RectangleNumeric.TabIndex = 26;
            this.RectangleNumeric.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // HelpCsvTextBox
            // 
            this.HelpCsvTextBox.Location = new System.Drawing.Point(136, 29);
            this.HelpCsvTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HelpCsvTextBox.Name = "HelpCsvTextBox";
            this.HelpCsvTextBox.ReadOnly = true;
            this.HelpCsvTextBox.Size = new System.Drawing.Size(943, 26);
            this.HelpCsvTextBox.TabIndex = 4;
            this.HelpCsvTextBox.TextChanged += new System.EventHandler(this.HelpCsvTextBox_TextChanged);
            this.HelpCsvTextBox.DoubleClick += new System.EventHandler(this.HelpCsvTextBox_DoubleClick);
            // 
            // StimulusGroup
            // 
            this.StimulusGroup.Controls.Add(this.HelpCsvButton);
            this.StimulusGroup.Controls.Add(this.HelpCsvLabel);
            this.StimulusGroup.Controls.Add(this.HelpCsvTextBox);
            this.StimulusGroup.Location = new System.Drawing.Point(18, 18);
            this.StimulusGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StimulusGroup.Name = "StimulusGroup";
            this.StimulusGroup.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StimulusGroup.Size = new System.Drawing.Size(1136, 86);
            this.StimulusGroup.TabIndex = 1;
            this.StimulusGroup.TabStop = false;
            this.StimulusGroup.Text = "Basic";
            // 
            // HelpCsvButton
            // 
            this.HelpCsvButton.Location = new System.Drawing.Point(1090, 29);
            this.HelpCsvButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HelpCsvButton.Name = "HelpCsvButton";
            this.HelpCsvButton.Size = new System.Drawing.Size(36, 31);
            this.HelpCsvButton.TabIndex = 6;
            this.HelpCsvButton.Text = "...";
            this.HelpCsvButton.UseVisualStyleBackColor = true;
            this.HelpCsvButton.Click += new System.EventHandler(this.HelpCsvButton_Click);
            // 
            // HelpCsvLabel
            // 
            this.HelpCsvLabel.AutoSize = true;
            this.HelpCsvLabel.Location = new System.Drawing.Point(20, 35);
            this.HelpCsvLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HelpCsvLabel.Name = "HelpCsvLabel";
            this.HelpCsvLabel.Size = new System.Drawing.Size(108, 20);
            this.HelpCsvLabel.TabIndex = 5;
            this.HelpCsvLabel.Text = "Help CSV File";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(1395, 948);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(112, 35);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "CSV files (*.csv)|*.csv";
            // 
            // BrmsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1524, 994);
            this.Controls.Add(this.ParamsGroupBox);
            this.Controls.Add(this.AllBRMSGroupBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.StimulusGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BrmsForm";
            this.Text = "bRMS";
            this.AllBRMSGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CountNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxTypeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FadeInTimeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacdeOutTimeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BreakTimeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostTrialGapNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StimulusDelayNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MondrianCountNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimingResponseNumeric)).EndInit();
            this.ParamsGroupBox.ResumeLayout(false);
            this.ParamsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FixationHeightNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FixationWidthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StimulusHeightNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StimulusWidthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StimulusOpacityNumeric)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.RectWidthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MondrianMaxOpacityNumeric)).EndInit();
            this.TypeGroupBox.ResumeLayout(false);
            this.TypeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubBlockNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectangleNumeric)).EndInit();
            this.StimulusGroup.ResumeLayout(false);
            this.StimulusGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button RemoveButton;
        private Button DuplicateButton;
        private Button DownButton;
        private Button UpButton;
        private GroupBox AllBRMSGroupBox;
        private ListView AllTrialsListView;
        private NumericUpDown CountNumeric;
        private NumericUpDown MaxTypeNumeric;
        private Label CountLabel;
        private Label MaxTypeLabel;
        private NumericUpDown FadeInTimeNumeric;
        private Label label5;
        private NumericUpDown FacdeOutTimeNumeric;
        private Label label6;
        private NumericUpDown BreakTimeNumeric;
        private NumericUpDown PostTrialGapNumeric;
        private Label label9;
        private NumericUpDown StimulusDelayNumeric;
        private Label StimulusDelayLabel;
        private NumericUpDown MondrianCountNumeric;
        private Label MondrianCountLabel;
        private NumericUpDown TimingResponseNumeric;
        private Label TimingResponseLabel;
        private GroupBox ParamsGroupBox;
        private NumericUpDown FixationHeightNumeric;
        private Label label10;
        private NumericUpDown FixationWidthNumeric;
        private Label label17;
        private NumericUpDown StimulusHeightNumeric;
        private Label label11;
        private NumericUpDown StimulusWidthNumeric;
        private Label label13;
        private NumericUpDown StimulusOpacityNumeric;
        private Label label16;
        private GroupBox TagsGroupBox;
        private ListView TagsListView;
        private Button ClearButton;
        private Button AddButton;
        private GroupBox OrderGroup;
        private Button DuplicateOrderButton;
        private Button RemoveOrderButton;
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
        private NumericUpDown RectWidthNumeric;
        private Label label4;
        private NumericUpDown MondrianMaxOpacityNumeric;
        private Label label8;
        private Label label3;
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
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox HelpCsvTextBox;
        private GroupBox StimulusGroup;
        private Button HelpCsvButton;
        private Label HelpCsvLabel;
        private Button SaveButton;
        private OpenFileDialog openFileDialog1;
    }
}