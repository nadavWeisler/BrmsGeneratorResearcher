using System.Windows.Forms;

namespace bRMS_Generator
{
    partial class FullscreenForm: Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FullscreenForm));
            this.MsgRich = new System.Windows.Forms.RichTextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SubGroupNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.GroupNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SubGroupNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // MsgRich
            // 
            this.MsgRich.Location = new System.Drawing.Point(12, 12);
            this.MsgRich.Name = "MsgRich";
            this.MsgRich.Size = new System.Drawing.Size(375, 183);
            this.MsgRich.TabIndex = 0;
            this.MsgRich.Text = "";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(312, 201);
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
            // SubGroupNumeric
            // 
            this.SubGroupNumeric.Location = new System.Drawing.Point(255, 205);
            this.SubGroupNumeric.Name = "SubGroupNumeric";
            this.SubGroupNumeric.Size = new System.Drawing.Size(51, 20);
            this.SubGroupNumeric.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Sub Group";
            // 
            // GroupNumeric
            // 
            this.GroupNumeric.Location = new System.Drawing.Point(135, 205);
            this.GroupNumeric.Name = "GroupNumeric";
            this.GroupNumeric.Size = new System.Drawing.Size(51, 20);
            this.GroupNumeric.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Group";
            // 
            // FullscreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 235);
            this.Controls.Add(this.SubGroupNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GroupNumeric);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.MsgRich);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FullscreenForm";
            this.Text = "Fullscreen";
            ((System.ComponentModel.ISupportInitialize)(this.SubGroupNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox MsgRich;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ClearButton;
        private NumericUpDown SubGroupNumeric;
        private Label label2;
        private NumericUpDown GroupNumeric;
        private Label label1;
    }
}