﻿/*

1512. Number of Good Pairs

https://leetcode.com/problems/number-of-good-pairs/

Given an array of integers nums, return the number of good pairs.

A pair (i, j) is called good if nums[i] == nums[j] and i < j.

 

Example 1:

Input: nums = [1,2,3,1,1,3]
Output: 4
Explanation: There are 4 good pairs (0,3), (0,4), (3,4), (2,5) 0-indexed.
Example 2:

Input: nums = [1,1,1,1]
Output: 6
Explanation: Each pair in the array are good.
Example 3:

Input: nums = [1,2,3]
Output: 0
 

Constraints:

1 <= nums.length <= 100
1 <= nums[i] <= 100
 
*/
using System.Diagnostics.Metrics;

namespace LeetCode.Easy
{
    public static class NumberOfGoodPairsSolution
    {
        public static int NumIdenticalPairs(int[] nums)
        {
            //var dic = new Dictionary<int, int>();
            //int count = 0;

            //for(int i = 0; i < nums.Length; i++)
            //{
            //    if (dic.ContainsKey(nums[i]))
            //    {
            //        count += dic[nums[i]];
            //        dic[nums[i]]++;
            //    }
            //    else
            //        dic[nums[i]] = 1;
            //}

            //return count;

            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j] && i < j)
                        count++;
                }
            }

            return count;
        }
    }
}