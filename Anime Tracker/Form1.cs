using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;

namespace Anime_Tracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //attempt to load data on startup
            this.animeListTableAdapter.Fill(this.animeListDataSet.animeList);
        }
        private void animeListBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!checkTextBoxes(nameTextBox, typeTextBox, scoreTextBox, epTextBox, totalEpTextBox))
            {
                // If validation fails, do NOT proceed with EndEdit or UpdateAll.
                // We will notify the user via the checkTextBoxes' MessageBox.
                return;
            }

            this.Validate();
            this.animeListBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.animeListDataSet);
            this.animeListTableAdapter.Fill(this.animeListDataSet.animeList);

        }

        private bool checkTextBoxes(TextBox name, TextBox type, TextBox score, TextBox ep, TextBox total)
        {
            // name text check
            if (name.Text == "")
            {
                MessageBox.Show("Error: Name cannot be empty!", "Error");
                return false;
            }

            // type text check
            if (type.Text == "")
            {
                MessageBox.Show("Error: Show type cannot be empty!", "Error");
                return false;
            }

            // episode # check
            string epInput = ep.Text.Trim();
            if (string.IsNullOrEmpty(epInput))
            {
                MessageBox.Show("Error: Current episode number cannot be empty!", "Error");
                return false;
            }
            if (!int.TryParse(epInput, out int epValue))
            {
                MessageBox.Show("Error: Episode number must be a valid number.", "Error");
                return false;
            }
            if (epValue < 0)
            {
                MessageBox.Show("Error: Episode number must be a positive number or 0.", "Error");
                return false;
            }

            // total episode check
            string totalEpInput = total.Text.Trim();
            if (string.IsNullOrEmpty(totalEpInput))
            {
                MessageBox.Show("Error: Current episode number cannot be empty!", "Error");
                return false;
            }
            if (!int.TryParse(totalEpInput, out int totalEpValue))
            {
                MessageBox.Show("Error: Total episodes must be a valid number.", "Error");
                return false;
            }
            if (totalEpValue < 0)
            {
                MessageBox.Show("Error: Total episodes must be a positive number or 0.", "Error");
                return false;
            }

            //score # check
            string scoreInput = score.Text.Trim();
            if (string.IsNullOrEmpty(scoreInput))
            {
                MessageBox.Show("Error: Score cannot be empty!", "Error");
                return false;
            }
            if (!decimal.TryParse(scoreInput, out decimal scoreValue))
            {
                MessageBox.Show("Error: Episode number must be a valid number.", "Error");
                return false;
            }
            int decimalPointIndex = scoreInput.IndexOf('.');
            if (decimalPointIndex >= 0) // If a decimal point exists
            {
                // Check if there is more than one digit after the decimal point
                if (scoreInput.Length - 1 - decimalPointIndex > 1)
                {
                    MessageBox.Show("Error: Score can have a maximum of one decimal place (e.g., 8.5).", "Error");
                    return false;
                }
            }
            if (scoreValue < 0 || scoreValue > 10)
            {
                MessageBox.Show("Error: Rating must be between 0 and 10", "Error");
                return false;
            }
            
            //passed all checks
            return true;
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (!checkTextBoxes(nameTextBox, typeTextBox, scoreTextBox, epTextBox, totalEpTextBox))
            {
                MessageBox.Show("Error saving record to database.", "Error", MessageBoxButtons.OK);
                return;
            }
            try
            {
                this.animeListBindingNavigatorSaveItem_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred editting record in database: " + ex.Message, "Error");
                this.animeListBindingSource.CancelEdit();
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            if (!checkTextBoxes(nameTextBox, typeTextBox, scoreTextBox, epTextBox, totalEpTextBox))
            {
                return; // Stop if validation fails.
            }
            try
            {
                string nameInput = nameTextBox.Text.Trim();
                string typeInput = typeTextBox.Text.Trim();
                string scoreInput = scoreTextBox.Text.Trim();
                string epInput = epTextBox.Text.Trim();
                string totalEpInput = totalEpTextBox.Text.Trim();

                this.animeListBindingSource.AddNew();

                nameTextBox.Text = nameInput;
                typeTextBox.Text = typeInput;
                scoreTextBox.Text = scoreInput;
                epTextBox.Text = epInput;
                totalEpTextBox.Text = totalEpInput;

                this.animeListBindingNavigatorSaveItem_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred adding record to database: " + ex.Message, "Error");
                this.animeListBindingSource.CancelEdit();
            }
        }
    }
}
