using System.Windows.Forms;

namespace BrmsGeneratorResearcher
{
    partial class FullscreenForm: Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FullscreenForm));
            this.MsgRich = new System.Windows.Forms.RichTextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SubBlockNumeric = new System.Windows.Forms.NumericUpDown();
            this.SubBlockLabel = new System.Windows.Forms.Label();
            this.BlockNumeric = new System.Windows.Forms.NumericUpDown();
            this.BlockLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NameGroupBox = new System.Windows.Forms.GroupBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SubBlockNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockNumeric)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.NameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MsgRich
            // 
            this.MsgRich.Location = new System.Drawing.Point(7, 29);
            this.MsgRich.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MsgRich.Name = "MsgRich";
            this.MsgRich.Size = new System.Drawing.Size(538, 286);
            this.MsgRich.TabIndex = 0;
            this.MsgRich.Text = "";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(464, 429);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(112, 35);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(18, 429);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(112, 35);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // SubBlockNumeric
            // 
            this.SubBlockNumeric.Location = new System.Drawing.Point(382, 433);
            this.SubBlockNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubBlockNumeric.Name = "SubBlockNumeric";
            this.SubBlockNumeric.Size = new System.Drawing.Size(76, 26);
            this.SubBlockNumeric.TabIndex = 26;
            // 
            // SubBlockLabel
            // 
            this.SubBlockLabel.AutoSize = true;
            this.SubBlockLabel.Location = new System.Drawing.Point(286, 436);
            this.SubBlockLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SubBlockLabel.Name = "SubBlockLabel";
            this.SubBlockLabel.Size = new System.Drawing.Size(81, 20);
            this.SubBlockLabel.TabIndex = 25;
            this.SubBlockLabel.Text = "Sub Block";
            // 
            // BlockNumeric
            // 
            this.BlockNumeric.Location = new System.Drawing.Point(202, 433);
            this.BlockNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BlockNumeric.Name = "BlockNumeric";
            this.BlockNumeric.Size = new System.Drawing.Size(76, 26);
            this.BlockNumeric.TabIndex = 24;
            // 
            // BlockLabel
            // 
            this.BlockLabel.AutoSize = true;
            this.BlockLabel.Location = new System.Drawing.Point(140, 436);
            this.BlockLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BlockLabel.Name = "BlockLabel";
            this.BlockLabel.Size = new System.Drawing.Size(48, 20);
            this.BlockLabel.TabIndex = 23;
            this.BlockLabel.Text = "Block";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MsgRich);
            this.groupBox1.Location = new System.Drawing.Point(18, 94);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(558, 325);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Messeage";
            // 
            // NameGroupBox
            // 
            this.NameGroupBox.Controls.Add(this.NameTextBox);
            this.NameGroupBox.Location = new System.Drawing.Point(18, 14);
            this.NameGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameGroupBox.Name = "NameGroupBox";
            this.NameGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameGroupBox.Size = new System.Drawing.Size(558, 70);
            this.NameGroupBox.TabIndex = 28;
            this.NameGroupBox.TabStop = false;
            this.NameGroupBox.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(7, 27);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(544, 26);
            this.NameTextBox.TabIndex = 0;
            // 
            // FullscreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 478);
            this.Controls.Add(this.NameGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SubBlockNumeric);
            this.Controls.Add(this.SubBlockLabel);
            this.Controls.Add(this.BlockNumeric);
            this.Controls.Add(this.BlockLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SaveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FullscreenForm";
            this.Text = "Fullscreen";
            ((System.ComponentModel.ISupportInitialize)(this.SubBlockNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockNumeric)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.NameGroupBox.ResumeLayout(false);
            this.NameGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox MsgRich;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ClearButton;
        private NumericUpDown SubBlockNumeric;
        private Label SubBlockLabel;
        private NumericUpDown BlockNumeric;
        private Label BlockLabel;
        private GroupBox groupBox1;
        private GroupBox NameGroupBox;
        private TextBox NameTextBox;
    }
}