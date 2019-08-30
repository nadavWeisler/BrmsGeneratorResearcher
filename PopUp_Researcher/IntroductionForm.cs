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
    public partial class IntroductionForm : Form
    {
        /// <summary>
        /// Introduction result object
        /// </summary>
        protected Instructions intro;

        /// <summary>
        /// Contractor
        /// </summary>
        public IntroductionForm()
        {
            InitializeComponent();
            this.intro = new Instructions();
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
            if (this.intro.GetPages().Count > 0)
            {
                this.intro.SetGroup(this.GroupNumeric.Value);
                this.intro.SetSubGroup(this.SubGroupNumeric.Value);
                MainForm.AddIntro(intro);
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
            string newintro = PageRichTextBox.Text;
            if (!string.IsNullOrEmpty(newintro))
            {
                this.intro.AddPage(newintro);
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
            foreach (var item in this.intro.GetPages())
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
                this.intro.SetPages(Utils.RemoveItemByIndex(this.intro.GetPages(), item.Index));
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
                this.intro.AddPage(item.Text);
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
            if (listView1.SelectedItems.Count > 0 && listView1.SelectedItems[0].Index < this.intro.GetPages().Count - 1)
            {
                this.intro.SetPages(Utils.UpOneItem(this.intro.GetPages(), listView1.SelectedItems[0].Index));
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
                this.intro.SetPages(Utils.DownOneItem(this.intro.GetPages(), listView1.SelectedItems[0].Index));
                BindListView();
            }
        }
    }
}
