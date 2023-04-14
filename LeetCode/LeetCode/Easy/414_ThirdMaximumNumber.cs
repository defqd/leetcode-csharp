/*

414. Third Maximum Number

https://leetcode.com/problems/third-maximum-number/

Given an integer array nums, return the third distinct maximum number in this array. If the third maximum does not exist, return the maximum number.

 

Example 1:

Input: nums = [3,2,1]
Output: 1
Explanation:
The first distinct maximum is 3.
The second distinct maximum is 2.
The third distinct maximum is 1.
Example 2:

Input: nums = [1,2]
Output: 2
Explanation:
The first distinct maximum is 2.
The second distinct maximum is 1.
The third distinct maximum does not exist, so the maximum (2) is returned instead.
Example 3:

Input: nums = [2,2,3,1]
Output: 1
Explanation:
The first distinct maximum is 3.
The second distinct maximum is 2 (both 2's are counted together since they have the same value).
The third distinct maximum is 1.
 

Constraints:

1 <= nums.length <= 104
-231 <= nums[i] <= 231 - 1
 

Follow up: Can you find an O(n) solution?
 
*/
using System.Linq;
using System;

namespace LeetCode.Easy
{
    public static class ThirdMaximumNumber
    {
        public static int ThirdMax(int[] nums)
        {
            var sortedNums = new SortedSet<int>();

            foreach (int item in nums)
            {
                if (sortedNums.Contains(item))
                    continue;
                if (sortedNums.Count == 3)
                {
                    //And the smallest element is smaller than current element.
                    if (sortedNums.Min < item)
                    {
                        // Then remove the smallest element and push the current element.
                        sortedNums.Remove(sortedNums.Min);
                        sortedNums.Add(item);
                    }

                }

                else
                    sortedNums.Add(item);
            }

            // If sorted set has three elements return the smallest among those 3.
            if (sortedNums.Count == 3)
                return sortedNums.Min;

            // Otherwise return the biggest element of nums array.
            return sortedNums.Max;



            //nums = nums.Distinct().OrderByDescending(x => x).ToArray();

            //if (nums.Length > 2)
            //    return nums[2];
            //else
            //    return nums.Max();



            //int max = 0;
            ////int index = 0;
            //int length = nums.Length;

            //Array.Sort(nums);
            //Array.Reverse(nums);

            ////for (int i = 0; i < nums.Length - 1; i++)
            ////{
            ////    if (nums[i] < nums[i + 1])
            ////    {
            ////        int temp = nums[i];
            ////        nums[index++] = nums[i + 1];
            ////        nums[i + 1] = temp;
            ////    }
            ////}

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] > max)
            //        max = nums[i];
            //    else if (nums[i] == max)
            //        length--;
            //    else
            //        max = nums[i];
            //}

            //if (length < 3)
            //    max = nums[0];

            //return max;
        }
    }
}