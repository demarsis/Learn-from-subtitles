using System.IO;

namespace LearnFromSubtitles
{
    public class Account
    {
        public string filenameTrash { get; }
        public string filenameKnown { get; }
        public Account(string filenameTrash, string filenameKnown)
        {
            this.filenameTrash = filenameTrash;
            this.filenameKnown = filenameKnown;
        }
    }
}
