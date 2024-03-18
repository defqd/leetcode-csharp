namespace LeetCode.Easy
{
    public static class WordPattern
    {
        public static bool WordPatternMethod(string pattern, string s)
        {
            var words = s.Split(' ');
            var charToWord = new Dictionary<char, string>();
            var wordToChar = new Dictionary<string, char>();

            if (pattern.Length != words.Length)
                return false;

            for (int i = 0; i < words.Length; i++)
            {
                charToWord.TryAdd(pattern[i], words[i]);
                wordToChar.TryAdd(words[i], pattern[i]);

                if (charToWord[pattern[i]] != words[i])
                    return false;
                if (wordToChar[words[i]] != pattern[i])
                    return false;
            }

            return true;
        }
    }
}