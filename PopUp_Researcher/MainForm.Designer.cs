﻿namespace bRMS_Generator
{
    partial class MainForm
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
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.bRMS_button = new System.Windows.Forms.Button();
            this.introButton = new System.Windows.Forms.Button();
            this.surveyButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.TrialsButtonGroup = new System.Windows.Forms.GroupBox();
            this.FullscreenButton = new System.Windows.Forms.Button();
            this.SaveButtonGroup = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.LoadButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.TrialsButtonGroup.SuspendLayout();
            this.SaveButtonGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(35, 13);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "Name";
            // 
            // bRMS_button
            // 
            this.bRMS_button.Location = new System.Drawing.Point(10, 77);
            this.bRMS_button.Name = "bRMS_button";
            this.bRMS_button.Size = new System.Drawing.Size(75, 23);
            this.bRMS_button.TabIndex = 2;
            this.bRMS_button.Text = "bRMS";
            this.bRMS_button.UseVisualStyleBackColor = true;
            this.bRMS_button.Click += new System.EventHandler(this.BRms_button_Click);
            // 
            // introButton
            // 
            this.introButton.Location = new System.Drawing.Point(10, 106);
            this.introButton.Name = "introButton";
            this.introButton.Size = new System.Drawing.Size(75, 23);
            this.introButton.TabIndex = 3;
            this.introButton.Text = "Introduction";
            this.introButton.UseVisualStyleBackColor = true;
            this.introButton.Click += new System.EventHandler(this.IntroButton_Click);
            // 
            // surveyButton
            // 
            this.surveyButton.Location = new System.Drawing.Point(10, 19);
            this.surveyButton.Name = "surveyButton";
            this.surveyButton.Size = new System.Drawing.Size(75, 23);
            this.surveyButton.TabIndex = 4;
            this.surveyButton.Text = "Survey";
            this.surveyButton.UseVisualStyleBackColor = true;
            this.surveyButton.Click += new System.EventHandler(this.SurveyButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(6, 77);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(6, 19);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 6;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // TrialsButtonGroup
            // 
            this.TrialsButtonGroup.Controls.Add(this.FullscreenButton);
            this.TrialsButtonGroup.Controls.Add(this.bRMS_button);
            this.TrialsButtonGroup.Controls.Add(this.introButton);
            this.TrialsButtonGroup.Controls.Add(this.surveyButton);
            this.TrialsButtonGroup.Location = new System.Drawing.Point(359, 32);
            this.TrialsButtonGroup.Name = "TrialsButtonGroup";
            this.TrialsButtonGroup.Size = new System.Drawing.Size(96, 135);
            this.TrialsButtonGroup.TabIndex = 8;
            this.TrialsButtonGroup.TabStop = false;
            this.TrialsButtonGroup.Text = "Experiments";
            // 
            // FullscreenButton
            // 
            this.FullscreenButton.Location = new System.Drawing.Point(10, 48);
            this.FullscreenButton.Name = "FullscreenButton";
            this.FullscreenButton.Size = new System.Drawing.Size(75, 23);
            this.FullscreenButton.TabIndex = 5;
            this.FullscreenButton.Text = "Fullscreen";
            this.FullscreenButton.UseVisualStyleBackColor = true;
            this.FullscreenButton.Click += new System.EventHandler(this.FullscreenButton_Click);
            // 
            // SaveButtonGroup
            // 
            this.SaveButtonGroup.Controls.Add(this.EditButton);
            this.SaveButtonGroup.Controls.Add(this.saveButton);
            this.SaveButtonGroup.Controls.Add(this.removeButton);
            this.SaveButtonGroup.Location = new System.Drawing.Point(359, 173);
            this.SaveButtonGroup.Name = "SaveButtonGroup";
            this.SaveButtonGroup.Size = new System.Drawing.Size(96, 107);
            this.SaveButtonGroup.TabIndex = 9;
            this.SaveButtonGroup.TabStop = false;
            this.SaveButtonGroup.Text = "Save";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 20);
            this.textBox1.TabIndex = 10;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(15, 32);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(338, 248);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(369, 4);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 6;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(6, 48);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 7;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 287);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SaveButtonGroup);
            this.Controls.Add(this.TrialsButtonGroup);
            this.Controls.Add(this.HeaderLabel);
            this.Name = "MainForm";
            this.Text = "Main";
            this.TrialsButtonGroup.ResumeLayout(false);
            this.SaveButtonGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Button bRMS_button;
        private System.Windows.Forms.Button introButton;
        private System.Windows.Forms.Button surveyButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.GroupBox TrialsButtonGroup;
        private System.Windows.Forms.GroupBox SaveButtonGroup;
        private System.Windows.Forms.Button FullscreenButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button LoadButton
            ;
        private System.Windows.Forms.Button EditButton;
    }
}
