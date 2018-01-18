namespace LearnFromSubtitles
{
    public class WordListFromText
    {
        static char[] delimiterChars = { ' ', ',', '.', ':', '\t', '\n', '\r',
                                         '!', '@', '#', '$', '%', '^', '&', '*', '(', ')',
                                         '"', '<', '>', '+', '-', '—', '=',
                                         '\\', '|', '/', '?'};

        public static WordList get(string text)
        {
            string[] words = text.Split(delimiterChars);
            WordList result = new WordList();
            foreach (string str in words)
            {
                if (str.Length <= 0) continue;
                result.Add(str.ToLower());
            }
            return result;
        }

        public static WordList get(TextLoader textLoader)
        {
            WordList result = new WordList();
            if (textLoader == null) return result;

            string text = textLoader.getText();
            return get(text);
        }
    }
}
