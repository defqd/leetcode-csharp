/*

49. Group Anagrams

https://leetcode.com/problems/group-anagrams/description/

Given an array of strings strs, group the anagrams together. You can return the answer in any order.

An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

 

Example 1:

Input: strs = ["eat","tea","tan","ate","nat","bat"]
Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
Example 2:

Input: strs = [""]
Output: [[""]]
Example 3:

Input: strs = ["a"]
Output: [["a"]]
 

Constraints:

1 <= strs.length <= 104
0 <= strs[i].length <= 100
strs[i] consists of lowercase English letters.
 
*/

namespace LeetCode.Medium
{
    public static class GroupAnagramsSolution
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var dic = new Dictionary<string, IList<string>>();

            foreach (string s in strs)
            {
                char[] hash = new char[26];

                foreach (char c in s)
                    hash[c - 'a']++;

                string key = new string(hash);

                if (!dic.ContainsKey(key))
                    dic[key] = new List<string>();

                dic[key].Add(s);
            }

            return dic.Values.ToList();



            //var dic = new Dictionary<string, IList<string>>();

            //foreach (var item in strs)
            //{
            //    char[] temp = item.ToCharArray();

            //    Array.Sort(temp);

            //    var sorted = new string(temp);

            //    if (dic.ContainsKey(sorted))
            //        dic[sorted].Add(item);
            //    else
            //        dic.Add(sorted, new List<string>() { item });
            //}

            //return dic.Values.ToList();
        }
    }
}