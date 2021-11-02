using BrmsGeneratorResearcher.Helpers;
using BrmsGeneratorResearcher.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrmsGeneratorResearcher
{
    public partial class CptForm : Form
    {
        private readonly Cpt _existingTrial;
        public Cpt ReturnEdit;
        public CptForm()
        {
            InitializeComponent();
        }

        private void cpt_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Update Existing Trial by this.existingTrial
        /// </summary>
        private void UpdateExistingTrial()
        {
            this.SubBlockNumeric.Value = this._existingTrial.sub_block;
            this.BlockNumeric.Value = this._existingTrial.block;
            this.NameTextBox.Text = this._existingTrial.name;
            this.StimulusColorTextBox.Text = this._existingTrial.stimulus_color;
            this.StimulusShapeUpDown.SelectedItem = this._existingTrial.stimulus_shape;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                MessageBox.Show(ErrMsg.NameMissingError);
                return;
            }

            if(!Utils.ValidateRgb(this.StimulusColorTextBox.Text)) {
                MessageBox.Show(ErrMsg.InvalidRGBcode);
                this.StimulusColorTextBox.Text = string.Empty;
                return;
            }

            var otherColors = new List<string>();
            if(string.IsNullOrWhiteSpace(this.OtherColorsTextBox.Text))
            {
                otherColors = null;
            }
            foreach (var choice in this.OtherColorsTextBox.Text.Split(','))
            {
                if (!string.IsNullOrEmpty(choice))
                {
                    otherColors.Add(choice);
                }
            }

            if(otherColors.Count == 0)
            {
                otherColors = null;
            }

            var newCpt = new Cpt()
            {
                stimulus_shape = this.StimulusShapeUpDown.Text,
                stimulus_color = this.StimulusColorTextBox.Text,
                other_colors = otherColors,
                block = (BlockNumeric.Value),
                sub_block = (SubBlockNumeric.Value),
                name = NameTextBox.Text
            };


            if (this._existingTrial != null)
            {
                this.ReturnEdit = newCpt;
            }

            else
            {
                MainForm.AddCpt(newCpt);
            }
            this.Close();
        }

        private void ChoicesButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddOtherColorTextBox.Text))
            {
                AddOtherColorTextBox.Text = string.Empty;
            }
            else if (!Utils.ValidateRgb(this.AddOtherColorTextBox.Text))
            {
                MessageBox.Show(ErrMsg.InvalidRGBcode);
                this.AddOtherColorTextBox.Text = string.Empty;
            }
            else if (this.OtherColorsTextBox.Text.Contains(this.AddOtherColorTextBox.Text))
            {
                MessageBox.Show(ErrMsg.ChoiceAlreadyExistError);
                this.AddOtherColorTextBox.Text = string.Empty;
            }
            else
            {
                this.OtherColorsTextBox.Text += this.AddOtherColorTextBox.Text;
                if (!string.IsNullOrEmpty(this.OtherColorsTextBox.Text))
                {
                    this.OtherColorsTextBox.Text += ",";
                }
                this.AddOtherColorTextBox.Text = string.Empty;
            }
        }
    }
}