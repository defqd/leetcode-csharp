﻿namespace LeetCode.Easy
{
    public static class FindWordsContainingCharacter
    {
        public static IList<int> FindWordsContaining(string[] words, char x)
        {
            var result = new List<int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(x))
                    result.Add(i);
            }

            return result;
        }
    }
}
