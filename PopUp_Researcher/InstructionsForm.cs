using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PopUp_Researcher.Helpers;

namespace bRMS_Generator
{
    public partial class InstructionsForm : Form
    {
        /// <summary>
        /// 
        /// </summary>
        protected Dictionary<string, string> PagesDictionary;

        /// <summary>
        /// Return value for edit
        /// </summary>
        public Instructions ReturnEdit;

        /// <summary>
        /// Existing trial to edit
        /// </summary>
        private Instructions _existingTrial;

        /// <summary>
        /// Contractor
        /// </summary>
        public InstructionsForm(Instructions existing=null)
        {
            InitializeComponent();
            this.PagesDictionary = new Dictionary<string, string>();
            if (existing == null) return;
            this._existingTrial = existing;
            UpdateExistingTrial();
            BindListView();
        }

        /// <summary>
        /// Update existing trial by existingTrial
        /// </summary>
        private void UpdateExistingTrial()
        {
            this.SubBlockNumeric.Value = this._existingTrial.sub_block;
            this.BlockNumeric.Value = this._existingTrial.block;
            foreach(var page in this._existingTrial.pages)
            {
                AddPageToPagesDictionary(page);
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
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                MessageBox.Show("Enter Name");
                return;
            }

            var newInstructions = new Instructions
            {
                pages = this.PagesDictionary.Values.ToList()
            };

            if (newInstructions.GetPages().Count <= 0) return;

            newInstructions.SetGroup(this.BlockNumeric.Value);
            newInstructions.SetSubGroup(this.SubBlockNumeric.Value);
            newInstructions.name = NameTextBox.Text;
              
            if(this._existingTrial != null)
            {
                this.ReturnEdit = newInstructions;
            }
            else
            {
                MainForm.AddIntro(newInstructions);
            }
            Close();
        }

        /// <summary>
        /// this function confirm texts from the PageRichTextBox and put them in the PagesListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            var newIntro = Utils.AddHtmlBreakLines(PageRichTextBox.Text);
            if (string.IsNullOrEmpty(newIntro)) return;
            if (listView1.SelectedItems.Count == 0)
            {
                AddPageToPagesDictionary(newIntro);
            }
            else
            {
                PagesDictionary[this.listView1.SelectedItems[0].Text] = newIntro;
            }
            BindListView();
            PageRichTextBox.ResetText();
        }

        /// <summary>
        /// Add new page and his display name to PagesDictionary
        /// </summary>
        /// <param name="newIntro"></param>
        private void AddPageToPagesDictionary(string newIntro)
        {
            var pageDisplayName = newIntro.Substring(0, Math.Min(10, newIntro.Length));
            pageDisplayName = pageDisplayName.Replace("<br>", " ");

            if (PagesDictionary.ContainsKey(pageDisplayName + "..."))
            {
                var count = 1;
                while (PagesDictionary.ContainsKey(pageDisplayName + "(" + count + ")" + "..."))
                {
                    count++;
                }
                pageDisplayName += "(" + count + ")";
            }

            pageDisplayName += "...";
            PagesDictionary.Add(pageDisplayName , newIntro);
        }

        /// <summary>
        /// Bind ListView 
        /// </summary>
        private void BindListView()
        {
            this.listView1.Items.Clear();
            foreach (var item in this.PagesDictionary.Keys)
            {
                this.listView1.Items.Add(item);
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
                var allPages = Utils.RemoveItemByIndex(this.PagesDictionary.Keys.ToList(), 
                    item.Index);
                var newDic = new Dictionary<string, string>();
                foreach (var page in allPages)
                {
                    newDic.Add(page, PagesDictionary[page]);
                }

                this.PagesDictionary = newDic;
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
                AddPageToPagesDictionary(item.Text);
            }
            BindListView();
        }

        /// <summary>
        /// Change Order (Down) of selected item in ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinusButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count <= 0 ||
                listView1.SelectedItems[0].Index >= this.PagesDictionary.Count - 1) return;

            var allPages = Utils.UpOneItem(this.PagesDictionary.Values.ToList(),
                listView1.SelectedItems[0].Index);
            var newDic = new Dictionary<string, string>();
            foreach (var page in allPages)
            {
                newDic.Add(page, PagesDictionary[page]);
            }

            this.PagesDictionary = newDic;

            BindListView();
        }

        /// <summary>
        /// Change Order (Up) of selected item in ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlusButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count <= 0 || listView1.SelectedItems[0].Index <= 0) return;
            
            var allPages = Utils.DownOneItem(this.PagesDictionary.Values.ToList(),
                listView1.SelectedItems[0].Index);
            var newDic = new Dictionary<string, string>();
            foreach (var page in allPages)
            {
                newDic.Add(page, PagesDictionary[page]);
            }

            this.PagesDictionary = newDic;

            BindListView();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                PageRichTextBox.Text = listView1.SelectedItems[0].Text;
            }
            else
            {
                PageRichTextBox.Text = string.Empty;
            }
        }

        private void InstructionsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
