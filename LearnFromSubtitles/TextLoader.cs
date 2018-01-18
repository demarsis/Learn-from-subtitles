using System;
using System.IO;

namespace LearnFromSubtitles
{
    public class TextLoader
    {
        string filename;
        public TextLoader(string filename)
        {
            this.filename = filename;
        }

        public string getText()
        {
            if (!File.Exists(filename)) return String.Empty;
            return File.ReadAllText(filename);
        }
    }
}
