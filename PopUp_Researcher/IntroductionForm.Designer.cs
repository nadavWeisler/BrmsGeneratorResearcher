namespace bRMS_Generator
{
    partial class IntroductionForm
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
            this.PageRichTextBox = new System.Windows.Forms.RichTextBox();
            this.cleanButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.DuplicateButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.GroupNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SubGroupNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.GroupNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubGroupNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // PageRichTextBox
            // 
            this.PageRichTextBox.Location = new System.Drawing.Point(12, 12);
            this.PageRichTextBox.Name = "PageRichTextBox";
            this.PageRichTextBox.Size = new System.Drawing.Size(317, 67);
            this.PageRichTextBox.TabIndex = 2;
            this.PageRichTextBox.Text = "";
            // 
            // cleanButton
            // 
            this.cleanButton.Location = new System.Drawing.Point(12, 85);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(75, 23);
            this.cleanButton.TabIndex = 4;
            this.cleanButton.Text = "clean";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(254, 85);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 6;
            this.confirmButton.Text = "confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(255, 400);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DuplicateButton
            // 
            this.DuplicateButton.Location = new System.Drawing.Point(12, 371);
            this.DuplicateButton.Name = "DuplicateButton";
            this.DuplicateButton.Size = new System.Drawing.Size(75, 23);
            this.DuplicateButton.TabIndex = 8;
            this.DuplicateButton.Text = "Duplicate";
            this.DuplicateButton.UseVisualStyleBackColor = true;
            this.DuplicateButton.Click += new System.EventHandler(this.DuplicateButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(255, 371);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 9;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.Location = new System.Drawing.Point(174, 371);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(75, 23);
            this.PlusButton.TabIndex = 10;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Location = new System.Drawing.Point(93, 371);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(75, 23);
            this.MinusButton.TabIndex = 11;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 114);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(318, 251);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // GroupNumeric
            // 
            this.GroupNumeric.Location = new System.Drawing.Point(54, 400);
            this.GroupNumeric.Name = "GroupNumeric";
            this.GroupNumeric.Size = new System.Drawing.Size(51, 20);
            this.GroupNumeric.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Sub Group";
            // 
            // SubGroupNumeric
            // 
            this.SubGroupNumeric.Location = new System.Drawing.Point(174, 400);
            this.SubGroupNumeric.Name = "SubGroupNumeric";
            this.SubGroupNumeric.Size = new System.Drawing.Size(51, 20);
            this.SubGroupNumeric.TabIndex = 22;
            // 
            // IntroductionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 425);
            this.Controls.Add(this.SubGroupNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GroupNumeric);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.DuplicateButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.PageRichTextBox);
            this.Name = "IntroductionForm";
            this.Text = "Introductions";
            ((System.ComponentModel.ISupportInitialize)(this.GroupNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubGroupNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox PageRichTextBox;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button DuplicateButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.NumericUpDown GroupNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown SubGroupNumeric;
    }
}