using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bRMS_Generator.src;

namespace bRMS_Generator
{
    public partial class InstructionsForm : Form
    {
        /// <summary>
        /// Introduction result object
        /// </summary>
        protected Instructions instru;

        /// <summary>
        /// Return value for edit
        /// </summary>
        public Instructions returnEdit;

        /// <summary>
        /// Existing trial to edit
        /// </summary>
        private Instructions existingTrial;

        /// <summary>
        /// Contractor
        /// </summary>
        public InstructionsForm(Instructions existing=null)
        {
            InitializeComponent();
            this.instru = new Instructions();

            if (existing != null)
            {
                this.existingTrial = existing;
                UpdateExistingTrial();
                BindListView();
            }
        }

        /// <summary>
        /// Update existing trial by existingTrial
        /// </summary>
        private void UpdateExistingTrial()
        {
            this.SubBlockNumeric.Value = this.existingTrial.sub_group;
            this.BlockNumeric.Value = this.existingTrial.group;
            foreach(string page in this.existingTrial.pages)
            {
                this.instru.pages.Add(page);
            }
        }

        /// <summary>
        /// Clear RichTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CleanButton_Click(object sender, EventArgs e)
        {
            PageRichTextBox.ResetText();
        }

        /// <summary>
        /// Save Intro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {       
            if (this.instru.GetPages().Count > 0)
            {
                this.instru.SetGroup(this.BlockNumeric.Value);
                this.instru.SetSubGroup(this.SubBlockNumeric.Value);
              
                if(this.existingTrial != null)
                {
                    this.returnEdit = instru;
                }
                else
                {
                    MainForm.AddIntro(instru);
                }
                Close();
            }
        }

        /// <summary>
        /// this function confirm texts from the PageRichTextBox and put them in the PagesListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            string newintro = Utils.AddHtmlBreakLines(PageRichTextBox.Text);
            if (!string.IsNullOrEmpty(newintro))
            {
                if (listView1.SelectedItems.Count == 0)
                {
                    this.instru.AddPage(newintro);
                }
                else
                {
                    this.instru.pages[this.listView1.SelectedItems[0].Index] = newintro;
                }
                BindListView();
                PageRichTextBox.ResetText();
            }
        }

        /// <summary>
        /// Bind ListView 
        /// </summary>
        private void BindListView()
        {
            this.listView1.Items.Clear();
            foreach (var item in this.instru.GetPages())
            {
                int endIndex = Math.Min(10, item.Length - 1);
                this.listView1.Items.Add(item.Substring(endIndex) + "...");
            }
        }

        /// <summary>
        /// Remove item from listView and bind
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                this.instru.SetPages(Utils.RemoveItemByIndex(this.instru.GetPages(), item.Index));
            }
            BindListView();
        }

        /// <summary>
        /// Duplicate Selected ListView Item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DuplicateButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                this.instru.AddPage(item.Text);
            }
            BindListView();
        }

        /// <summary>
        /// Change Oreder (Down) of selected item in ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinusButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0 && listView1.SelectedItems[0].Index < this.instru.GetPages().Count - 1)
            {
                this.instru.SetPages(Utils.UpOneItem(this.instru.GetPages(), listView1.SelectedItems[0].Index));
                BindListView();
            }
        }

        /// <summary>
        /// Change Oreder (Up) of selected item in ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlusButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0 && listView1.SelectedItems[0].Index > 0)
            {
                this.instru.SetPages(Utils.DownOneItem(this.instru.GetPages(), listView1.SelectedItems[0].Index));
                BindListView();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count == 0)
            {
                PageRichTextBox.Text = string.Empty;
            }
            else
            {
                PageRichTextBox.Text = listView1.SelectedItems[0].Text;
            }
        }
    }
}
