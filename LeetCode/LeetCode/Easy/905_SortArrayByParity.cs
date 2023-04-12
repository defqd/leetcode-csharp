/*

905. Sort Array By Parity

https://leetcode.com/problems/sort-array-by-parity/ 

Given an integer array nums, move all the even integers at the beginning of the array followed by all the odd integers.

Return any array that satisfies this condition.

 

Example 1:

Input: nums = [3,1,2,4]
Output: [2,4,3,1]
Explanation: The outputs [4,2,3,1], [2,4,1,3], and [4,2,1,3] would also be accepted.
Example 2:

Input: nums = [0]
Output: [0]
 

Constraints:

1 <= nums.length <= 5000
0 <= nums[i] <= 5000
 
*/

namespace LeetCode.Easy
{
    public static class SortArrayByParitySolution
    {
        public static int[] SortArrayByParity(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            //int[] arr = new int[nums.Length];

            while (left < right)
            {
                if (nums[left] % 2 > nums[right] % 2)
                {
                    int temp = nums[left];
                    nums[left] = nums[right];
                    nums[right] = temp;
                }

                if (nums[left] % 2 == 0) left++;
                if (nums[right] % 2 == 1) right--;
            }

            //while (left < right)
            //{
            //    if (nums[left] % 2 == 0 && nums[right] % 2 == 1)
            //    {
            //        left++;
            //        right--;
            //    }
            //    else if (nums[left] % 2 == 1 && nums[right] % 2 == 0)
            //    {
            //        int temp = nums[left];
            //        nums[left++] = nums[right];
            //        nums[right--] = temp;
            //    }
            //    else if (nums[left] % 2 == 0 && nums[right] % 2 == 0)
            //        left++;
            //    else if (nums[left] % 2 == 1 && nums[right] % 2 == 1)
            //        right--;
            //}

            //foreach (int item in nums)
            //{
            //    if (item % 2 == 0)
            //        arr[left++] = item;
            //    else
            //        arr[right--] = item;
            //}

            return nums;
        }
    }
}