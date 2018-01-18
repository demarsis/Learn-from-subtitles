using System.IO;

namespace LearnFromSubtitles
{
    public class FileAppendWord
    {
        string filename;

        public FileAppendWord(string filename)
        {
            this.filename = filename;
        }

        public bool append(string word)
        {
            if (word == null) return false;
            if (word.Length <= 0) return false;

            if (!File.Exists(filename)) return false;
            using (StreamWriter sw = File.AppendText(filename))
            {
                sw.WriteLine(word);
            }
            return true;
        }
    }
}
