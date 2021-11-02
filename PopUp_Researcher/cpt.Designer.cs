
namespace BrmsGeneratorResearcher
{
    partial class CptForm
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
            this.NameGroupBox = new System.Windows.Forms.GroupBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.StimulusShapeUpDown = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.AddOtherColorTextBox = new System.Windows.Forms.TextBox();
            this.ChoicesButton = new System.Windows.Forms.Button();
            this.OtherColorsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StimulusColorTextBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.SubBlockNumeric = new System.Windows.Forms.NumericUpDown();
            this.SubBlockLabel = new System.Windows.Forms.Label();
            this.BlockNumeric = new System.Windows.Forms.NumericUpDown();
            this.BlockLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NameGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubBlockNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // NameGroupBox
            // 
            this.NameGroupBox.Controls.Add(this.NameTextBox);
            this.NameGroupBox.Location = new System.Drawing.Point(32, 29);
            this.NameGroupBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.NameGroupBox.Name = "NameGroupBox";
            this.NameGroupBox.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.NameGroupBox.Size = new System.Drawing.Size(1184, 122);
            this.NameGroupBox.TabIndex = 37;
            this.NameGroupBox.TabStop = false;
            this.NameGroupBox.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(21, 41);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(1119, 38);
            this.NameTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.StimulusShapeUpDown);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.AddOtherColorTextBox);
            this.groupBox2.Controls.Add(this.ChoicesButton);
            this.groupBox2.Controls.Add(this.OtherColorsTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.StimulusColorTextBox);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Location = new System.Drawing.Point(32, 162);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(1184, 262);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parameters";
            // 
            // StimulusShapeUpDown
            // 
            this.StimulusShapeUpDown.Items.Add("square");
            this.StimulusShapeUpDown.Items.Add("circle");
            this.StimulusShapeUpDown.Items.Add("triangle");
            this.StimulusShapeUpDown.Items.Add("down_triangle");
            this.StimulusShapeUpDown.Location = new System.Drawing.Point(434, 112);
            this.StimulusShapeUpDown.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.StimulusShapeUpDown.Name = "StimulusShapeUpDown";
            this.StimulusShapeUpDown.Size = new System.Drawing.Size(275, 38);
            this.StimulusShapeUpDown.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 32);
            this.label1.TabIndex = 76;
            this.label1.Text = "Stimulus Shape";
            // 
            // AddOtherColorTextBox
            // 
            this.AddOtherColorTextBox.Location = new System.Drawing.Point(405, 176);
            this.AddOtherColorTextBox.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.AddOtherColorTextBox.MaxLength = 7;
            this.AddOtherColorTextBox.Name = "AddOtherColorTextBox";
            this.AddOtherColorTextBox.Size = new System.Drawing.Size(223, 38);
            this.AddOtherColorTextBox.TabIndex = 75;
            // 
            // ChoicesButton
            // 
            this.ChoicesButton.Location = new System.Drawing.Point(648, 176);
            this.ChoicesButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ChoicesButton.Name = "ChoicesButton";
            this.ChoicesButton.Size = new System.Drawing.Size(61, 45);
            this.ChoicesButton.TabIndex = 74;
            this.ChoicesButton.Text = "+";
            this.ChoicesButton.UseVisualStyleBackColor = true;
            this.ChoicesButton.Click += new System.EventHandler(this.ChoicesButton_Click);
            // 
            // OtherColorsTextBox
            // 
            this.OtherColorsTextBox.Enabled = false;
            this.OtherColorsTextBox.Location = new System.Drawing.Point(723, 181);
            this.OtherColorsTextBox.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.OtherColorsTextBox.Name = "OtherColorsTextBox";
            this.OtherColorsTextBox.Size = new System.Drawing.Size(417, 38);
            this.OtherColorsTextBox.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 32);
            this.label2.TabIndex = 72;
            this.label2.Text = "Other colors (RGB include #)";
            // 
            // StimulusColorTextBox
            // 
            this.StimulusColorTextBox.Location = new System.Drawing.Point(434, 53);
            this.StimulusColorTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.StimulusColorTextBox.MaxLength = 7;
            this.StimulusColorTextBox.Name = "StimulusColorTextBox";
            this.StimulusColorTextBox.Size = new System.Drawing.Size(268, 38);
            this.StimulusColorTextBox.TabIndex = 71;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 48);
            this.label19.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(408, 32);
            this.label19.TabIndex = 70;
            this.label19.Text = "Stimulus Color (RGB Include #)";
            // 
            // SubBlockNumeric
            // 
            this.SubBlockNumeric.Location = new System.Drawing.Point(464, 441);
            this.SubBlockNumeric.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.SubBlockNumeric.Name = "SubBlockNumeric";
            this.SubBlockNumeric.Size = new System.Drawing.Size(136, 38);
            this.SubBlockNumeric.TabIndex = 44;
            // 
            // SubBlockLabel
            // 
            this.SubBlockLabel.AutoSize = true;
            this.SubBlockLabel.Location = new System.Drawing.Point(293, 446);
            this.SubBlockLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.SubBlockLabel.Name = "SubBlockLabel";
            this.SubBlockLabel.Size = new System.Drawing.Size(143, 32);
            this.SubBlockLabel.TabIndex = 43;
            this.SubBlockLabel.Text = "Sub Block";
            // 
            // BlockNumeric
            // 
            this.BlockNumeric.Location = new System.Drawing.Point(144, 441);
            this.BlockNumeric.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.BlockNumeric.Name = "BlockNumeric";
            this.BlockNumeric.Size = new System.Drawing.Size(136, 38);
            this.BlockNumeric.TabIndex = 42;
            // 
            // BlockLabel
            // 
            this.BlockLabel.AutoSize = true;
            this.BlockLabel.Location = new System.Drawing.Point(32, 446);
            this.BlockLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.BlockLabel.Name = "BlockLabel";
            this.BlockLabel.Size = new System.Drawing.Size(85, 32);
            this.BlockLabel.TabIndex = 41;
            this.BlockLabel.Text = "Block";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(1011, 434);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(200, 55);
            this.SaveButton.TabIndex = 39;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 517);
            this.Controls.Add(this.SubBlockNumeric);
            this.Controls.Add(this.SubBlockLabel);
            this.Controls.Add(this.BlockNumeric);
            this.Controls.Add(this.BlockLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.NameGroupBox);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "CptForm";
            this.Text = "cpt";
            this.Load += new System.EventHandler(this.cpt_Load);
            this.NameGroupBox.ResumeLayout(false);
            this.NameGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubBlockNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox NameGroupBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox StimulusColorTextBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddOtherColorTextBox;
        private System.Windows.Forms.Button ChoicesButton;
        private System.Windows.Forms.TextBox OtherColorsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DomainUpDown StimulusShapeUpDown;
        private System.Windows.Forms.NumericUpDown SubBlockNumeric;
        private System.Windows.Forms.Label SubBlockLabel;
        private System.Windows.Forms.NumericUpDown BlockNumeric;
        private System.Windows.Forms.Label BlockLabel;
        private System.Windows.Forms.Button SaveButton;
    }
}