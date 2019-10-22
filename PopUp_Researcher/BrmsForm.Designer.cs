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
            this.RemoveButton = new System.Windows.Forms.Button();
            this.DuplicateButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.UpButton = new System.Windows.Forms.Button();
            this.AllBRMSGroupBox = new System.Windows.Forms.GroupBox();
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
            this.RectangleNumeric = new System.Windows.Forms.NumericUpDown();
            this.rectNumLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.TypeGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OriantetionComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.HelpCsvTextBox = new System.Windows.Forms.TextBox();
            this.StimulusGroup = new System.Windows.Forms.GroupBox();
            this.HelpCsvLabel = new System.Windows.Forms.Label();
            this.HelpCsvButton = new System.Windows.Forms.Button();
            this.MondrianMaxOpacityNumeric = new System.Windows.Forms.NumericUpDown();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.RectWidthNumeric = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.AllTrialsListView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.MixedRadio = new System.Windows.Forms.RadioButton();
            this.OrderdRadio = new System.Windows.Forms.RadioButton();
            this.RandomRadio = new System.Windows.Forms.RadioButton();
            this.BlockLabel = new System.Windows.Forms.Label();
            this.RectHeightNumeric = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.PerformanceNumeric = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.AllowedToRepeatNumeric = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PerformanceMessageRchTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.StopMessageRichTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.FrameWidthNumeric = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.FrameHeightNumeric = new System.Windows.Forms.NumericUpDown();
            this.OrderlistView = new System.Windows.Forms.ListView();
            this.MinusButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.RemoveOrderButton = new System.Windows.Forms.Button();
            this.DuplicateOrderButton = new System.Windows.Forms.Button();
            this.OrderGroup = new System.Windows.Forms.GroupBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.TagsListView = new System.Windows.Forms.ListView();
            this.TagsGroupBox = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.StimulusOpacityNumeric = new System.Windows.Forms.NumericUpDown();
            this.BlockNumeric = new System.Windows.Forms.NumericUpDown();
            this.SubBlockLabel = new System.Windows.Forms.Label();
            this.SubBlockNumeric = new System.Windows.Forms.NumericUpDown();
            this.StimulusHeightNumeric = new System.Windows.Forms.NumericUpDown();
            this.FixationWidthNumeric = new System.Windows.Forms.NumericUpDown();
            this.BreakMessageRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.StimulusWidthNumeric = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.FixationHeightNumeric = new System.Windows.Forms.NumericUpDown();
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
            ((System.ComponentModel.ISupportInitialize)(this.RectangleNumeric)).BeginInit();
            this.TypeGroupBox.SuspendLayout();
            this.StimulusGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MondrianMaxOpacityNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectWidthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectHeightNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PerformanceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllowedToRepeatNumeric)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FrameWidthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrameHeightNumeric)).BeginInit();
            this.OrderGroup.SuspendLayout();
            this.TagsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StimulusOpacityNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubBlockNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StimulusHeightNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FixationWidthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StimulusWidthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FixationHeightNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(161, 569);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 31;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // DuplicateButton
            // 
            this.DuplicateButton.Enabled = false;
            this.DuplicateButton.Location = new System.Drawing.Point(6, 569);
            this.DuplicateButton.Name = "DuplicateButton";
            this.DuplicateButton.Size = new System.Drawing.Size(75, 23);
            this.DuplicateButton.TabIndex = 32;
            this.DuplicateButton.Text = "Duplicate";
            this.DuplicateButton.UseVisualStyleBackColor = true;
            // 
            // DownButton
            // 
            this.DownButton.Location = new System.Drawing.Point(125, 569);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(30, 23);
            this.DownButton.TabIndex = 33;
            this.DownButton.Text = "-";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // UpButton
            // 
            this.UpButton.Location = new System.Drawing.Point(87, 569);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(30, 23);
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
            this.AllBRMSGroupBox.Location = new System.Drawing.Point(769, 12);
            this.AllBRMSGroupBox.Name = "AllBRMSGroupBox";
            this.AllBRMSGroupBox.Size = new System.Drawing.Size(245, 598);
            this.AllBRMSGroupBox.TabIndex = 10;
            this.AllBRMSGroupBox.TabStop = false;
            this.AllBRMSGroupBox.Text = "All Trials";
            // 
            // CountNumeric
            // 
            this.CountNumeric.Location = new System.Drawing.Point(174, 79);
            this.CountNumeric.Name = "CountNumeric";
            this.CountNumeric.Size = new System.Drawing.Size(71, 20);
            this.CountNumeric.TabIndex = 0;
            this.CountNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MaxTypeNumeric
            // 
            this.MaxTypeNumeric.Location = new System.Drawing.Point(174, 105);
            this.MaxTypeNumeric.Name = "MaxTypeNumeric";
            this.MaxTypeNumeric.Size = new System.Drawing.Size(71, 20);
            this.MaxTypeNumeric.TabIndex = 1;
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(6, 80);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(96, 13);
            this.CountLabel.TabIndex = 2;
            this.CountLabel.Text = "Repetitions (count)";
            // 
            // MaxTypeLabel
            // 
            this.MaxTypeLabel.AutoSize = true;
            this.MaxTypeLabel.Location = new System.Drawing.Point(6, 106);
            this.MaxTypeLabel.Name = "MaxTypeLabel";
            this.MaxTypeLabel.Size = new System.Drawing.Size(86, 13);
            this.MaxTypeLabel.TabIndex = 3;
            this.MaxTypeLabel.Text = "Max type (count)";
            // 
            // FadeInTimeNumeric
            // 
            this.FadeInTimeNumeric.Location = new System.Drawing.Point(174, 133);
            this.FadeInTimeNumeric.Name = "FadeInTimeNumeric";
            this.FadeInTimeNumeric.Size = new System.Drawing.Size(71, 20);
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
            this.label5.Location = new System.Drawing.Point(6, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fade In Time (sec)";
            // 
            // FacdeOutTimeNumeric
            // 
            this.FacdeOutTimeNumeric.Location = new System.Drawing.Point(174, 159);
            this.FacdeOutTimeNumeric.Name = "FacdeOutTimeNumeric";
            this.FacdeOutTimeNumeric.Size = new System.Drawing.Size(71, 20);
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
            this.label6.Location = new System.Drawing.Point(6, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fade Out Time (sec)";
            // 
            // BreakTimeNumeric
            // 
            this.BreakTimeNumeric.Location = new System.Drawing.Point(174, 210);
            this.BreakTimeNumeric.Name = "BreakTimeNumeric";
            this.BreakTimeNumeric.Size = new System.Drawing.Size(71, 20);
            this.BreakTimeNumeric.TabIndex = 12;
            this.BreakTimeNumeric.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // PostTrialGapNumeric
            // 
            this.PostTrialGapNumeric.Location = new System.Drawing.Point(439, 81);
            this.PostTrialGapNumeric.Name = "PostTrialGapNumeric";
            this.PostTrialGapNumeric.Size = new System.Drawing.Size(71, 20);
            this.PostTrialGapNumeric.TabIndex = 14;
            this.PostTrialGapNumeric.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(288, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Post Trial Gap (sec)";
            // 
            // StimulusDelayNumeric
            // 
            this.StimulusDelayNumeric.Location = new System.Drawing.Point(439, 156);
            this.StimulusDelayNumeric.Name = "StimulusDelayNumeric";
            this.StimulusDelayNumeric.Size = new System.Drawing.Size(71, 20);
            this.StimulusDelayNumeric.TabIndex = 18;
            // 
            // StimulusDelayLabel
            // 
            this.StimulusDelayLabel.AutoSize = true;
            this.StimulusDelayLabel.Location = new System.Drawing.Point(289, 161);
            this.StimulusDelayLabel.Name = "StimulusDelayLabel";
            this.StimulusDelayLabel.Size = new System.Drawing.Size(145, 13);
            this.StimulusDelayLabel.TabIndex = 19;
            this.StimulusDelayLabel.Text = "Stimulus Delay Duration (sec)";
            // 
            // MondrianCountNumeric
            // 
            this.MondrianCountNumeric.Location = new System.Drawing.Point(174, 184);
            this.MondrianCountNumeric.Name = "MondrianCountNumeric";
            this.MondrianCountNumeric.Size = new System.Drawing.Size(71, 20);
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
            this.MondrianCountLabel.Location = new System.Drawing.Point(6, 185);
            this.MondrianCountLabel.Name = "MondrianCountLabel";
            this.MondrianCountLabel.Size = new System.Drawing.Size(118, 13);
            this.MondrianCountLabel.TabIndex = 21;
            this.MondrianCountLabel.Text = "Mondrian Count (count)";
            // 
            // TimingResponseNumeric
            // 
            this.TimingResponseNumeric.Location = new System.Drawing.Point(173, 236);
            this.TimingResponseNumeric.Name = "TimingResponseNumeric";
            this.TimingResponseNumeric.Size = new System.Drawing.Size(71, 20);
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
            this.TimingResponseLabel.Location = new System.Drawing.Point(6, 238);
            this.TimingResponseLabel.Name = "TimingResponseLabel";
            this.TimingResponseLabel.Size = new System.Drawing.Size(89, 13);
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
            this.ParamsGroupBox.Location = new System.Drawing.Point(12, 74);
            this.ParamsGroupBox.Name = "ParamsGroupBox";
            this.ParamsGroupBox.Size = new System.Drawing.Size(757, 574);
            this.ParamsGroupBox.TabIndex = 22;
            this.ParamsGroupBox.TabStop = false;
            this.ParamsGroupBox.Text = "Paramenters";
            this.ParamsGroupBox.Enter += new System.EventHandler(this.ParamsGroupBox_Enter);
            // 
            // RectangleNumeric
            // 
            this.RectangleNumeric.Location = new System.Drawing.Point(173, 314);
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
            // rectNumLabel
            // 
            this.rectNumLabel.AutoSize = true;
            this.rectNumLabel.Location = new System.Drawing.Point(6, 317);
            this.rectNumLabel.Name = "rectNumLabel";
            this.rectNumLabel.Size = new System.Drawing.Size(151, 13);
            this.rectNumLabel.TabIndex = 27;
            this.rectNumLabel.Text = "Rectangle In Mondrian (count)";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Oriantetion";
            // 
            // OriantetionComboBox
            // 
            this.OriantetionComboBox.FormattingEnabled = true;
            this.OriantetionComboBox.Location = new System.Drawing.Point(174, 341);
            this.OriantetionComboBox.Name = "OriantetionComboBox";
            this.OriantetionComboBox.Size = new System.Drawing.Size(72, 21);
            this.OriantetionComboBox.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Break time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Mondrian Max Opacity (0-1)\r\n";
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
            // HelpCsvLabel
            // 
            this.HelpCsvLabel.AutoSize = true;
            this.HelpCsvLabel.Location = new System.Drawing.Point(13, 23);
            this.HelpCsvLabel.Name = "HelpCsvLabel";
            this.HelpCsvLabel.Size = new System.Drawing.Size(72, 13);
            this.HelpCsvLabel.TabIndex = 5;
            this.HelpCsvLabel.Text = "Help CSV File";
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
            // MondrianMaxOpacityNumeric
            // 
            this.MondrianMaxOpacityNumeric.DecimalPlaces = 2;
            this.MondrianMaxOpacityNumeric.Location = new System.Drawing.Point(439, 130);
            this.MondrianMaxOpacityNumeric.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MondrianMaxOpacityNumeric.Name = "MondrianMaxOpacityNumeric";
            this.MondrianMaxOpacityNumeric.Size = new System.Drawing.Size(71, 20);
            this.MondrianMaxOpacityNumeric.TabIndex = 33;
            this.MondrianMaxOpacityNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(930, 616);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Rectangle Width (mm)";
            // 
            // RectWidthNumeric
            // 
            this.RectWidthNumeric.DecimalPlaces = 1;
            this.RectWidthNumeric.Location = new System.Drawing.Point(439, 183);
            this.RectWidthNumeric.Name = "RectWidthNumeric";
            this.RectWidthNumeric.Size = new System.Drawing.Size(71, 20);
            this.RectWidthNumeric.TabIndex = 39;
            this.RectWidthNumeric.Value = new decimal(new int[] {
            65,
            0,
            0,
            65536});
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
            this.AllTrialsListView.Size = new System.Drawing.Size(230, 544);
            this.AllTrialsListView.TabIndex = 8;
            this.AllTrialsListView.UseCompatibleStateImageBehavior = false;
            this.AllTrialsListView.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Rectangle Height (mm)";
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
            // OrderdRadio
            // 
            this.OrderdRadio.AutoSize = true;
            this.OrderdRadio.Location = new System.Drawing.Point(164, 23);
            this.OrderdRadio.Name = "OrderdRadio";
            this.OrderdRadio.Size = new System.Drawing.Size(78, 17);
            this.OrderdRadio.TabIndex = 1;
            this.OrderdRadio.TabStop = true;
            this.OrderdRadio.Text = "Fixed-Fixed";
            this.OrderdRadio.UseVisualStyleBackColor = true;
            this.OrderdRadio.CheckedChanged += new System.EventHandler(this.OrderdRadio_CheckedChanged);
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
            // BlockLabel
            // 
            this.BlockLabel.AutoSize = true;
            this.BlockLabel.Location = new System.Drawing.Point(298, 21);
            this.BlockLabel.Name = "BlockLabel";
            this.BlockLabel.Size = new System.Drawing.Size(34, 13);
            this.BlockLabel.TabIndex = 23;
            this.BlockLabel.Text = "Block";
            // 
            // RectHeightNumeric
            // 
            this.RectHeightNumeric.DecimalPlaces = 1;
            this.RectHeightNumeric.Location = new System.Drawing.Point(439, 209);
            this.RectHeightNumeric.Name = "RectHeightNumeric";
            this.RectHeightNumeric.Size = new System.Drawing.Size(71, 20);
            this.RectHeightNumeric.TabIndex = 41;
            this.RectHeightNumeric.Value = new decimal(new int[] {
            65,
            0,
            0,
            65536});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Performance Percentage (0-1)";
            // 
            // PerformanceNumeric
            // 
            this.PerformanceNumeric.DecimalPlaces = 2;
            this.PerformanceNumeric.Location = new System.Drawing.Point(173, 288);
            this.PerformanceNumeric.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PerformanceNumeric.Name = "PerformanceNumeric";
            this.PerformanceNumeric.Size = new System.Drawing.Size(71, 20);
            this.PerformanceNumeric.TabIndex = 43;
            this.PerformanceNumeric.Value = new decimal(new int[] {
            85,
            0,
            0,
            131072});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(289, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "Allowed to repeat (count)";
            // 
            // AllowedToRepeatNumeric
            // 
            this.AllowedToRepeatNumeric.Location = new System.Drawing.Point(439, 105);
            this.AllowedToRepeatNumeric.Name = "AllowedToRepeatNumeric";
            this.AllowedToRepeatNumeric.Size = new System.Drawing.Size(71, 20);
            this.AllowedToRepeatNumeric.TabIndex = 45;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BreakMessageRichTextBox);
            this.groupBox1.Location = new System.Drawing.Point(11, 416);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 114);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Break Message";
            // 
            // PerformanceMessageRchTextBox
            // 
            this.PerformanceMessageRchTextBox.Location = new System.Drawing.Point(6, 19);
            this.PerformanceMessageRchTextBox.Name = "PerformanceMessageRchTextBox";
            this.PerformanceMessageRchTextBox.Size = new System.Drawing.Size(232, 89);
            this.PerformanceMessageRchTextBox.TabIndex = 0;
            this.PerformanceMessageRchTextBox.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PerformanceMessageRchTextBox);
            this.groupBox2.Location = new System.Drawing.Point(262, 416);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 114);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Performance Message";
            // 
            // StopMessageRichTextBox
            // 
            this.StopMessageRichTextBox.Location = new System.Drawing.Point(6, 19);
            this.StopMessageRichTextBox.Name = "StopMessageRichTextBox";
            this.StopMessageRichTextBox.Size = new System.Drawing.Size(225, 89);
            this.StopMessageRichTextBox.TabIndex = 0;
            this.StopMessageRichTextBox.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.StopMessageRichTextBox);
            this.groupBox3.Location = new System.Drawing.Point(511, 416);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 114);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stop Message";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(289, 241);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 13);
            this.label14.TabIndex = 46;
            this.label14.Text = "Frame Width (mm)";
            // 
            // FrameWidthNumeric
            // 
            this.FrameWidthNumeric.DecimalPlaces = 1;
            this.FrameWidthNumeric.Location = new System.Drawing.Point(439, 237);
            this.FrameWidthNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.FrameWidthNumeric.Name = "FrameWidthNumeric";
            this.FrameWidthNumeric.Size = new System.Drawing.Size(71, 20);
            this.FrameWidthNumeric.TabIndex = 47;
            this.FrameWidthNumeric.Value = new decimal(new int[] {
            160,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(289, 268);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 13);
            this.label15.TabIndex = 48;
            this.label15.Text = "Frame Height (mm)";
            // 
            // FrameHeightNumeric
            // 
            this.FrameHeightNumeric.DecimalPlaces = 1;
            this.FrameHeightNumeric.Location = new System.Drawing.Point(439, 263);
            this.FrameHeightNumeric.Name = "FrameHeightNumeric";
            this.FrameHeightNumeric.Size = new System.Drawing.Size(71, 20);
            this.FrameHeightNumeric.TabIndex = 49;
            this.FrameHeightNumeric.Value = new decimal(new int[] {
            67,
            0,
            0,
            0});
            // 
            // OrderlistView
            // 
            this.OrderlistView.HideSelection = false;
            this.OrderlistView.Location = new System.Drawing.Point(6, 19);
            this.OrderlistView.MultiSelect = false;
            this.OrderlistView.Name = "OrderlistView";
            this.OrderlistView.Size = new System.Drawing.Size(209, 159);
            this.OrderlistView.TabIndex = 0;
            this.OrderlistView.UseCompatibleStateImageBehavior = false;
            this.OrderlistView.View = System.Windows.Forms.View.List;
            // 
            // MinusButton
            // 
            this.MinusButton.Location = new System.Drawing.Point(113, 184);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(36, 23);
            this.MinusButton.TabIndex = 1;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.Location = new System.Drawing.Point(71, 184);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(36, 23);
            this.PlusButton.TabIndex = 3;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // RemoveOrderButton
            // 
            this.RemoveOrderButton.Location = new System.Drawing.Point(155, 184);
            this.RemoveOrderButton.Name = "RemoveOrderButton";
            this.RemoveOrderButton.Size = new System.Drawing.Size(60, 23);
            this.RemoveOrderButton.TabIndex = 4;
            this.RemoveOrderButton.Text = "Remove";
            this.RemoveOrderButton.UseVisualStyleBackColor = true;
            this.RemoveOrderButton.Click += new System.EventHandler(this.RemoveOrderButton_Click);
            // 
            // DuplicateOrderButton
            // 
            this.DuplicateOrderButton.Location = new System.Drawing.Point(5, 184);
            this.DuplicateOrderButton.Name = "DuplicateOrderButton";
            this.DuplicateOrderButton.Size = new System.Drawing.Size(60, 23);
            this.DuplicateOrderButton.TabIndex = 5;
            this.DuplicateOrderButton.Text = "DuplicateOrderButton";
            this.DuplicateOrderButton.UseVisualStyleBackColor = true;
            this.DuplicateOrderButton.Click += new System.EventHandler(this.DuplicateOrderButton_Click);
            // 
            // OrderGroup
            // 
            this.OrderGroup.Controls.Add(this.DuplicateOrderButton);
            this.OrderGroup.Controls.Add(this.RemoveOrderButton);
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
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(670, 542);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 20;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(8, 542);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 21;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
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
            this.TagsListView.SelectedIndexChanged += new System.EventHandler(this.TagsListView_SelectedIndexChanged);
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
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 263);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 13);
            this.label16.TabIndex = 52;
            this.label16.Text = "Stimulus Opacity (0-1)";
            // 
            // StimulusOpacityNumeric
            // 
            this.StimulusOpacityNumeric.DecimalPlaces = 2;
            this.StimulusOpacityNumeric.Location = new System.Drawing.Point(173, 261);
            this.StimulusOpacityNumeric.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StimulusOpacityNumeric.Name = "StimulusOpacityNumeric";
            this.StimulusOpacityNumeric.Size = new System.Drawing.Size(71, 20);
            this.StimulusOpacityNumeric.TabIndex = 53;
            // 
            // BlockNumeric
            // 
            this.BlockNumeric.Location = new System.Drawing.Point(339, 19);
            this.BlockNumeric.Name = "BlockNumeric";
            this.BlockNumeric.Size = new System.Drawing.Size(51, 20);
            this.BlockNumeric.TabIndex = 24;
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
            // SubBlockNumeric
            // 
            this.SubBlockNumeric.Location = new System.Drawing.Point(458, 19);
            this.SubBlockNumeric.Name = "SubBlockNumeric";
            this.SubBlockNumeric.Size = new System.Drawing.Size(51, 20);
            this.SubBlockNumeric.TabIndex = 26;
            // 
            // StimulusHeightNumeric
            // 
            this.StimulusHeightNumeric.Location = new System.Drawing.Point(439, 317);
            this.StimulusHeightNumeric.Name = "StimulusHeightNumeric";
            this.StimulusHeightNumeric.Size = new System.Drawing.Size(71, 20);
            this.StimulusHeightNumeric.TabIndex = 57;
            this.StimulusHeightNumeric.Value = new decimal(new int[] {
            65,
            0,
            0,
            0});
            // 
            // FixationWidthNumeric
            // 
            this.FixationWidthNumeric.DecimalPlaces = 1;
            this.FixationWidthNumeric.Location = new System.Drawing.Point(439, 347);
            this.FixationWidthNumeric.Name = "FixationWidthNumeric";
            this.FixationWidthNumeric.Size = new System.Drawing.Size(71, 20);
            this.FixationWidthNumeric.TabIndex = 59;
            this.FixationWidthNumeric.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // BreakMessageRichTextBox
            // 
            this.BreakMessageRichTextBox.Location = new System.Drawing.Point(6, 19);
            this.BreakMessageRichTextBox.Name = "BreakMessageRichTextBox";
            this.BreakMessageRichTextBox.Size = new System.Drawing.Size(232, 89);
            this.BreakMessageRichTextBox.TabIndex = 0;
            this.BreakMessageRichTextBox.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(289, 295);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 13);
            this.label13.TabIndex = 54;
            this.label13.Text = "Stimulus Width (mm)";
            // 
            // StimulusWidthNumeric
            // 
            this.StimulusWidthNumeric.DecimalPlaces = 1;
            this.StimulusWidthNumeric.Location = new System.Drawing.Point(439, 291);
            this.StimulusWidthNumeric.Name = "StimulusWidthNumeric";
            this.StimulusWidthNumeric.Size = new System.Drawing.Size(71, 20);
            this.StimulusWidthNumeric.TabIndex = 55;
            this.StimulusWidthNumeric.Value = new decimal(new int[] {
            65,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(289, 322);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 13);
            this.label11.TabIndex = 56;
            this.label11.Text = "Stimulus Height (mm)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(289, 351);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 13);
            this.label17.TabIndex = 58;
            this.label17.Text = "Fixation Width (mm)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(289, 378);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 13);
            this.label10.TabIndex = 60;
            this.label10.Text = "Fixation Height (mm)";
            // 
            // FixationHeightNumeric
            // 
            this.FixationHeightNumeric.DecimalPlaces = 1;
            this.FixationHeightNumeric.Location = new System.Drawing.Point(439, 373);
            this.FixationHeightNumeric.Name = "FixationHeightNumeric";
            this.FixationHeightNumeric.Size = new System.Drawing.Size(71, 20);
            this.FixationHeightNumeric.TabIndex = 61;
            this.FixationHeightNumeric.Value = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            // 
            // BrmsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 646);
            this.Controls.Add(this.ParamsGroupBox);
            this.Controls.Add(this.AllBRMSGroupBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.StimulusGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            ((System.ComponentModel.ISupportInitialize)(this.RectangleNumeric)).EndInit();
            this.TypeGroupBox.ResumeLayout(false);
            this.TypeGroupBox.PerformLayout();
            this.StimulusGroup.ResumeLayout(false);
            this.StimulusGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MondrianMaxOpacityNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectWidthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectHeightNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PerformanceNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllowedToRepeatNumeric)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FrameWidthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrameHeightNumeric)).EndInit();
            this.OrderGroup.ResumeLayout(false);
            this.TagsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StimulusOpacityNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubBlockNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StimulusHeightNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FixationWidthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StimulusWidthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FixationHeightNumeric)).EndInit();
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