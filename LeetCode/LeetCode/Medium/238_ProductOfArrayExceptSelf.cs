﻿/*

https://leetcode.com/problems/product-of-array-except-self/

238. Product of Array Except Self 

Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

You must write an algorithm that runs in O(n) time and without using the division operation.

 

Example 1:

Input: nums = [1,2,3,4]
Output: [24,12,8,6]
Example 2:

Input: nums = [-1,1,0,-3,3]
Output: [0,0,9,0,0]
 

Constraints:

2 <= nums.length <= 105
-30 <= nums[i] <= 30
The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
 

Follow up: Can you solve the problem in O(1) extra space complexity? (The output array does not count as extra space for space complexity analysis.)
 
*/
namespace LeetCode.Medium
{
    public static class ProductOfArrayExceptSelf
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] answer = new int[nums.Length];
            int prefix = 1;
            int postfix = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                answer[i] = prefix;
                prefix *= nums[i];
            }

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                answer[i] *= postfix;
                postfix *= nums[i];
            }

            return answer;
        }
    }
}