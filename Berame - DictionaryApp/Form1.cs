using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Berame___DictionaryApp
{
    public partial class Form1 : Form
    {
        private readonly DictionarySearchService _searchService;

        public Form1()
        {
            InitializeComponent();
            _searchService = new DictionarySearchService();

            searchDictionaryTextBox.Font = new Font("Arial", 14);
            searchDictionaryTextBox.Padding = new Padding(5);

            meaningsFlowLayoutPanel.AutoScroll = true;
            meaningsFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            meaningsFlowLayoutPanel.WrapContents = false;

            synonymBtn.Click += new EventHandler(synonymBtn_Click);
            antonymBtn.Click += new EventHandler(antonymBtn_Click);

            this.BackColor = Color.FromArgb(230, 131, 105);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private async void searchDictionaryTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                await PerformSearch();
            }
        }

        private async void searchWordBtn_Click(object sender, EventArgs e)
        {
            await PerformSearch();
        }

        private async Task PerformSearch()
        {
            string word = searchDictionaryTextBox.Text;
            if (!string.IsNullOrEmpty(word))
            {
                try
                {
                    meaningsFlowLayoutPanel.Text = "Searching...";

                    var definitions = await _searchService.GetWordDefinitionAsync(word);

                    if (definitions != null && definitions.Count > 0)
                    {
                        Functions.DisplayDefinitions(meaningsFlowLayoutPanel, definitions);
                    }
                    else
                    {
                        meaningsFlowLayoutPanel.Text = "No definitions found.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while searching: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please enter a word to search.");
            }
        }

        private async void synonymBtn_Click(object sender, EventArgs e)
        {
            string word = searchDictionaryTextBox.Text;
            if (!string.IsNullOrEmpty(word))
            {
                var definitions = await _searchService.GetWordDefinitionAsync(word);
                Functions.DisplaySynonyms(meaningsFlowLayoutPanel, definitions);
            }
            else
            {
                MessageBox.Show("Please enter a word to search.");
            }
        }

        private async void antonymBtn_Click(object sender, EventArgs e)
        {
            string word = searchDictionaryTextBox.Text;
            if (!string.IsNullOrEmpty(word))
            {
                var definitions = await _searchService.GetWordDefinitionAsync(word);
                Functions.DisplayAntonyms(meaningsFlowLayoutPanel, definitions);
            }
            else
            {
                MessageBox.Show("Please enter a word to search.");
            }
        }

        private async void definitionBtn_Click(object sender, EventArgs e)
        {
            string word = searchDictionaryTextBox.Text;
            if (!string.IsNullOrEmpty(word))
            {
                var definitions = await _searchService.GetWordDefinitionAsync(word);
                Functions.DisplayDefinitions(meaningsFlowLayoutPanel, definitions);
            }
            else
            {
                MessageBox.Show("Please enter a word to search.");
            }
        }
    }
}
