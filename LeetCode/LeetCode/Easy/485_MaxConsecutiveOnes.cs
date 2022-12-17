/*

485. Max Consecutive Ones

https://leetcode.com/problems/max-consecutive-ones/description/

Given a binary array nums, return the maximum number of consecutive 1's in the array.

Example 1:

Input: nums = [1,1,0,1,1,1]
Output: 3
Explanation: The first two digits or the last three digits are consecutive 1s. The maximum number of consecutive 1s is 3.
Example 2:

Input: nums = [1,0,1,1,0,1]
Output: 2
 
*/

namespace LeetCode.Easy
{
    public static class MaxConsecutiveOnes
    {
        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            int count = 0;
            int max = 0;

            foreach (int n in nums)
            {
                if (n == 1)
                    count++;
                else
                    count = 0;

                if (count > max)
                    max = count;
            }

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] == 1)
            //    {
            //        count++;
            //    }
            //    else
            //        count = 0;

            //    if (count > max)
            //        max = count;
            //}

            return max;
        }
    }
}