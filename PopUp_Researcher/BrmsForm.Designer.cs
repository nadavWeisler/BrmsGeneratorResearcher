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
            this.FadeInTimeNumeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.FacdeOutTimeNumeric = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.PostTrialGapNumeric = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.StimulusDelayNumeric = new System.Windows.Forms.NumericUpDown();
            this.StimulusDelayLabel = new System.Windows.Forms.Label();
            this.MondrianCountNumeric = new System.Windows.Forms.NumericUpDown();
            this.MondrianCountLabel = new System.Windows.Forms.Label();
            this.TimingResponseNumeric = new System.Windows.Forms.NumericUpDown();
            this.TimingResponseLabel = new System.Windows.Forms.Label();
            this.ParamsGroupBox = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.numericGapDuration = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericMondrianDuration = new System.Windows.Forms.NumericUpDown();
            this.NameGroupBox = new System.Windows.Forms.GroupBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SubBlockNumeric = new System.Windows.Forms.NumericUpDown();
            this.SubBlockLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.BlockNumeric = new System.Windows.Forms.NumericUpDown();
            this.StimulusDurationNumeric = new System.Windows.Forms.NumericUpDown();
            this.BlockLabel = new System.Windows.Forms.Label();
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
            this.RectHeightNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.RectWidthNumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.MondrianMaxOpacityNumeric = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.TypeGroupBox = new System.Windows.Forms.GroupBox();
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
            this.openFileDialogImages = new System.Windows.Forms.OpenFileDialog();
            this.AllBRMSGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FadeInTimeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacdeOutTimeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostTrialGapNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StimulusDelayNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MondrianCountNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimingResponseNumeric)).BeginInit();
            this.ParamsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericGapDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMondrianDuration)).BeginInit();
            this.NameGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubBlockNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StimulusDurationNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FixationHeightNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FixationWidthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StimulusHeightNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StimulusWidthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StimulusOpacityNumeric)).BeginInit();
            this.TagsGroupBox.SuspendLayout();
            this.OrderGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FrameHeightNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrameWidthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectHeightNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectWidthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MondrianMaxOpacityNumeric)).BeginInit();
            this.TypeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RectangleNumeric)).BeginInit();
            this.StimulusGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(240, 618);
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
            this.DuplicateButton.Location = new System.Drawing.Point(8, 618);
            this.DuplicateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DuplicateButton.Name = "DuplicateButton";
            this.DuplicateButton.Size = new System.Drawing.Size(112, 35);
            this.DuplicateButton.TabIndex = 32;
            this.DuplicateButton.Text = "Duplicate";
            this.DuplicateButton.UseVisualStyleBackColor = true;
            // 
            // DownButton
            // 
            this.DownButton.Location = new System.Drawing.Point(186, 618);
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
            this.UpButton.Location = new System.Drawing.Point(128, 618);
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
            this.AllBRMSGroupBox.Size = new System.Drawing.Size(368, 662);
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
            this.AllTrialsListView.Size = new System.Drawing.Size(343, 572);
            this.AllTrialsListView.TabIndex = 8;
            this.AllTrialsListView.UseCompatibleStateImageBehavior = false;
            this.AllTrialsListView.View = System.Windows.Forms.View.List;
            // 
            // FadeInTimeNumeric
            // 
            this.FadeInTimeNumeric.Location = new System.Drawing.Point(259, 119);
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
            this.label5.Location = new System.Drawing.Point(8, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Stimulus Fade In Time (sec)";
            // 
            // FacdeOutTimeNumeric
            // 
            this.FacdeOutTimeNumeric.Location = new System.Drawing.Point(259, 152);
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
            this.label6.Location = new System.Drawing.Point(8, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mondrians Fade Out Time (sec)";
            // 
            // PostTrialGapNumeric
            // 
            this.PostTrialGapNumeric.DecimalPlaces = 1;
            this.PostTrialGapNumeric.Location = new System.Drawing.Point(259, 332);
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
            this.label9.Location = new System.Drawing.Point(8, 334);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Post Trial Gap (sec)";
            // 
            // StimulusDelayNumeric
            // 
            this.StimulusDelayNumeric.Location = new System.Drawing.Point(259, 368);
            this.StimulusDelayNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StimulusDelayNumeric.Name = "StimulusDelayNumeric";
            this.StimulusDelayNumeric.Size = new System.Drawing.Size(106, 26);
            this.StimulusDelayNumeric.TabIndex = 18;
            // 
            // StimulusDelayLabel
            // 
            this.StimulusDelayLabel.AutoSize = true;
            this.StimulusDelayLabel.Location = new System.Drawing.Point(8, 368);
            this.StimulusDelayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StimulusDelayLabel.Name = "StimulusDelayLabel";
            this.StimulusDelayLabel.Size = new System.Drawing.Size(218, 20);
            this.StimulusDelayLabel.TabIndex = 19;
            this.StimulusDelayLabel.Text = "Stimulus Delay Duration (sec)";
            // 
            // MondrianCountNumeric
            // 
            this.MondrianCountNumeric.Location = new System.Drawing.Point(662, 119);
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
            this.MondrianCountLabel.Location = new System.Drawing.Point(410, 125);
            this.MondrianCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MondrianCountLabel.Name = "MondrianCountLabel";
            this.MondrianCountLabel.Size = new System.Drawing.Size(176, 20);
            this.MondrianCountLabel.TabIndex = 21;
            this.MondrianCountLabel.Text = "Mondrian Count (count)";
            // 
            // TimingResponseNumeric
            // 
            this.TimingResponseNumeric.Location = new System.Drawing.Point(259, 188);
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
            this.TimingResponseLabel.Location = new System.Drawing.Point(8, 188);
            this.TimingResponseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimingResponseLabel.Name = "TimingResponseLabel";
            this.TimingResponseLabel.Size = new System.Drawing.Size(152, 20);
            this.TimingResponseLabel.TabIndex = 23;
            this.TimingResponseLabel.Text = "All Trial Length (sec)";
            // 
            // ParamsGroupBox
            // 
            this.ParamsGroupBox.Controls.Add(this.label18);
            this.ParamsGroupBox.Controls.Add(this.numericGapDuration);
            this.ParamsGroupBox.Controls.Add(this.label7);
            this.ParamsGroupBox.Controls.Add(this.numericMondrianDuration);
            this.ParamsGroupBox.Controls.Add(this.NameGroupBox);
            this.ParamsGroupBox.Controls.Add(this.SubBlockNumeric);
            this.ParamsGroupBox.Controls.Add(this.SubBlockLabel);
            this.ParamsGroupBox.Controls.Add(this.label12);
            this.ParamsGroupBox.Controls.Add(this.BlockNumeric);
            this.ParamsGroupBox.Controls.Add(this.StimulusDurationNumeric);
            this.ParamsGroupBox.Controls.Add(this.BlockLabel);
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
            this.ParamsGroupBox.Controls.Add(this.AddButton);
            this.ParamsGroupBox.Controls.Add(this.OrderGroup);
            this.ParamsGroupBox.Controls.Add(this.FrameHeightNumeric);
            this.ParamsGroupBox.Controls.Add(this.label15);
            this.ParamsGroupBox.Controls.Add(this.FrameWidthNumeric);
            this.ParamsGroupBox.Controls.Add(this.label14);
            this.ParamsGroupBox.Controls.Add(this.RectHeightNumeric);
            this.ParamsGroupBox.Controls.Add(this.label1);
            this.ParamsGroupBox.Controls.Add(this.RectWidthNumeric);
            this.ParamsGroupBox.Controls.Add(this.label4);
            this.ParamsGroupBox.Controls.Add(this.MondrianMaxOpacityNumeric);
            this.ParamsGroupBox.Controls.Add(this.label8);
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
            this.ParamsGroupBox.Controls.Add(this.label6);
            this.ParamsGroupBox.Controls.Add(this.FacdeOutTimeNumeric);
            this.ParamsGroupBox.Controls.Add(this.label5);
            this.ParamsGroupBox.Controls.Add(this.FadeInTimeNumeric);
            this.ParamsGroupBox.Location = new System.Drawing.Point(18, 114);
            this.ParamsGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ParamsGroupBox.Name = "ParamsGroupBox";
            this.ParamsGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ParamsGroupBox.Size = new System.Drawing.Size(1136, 566);
            this.ParamsGroupBox.TabIndex = 22;
            this.ParamsGroupBox.TabStop = false;
            this.ParamsGroupBox.Text = "Paramenters";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 298);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(140, 20);
            this.label18.TabIndex = 67;
            this.label18.Text = "Gap Duration (ms)";
            // 
            // numericGapDuration
            // 
            this.numericGapDuration.Location = new System.Drawing.Point(259, 296);
            this.numericGapDuration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericGapDuration.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericGapDuration.Name = "numericGapDuration";
            this.numericGapDuration.Size = new System.Drawing.Size(106, 26);
            this.numericGapDuration.TabIndex = 66;
            this.numericGapDuration.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 224);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 20);
            this.label7.TabIndex = 65;
            this.label7.Text = "Mask Duration (ms)";
            // 
            // numericMondrianDuration
            // 
            this.numericMondrianDuration.Location = new System.Drawing.Point(259, 224);
            this.numericMondrianDuration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericMondrianDuration.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericMondrianDuration.Name = "numericMondrianDuration";
            this.numericMondrianDuration.Size = new System.Drawing.Size(106, 26);
            this.numericMondrianDuration.TabIndex = 64;
            this.numericMondrianDuration.Value = new decimal(new int[] {
            67,
            0,
            0,
            0});
            // 
            // NameGroupBox
            // 
            this.NameGroupBox.Controls.Add(this.NameTextBox);
            this.NameGroupBox.Location = new System.Drawing.Point(414, 32);
            this.NameGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameGroupBox.Name = "NameGroupBox";
            this.NameGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameGroupBox.Size = new System.Drawing.Size(354, 78);
            this.NameGroupBox.TabIndex = 36;
            this.NameGroupBox.TabStop = false;
            this.NameGroupBox.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(8, 28);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(337, 26);
            this.NameTextBox.TabIndex = 0;
            // 
            // SubBlockNumeric
            // 
            this.SubBlockNumeric.Location = new System.Drawing.Point(913, 528);
            this.SubBlockNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubBlockNumeric.Name = "SubBlockNumeric";
            this.SubBlockNumeric.Size = new System.Drawing.Size(76, 26);
            this.SubBlockNumeric.TabIndex = 26;
            // 
            // SubBlockLabel
            // 
            this.SubBlockLabel.AutoSize = true;
            this.SubBlockLabel.Location = new System.Drawing.Point(819, 529);
            this.SubBlockLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SubBlockLabel.Name = "SubBlockLabel";
            this.SubBlockLabel.Size = new System.Drawing.Size(81, 20);
            this.SubBlockLabel.TabIndex = 25;
            this.SubBlockLabel.Text = "Sub Block";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 262);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 20);
            this.label12.TabIndex = 63;
            this.label12.Text = "Stimulus Duration (ms)";
            // 
            // BlockNumeric
            // 
            this.BlockNumeric.Location = new System.Drawing.Point(734, 528);
            this.BlockNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BlockNumeric.Name = "BlockNumeric";
            this.BlockNumeric.Size = new System.Drawing.Size(76, 26);
            this.BlockNumeric.TabIndex = 24;
            // 
            // StimulusDurationNumeric
            // 
            this.StimulusDurationNumeric.Location = new System.Drawing.Point(259, 260);
            this.StimulusDurationNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StimulusDurationNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.StimulusDurationNumeric.Name = "StimulusDurationNumeric";
            this.StimulusDurationNumeric.Size = new System.Drawing.Size(106, 26);
            this.StimulusDurationNumeric.TabIndex = 62;
            this.StimulusDurationNumeric.Value = new decimal(new int[] {
            33,
            0,
            0,
            0});
            // 
            // BlockLabel
            // 
            this.BlockLabel.AutoSize = true;
            this.BlockLabel.Location = new System.Drawing.Point(673, 529);
            this.BlockLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BlockLabel.Name = "BlockLabel";
            this.BlockLabel.Size = new System.Drawing.Size(48, 20);
            this.BlockLabel.TabIndex = 23;
            this.BlockLabel.Text = "Block";
            // 
            // FixationHeightNumeric
            // 
            this.FixationHeightNumeric.DecimalPlaces = 1;
            this.FixationHeightNumeric.Location = new System.Drawing.Point(662, 440);
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
            this.label10.Location = new System.Drawing.Point(412, 442);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 20);
            this.label10.TabIndex = 60;
            this.label10.Text = "Fixation Height (mm)";
            // 
            // FixationWidthNumeric
            // 
            this.FixationWidthNumeric.DecimalPlaces = 1;
            this.FixationWidthNumeric.Location = new System.Drawing.Point(662, 404);
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
            this.label17.Location = new System.Drawing.Point(412, 404);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(149, 20);
            this.label17.TabIndex = 58;
            this.label17.Text = "Fixation Width (mm)";
            // 
            // StimulusHeightNumeric
            // 
            this.StimulusHeightNumeric.Location = new System.Drawing.Point(662, 368);
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
            this.label11.Location = new System.Drawing.Point(410, 370);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 20);
            this.label11.TabIndex = 56;
            this.label11.Text = "Stimulus Height (mm)";
            // 
            // StimulusWidthNumeric
            // 
            this.StimulusWidthNumeric.DecimalPlaces = 1;
            this.StimulusWidthNumeric.Location = new System.Drawing.Point(662, 332);
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
            this.label13.Location = new System.Drawing.Point(412, 334);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(155, 20);
            this.label13.TabIndex = 54;
            this.label13.Text = "Stimulus Width (mm)";
            // 
            // StimulusOpacityNumeric
            // 
            this.StimulusOpacityNumeric.DecimalPlaces = 2;
            this.StimulusOpacityNumeric.Location = new System.Drawing.Point(259, 404);
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
            35,
            0,
            0,
            131072});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 404);
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
            this.TagsGroupBox.Size = new System.Drawing.Size(332, 205);
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
            this.TagsListView.Size = new System.Drawing.Size(307, 159);
            this.TagsListView.TabIndex = 7;
            this.TagsListView.UseCompatibleStateImageBehavior = false;
            this.TagsListView.View = System.Windows.Forms.View.List;
            this.TagsListView.SelectedIndexChanged += new System.EventHandler(this.TagsListView_SelectedIndexChanged);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(1005, 522);
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
            this.OrderGroup.Location = new System.Drawing.Point(796, 246);
            this.OrderGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OrderGroup.Name = "OrderGroup";
            this.OrderGroup.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OrderGroup.Size = new System.Drawing.Size(332, 266);
            this.OrderGroup.TabIndex = 50;
            this.OrderGroup.TabStop = false;
            this.OrderGroup.Text = "Order";
            // 
            // DuplicateOrderButton
            // 
            this.DuplicateOrderButton.Location = new System.Drawing.Point(8, 212);
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
            this.RemoveOrderButton.Location = new System.Drawing.Point(231, 212);
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
            this.PlusButton.Location = new System.Drawing.Point(105, 212);
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
            this.MinusButton.Location = new System.Drawing.Point(170, 212);
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
            this.OrderlistView.Size = new System.Drawing.Size(312, 173);
            this.OrderlistView.TabIndex = 0;
            this.OrderlistView.UseCompatibleStateImageBehavior = false;
            this.OrderlistView.View = System.Windows.Forms.View.List;
            // 
            // FrameHeightNumeric
            // 
            this.FrameHeightNumeric.DecimalPlaces = 1;
            this.FrameHeightNumeric.Location = new System.Drawing.Point(662, 296);
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
            this.label15.Location = new System.Drawing.Point(410, 298);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 20);
            this.label15.TabIndex = 48;
            this.label15.Text = "Frame Height (mm)";
            // 
            // FrameWidthNumeric
            // 
            this.FrameWidthNumeric.DecimalPlaces = 1;
            this.FrameWidthNumeric.Location = new System.Drawing.Point(662, 260);
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
            this.label14.Location = new System.Drawing.Point(410, 260);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 20);
            this.label14.TabIndex = 46;
            this.label14.Text = "Frame Width (mm)";
            // 
            // RectHeightNumeric
            // 
            this.RectHeightNumeric.DecimalPlaces = 1;
            this.RectHeightNumeric.Location = new System.Drawing.Point(662, 224);
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
            this.label1.Location = new System.Drawing.Point(410, 224);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Rectangle Max Height (mm)";
            // 
            // RectWidthNumeric
            // 
            this.RectWidthNumeric.DecimalPlaces = 1;
            this.RectWidthNumeric.Location = new System.Drawing.Point(662, 188);
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
            this.label4.Location = new System.Drawing.Point(410, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Rectangle Max Width (mm)";
            // 
            // MondrianMaxOpacityNumeric
            // 
            this.MondrianMaxOpacityNumeric.DecimalPlaces = 2;
            this.MondrianMaxOpacityNumeric.Location = new System.Drawing.Point(259, 440);
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
            this.label8.Location = new System.Drawing.Point(10, 442);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Mondrian Max Opacity (0-1)\r\n";
            // 
            // TypeGroupBox
            // 
            this.TypeGroupBox.Controls.Add(this.RandomRadio);
            this.TypeGroupBox.Controls.Add(this.OrderdRadio);
            this.TypeGroupBox.Controls.Add(this.MixedRadio);
            this.TypeGroupBox.Location = new System.Drawing.Point(14, 32);
            this.TypeGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TypeGroupBox.Name = "TypeGroupBox";
            this.TypeGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TypeGroupBox.Size = new System.Drawing.Size(392, 78);
            this.TypeGroupBox.TabIndex = 4;
            this.TypeGroupBox.TabStop = false;
            this.TypeGroupBox.Text = "bRMS type";
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
            this.OrderdRadio.Location = new System.Drawing.Point(255, 34);
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
            this.rectNumLabel.Location = new System.Drawing.Point(410, 158);
            this.rectNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rectNumLabel.Name = "rectNumLabel";
            this.rectNumLabel.Size = new System.Drawing.Size(224, 20);
            this.rectNumLabel.TabIndex = 27;
            this.rectNumLabel.Text = "Rectangle In Mondrian (count)";
            // 
            // RectangleNumeric
            // 
            this.RectangleNumeric.Location = new System.Drawing.Point(662, 152);
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
            this.HelpCsvTextBox.Size = new System.Drawing.Size(949, 26);
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
            this.StimulusGroup.Size = new System.Drawing.Size(1137, 86);
            this.StimulusGroup.TabIndex = 1;
            this.StimulusGroup.TabStop = false;
            this.StimulusGroup.Text = "Basic";
            // 
            // HelpCsvButton
            // 
            this.HelpCsvButton.Location = new System.Drawing.Point(1093, 27);
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
            this.SaveButton.Location = new System.Drawing.Point(1394, 689);
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
            // openFileDialogImages
            // 
            this.openFileDialogImages.Filter = "IMAGE files (*.jpg)|*.jpg";
            this.openFileDialogImages.Multiselect = true;
            // 
            // BrmsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1524, 729);
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
            ((System.ComponentModel.ISupportInitialize)(this.FadeInTimeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacdeOutTimeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostTrialGapNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StimulusDelayNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MondrianCountNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimingResponseNumeric)).EndInit();
            this.ParamsGroupBox.ResumeLayout(false);
            this.ParamsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericGapDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMondrianDuration)).EndInit();
            this.NameGroupBox.ResumeLayout(false);
            this.NameGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubBlockNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StimulusDurationNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FixationHeightNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FixationWidthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StimulusHeightNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StimulusWidthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StimulusOpacityNumeric)).EndInit();
            this.TagsGroupBox.ResumeLayout(false);
            this.OrderGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FrameHeightNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrameWidthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectHeightNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectWidthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MondrianMaxOpacityNumeric)).EndInit();
            this.TypeGroupBox.ResumeLayout(false);
            this.TypeGroupBox.PerformLayout();
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
        private NumericUpDown FadeInTimeNumeric;
        private Label label5;
        private NumericUpDown FacdeOutTimeNumeric;
        private Label label6;
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
        private NumericUpDown RectHeightNumeric;
        private Label label1;
        private NumericUpDown RectWidthNumeric;
        private Label label4;
        private NumericUpDown MondrianMaxOpacityNumeric;
        private Label label8;
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
        private OpenFileDialog openFileDialogImages;
        private Label label12;
        private NumericUpDown StimulusDurationNumeric;
        private GroupBox NameGroupBox;
        private TextBox NameTextBox;
        private Label label18;
        private NumericUpDown numericGapDuration;
        private Label label7;
        private NumericUpDown numericMondrianDuration;
    }
}