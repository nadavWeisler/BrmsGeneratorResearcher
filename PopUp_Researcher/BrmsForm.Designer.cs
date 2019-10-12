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
            this.TypeGroupBox = new System.Windows.Forms.GroupBox();
            this.SubBlockNumeric = new System.Windows.Forms.NumericUpDown();
            this.SubBlockLabel = new System.Windows.Forms.Label();
            this.BlockNumeric = new System.Windows.Forms.NumericUpDown();
            this.BlockLabel = new System.Windows.Forms.Label();
            this.RandomRadio = new System.Windows.Forms.RadioButton();
            this.OrderdRadio = new System.Windows.Forms.RadioButton();
            this.MixedRadio = new System.Windows.Forms.RadioButton();
            this.ParamsGroup = new System.Windows.Forms.GroupBox();
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
            this.ClearButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.OrderGroup = new System.Windows.Forms.GroupBox();
            this.PlusButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.OrderlistView = new System.Windows.Forms.ListView();
            this.SaveButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TagsListView = new System.Windows.Forms.ListView();
            this.TagsGroupBox = new System.Windows.Forms.GroupBox();
            this.onebRMSGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BreakMessageRichTextBox = new System.Windows.Forms.RichTextBox();
            this.AllTrialsListView = new System.Windows.Forms.ListView();
            this.AllBRMSGroupBox = new System.Windows.Forms.GroupBox();
            this.UpButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.DuplicateButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AllowedToRepeatNumeric = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PerformanceMessageRchTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.StopMessageRichTextBox = new System.Windows.Forms.RichTextBox();
            this.FrameWidthNumeric = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OriantetionComboBox = new System.Windows.Forms.ComboBox();
            this.FrameHeightNumeric = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.StimulusGroup.SuspendLayout();
            this.TypeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubBlockNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockNumeric)).BeginInit();
            this.ParamsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PerformanceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectHeightNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectWithNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FadeOutLengthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrialLimitNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MondrianMaxOpacityNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StimulusMaxOpacityNumeric)).BeginInit();
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
            this.OrderGroup.SuspendLayout();
            this.TagsGroupBox.SuspendLayout();
            this.onebRMSGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.AllBRMSGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllowedToRepeatNumeric)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FrameWidthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrameHeightNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // StimulusGroup
            // 
            this.StimulusGroup.Controls.Add(this.HelpCsvButton);
            this.StimulusGroup.Controls.Add(this.HelpCsvLabel);
            this.StimulusGroup.Controls.Add(this.HelpCsvTextBox);
            this.StimulusGroup.Location = new System.Drawing.Point(12, 12);
            this.StimulusGroup.Name = "StimulusGroup";
            this.StimulusGroup.Size = new System.Drawing.Size(745, 56);
            this.StimulusGroup.TabIndex = 1;
            this.StimulusGroup.TabStop = false;
            this.StimulusGroup.Text = "Basic";
            // 
            // HelpCsvButton
            // 
            this.HelpCsvButton.Location = new System.Drawing.Point(709, 18);
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
            this.HelpCsvTextBox.Size = new System.Drawing.Size(612, 20);
            this.HelpCsvTextBox.TabIndex = 4;
            this.HelpCsvTextBox.TextChanged += new System.EventHandler(this.HelpCsvTextBox_TextChanged);
            this.HelpCsvTextBox.DoubleClick += new System.EventHandler(this.HelpCsvTextBox_DoubleClick);
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
            this.TypeGroupBox.Size = new System.Drawing.Size(527, 51);
            this.TypeGroupBox.TabIndex = 4;
            this.TypeGroupBox.TabStop = false;
            this.TypeGroupBox.Text = "bRMS type";
            // 
            // SubBlockNumeric
            // 
            this.SubBlockNumeric.Location = new System.Drawing.Point(466, 25);
            this.SubBlockNumeric.Name = "SubBlockNumeric";
            this.SubBlockNumeric.Size = new System.Drawing.Size(51, 20);
            this.SubBlockNumeric.TabIndex = 26;
            // 
            // SubBlockLabel
            // 
            this.SubBlockLabel.AutoSize = true;
            this.SubBlockLabel.Location = new System.Drawing.Point(404, 27);
            this.SubBlockLabel.Name = "SubBlockLabel";
            this.SubBlockLabel.Size = new System.Drawing.Size(56, 13);
            this.SubBlockLabel.TabIndex = 25;
            this.SubBlockLabel.Text = "Sub Block";
            // 
            // BlockNumeric
            // 
            this.BlockNumeric.Location = new System.Drawing.Point(347, 25);
            this.BlockNumeric.Name = "BlockNumeric";
            this.BlockNumeric.Size = new System.Drawing.Size(51, 20);
            this.BlockNumeric.TabIndex = 24;
            // 
            // BlockLabel
            // 
            this.BlockLabel.AutoSize = true;
            this.BlockLabel.Location = new System.Drawing.Point(306, 27);
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
            this.OrderdRadio.CheckedChanged += new System.EventHandler(this.OrderedRadio_CheckedChanged);
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
            // ParamsGroup
            // 
            this.ParamsGroup.Controls.Add(this.FrameHeightNumeric);
            this.ParamsGroup.Controls.Add(this.label15);
            this.ParamsGroup.Controls.Add(this.FrameWidthNumeric);
            this.ParamsGroup.Controls.Add(this.label14);
            this.ParamsGroup.Controls.Add(this.groupBox3);
            this.ParamsGroup.Controls.Add(this.groupBox2);
            this.ParamsGroup.Controls.Add(this.groupBox1);
            this.ParamsGroup.Controls.Add(this.AllowedToRepeatNumeric);
            this.ParamsGroup.Controls.Add(this.label12);
            this.ParamsGroup.Controls.Add(this.PerformanceNumeric);
            this.ParamsGroup.Controls.Add(this.label7);
            this.ParamsGroup.Controls.Add(this.RectHeightNumeric);
            this.ParamsGroup.Controls.Add(this.label1);
            this.ParamsGroup.Controls.Add(this.RectWithNumeric);
            this.ParamsGroup.Controls.Add(this.label4);
            this.ParamsGroup.Controls.Add(this.label13);
            this.ParamsGroup.Controls.Add(this.FadeOutLengthNumeric);
            this.ParamsGroup.Controls.Add(this.TrialLimitNumeric);
            this.ParamsGroup.Controls.Add(this.label11);
            this.ParamsGroup.Controls.Add(this.MondrianMaxOpacityNumeric);
            this.ParamsGroup.Controls.Add(this.label8);
            this.ParamsGroup.Controls.Add(this.label3);
            this.ParamsGroup.Controls.Add(this.StimulusMaxOpacityNumeric);
            this.ParamsGroup.Controls.Add(this.OriantetionComboBox);
            this.ParamsGroup.Controls.Add(this.label2);
            this.ParamsGroup.Controls.Add(this.TypeGroupBox);
            this.ParamsGroup.Controls.Add(this.rectNumLabel);
            this.ParamsGroup.Controls.Add(this.RectangleNumeric);
            this.ParamsGroup.Controls.Add(this.ExperimentLengthNumeric);
            this.ParamsGroup.Controls.Add(this.TimingResponseLabel);
            this.ParamsGroup.Controls.Add(this.TimingResponseNumeric);
            this.ParamsGroup.Controls.Add(this.MondrianCountLabel);
            this.ParamsGroup.Controls.Add(this.MondrianCountNumeric);
            this.ParamsGroup.Controls.Add(this.ITILabel);
            this.ParamsGroup.Controls.Add(this.ItiNumeric);
            this.ParamsGroup.Controls.Add(this.label10);
            this.ParamsGroup.Controls.Add(this.label9);
            this.ParamsGroup.Controls.Add(this.TimingPostTrialNumeric);
            this.ParamsGroup.Controls.Add(this.MondrianMaxOpacity);
            this.ParamsGroup.Controls.Add(this.BreakTimeNumeric);
            this.ParamsGroup.Controls.Add(this.VisUnitNumeric);
            this.ParamsGroup.Controls.Add(this.label6);
            this.ParamsGroup.Controls.Add(this.FacdeOutTimeNumeric);
            this.ParamsGroup.Controls.Add(this.label5);
            this.ParamsGroup.Controls.Add(this.FadeInTimeNumeric);
            this.ParamsGroup.Controls.Add(this.TrialLengthLabel);
            this.ParamsGroup.Controls.Add(this.MaxTypeLabel);
            this.ParamsGroup.Controls.Add(this.CountLabel);
            this.ParamsGroup.Controls.Add(this.MaxTypeNumeric);
            this.ParamsGroup.Controls.Add(this.CountNumeric);
            this.ParamsGroup.Location = new System.Drawing.Point(6, 19);
            this.ParamsGroup.Name = "ParamsGroup";
            this.ParamsGroup.Size = new System.Drawing.Size(542, 552);
            this.ParamsGroup.TabIndex = 5;
            this.ParamsGroup.TabStop = false;
            this.ParamsGroup.Text = "Paramenters";
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
            this.label7.Location = new System.Drawing.Point(293, 262);
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
            this.label1.Location = new System.Drawing.Point(291, 312);
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
            this.label4.Location = new System.Drawing.Point(291, 286);
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
            this.TrialLimitNumeric.Location = new System.Drawing.Point(110, 317);
            this.TrialLimitNumeric.Name = "TrialLimitNumeric";
            this.TrialLimitNumeric.Size = new System.Drawing.Size(71, 20);
            this.TrialLimitNumeric.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 317);
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
            this.label8.Location = new System.Drawing.Point(291, 234);
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
            // rectNumLabel
            // 
            this.rectNumLabel.AutoSize = true;
            this.rectNumLabel.Location = new System.Drawing.Point(291, 160);
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
            this.ExperimentLengthNumeric.Location = new System.Drawing.Point(453, 132);
            this.ExperimentLengthNumeric.Name = "ExperimentLengthNumeric";
            this.ExperimentLengthNumeric.Size = new System.Drawing.Size(71, 20);
            this.ExperimentLengthNumeric.TabIndex = 24;
            // 
            // TimingResponseLabel
            // 
            this.TimingResponseLabel.AutoSize = true;
            this.TimingResponseLabel.Location = new System.Drawing.Point(292, 183);
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
            this.ITILabel.Location = new System.Drawing.Point(293, 109);
            this.ITILabel.Name = "ITILabel";
            this.ITILabel.Size = new System.Drawing.Size(112, 13);
            this.ITILabel.TabIndex = 19;
            this.ITILabel.Text = "ITI Reserved Duration";
            // 
            // ItiNumeric
            // 
            this.ItiNumeric.Location = new System.Drawing.Point(453, 106);
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
            this.label9.Location = new System.Drawing.Point(291, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Timing Post Experiment ";
            // 
            // TimingPostTrialNumeric
            // 
            this.TimingPostTrialNumeric.Location = new System.Drawing.Point(453, 77);
            this.TimingPostTrialNumeric.Name = "TimingPostTrialNumeric";
            this.TimingPostTrialNumeric.Size = new System.Drawing.Size(71, 20);
            this.TimingPostTrialNumeric.TabIndex = 14;
            // 
            // MondrianMaxOpacity
            // 
            this.MondrianMaxOpacity.AutoSize = true;
            this.MondrianMaxOpacity.Location = new System.Drawing.Point(291, 210);
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
            this.TrialLengthLabel.Location = new System.Drawing.Point(293, 135);
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
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(6, 577);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 21;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(467, 577);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 20;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // OrderGroup
            // 
            this.OrderGroup.Controls.Add(this.PlusButton);
            this.OrderGroup.Controls.Add(this.MinusButton);
            this.OrderGroup.Controls.Add(this.OrderlistView);
            this.OrderGroup.Enabled = false;
            this.OrderGroup.Location = new System.Drawing.Point(554, 180);
            this.OrderGroup.Name = "OrderGroup";
            this.OrderGroup.Size = new System.Drawing.Size(185, 217);
            this.OrderGroup.TabIndex = 5;
            this.OrderGroup.TabStop = false;
            this.OrderGroup.Text = "Order";
            // 
            // PlusButton
            // 
            this.PlusButton.Location = new System.Drawing.Point(143, 188);
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
            this.OrderlistView.Size = new System.Drawing.Size(173, 159);
            this.OrderlistView.TabIndex = 0;
            this.OrderlistView.UseCompatibleStateImageBehavior = false;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(905, 453);
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
            // TagsListView
            // 
            this.TagsListView.HideSelection = false;
            this.TagsListView.Location = new System.Drawing.Point(9, 21);
            this.TagsListView.Name = "TagsListView";
            this.TagsListView.Size = new System.Drawing.Size(170, 134);
            this.TagsListView.TabIndex = 7;
            this.TagsListView.UseCompatibleStateImageBehavior = false;
            this.TagsListView.View = System.Windows.Forms.View.List;
            // 
            // TagsGroupBox
            // 
            this.TagsGroupBox.Controls.Add(this.TagsListView);
            this.TagsGroupBox.Location = new System.Drawing.Point(554, 19);
            this.TagsGroupBox.Name = "TagsGroupBox";
            this.TagsGroupBox.Size = new System.Drawing.Size(185, 162);
            this.TagsGroupBox.TabIndex = 8;
            this.TagsGroupBox.TabStop = false;
            this.TagsGroupBox.Text = "Tags";
            // 
            // onebRMSGroupBox
            // 
            this.onebRMSGroupBox.Controls.Add(this.TagsGroupBox);
            this.onebRMSGroupBox.Controls.Add(this.ClearButton);
            this.onebRMSGroupBox.Controls.Add(this.OrderGroup);
            this.onebRMSGroupBox.Controls.Add(this.ParamsGroup);
            this.onebRMSGroupBox.Controls.Add(this.AddButton);
            this.onebRMSGroupBox.Location = new System.Drawing.Point(12, 74);
            this.onebRMSGroupBox.Name = "onebRMSGroupBox";
            this.onebRMSGroupBox.Size = new System.Drawing.Size(745, 606);
            this.onebRMSGroupBox.TabIndex = 9;
            this.onebRMSGroupBox.TabStop = false;
            this.onebRMSGroupBox.Text = "Single bRMS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BreakMessageRichTextBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 419);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 127);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Break Message";
            // 
            // BreakMessageRichTextBox
            // 
            this.BreakMessageRichTextBox.Location = new System.Drawing.Point(6, 19);
            this.BreakMessageRichTextBox.Name = "BreakMessageRichTextBox";
            this.BreakMessageRichTextBox.Size = new System.Drawing.Size(163, 102);
            this.BreakMessageRichTextBox.TabIndex = 0;
            this.BreakMessageRichTextBox.Text = "";
            // 
            // AllTrialsListView
            // 
            this.AllTrialsListView.HideSelection = false;
            this.AllTrialsListView.Location = new System.Drawing.Point(6, 19);
            this.AllTrialsListView.Name = "AllTrialsListView";
            this.AllTrialsListView.Size = new System.Drawing.Size(211, 350);
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
            this.AllBRMSGroupBox.Location = new System.Drawing.Point(763, 12);
            this.AllBRMSGroupBox.Name = "AllBRMSGroupBox";
            this.AllBRMSGroupBox.Size = new System.Drawing.Size(227, 436);
            this.AllBRMSGroupBox.TabIndex = 10;
            this.AllBRMSGroupBox.TabStop = false;
            this.AllBRMSGroupBox.Text = "All Trials";
            // 
            // UpButton
            // 
            this.UpButton.Location = new System.Drawing.Point(6, 375);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(75, 23);
            this.UpButton.TabIndex = 34;
            this.UpButton.Text = "+";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // DownButton
            // 
            this.DownButton.Location = new System.Drawing.Point(142, 375);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(75, 23);
            this.DownButton.TabIndex = 33;
            this.DownButton.Text = "-";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // DuplicateButton
            // 
            this.DuplicateButton.Enabled = false;
            this.DuplicateButton.Location = new System.Drawing.Point(6, 404);
            this.DuplicateButton.Name = "DuplicateButton";
            this.DuplicateButton.Size = new System.Drawing.Size(75, 23);
            this.DuplicateButton.TabIndex = 32;
            this.DuplicateButton.Text = "Duplicate";
            this.DuplicateButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(142, 401);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 31;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AllowedToRepeatNumeric
            // 
            this.AllowedToRepeatNumeric.Location = new System.Drawing.Point(455, 338);
            this.AllowedToRepeatNumeric.Name = "AllowedToRepeatNumeric";
            this.AllowedToRepeatNumeric.Size = new System.Drawing.Size(71, 20);
            this.AllowedToRepeatNumeric.TabIndex = 45;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(293, 338);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "Allowed to repeat";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PerformanceMessageRchTextBox);
            this.groupBox2.Location = new System.Drawing.Point(187, 419);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 127);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Performance Message";
            // 
            // PerformanceMessageRchTextBox
            // 
            this.PerformanceMessageRchTextBox.Location = new System.Drawing.Point(6, 19);
            this.PerformanceMessageRchTextBox.Name = "PerformanceMessageRchTextBox";
            this.PerformanceMessageRchTextBox.Size = new System.Drawing.Size(163, 102);
            this.PerformanceMessageRchTextBox.TabIndex = 0;
            this.PerformanceMessageRchTextBox.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.StopMessageRichTextBox);
            this.groupBox3.Location = new System.Drawing.Point(368, 419);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(168, 127);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stop Message";
            // 
            // StopMessageRichTextBox
            // 
            this.StopMessageRichTextBox.Location = new System.Drawing.Point(6, 19);
            this.StopMessageRichTextBox.Name = "StopMessageRichTextBox";
            this.StopMessageRichTextBox.Size = new System.Drawing.Size(156, 102);
            this.StopMessageRichTextBox.TabIndex = 0;
            this.StopMessageRichTextBox.Text = "";
            // 
            // FrameWidthNumeric
            // 
            this.FrameWidthNumeric.Location = new System.Drawing.Point(455, 364);
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
            this.label14.Location = new System.Drawing.Point(296, 366);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 13);
            this.label14.TabIndex = 46;
            this.label14.Text = "Frame Width Percentage";
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
            this.OriantetionComboBox.SelectedIndexChanged += new System.EventHandler(this.OriantetionComboBox_SelectedIndexChanged);
            // 
            // FrameHeightNumeric
            // 
            this.FrameHeightNumeric.Location = new System.Drawing.Point(455, 391);
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
            this.label15.Location = new System.Drawing.Point(296, 393);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 13);
            this.label15.TabIndex = 48;
            this.label15.Text = "Frame Height Percentage";
            // 
            // BrmsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 692);
            this.Controls.Add(this.AllBRMSGroupBox);
            this.Controls.Add(this.onebRMSGroupBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.StimulusGroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BrmsForm";
            this.Text = "bRMS";
            this.StimulusGroup.ResumeLayout(false);
            this.StimulusGroup.PerformLayout();
            this.TypeGroupBox.ResumeLayout(false);
            this.TypeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubBlockNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockNumeric)).EndInit();
            this.ParamsGroup.ResumeLayout(false);
            this.ParamsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PerformanceNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectHeightNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectWithNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FadeOutLengthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrialLimitNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MondrianMaxOpacityNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StimulusMaxOpacityNumeric)).EndInit();
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
            this.OrderGroup.ResumeLayout(false);
            this.TagsGroupBox.ResumeLayout(false);
            this.onebRMSGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.AllBRMSGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AllowedToRepeatNumeric)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FrameWidthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrameHeightNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox StimulusGroup;
        private System.Windows.Forms.GroupBox TypeGroupBox;
        private System.Windows.Forms.RadioButton RandomRadio;
        private System.Windows.Forms.RadioButton OrderdRadio;
        private System.Windows.Forms.RadioButton MixedRadio;
        private System.Windows.Forms.GroupBox ParamsGroup;
        private System.Windows.Forms.Label ITILabel;
        private System.Windows.Forms.NumericUpDown ItiNumeric;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown TimingPostTrialNumeric;
        private System.Windows.Forms.Label MondrianMaxOpacity;
        private System.Windows.Forms.NumericUpDown BreakTimeNumeric;
        private System.Windows.Forms.NumericUpDown VisUnitNumeric;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown FacdeOutTimeNumeric;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown FadeInTimeNumeric;
        private System.Windows.Forms.Label TrialLengthLabel;
        private System.Windows.Forms.Label MaxTypeLabel;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.NumericUpDown MaxTypeNumeric;
        private System.Windows.Forms.NumericUpDown CountNumeric;
        private System.Windows.Forms.GroupBox OrderGroup;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.ListView OrderlistView;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button HelpCsvButton;
        private System.Windows.Forms.Label HelpCsvLabel;
        private System.Windows.Forms.TextBox HelpCsvTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListView TagsListView;
        private System.Windows.Forms.GroupBox TagsGroupBox;
        private System.Windows.Forms.GroupBox onebRMSGroupBox;
        private System.Windows.Forms.ListView AllTrialsListView;
        private System.Windows.Forms.GroupBox AllBRMSGroupBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label MondrianCountLabel;
        private System.Windows.Forms.NumericUpDown MondrianCountNumeric;
        private System.Windows.Forms.NumericUpDown ExperimentLengthNumeric;
        private System.Windows.Forms.Label TimingResponseLabel;
        private System.Windows.Forms.NumericUpDown TimingResponseNumeric;
        private System.Windows.Forms.Label rectNumLabel;
        private System.Windows.Forms.NumericUpDown RectangleNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown StimulusMaxOpacityNumeric;
        private System.Windows.Forms.NumericUpDown TrialLimitNumeric;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown MondrianMaxOpacityNumeric;
        private System.Windows.Forms.Label label8;
        private Label label13;
        private NumericUpDown FadeOutLengthNumeric;
        private NumericUpDown SubBlockNumeric;
        private Label SubBlockLabel;
        private NumericUpDown BlockNumeric;
        private Label BlockLabel;
        private Button UpButton;
        private Button DownButton;
        private Button DuplicateButton;
        private Button RemoveButton;
        private NumericUpDown RectHeightNumeric;
        private Label label1;
        private NumericUpDown RectWithNumeric;
        private Label label4;
        private NumericUpDown PerformanceNumeric;
        private Label label7;
        private GroupBox groupBox1;
        private RichTextBox BreakMessageRichTextBox;
        private GroupBox groupBox3;
        private RichTextBox StopMessageRichTextBox;
        private GroupBox groupBox2;
        private RichTextBox PerformanceMessageRchTextBox;
        private NumericUpDown AllowedToRepeatNumeric;
        private Label label12;
        private NumericUpDown FrameHeightNumeric;
        private Label label15;
        private NumericUpDown FrameWidthNumeric;
        private Label label14;
        private ComboBox OriantetionComboBox;
        private Label label2;
    }
}