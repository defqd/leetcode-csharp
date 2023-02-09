/*

1346. Check If N and Its Double Exist

https://leetcode.com/problems/check-if-n-and-its-double-exist/

Given an array arr of integers, check if there exist two indices i and j such that :

i != j
0 <= i, j < arr.length
arr[i] == 2 * arr[j]
 

Example 1:

Input: arr = [10,2,5,3]
Output: true
Explanation: For i = 0 and j = 2, arr[i] == 10 == 2 * 5 == 2 * arr[j]
Example 2:

Input: arr = [3,1,7,11]
Output: false
Explanation: There is no i and j that satisfy the conditions. 
 
*/
using System.Collections;

namespace LeetCode.Easy
{
    public static class CheckIfNAndItsDoubleExist
    {
        public static bool CheckIfExist(int[] arr)
        {
            //List<int> values = new List<int>();

            //foreach (var item in arr)
            //{
            //    if (values.Contains(item * 2))
            //        return true;

            //    if (item % 2 == 0 && values.Contains(item / 2))
            //        return true;

            //    values.Add(item);
            //}

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j)
                    {
                        if (arr[i] == arr[j] * 2)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}