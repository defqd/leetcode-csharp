/*

242. Valid Anagram

https://leetcode.com/problems/valid-anagram/

Given two strings s and t, return true if t is an anagram of s, and false otherwise.

An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

 

Example 1:

Input: s = "anagram", t = "nagaram"
Output: true
Example 2:

Input: s = "rat", t = "car"
Output: false
 

Constraints:

1 <= s.length, t.length <= 5 * 104
s and t consist of lowercase English letters.
 

Follow up: What if the inputs contain Unicode characters? How would you adapt your solution to such a case?
 
*/

namespace LeetCode.Easy
{
    public static class ValidAnagram
    {
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            if (s == t)
                return true;

            var count = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                count[s[i]] = (count.ContainsKey(s[i]) ? count[s[i]] : 0) + 1;
                count[t[i]] = (count.ContainsKey(t[i]) ? count[t[i]] : 0) - 1;
            }

            foreach (char item in count.Keys)
            {
                if (count[item] != 0)
                    return false;
            }

            return true;



            //char[] sChars = s.ToCharArray();
            //char[] tChars = t.ToCharArray();

            //Array.Sort(sChars);
            //Array.Sort(tChars);

            //return sChars.SequenceEqual(tChars);
        }
    }
}