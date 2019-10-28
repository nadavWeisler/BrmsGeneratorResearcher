using System.Windows.Forms;

namespace bRMS_Generator
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
            ((System.ComponentModel.ISupportInitialize)(this.SubBlockNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockNumeric)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MsgRich
            // 
            this.MsgRich.Location = new System.Drawing.Point(6, 19);
            this.MsgRich.Name = "MsgRich";
            this.MsgRich.Size = new System.Drawing.Size(360, 166);
            this.MsgRich.TabIndex = 0;
            this.MsgRich.Text = "";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(309, 202);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(12, 202);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // SubBlockNumeric
            // 
            this.SubBlockNumeric.Location = new System.Drawing.Point(255, 205);
            this.SubBlockNumeric.Name = "SubBlockNumeric";
            this.SubBlockNumeric.Size = new System.Drawing.Size(51, 20);
            this.SubBlockNumeric.TabIndex = 26;
            // 
            // SubBlockLabel
            // 
            this.SubBlockLabel.AutoSize = true;
            this.SubBlockLabel.Location = new System.Drawing.Point(191, 207);
            this.SubBlockLabel.Name = "SubBlockLabel";
            this.SubBlockLabel.Size = new System.Drawing.Size(56, 13);
            this.SubBlockLabel.TabIndex = 25;
            this.SubBlockLabel.Text = "Sub Block";
            // 
            // BlockNumeric
            // 
            this.BlockNumeric.Location = new System.Drawing.Point(135, 205);
            this.BlockNumeric.Name = "BlockNumeric";
            this.BlockNumeric.Size = new System.Drawing.Size(51, 20);
            this.BlockNumeric.TabIndex = 24;
            // 
            // BlockLabel
            // 
            this.BlockLabel.AutoSize = true;
            this.BlockLabel.Location = new System.Drawing.Point(93, 207);
            this.BlockLabel.Name = "BlockLabel";
            this.BlockLabel.Size = new System.Drawing.Size(34, 13);
            this.BlockLabel.TabIndex = 23;
            this.BlockLabel.Text = "Block";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MsgRich);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 191);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Messeage";
            // 
            // FullscreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 235);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SubBlockNumeric);
            this.Controls.Add(this.SubBlockLabel);
            this.Controls.Add(this.BlockNumeric);
            this.Controls.Add(this.BlockLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SaveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FullscreenForm";
            this.Text = "Fullscreen";
            ((System.ComponentModel.ISupportInitialize)(this.SubBlockNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockNumeric)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
    }
}