using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordFrequency
{
    public partial class WordFrequency : Form
    {
        public WordFrequency()
        {
            InitializeComponent();
            wordFreqList.View = View.Details;
            wordFreqList.GridLines = true;
            wordFreqList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            userInput.Clear();
            wordFreqList.Items.Clear();
        }
        private void translate_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            errorMsg.Text = "";
            string userInputStr = userInput.Text;

            if (userInputStr == "") 
            {
                errorProvider.SetError(errorMsg, "Error");
                errorMsg.Text = "Error: Empty input"; 
            }

            wordFreqList.Items.Clear();
            frequency_Count(userInputStr.ToLower());
        }

        private void frequency_Count(string inputStr)
        {
            Dictionary<string, int> wordFreq = new Dictionary<string, int>();

            // Regex to remove non-word punctuation
            Regex reg = new Regex("[^a-zA-Z0-9'\\- ]|(?<=\\s)-|(?<=\\s|^)'(?=[a-zA-z])|(?<=[a-zA-Z])'(?=\\s)");
            inputStr = reg.Replace(inputStr, " ");
            string[] inputArr = inputStr.Split(' ').Where(x => !string.IsNullOrEmpty(x)).ToArray();
            string[] distinctWords = inputArr.Distinct().ToArray();

            foreach (string word in distinctWords)
            {
                int count = inputArr.Where(x => x == word).ToArray().Length;
                wordFreq.Add(word, count);
            }

            wordFreq = wordFreq.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            list_Create(wordFreq);
        }

        private void list_Create(Dictionary<string, int> wordFreq)
        {
            foreach (KeyValuePair<string, int> word in wordFreq)
            {
                wordFreqList.Items.Add(word.Key).SubItems.Add(word.Value.ToString());
            }
        }

        private void WordFrequency_Load(object sender, EventArgs e)
        {

        }
    }
}
