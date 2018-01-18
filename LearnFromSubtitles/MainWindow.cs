using System;
using System.IO;
using System.Windows.Forms;

namespace LearnFromSubtitles
{
    public partial class MainWindow : Form
    {
        Session session = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();

            if (result != DialogResult.OK) return;
            if (string.IsNullOrWhiteSpace(dialog.SelectedPath)) return;

            Account account = AccountLoader.load(dialog.SelectedPath);
            if (account == null)
            {
                MessageBox.Show("The folder doesn't contain an account!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            session = new Session(account);
            this.Text = Path.GetFileName(Path.GetDirectoryName(account.filenameKnown));
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();

            if (result != DialogResult.OK) return;
            if (string.IsNullOrWhiteSpace(dialog.SelectedPath)) return;

            // check alreary have an account
            Account account = AccountLoader.load(dialog.SelectedPath);
            if (account != null)
            {
                MessageBox.Show("The folder already contains an account! Select another folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // create new
            account = AccountLoader.create(dialog.SelectedPath);
            if (account == null)
            {
                MessageBox.Show("Cannot create an account!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            session = new Session(account);
            this.Text = Path.GetFileName(Path.GetDirectoryName(account.filenameKnown));
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openTextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (session == null)
            {
                MessageBox.Show("The session is not opened! Open an existing session or create a new one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();

            if (result != DialogResult.OK) return;
            if (string.IsNullOrWhiteSpace(dialog.FileName)) return;

            session.open(dialog.FileName);

            // fill with new words
            updateWordList();
        }

        private void sortNewWordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (session == null)
            {
                MessageBox.Show("The session is not opened! Open an existing session or create a new one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool flag = true;
            for (int i = 0; i < session.countNewWords(); i++)
            {
                string word = session.getNewWord(i);

                // show sort window
                SortWindow wnd = new SortWindow(session.countNewWords() - i, word);
                wnd.StartPosition = FormStartPosition.CenterScreen;
                wnd.ShowDialog();

                switch (wnd.getChoice())
                {
                    case SortWindowChoice.Known:
                        session.removeNewWord(i);
                        session.addKnownWord(word);
                        i--;
                        break;
                    case SortWindowChoice.Trash:
                        session.removeNewWord(i);
                        session.addTrashWord(word);
                        i--;
                        break;
                    case SortWindowChoice.Cancel:
                        flag = false;
                        break;
                    default:
                        break;
                }

                // not to continue
                if (!flag) break;
            }

            updateWordList();
        }

        void updateWordList()
        {
            wordList.Items.Clear();
            if (session == null) return;
            for (int i = 0; i < session.countNewWords(); i++)
            {
                wordList.Items.Add(session.getNewWord(i));
            }
        }

        private void exportWordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (session == null)
            {
                MessageBox.Show("The session is not opened! Open an existing session or create a new one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Text files (*.txt)|*.txt";
            DialogResult result = dialog.ShowDialog();

            if (result != DialogResult.OK) return;
            if (string.IsNullOrWhiteSpace(dialog.FileName)) return;

            using (StreamWriter file = new StreamWriter(dialog.FileName))
            {
                for (int i = 0; i < session.countNewWords(); i++)
                {
                    file.WriteLine(session.getNewWord(i));
                }
            }
        }
    }
}
