
namespace LearnFromSubtitles
{
    public interface IWordFilter
    {
        bool bypass(string word);
    }

    public class WordFilterNoWord : IWordFilter
    {
        public bool bypass(string word)
        {
            if (word.Length <= 0) return false;
            if ((word[0] >= '0') && (word[0] <= '9')) return false;

            return true;
        }
    }

    public class WordFilterExistsInList : IWordFilter
    {
        WordList wordList;
        public WordFilterExistsInList(WordList wordList)
        {
            this.wordList = wordList;
        }
        public bool bypass(string word)
        {
            if (wordList == null) return true;
            return !wordList.Contains(word);
        }
    }
}
