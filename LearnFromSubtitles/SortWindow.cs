using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnFromSubtitles
{
    public enum SortWindowChoice
    {
        Known,
        Trash,
        New,
        Cancel
    };
    public partial class SortWindow : Form
    {
        SortWindowChoice result = SortWindowChoice.Cancel;
        public SortWindow(int wordsLeft, string text)
        {
            InitializeComponent();
            labelCounter.Text = "Left: " + wordsLeft.ToString();
            labelWord.Text = text;
        }

        public SortWindowChoice getChoice()
        {
            return result;
        }

        private void buttonKnown_Click(object sender, EventArgs e)
        {
            result = SortWindowChoice.Known;
            this.Close();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            result = SortWindowChoice.New;
            this.Close();
        }

        private void buttonTrash_Click(object sender, EventArgs e)
        {
            result = SortWindowChoice.Trash;
            this.Close();
        }
        
    }
}
