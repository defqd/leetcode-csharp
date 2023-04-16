/*

217. Contains Duplicate

https://leetcode.com/problems/contains-duplicate/

Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

 

Example 1:

Input: nums = [1,2,3,1]
Output: true
Example 2:

Input: nums = [1,2,3,4]
Output: false
Example 3:

Input: nums = [1,1,1,3,3,4,3,2,4,2]
Output: true
 

Constraints:

1 <= nums.length <= 105
-109 <= nums[i] <= 109
 
*/
namespace LeetCode.Easy
{
    public static class ContainsDuplicateSolution
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            var hash = new HashSet<int>();

            foreach (int item in nums)
            {
                if (!hash.Add(item))
                    return true;
            }

            return false;

            //var list = new List<int>();

            //foreach (int item in nums)
            //{
            //    if (list.Contains(item))
            //        return true;

            //    list.Add(item);
            //}

            //return false;
        }
    }
}