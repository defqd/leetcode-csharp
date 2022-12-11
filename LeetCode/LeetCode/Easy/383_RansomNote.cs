/*

383. Ransom Note

https://leetcode.com/problems/ransom-note/description/

Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.

Each letter in magazine can only be used once in ransomNote.

Example 1:

Input: ransomNote = "a", magazine = "b"
Output: false
Example 2:

Input: ransomNote = "aa", magazine = "ab"
Output: false
Example 3:

Input: ransomNote = "aa", magazine = "aab"
Output: true
*/
namespace LeetCode.Easy
{
    public static class RansomNote
    {
        public static bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            for (int i = 0; i < magazine.Length; i++)
            {
                if (dictionary.TryAdd(magazine[i], 0))
                {
                    dictionary[magazine[i]]++;
                }
                else
                    dictionary[magazine[i]]++;
            }

            for (int i = 0; i < ransomNote.Length; i++)
            {
                int currentCount = dictionary.GetValueOrDefault(ransomNote[i], 0);

                if (currentCount == 0)
                {
                    return false;
                }

                dictionary[ransomNote[i]] = --currentCount;
            }

            return true;
        }
    }
}