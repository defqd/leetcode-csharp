/*

977. Squares of a Sorted Array

https://leetcode.com/problems/squares-of-a-sorted-array/description/

Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number sorted in non-decreasing order.

Example 1:

Input: nums = [-4,-1,0,3,10]
Output: [0,1,9,16,100]
Explanation: After squaring, the array becomes [16,1,0,9,100].
After sorting, it becomes [0,1,9,16,100].
Example 2:

Input: nums = [-7,-3,2,3,11]
Output: [4,9,9,49,121]
 
*/

namespace LeetCode.Easy
{
    public static class SquaresOfASortedArray
    {
        public static int[] SortedSquares(int[] nums)
        {
            int [] arr = new int[nums.Length];
            int begIndex = 0;
            int endIndex = nums.Length - 1;
            int end = endIndex;

            while (begIndex <= endIndex)
            {
                if (Math.Abs(nums[endIndex]) > Math.Abs(nums[begIndex]))
                {
                    arr[end--] = nums[endIndex] * nums[endIndex--];
                }
                else
                    arr[end--] = nums[begIndex] * nums[begIndex++];
            }

            return arr;

            //for (int i = 0; i < nums.Length; i++)
            //    nums[i] *= nums[i];

            //Array.Sort(nums);

            //return nums;
        }
    }
}