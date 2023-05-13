/*

169. Majority Element

https://leetcode.com/problems/majority-element/

Given an array nums of size n, return the majority element.

The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.

 

Example 1:

Input: nums = [3,2,3]
Output: 3
Example 2:

Input: nums = [2,2,1,1,1,2,2]
Output: 2
 

Constraints:

n == nums.length
1 <= n <= 5 * 104
-109 <= nums[i] <= 109
 

Follow-up: Could you solve the problem in linear time and in O(1) space? 
 
*/

namespace LeetCode.Easy
{
    public static class MajorityElementSolution
    {
        public static int MajorityElement(int[] nums)
        {
            int countAppear = nums.Length / 2;

            var dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                dic[nums[i]] = (dic.ContainsKey(nums[i]) ? dic[nums[i]] : 0) + 1;

                if (dic[nums[i]] > countAppear)
                    return nums[i];
            }

            return 0;



            //int res = 0;
            //int count = 0;

            //for (var i = 0; i < nums.Length; i++)
            //{
            //    if (count == 0)
            //        res = nums[i];

            //    count += (nums[i] == res) ? 1 : -1;
            //}

            //return res;



            //Array.Sort(nums);

            //if (nums.Length == 1)
            //    return nums[0];

            //int max = nums.Length / 2;

            //return nums[max];

        }
    }
}