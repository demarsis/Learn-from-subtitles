using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnFromSubtitles
{   
    class Session
    {
        Account account;
        WordList knownWords, trashWords, newWords;
        FileAppendWord appendKnown, appendTrash;
        List<IWordFilter> filters = new List<IWordFilter>();

        public Session(Account account)
        {
            this.account = account;

            knownWords = WordListFromText.get(new TextLoader(account.filenameKnown));
            trashWords = WordListFromText.get(new TextLoader(account.filenameTrash));

            appendKnown = new FileAppendWord(account.filenameKnown);
            appendTrash = new FileAppendWord(account.filenameTrash);

            filters.Add(new WordFilterNoWord());
            filters.Add(new WordFilterExistsInList(knownWords));
            filters.Add(new WordFilterExistsInList(trashWords));
        }

        public void open(string filename)
        {
            WordList currentWords = WordListFromText.get(new TextLoader(filename));
            newWords = new WordList();

            // remove trash and known
            foreach (string str in currentWords)
            {
                bool bypass = true;
                foreach (IWordFilter filter in filters)
                {
                    if (!filter.bypass(str))
                    {
                        bypass = false;
                        break;
                    }
                }
                if (!bypass) continue;

                // no duplicates
                if (newWords.Contains(str)) continue;

                // add to new words
                newWords.Add(str);
            }
        }

        public int countNewWords()
        {
            if (newWords == null) return 0;
            return newWords.Count;
        }

        public string getNewWord(int index)
        {
            if (newWords == null) return "";
            return newWords[index];
        }

        public void removeNewWord(int index)
        {
            newWords.RemoveAt(index);
        }

        public void addKnownWord(string word)
        {
            if (newWords == null) return;
            appendKnown.append(word);
            knownWords.Add(word);
        }

        public void addTrashWord(string word)
        {
            if (newWords == null) return;
            appendTrash.append(word);
            trashWords.Add(word);
        }
    }
}
