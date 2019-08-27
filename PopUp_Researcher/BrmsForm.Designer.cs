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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.StimulusTextBox = new System.Windows.Forms.TextBox();
            this.StimulusGroup = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.HelpCsvButton = new System.Windows.Forms.Button();
            this.HelpCsvLabel = new System.Windows.Forms.Label();
            this.HelpCsvTextBox = new System.Windows.Forms.TextBox();
            this.StimulusFolderButton = new System.Windows.Forms.Button();
            this.StimulusFolderLabel = new System.Windows.Forms.Label();
            this.TypeGroupBox = new System.Windows.Forms.GroupBox();
            this.RandomRadio = new System.Windows.Forms.RadioButton();
            this.OrderdRadio = new System.Windows.Forms.RadioButton();
            this.MixedRadio = new System.Windows.Forms.RadioButton();
            this.ParamsGroup = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.FadeOutLengthNumeric = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown12 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown11 = new System.Windows.Forms.NumericUpDown();
            this.OriantetionComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rectNumLabel = new System.Windows.Forms.Label();
            this.RectangleNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.TimingResponseLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.MondrianCountLabel = new System.Windows.Forms.Label();
            this.MondrianCountNumeric = new System.Windows.Forms.NumericUpDown();
            this.ITILabel = new System.Windows.Forms.Label();
            this.numericUpDown10 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.MondrianMaxOpacity = new System.Windows.Forms.Label();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.VisUnitNumeric = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.FacdeOutTimeNumeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.FadeInTimeNumeric = new System.Windows.Forms.NumericUpDown();
            this.TrialLengthLabel = new System.Windows.Forms.Label();
            this.TrialLengthNumeric = new System.Windows.Forms.NumericUpDown();
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
            this.AllTrialsListView = new System.Windows.Forms.ListView();
            this.AllBRMSGroupBox = new System.Windows.Forms.GroupBox();
            this.SubGroupNumeric = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.GroupNumeric = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DuplicateButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.StimulusGroup.SuspendLayout();
            this.TypeGroupBox.SuspendLayout();
            this.ParamsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FadeOutLengthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectangleNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MondrianCountNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisUnitNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacdeOutTimeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FadeInTimeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrialLengthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxTypeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountNumeric)).BeginInit();
            this.OrderGroup.SuspendLayout();
            this.TagsGroupBox.SuspendLayout();
            this.onebRMSGroupBox.SuspendLayout();
            this.AllBRMSGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubGroupNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // StimulusTextBox
            // 
            this.StimulusTextBox.Location = new System.Drawing.Point(284, 21);
            this.StimulusTextBox.Name = "StimulusTextBox";
            this.StimulusTextBox.ReadOnly = true;
            this.StimulusTextBox.Size = new System.Drawing.Size(138, 20);
            this.StimulusTextBox.TabIndex = 0;
            this.StimulusTextBox.DoubleClick += new System.EventHandler(this.StimulusTextBox_DoubleClick);
            // 
            // StimulusGroup
            // 
            this.StimulusGroup.Controls.Add(this.label4);
            this.StimulusGroup.Controls.Add(this.NameTextBox);
            this.StimulusGroup.Controls.Add(this.HelpCsvButton);
            this.StimulusGroup.Controls.Add(this.HelpCsvLabel);
            this.StimulusGroup.Controls.Add(this.HelpCsvTextBox);
            this.StimulusGroup.Controls.Add(this.StimulusFolderButton);
            this.StimulusGroup.Controls.Add(this.StimulusFolderLabel);
            this.StimulusGroup.Controls.Add(this.StimulusTextBox);
            this.StimulusGroup.Location = new System.Drawing.Point(12, 12);
            this.StimulusGroup.Name = "StimulusGroup";
            this.StimulusGroup.Size = new System.Drawing.Size(739, 56);
            this.StimulusGroup.TabIndex = 1;
            this.StimulusGroup.TabStop = false;
            this.StimulusGroup.Text = "Basic";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(58, 21);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(129, 20);
            this.NameTextBox.TabIndex = 7;
            // 
            // HelpCsvButton
            // 
            this.HelpCsvButton.Location = new System.Drawing.Point(681, 21);
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
            this.HelpCsvLabel.Location = new System.Drawing.Point(458, 25);
            this.HelpCsvLabel.Name = "HelpCsvLabel";
            this.HelpCsvLabel.Size = new System.Drawing.Size(72, 13);
            this.HelpCsvLabel.TabIndex = 5;
            this.HelpCsvLabel.Text = "Help CSV File";
            // 
            // HelpCsvTextBox
            // 
            this.HelpCsvTextBox.Location = new System.Drawing.Point(536, 21);
            this.HelpCsvTextBox.Name = "HelpCsvTextBox";
            this.HelpCsvTextBox.ReadOnly = true;
            this.HelpCsvTextBox.Size = new System.Drawing.Size(139, 20);
            this.HelpCsvTextBox.TabIndex = 4;
            this.HelpCsvTextBox.TextChanged += new System.EventHandler(this.HelpCsvTextBox_TextChanged);
            this.HelpCsvTextBox.DoubleClick += new System.EventHandler(this.HelpCsvTextBox_DoubleClick);
            // 
            // StimulusFolderButton
            // 
            this.StimulusFolderButton.Location = new System.Drawing.Point(428, 21);
            this.StimulusFolderButton.Name = "StimulusFolderButton";
            this.StimulusFolderButton.Size = new System.Drawing.Size(24, 20);
            this.StimulusFolderButton.TabIndex = 3;
            this.StimulusFolderButton.Text = "...";
            this.StimulusFolderButton.UseVisualStyleBackColor = true;
            this.StimulusFolderButton.Click += new System.EventHandler(this.StimulusFolderButton_Click);
            // 
            // StimulusFolderLabel
            // 
            this.StimulusFolderLabel.AutoSize = true;
            this.StimulusFolderLabel.Location = new System.Drawing.Point(200, 24);
            this.StimulusFolderLabel.Name = "StimulusFolderLabel";
            this.StimulusFolderLabel.Size = new System.Drawing.Size(78, 13);
            this.StimulusFolderLabel.TabIndex = 2;
            this.StimulusFolderLabel.Text = "Stimulus Folder";
            // 
            // TypeGroupBox
            // 
            this.TypeGroupBox.Controls.Add(this.SubGroupNumeric);
            this.TypeGroupBox.Controls.Add(this.label7);
            this.TypeGroupBox.Controls.Add(this.GroupNumeric);
            this.TypeGroupBox.Controls.Add(this.label12);
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
            // RandomRadio
            // 
            this.RandomRadio.AutoSize = true;
            this.RandomRadio.Location = new System.Drawing.Point(97, 22);
            this.RandomRadio.Name = "RandomRadio";
            this.RandomRadio.Size = new System.Drawing.Size(65, 17);
            this.RandomRadio.TabIndex = 2;
            this.RandomRadio.TabStop = true;
            this.RandomRadio.Text = "Random";
            this.RandomRadio.UseVisualStyleBackColor = true;
            // 
            // OrderdRadio
            // 
            this.OrderdRadio.AutoSize = true;
            this.OrderdRadio.Enabled = false;
            this.OrderdRadio.Location = new System.Drawing.Point(188, 22);
            this.OrderdRadio.Name = "OrderdRadio";
            this.OrderdRadio.Size = new System.Drawing.Size(57, 17);
            this.OrderdRadio.TabIndex = 1;
            this.OrderdRadio.TabStop = true;
            this.OrderdRadio.Text = "Orderd";
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
            this.ParamsGroup.Controls.Add(this.label13);
            this.ParamsGroup.Controls.Add(this.FadeOutLengthNumeric);
            this.ParamsGroup.Controls.Add(this.numericUpDown12);
            this.ParamsGroup.Controls.Add(this.label11);
            this.ParamsGroup.Controls.Add(this.numericUpDown3);
            this.ParamsGroup.Controls.Add(this.label8);
            this.ParamsGroup.Controls.Add(this.label3);
            this.ParamsGroup.Controls.Add(this.numericUpDown11);
            this.ParamsGroup.Controls.Add(this.OriantetionComboBox);
            this.ParamsGroup.Controls.Add(this.label2);
            this.ParamsGroup.Controls.Add(this.TypeGroupBox);
            this.ParamsGroup.Controls.Add(this.rectNumLabel);
            this.ParamsGroup.Controls.Add(this.RectangleNumeric);
            this.ParamsGroup.Controls.Add(this.label1);
            this.ParamsGroup.Controls.Add(this.numericUpDown2);
            this.ParamsGroup.Controls.Add(this.TimingResponseLabel);
            this.ParamsGroup.Controls.Add(this.numericUpDown1);
            this.ParamsGroup.Controls.Add(this.MondrianCountLabel);
            this.ParamsGroup.Controls.Add(this.MondrianCountNumeric);
            this.ParamsGroup.Controls.Add(this.ITILabel);
            this.ParamsGroup.Controls.Add(this.numericUpDown10);
            this.ParamsGroup.Controls.Add(this.label10);
            this.ParamsGroup.Controls.Add(this.label9);
            this.ParamsGroup.Controls.Add(this.numericUpDown8);
            this.ParamsGroup.Controls.Add(this.MondrianMaxOpacity);
            this.ParamsGroup.Controls.Add(this.numericUpDown7);
            this.ParamsGroup.Controls.Add(this.VisUnitNumeric);
            this.ParamsGroup.Controls.Add(this.label6);
            this.ParamsGroup.Controls.Add(this.FacdeOutTimeNumeric);
            this.ParamsGroup.Controls.Add(this.label5);
            this.ParamsGroup.Controls.Add(this.FadeInTimeNumeric);
            this.ParamsGroup.Controls.Add(this.TrialLengthLabel);
            this.ParamsGroup.Controls.Add(this.TrialLengthNumeric);
            this.ParamsGroup.Controls.Add(this.MaxTypeLabel);
            this.ParamsGroup.Controls.Add(this.CountLabel);
            this.ParamsGroup.Controls.Add(this.MaxTypeNumeric);
            this.ParamsGroup.Controls.Add(this.CountNumeric);
            this.ParamsGroup.Location = new System.Drawing.Point(6, 19);
            this.ParamsGroup.Name = "ParamsGroup";
            this.ParamsGroup.Size = new System.Drawing.Size(542, 343);
            this.ParamsGroup.TabIndex = 5;
            this.ParamsGroup.TabStop = false;
            this.ParamsGroup.Text = "Paramenters";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 210);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "Fade Out Length";
            // 
            // FadeOutLengthNumeric
            // 
            this.FadeOutLengthNumeric.Location = new System.Drawing.Point(107, 208);
            this.FadeOutLengthNumeric.Name = "FadeOutLengthNumeric";
            this.FadeOutLengthNumeric.Size = new System.Drawing.Size(71, 20);
            this.FadeOutLengthNumeric.TabIndex = 36;
            this.FadeOutLengthNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDown12
            // 
            this.numericUpDown12.Location = new System.Drawing.Point(453, 260);
            this.numericUpDown12.Name = "numericUpDown12";
            this.numericUpDown12.Size = new System.Drawing.Size(71, 20);
            this.numericUpDown12.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(315, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Trial Limit";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 1;
            this.numericUpDown3.Location = new System.Drawing.Point(453, 234);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(71, 20);
            this.numericUpDown3.TabIndex = 33;
            this.numericUpDown3.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Mondrian Maximum Opacity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Break time";
            // 
            // numericUpDown11
            // 
            this.numericUpDown11.DecimalPlaces = 1;
            this.numericUpDown11.Location = new System.Drawing.Point(453, 210);
            this.numericUpDown11.Name = "numericUpDown11";
            this.numericUpDown11.Size = new System.Drawing.Size(71, 20);
            this.numericUpDown11.TabIndex = 30;
            this.numericUpDown11.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // OriantetionComboBox
            // 
            this.OriantetionComboBox.FormattingEnabled = true;
            this.OriantetionComboBox.Items.AddRange(new object[] {
            "Vertical",
            "Horizontal"});
            this.OriantetionComboBox.Location = new System.Drawing.Point(108, 312);
            this.OriantetionComboBox.Name = "OriantetionComboBox";
            this.OriantetionComboBox.Size = new System.Drawing.Size(71, 21);
            this.OriantetionComboBox.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Oriantetion";
            // 
            // rectNumLabel
            // 
            this.rectNumLabel.AutoSize = true;
            this.rectNumLabel.Location = new System.Drawing.Point(317, 158);
            this.rectNumLabel.Name = "rectNumLabel";
            this.rectNumLabel.Size = new System.Drawing.Size(96, 13);
            this.rectNumLabel.TabIndex = 27;
            this.rectNumLabel.Text = "Rectangle Number";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Timing Response";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(453, 132);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(71, 20);
            this.numericUpDown2.TabIndex = 24;
            // 
            // TimingResponseLabel
            // 
            this.TimingResponseLabel.AutoSize = true;
            this.TimingResponseLabel.Location = new System.Drawing.Point(316, 185);
            this.TimingResponseLabel.Name = "TimingResponseLabel";
            this.TimingResponseLabel.Size = new System.Drawing.Size(89, 13);
            this.TimingResponseLabel.TabIndex = 23;
            this.TimingResponseLabel.Text = "Timing Response";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(453, 183);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(71, 20);
            this.numericUpDown1.TabIndex = 22;
            this.numericUpDown1.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // MondrianCountLabel
            // 
            this.MondrianCountLabel.AutoSize = true;
            this.MondrianCountLabel.Location = new System.Drawing.Point(6, 262);
            this.MondrianCountLabel.Name = "MondrianCountLabel";
            this.MondrianCountLabel.Size = new System.Drawing.Size(82, 13);
            this.MondrianCountLabel.TabIndex = 21;
            this.MondrianCountLabel.Text = "Mondrian Count";
            // 
            // MondrianCountNumeric
            // 
            this.MondrianCountNumeric.Location = new System.Drawing.Point(108, 260);
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
            this.ITILabel.Location = new System.Drawing.Point(318, 108);
            this.ITILabel.Name = "ITILabel";
            this.ITILabel.Size = new System.Drawing.Size(112, 13);
            this.ITILabel.TabIndex = 19;
            this.ITILabel.Text = "ITI Reserved Duration";
            // 
            // numericUpDown10
            // 
            this.numericUpDown10.Location = new System.Drawing.Point(453, 106);
            this.numericUpDown10.Name = "numericUpDown10";
            this.numericUpDown10.Size = new System.Drawing.Size(71, 20);
            this.numericUpDown10.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Base Visual Unit ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(316, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Timing Post Experiment ";
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.Location = new System.Drawing.Point(453, 77);
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(71, 20);
            this.numericUpDown8.TabIndex = 14;
            // 
            // MondrianMaxOpacity
            // 
            this.MondrianMaxOpacity.AutoSize = true;
            this.MondrianMaxOpacity.Location = new System.Drawing.Point(315, 212);
            this.MondrianMaxOpacity.Name = "MondrianMaxOpacity";
            this.MondrianMaxOpacity.Size = new System.Drawing.Size(132, 13);
            this.MondrianMaxOpacity.TabIndex = 13;
            this.MondrianMaxOpacity.Text = "Stimulus Maximum Opacity";
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Location = new System.Drawing.Point(108, 286);
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(71, 20);
            this.numericUpDown7.TabIndex = 12;
            this.numericUpDown7.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // VisUnitNumeric
            // 
            this.VisUnitNumeric.Location = new System.Drawing.Point(108, 233);
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
            this.label6.Location = new System.Drawing.Point(6, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fade Out Time";
            // 
            // FacdeOutTimeNumeric
            // 
            this.FacdeOutTimeNumeric.Location = new System.Drawing.Point(108, 182);
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
            this.label5.Location = new System.Drawing.Point(6, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fade In Time";
            // 
            // FadeInTimeNumeric
            // 
            this.FadeInTimeNumeric.Location = new System.Drawing.Point(108, 156);
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
            this.TrialLengthLabel.Location = new System.Drawing.Point(318, 134);
            this.TrialLengthLabel.Name = "TrialLengthLabel";
            this.TrialLengthLabel.Size = new System.Drawing.Size(95, 13);
            this.TrialLengthLabel.TabIndex = 5;
            this.TrialLengthLabel.Text = "Experiment Length";
            // 
            // TrialLengthNumeric
            // 
            this.TrialLengthNumeric.Location = new System.Drawing.Point(108, 130);
            this.TrialLengthNumeric.Name = "TrialLengthNumeric";
            this.TrialLengthNumeric.Size = new System.Drawing.Size(71, 20);
            this.TrialLengthNumeric.TabIndex = 4;
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
            this.ClearButton.Location = new System.Drawing.Point(9, 368);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 21;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(473, 368);
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
            // 
            // TagsListView
            // 
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
            this.onebRMSGroupBox.Size = new System.Drawing.Size(745, 403);
            this.onebRMSGroupBox.TabIndex = 9;
            this.onebRMSGroupBox.TabStop = false;
            this.onebRMSGroupBox.Text = "Single bRMS";
            // 
            // AllTrialsListView
            // 
            this.AllTrialsListView.Location = new System.Drawing.Point(6, 19);
            this.AllTrialsListView.Name = "AllTrialsListView";
            this.AllTrialsListView.Size = new System.Drawing.Size(211, 350);
            this.AllTrialsListView.TabIndex = 8;
            this.AllTrialsListView.UseCompatibleStateImageBehavior = false;
            // 
            // AllBRMSGroupBox
            // 
            this.AllBRMSGroupBox.Controls.Add(this.button1);
            this.AllBRMSGroupBox.Controls.Add(this.button2);
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
            // SubGroupNumeric
            // 
            this.SubGroupNumeric.Location = new System.Drawing.Point(468, 20);
            this.SubGroupNumeric.Name = "SubGroupNumeric";
            this.SubGroupNumeric.Size = new System.Drawing.Size(51, 20);
            this.SubGroupNumeric.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(404, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Sub Group";
            // 
            // GroupNumeric
            // 
            this.GroupNumeric.Location = new System.Drawing.Point(348, 20);
            this.GroupNumeric.Name = "GroupNumeric";
            this.GroupNumeric.Size = new System.Drawing.Size(51, 20);
            this.GroupNumeric.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(306, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Group";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
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
            // 
            // BrmsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 488);
            this.Controls.Add(this.AllBRMSGroupBox);
            this.Controls.Add(this.onebRMSGroupBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.StimulusGroup);
            this.Name = "BrmsForm";
            this.Text = "bRMS";
            this.StimulusGroup.ResumeLayout(false);
            this.StimulusGroup.PerformLayout();
            this.TypeGroupBox.ResumeLayout(false);
            this.TypeGroupBox.PerformLayout();
            this.ParamsGroup.ResumeLayout(false);
            this.ParamsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FadeOutLengthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectangleNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MondrianCountNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisUnitNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacdeOutTimeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FadeInTimeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrialLengthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxTypeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountNumeric)).EndInit();
            this.OrderGroup.ResumeLayout(false);
            this.TagsGroupBox.ResumeLayout(false);
            this.onebRMSGroupBox.ResumeLayout(false);
            this.AllBRMSGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SubGroupNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox StimulusTextBox;
        private System.Windows.Forms.GroupBox StimulusGroup;
        private System.Windows.Forms.Button StimulusFolderButton;
        private System.Windows.Forms.Label StimulusFolderLabel;
        private System.Windows.Forms.GroupBox TypeGroupBox;
        private System.Windows.Forms.RadioButton RandomRadio;
        private System.Windows.Forms.RadioButton OrderdRadio;
        private System.Windows.Forms.RadioButton MixedRadio;
        private System.Windows.Forms.GroupBox ParamsGroup;
        private System.Windows.Forms.Label ITILabel;
        private System.Windows.Forms.NumericUpDown numericUpDown10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown8;
        private System.Windows.Forms.Label MondrianMaxOpacity;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.NumericUpDown VisUnitNumeric;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown FacdeOutTimeNumeric;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown FadeInTimeNumeric;
        private System.Windows.Forms.Label TrialLengthLabel;
        private System.Windows.Forms.NumericUpDown TrialLengthNumeric;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label TimingResponseLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label rectNumLabel;
        private System.Windows.Forms.NumericUpDown RectangleNumeric;
        private System.Windows.Forms.ComboBox OriantetionComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.NumericUpDown numericUpDown12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label8;
        private Label label13;
        private NumericUpDown FadeOutLengthNumeric;
        private NumericUpDown SubGroupNumeric;
        private Label label7;
        private NumericUpDown GroupNumeric;
        private Label label12;
        private Button button1;
        private Button button2;
        private Button DuplicateButton;
        private Button RemoveButton;
    }
}