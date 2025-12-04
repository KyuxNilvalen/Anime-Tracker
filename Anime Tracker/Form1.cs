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
            // TODO: This line of code loads data into the 'animeListDataSet.animeList' table. You can move, or remove it, as needed.
            this.animeListTableAdapter.Fill(this.animeListDataSet.animeList);
            //attempt to load data on startup
        }
        private void LoadData()
        {
            
        }

        private void animeListBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.animeListBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.animeListDataSet);

        }

        private void checkTextBoxes()
        {
            if (nameTextBox.Text != "")
            {
                MessageBox.Show("Error: Name cannot be empty!", "Error");
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
